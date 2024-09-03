using System;
using System.IO;

public static class ReadDisk
{
    public static byte[] Read(string driveLetter, int sectorNumber)
    {
        int sectorSize = 512; // Standardgröße eines Sektors
        string drivePath = $@"\\.\{driveLetter}:";

        try
        {
            using (FileStream fs = new FileStream(drivePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] buffer = new byte[sectorSize];
                fs.Seek(sectorNumber * sectorSize, SeekOrigin.Begin);
                fs.Read(buffer, 0, sectorSize);

                // Return the sector data and raw bytes

                return buffer;
            }
        } catch (Exception ex)
        {
            // System error message popup
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return null;
        }
    }
}