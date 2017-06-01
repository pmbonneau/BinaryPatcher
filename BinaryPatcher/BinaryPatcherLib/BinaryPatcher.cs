using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace BinaryPatcherLib
{
    public class BinaryPatcher
    {
        string[] ID;
        string[] Position;
        string[] Data;

        string FileToPatchPath = "";

        public BinaryPatcher(string pFileToPatchPath, string PatchContainerPath)
        {
            XmlDocument XmlContainer = new XmlDocument();
            XmlContainer.Load(PatchContainerPath);
            int NodeCount = 0;
            XmlNodeList PatchNodeListID = XmlContainer.SelectNodes("/Container/Patch/ID");
            ID = new string[PatchNodeListID.Count];
            foreach (XmlNode PatchNode in PatchNodeListID)
            {
                ID[NodeCount] = PatchNode.InnerText;
                NodeCount++;
            }

            NodeCount = 0;
            XmlNodeList PatchNodeListPosition = XmlContainer.SelectNodes("/Container/Patch/Position");
            Position = new string[PatchNodeListPosition.Count];
            foreach (XmlNode PatchNode in PatchNodeListPosition)
            {
                Position[NodeCount] = PatchNode.InnerText;
                NodeCount++;
            }

            NodeCount = 0;
            XmlNodeList PatchNodeListData = XmlContainer.SelectNodes("/Container/Patch/Data");
            Data = new string[PatchNodeListData.Count];
            foreach (XmlNode PatchNode in PatchNodeListData)
            {
                Data[NodeCount] = PatchNode.InnerText;
                NodeCount++;
            }

            FileToPatchPath = pFileToPatchPath;
        }

        public bool ApplyPatchToFile()
        {
            FileStream WriteStream;
            WriteStream = new FileStream(FileToPatchPath, FileMode.Open);
            for (int i = 0; i < ID.Length; i++)
            {
                //WriteStream converts decimal to hexadecimal when it writes data to file.
                WriteStream.Position = Convert.ToInt32(Position[i], 16);
                WriteStream.Write(StringToDecByteArray(Data[i]), 0x0, StringToDecByteArray(Data[i]).Length);
            }
            WriteStream.Close();
            return true;
        }

        public bool ApplyPatchToFile(string PatchID)
        {
            FileStream WriteStream;
            WriteStream = new FileStream(FileToPatchPath, FileMode.Open);
            for (int i = 0; i < ID.Length; i++)
            {
                if (PatchID == ID[i])
                {
                    //WriteStream converts decimal to hexadecimal when it writes data to file.
                    WriteStream.Position = Convert.ToInt32(Position[i],16);
                    WriteStream.Write(StringToDecByteArray(Data[i]), 0x0, StringToDecByteArray(Data[i]).Length);
                }
            }
            WriteStream.Close();
            return true;
        }

        public string[] GetPatchListID()
        {
            return ID;
        }

        private byte[] StringToHexByteArray(string StringToConvert)
        {
            byte[] DataArray = new byte[StringToConvert.Length / 2];
            int ChunkSize = 2;
            int StringLength = StringToConvert.Length;
            int ArrayItemCount = 0;
            for (int i = 0; i < StringLength; i += ChunkSize)
            {
                if (i + ChunkSize > StringLength)
                {
                    ChunkSize = StringLength - i;
                }
                DataArray[ArrayItemCount] = Convert.ToByte(StringToConvert.Substring(i, ChunkSize));
                ArrayItemCount++;
            }
            return DataArray;
        }

        private byte[] StringToDecByteArray(string StringToConvert)
        {
            int NumberChars = StringToConvert.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(StringToConvert.Substring(i, 2), 16);
            }
            return bytes;
        }
    }
}
