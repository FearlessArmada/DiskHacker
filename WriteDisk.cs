using System;
using System.IO;

public static class WriteDisk
{
    public static void Write(string driveLetter, int sectorNumber, byte[] data)
    {
        int sectorSize = 512; // Standardgröße eines Sektors
        if (data.Length != sectorSize)
        {
            throw new ArgumentException($"Data must be exactly {sectorSize} bytes long.");
        }

        string drivePath = $@"\\.\{driveLetter}:";

        try
        {
            using (FileStream fs = new FileStream(drivePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite))
            {
                fs.Seek(sectorNumber * sectorSize, SeekOrigin.Begin);
                fs.Write(data, 0, sectorSize);
            }
        } catch (Exception ex)
        {
            // System error message popup
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}