﻿using System;
using System.IO;
using SonicRetro.KensSharp;

namespace SonicRetro.SonLVL.API
{
    [System.Diagnostics.DebuggerNonUserCode]
    public class Compression
    {
        public static byte[] Decompress(string file, CompressionType cmp)
        {
            byte[] ret = new byte[0];
            try
            {
                switch (cmp)
                {
                    case CompressionType.Uncompressed:
                        ret = File.ReadAllBytes(file);
                        break;
                    case CompressionType.Kosinski:
                        ret = Kosinski.Decompress(file);
                        break;
                    case CompressionType.KosinskiM:
                        ret = ModuledKosinski.Decompress(file, LevelData.littleendian ? Endianness.LittleEndian : Endianness.BigEndian);
                        break;
                    case CompressionType.Nemesis:
                        ret = Nemesis.Decompress(file);
                        break;
                    case CompressionType.Enigma:
                        ret = Enigma.Decompress(file, LevelData.littleendian ? Endianness.LittleEndian : Endianness.BigEndian);
                        break;
                    case CompressionType.SZDD:
                        ret = SZDDComp.SZDDComp.Decompress(file);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("cmp", "Invalid compression type " + cmp + "!");
                }
            }
            catch
            {
                LevelData.Log("Unable to read file \"" + file + "\" with compression " + cmp.ToString() + ":");
                throw;
            }
            return ret;
        }

        public static void Compress(byte[] file, string destination, CompressionType cmp)
        {
            try
            {
                switch (cmp)
                {
                    case CompressionType.Uncompressed:
                        File.WriteAllBytes(destination, file);
                        break;
                    case CompressionType.Kosinski:
                        using (MemoryStream input = new MemoryStream(file))
                        {
                            using (FileStream output = File.Create(destination))
                            {
                                using (PaddedStream paddedOutput = new PaddedStream(output, 2, PaddedStreamMode.Write))
                                {
                                    Kosinski.Compress(input, paddedOutput);
                                }
                            }
                        }
                        break;
                    case CompressionType.KosinskiM:
                        using (MemoryStream input = new MemoryStream(file))
                        {
                            using (FileStream output = File.Create(destination))
                            {
                                using (PaddedStream paddedOutput = new PaddedStream(output, 2, PaddedStreamMode.Write))
                                {
                                    ModuledKosinski.Compress(input, paddedOutput, LevelData.littleendian ? Endianness.LittleEndian : Endianness.BigEndian);
                                }
                            }
                        }
                        break;
                    case CompressionType.Nemesis:
                        Nemesis.Compress(file, destination);
                        break;
                    case CompressionType.Enigma:
                        Enigma.Compress(file, destination, LevelData.littleendian ? Endianness.LittleEndian : Endianness.BigEndian);
                        break;
                    case CompressionType.SZDD:
                        SZDDComp.SZDDComp.Compress(file, destination);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("cmp", "Invalid compression type " + cmp + "!");
                }
            }
            catch
            {
                LevelData.Log("Unable to write file \"" + file + "\" with compression " + cmp.ToString() + ":");
                throw;
            }
        }
    }

    public enum CompressionType
    {
        Invalid,
        Uncompressed,
        Kosinski,
        KosinskiM,
        Nemesis,
        Enigma,
        SZDD
    }
}