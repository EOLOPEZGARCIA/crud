﻿namespace ElsterGabinete
{

    public class Lectura 
    {
        
    public class string Leer (string PuertoCom, string)
        {
        byte[] T0 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x3f, 0x08, 0xca, 0x00, 0x00, 0x00, 0x00, 0x05, 0xb0, 0x40 }; //SALUDO
        byte[] T1 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x3f, 0x08, 0xc9, 0x00, 0x00, 0x00, 0x00, 0x20, 0x62, 0x3a }; //NUMERO MEDIDOR
        byte[] T2 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x3f, 0x00, 0x54, 0x00, 0x00, 0x00, 0x00, 0x01, 0xc8, 0xa6 }; //TIPO DE LECTURA
        byte[] T3_1 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x3f, 0x00, 0x54, 0x00, 0x00, 0x00, 0x00, 0x29, 0x82, 0x0b };// LECTURA normal
        byte[] T3_2 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x3f, 0x00, 0x54, 0x00, 0x00, 0x00, 0x00, 0x34, 0xe6, 0xc0 };// LECTURA bidi
        byte[] T4 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0b, 0x40, 0x00, 0x07, 0x00, 0x06, 0x08, 0xc9, 0x00, 0x00, 0x00, 0x00, 0x1e, 0x84 }; //Estado
        byte[] T5 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x3f, 0x09, 0x0e, 0x00, 0x00, 0x00, 0x00, 0x26, 0x23, 0xdb };// Validacion reco
        byte[] T6 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0b, 0x40, 0x00, 0x07, 0x00, 0x06, 0x08, 0xc9, 0x00, 0x80, 0x00, 0x00, 0xf2, 0x88 };//corte
        byte[] T7 = new byte[] { 0xb4, 0x00, 0x00, 0x00, 0x00, 0x00, 0x0b, 0x40, 0x00, 0x07, 0x00, 0x06, 0x08, 0xc9, 0x00, 0x80, 0x80, 0x00, 0x3e, 0x04 };//reconexion

}

    }
}