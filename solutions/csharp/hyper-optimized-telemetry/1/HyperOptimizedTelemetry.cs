public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte prefix;
        int numBytes;
        bool isSigned;
        byte[] payload;

        if (reading >= -32768 && reading <= -1)
            {numBytes = 2; isSigned = true;
             payload = BitConverter.GetBytes((short)reading);}
        
        else if (reading >= -2147483648 && reading <= -32769)
            {numBytes = 4; isSigned = true;
             payload = BitConverter.GetBytes((int)reading);}

        else if (reading <= -2147483649)
            {numBytes = 8; isSigned = true;
             payload = BitConverter.GetBytes(reading);}
        
        else if (reading >= 0 && reading <= 65535)
            {numBytes = 2; isSigned = false;
             payload = BitConverter.GetBytes((ushort)reading);}
        
        else if (reading <= 2147483647)
            {numBytes = 4; isSigned = true;
             payload = BitConverter.GetBytes((int)reading);}
        
        else if (reading <= 4294967295)
            {numBytes = 4; isSigned = false;
             payload = BitConverter.GetBytes((uint)reading);}
        
        else 
            {numBytes = 8; isSigned = true;
              payload = BitConverter.GetBytes((long)reading);}

        if(isSigned) {prefix = (byte)(256-numBytes);}
        else prefix = (byte)numBytes;        
    
        byte[] buffer = new byte[9];
        buffer[0] = prefix;
        Array.Copy(payload, 0, buffer,1, numBytes);
        return buffer;
    }

    public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];
        int numBytes;
        bool isSigned;

        if (prefix != 2 && prefix != 4 && prefix != 8 && prefix != 254 && prefix != 252 && prefix !=  248)
        {return 0;}
        else
        {
            if (prefix < 128)
            {
                numBytes = prefix;
                isSigned = false;
            }
            else
            {
                numBytes = 256 - prefix;
                isSigned = true;
            } 
        }



        byte[] payload = new byte[numBytes];
        Array.Copy(buffer, 1, payload, 0, numBytes);


        if (numBytes == 2 && !isSigned)
        {
            //ushort logic
            return BitConverter.ToUInt16(payload, 0);
        }
        else if (numBytes == 4 && !isSigned)
        {
            //uint logic
            return BitConverter.ToUInt32(payload, 0);
        }
        else if (numBytes == 2 && isSigned)
        {
            //short logic
            return BitConverter.ToInt16(payload, 0);
        }
        else if (numBytes == 4 && isSigned)
        {
            //int logic
            return BitConverter.ToInt32(payload, 0);
        }
        else if (numBytes == 8 && isSigned)
        {
            //long logic
            return BitConverter.ToInt64(payload, 0);
        }
        else {return 0;}
    }
}
