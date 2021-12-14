﻿using System;

namespace Banner
{
    class Banner
    {
        static void Main(string[] args)
        {
            Byte[] Matrix8x16 =  {
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0x81, 0xA5, 0x81, 0x81, 0xBD,
              0x99, 0x81, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0xFF, 0xDB, 0xFF, 0xFF, 0xC3,
              0xE7, 0xFF, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x36, 0x7F, 0x7F, 0x7F, 0x7F,
              0x3E, 0x1C, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x08, 0x1C, 0x3E, 0x7F, 0x3E,
              0x1C, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x3C, 0x3C, 0xE7, 0xE7, 0xE7,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x3C, 0x7E, 0xFF, 0xFF, 0x7E,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x3C, 0x3C,
              0x18, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xE7, 0xC3, 0xC3,
              0xE7, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x3C, 0x66, 0x42, 0x42,
              0x66, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0xFF, 0xFF, 0xFF, 0xFF, 0xC3, 0x99, 0xBD, 0xBD,
              0x99, 0xC3, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00,
              0x00, 0x00, 0x0F, 0x07, 0x0D, 0x19, 0x3C, 0x66,
              0x66, 0x66, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x3C, 0x66, 0x66, 0x66, 0x3C, 0x18,
              0x7E, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x3F, 0x33, 0x3F, 0x30, 0x30, 0x30,
              0x70, 0xF0, 0xE0, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7F, 0x63, 0x7F, 0x63, 0x63, 0x63,
              0x67, 0xE7, 0xE6, 0xC0, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0xDB, 0x3C, 0xE7, 0x3C,
              0xDB, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x40, 0x60, 0x70, 0x7C, 0x7F, 0x7C,
              0x70, 0x60, 0x40, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x01, 0x03, 0x07, 0x1F, 0x7F, 0x1F,
              0x07, 0x03, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x3C, 0x7E, 0x18, 0x18, 0x18,
              0x7E, 0x3C, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x33, 0x33, 0x33, 0x33, 0x33, 0x33,
              0x00, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7F, 0xDB, 0xDB, 0xDB, 0x7B, 0x1B,
              0x1B, 0x1B, 0x1B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x3E, 0x63, 0x30, 0x1C, 0x36, 0x63, 0x63,
              0x36, 0x1C, 0x06, 0x63, 0x3E, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x7F, 0x7F, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x3C, 0x7E, 0x18, 0x18, 0x18,
              0x7E, 0x3C, 0x18, 0x7E, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x3C, 0x7E, 0x18, 0x18, 0x18,
              0x18, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18,
              0x7E, 0x3C, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x0C, 0x06, 0x7F, 0x06,
              0x0C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x18, 0x30, 0x7F, 0x30,
              0x18, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x60, 0x60, 0x60,
              0x7F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x24, 0x66, 0xFF, 0x66,
              0x24, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x08, 0x1C, 0x1C, 0x3E, 0x3E,
              0x7F, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x7F, 0x7F, 0x3E, 0x3E, 0x1C,
              0x1C, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18,
              0x00, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x66, 0x66, 0x66, 0x24, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x66, 0x66, 0xFF, 0x66, 0x66, 0x66,
              0xFF, 0x66, 0x66, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x10, 0x7D, 0xD3, 0x91, 0xD0, 0x7C, 0x17,
              0x13, 0x96, 0x7C, 0x10, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x70, 0xDB, 0xDE, 0x7C, 0x18, 0x3E,
              0x7B, 0xDB, 0x0E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x3C, 0x66, 0x66, 0x3C, 0x3B, 0x6E,
              0xC6, 0xCE, 0x7B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x30, 0x30, 0x20, 0x40, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x0C, 0x18, 0x30, 0x60, 0x60, 0x60,
              0x30, 0x18, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x30, 0x18, 0x0C, 0x06, 0x06, 0x06,
              0x0C, 0x18, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0xDB, 0x7E, 0x3C, 0xFF, 0x3C,
              0x7E, 0xDB, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x18, 0x18, 0x18, 0xFF, 0x18,
              0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x18, 0x18, 0x10, 0x20, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x01, 0x03, 0x06, 0x0C, 0x18, 0x30,
              0x60, 0xC0, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x3C, 0x66, 0xC3, 0xC7, 0xCB, 0xD3,
              0xE3, 0x66, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x38, 0x18, 0x18, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0x83, 0x03, 0x06, 0x0C, 0x18,
              0x30, 0x61, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0x83, 0x03, 0x06, 0x3C, 0x06,
              0x03, 0xC3, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x06, 0x0E, 0x16, 0x26, 0x46, 0x86,
              0xFF, 0x06, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x3F, 0x40, 0x80, 0xFC, 0x06, 0x03,
              0x03, 0xC6, 0x7C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x1C, 0x30, 0x60, 0xC0, 0xFE, 0xC3,
              0xC3, 0xC3, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFF, 0x83, 0x03, 0x06, 0x0C, 0x18,
              0x30, 0x60, 0xE0, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0xC3, 0xC3, 0xC3, 0x7E, 0xC3,
              0xC3, 0xC3, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0xC3, 0xC3, 0xC3, 0x7F, 0x03,
              0x06, 0x0C, 0x38, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x18, 0x00,
              0x00, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x18, 0x00,
              0x00, 0x18, 0x18, 0x10, 0x20, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x0C, 0x18, 0x30, 0x60, 0xC0, 0x60,
              0x30, 0x18, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x7E, 0x00, 0x00, 0x7E,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x30, 0x18, 0x0C, 0x06, 0x03, 0x06,
              0x0C, 0x18, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0xC3, 0x03, 0x0E, 0x18, 0x18,
              0x00, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0xC3, 0xCF, 0xDB, 0xDB, 0xDB,
              0xCE, 0xC0, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x2C, 0x2C, 0x46, 0x7E,
              0x83, 0x83, 0xC7, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFC, 0xC6, 0xC6, 0xC6, 0xFC, 0xC3,
              0xC3, 0xC3, 0xFE, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7D, 0xC3, 0x81, 0x80, 0x80, 0x80,
              0x81, 0xC2, 0x7C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFE, 0xC3, 0xC1, 0xC1, 0xC1, 0xC1,
              0xC1, 0xC3, 0xFE, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFF, 0xC3, 0xC1, 0xC8, 0xF8, 0xC8,
              0xC1, 0xC3, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFF, 0xC3, 0xC1, 0xC8, 0xF8, 0xC8,
              0xC0, 0xC0, 0xE0, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7D, 0xC3, 0x81, 0x80, 0x80, 0x87,
              0x83, 0xC3, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xE7, 0xC3, 0xC3, 0xC3, 0xFF, 0xC3,
              0xC3, 0xC3, 0xE7, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x3C, 0x18, 0x18, 0x18, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x0F, 0x06, 0x06, 0x06, 0x06, 0x06,
              0xC6, 0xCC, 0x78, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xE7, 0xC4, 0xC8, 0xD0, 0xF8, 0xCC,
              0xC6, 0xC3, 0xE7, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xE0, 0xC0, 0xC0, 0xC0, 0xC0, 0xC0,
              0xC1, 0xC3, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x81, 0xC3, 0xE5, 0xB9, 0x91, 0x81,
              0x81, 0x81, 0x81, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x83, 0xC1, 0xE1, 0xB1, 0x99, 0x8D,
              0x87, 0x83, 0xC1, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0xC3, 0x81, 0x81, 0x81, 0x81,
              0x81, 0xC3, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFE, 0xC3, 0xC3, 0xC3, 0xFE, 0xC0,
              0xC0, 0xC0, 0xE0, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0xC3, 0x81, 0x81, 0x81, 0x81,
              0x81, 0xC3, 0x7E, 0x18, 0x0F, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFE, 0xC3, 0xC3, 0xC3, 0xFE, 0xCC,
              0xC6, 0xC3, 0xE3, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7D, 0xC3, 0x81, 0xC0, 0x7C, 0x06,
              0x03, 0x86, 0x7C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFF, 0x99, 0x18, 0x18, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xE3, 0xC1, 0xC1, 0xC1, 0xC1, 0xC1,
              0xC1, 0xC1, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xE3, 0xC1, 0xC1, 0x62, 0x62, 0x34,
              0x34, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x91, 0x99, 0x99, 0xC9, 0xCD, 0x6D,
              0x77, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xC3, 0xC2, 0x64, 0x38, 0x18, 0x2C,
              0x46, 0x83, 0x83, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xC1, 0xC1, 0x62, 0x34, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xFF, 0x86, 0x0C, 0x18, 0x30, 0x60,
              0xC1, 0x83, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x3C, 0x30, 0x30, 0x30, 0x30, 0x30, 0x30,
              0x30, 0x30, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x80, 0xC0, 0x60, 0x30, 0x18, 0x0C,
              0x06, 0x03, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x3C, 0x0C, 0x0C, 0x0C, 0x0C, 0x0C, 0x0C,
              0x0C, 0x0C, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x08, 0x1C, 0x36, 0x63, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x18, 0x18, 0x08, 0x04, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0x06, 0x7E,
              0xC6, 0xC6, 0x7B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xE0, 0x60, 0x60, 0x6E, 0x73, 0x63,
              0x63, 0x63, 0xDE, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0xC6, 0xC0,
              0xC0, 0xC2, 0x7C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x0E, 0x06, 0x06, 0x76, 0xCE, 0xC6,
              0xC6, 0xC6, 0x7B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x3E, 0x63, 0x7F,
              0x60, 0x61, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x1C, 0x36, 0x30, 0x30, 0x7C, 0x30,
              0x30, 0x30, 0x78, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x7B, 0xC6, 0xC6,
              0x7C, 0xC0, 0x7E, 0xC3, 0x7E, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xE0, 0x60, 0x60, 0x6E, 0x73, 0x63,
              0x63, 0x63, 0xF3, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x00, 0x38, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x06, 0x06, 0x00, 0x0E, 0x06, 0x06,
              0x06, 0x06, 0x66, 0x66, 0x3C, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xE0, 0x60, 0x60, 0x66, 0x68, 0x78,
              0x6C, 0x66, 0xE7, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x38, 0x18, 0x18, 0x18, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xB6, 0xDB, 0xDB,
              0xDB, 0xDB, 0xDB, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xDE, 0x63, 0x63,
              0x63, 0x63, 0xF3, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x7C, 0xC6, 0xC6,
              0xC6, 0xC6, 0x7C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xDE, 0x63, 0x63,
              0x63, 0x73, 0x6E, 0x60, 0xF0, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x7B, 0xC6, 0xC6,
              0xC6, 0xCE, 0x76, 0x06, 0x0F, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xDC, 0x66, 0x60,
              0x60, 0x60, 0xF0, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x7A, 0xC6, 0x70,
              0x1C, 0xC6, 0xBC, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x10, 0x30, 0xFC, 0x30, 0x30,
              0x30, 0x32, 0x1C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xF3, 0x63, 0x63,
              0x63, 0x63, 0x3D, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xE3, 0x62, 0x64,
              0x34, 0x38, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x91, 0xD9, 0xCD,
              0x6F, 0x77, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xE3, 0x32, 0x1C,
              0x1C, 0x26, 0xE3, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xE3, 0x31, 0x19,
              0x0D, 0x07, 0x03, 0x36, 0x1C, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x7F, 0x46, 0x0C,
              0x18, 0x31, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x0E, 0x18, 0x18, 0x18, 0x70, 0x18,
              0x18, 0x18, 0x0E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x18, 0x18, 0x00, 0x18,
              0x18, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x70, 0x18, 0x18, 0x18, 0x0E, 0x18,
              0x18, 0x18, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7B, 0xDE, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x3C, 0x66,
              0xC3, 0xC3, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x1E, 0x33, 0x61, 0x60, 0x60, 0x61,
              0x33, 0x1E, 0x06, 0x03, 0x3E, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x66, 0x66, 0x00, 0x66, 0x66, 0x66,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x06, 0x0C, 0x18, 0x00, 0x3E, 0x63, 0x7F,
              0x60, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x08, 0x1C, 0x36, 0x00, 0x3C, 0x06, 0x3E,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x66, 0x66, 0x00, 0x3C, 0x06, 0x3E,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x30, 0x18, 0x0C, 0x00, 0x3C, 0x06, 0x3E,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x1C, 0x36, 0x1C, 0x00, 0x3C, 0x06, 0x3E,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x3C, 0x66, 0x60, 0x66,
              0x3C, 0x0C, 0x06, 0x3C, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x08, 0x1C, 0x36, 0x00, 0x3E, 0x63, 0x7F,
              0x60, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x66, 0x66, 0x00, 0x3E, 0x63, 0x7F,
              0x60, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x30, 0x18, 0x0C, 0x00, 0x3E, 0x63, 0x7F,
              0x60, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x66, 0x66, 0x00, 0x38, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x18, 0x3C, 0x66, 0x00, 0x38, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x60, 0x30, 0x18, 0x00, 0x38, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x63, 0x63, 0x08, 0x1C, 0x36, 0x63, 0x63,
              0x7F, 0x63, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x1C, 0x36, 0x1C, 0x00, 0x1C, 0x36, 0x63, 0x63,
              0x7F, 0x63, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x0C, 0x18, 0x30, 0x00, 0x7F, 0x33, 0x30, 0x3E,
              0x30, 0x33, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x6E, 0x3B, 0x1B, 0x7E,
              0xD8, 0xDC, 0x77, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x1F, 0x36, 0x66, 0x66, 0x7F, 0x66,
              0x66, 0x66, 0x67, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x08, 0x1C, 0x36, 0x00, 0x3E, 0x63, 0x63,
              0x63, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x63, 0x63, 0x00, 0x3E, 0x63, 0x63,
              0x63, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x30, 0x18, 0x0C, 0x00, 0x3E, 0x63, 0x63,
              0x63, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x18, 0x3C, 0x66, 0x00, 0x66, 0x66, 0x66,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x30, 0x18, 0x0C, 0x00, 0x66, 0x66, 0x66,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x63, 0x63, 0x00, 0x63, 0x63, 0x63,
              0x63, 0x3F, 0x03, 0x06, 0x3C, 0x00, 0x00, 0x00,
              0x00, 0x63, 0x63, 0x1C, 0x36, 0x63, 0x63, 0x63,
              0x63, 0x36, 0x1C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x63, 0x63, 0x00, 0x63, 0x63, 0x63, 0x63,
              0x63, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x18, 0x18, 0x7E, 0xC3, 0xC0, 0xC0, 0xC3,
              0x7E, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x1C, 0x36, 0x32, 0x30, 0x78, 0x30, 0x30,
              0x30, 0x73, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0xC3, 0x66, 0x3C, 0x18, 0xFF, 0x18,
              0xFF, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0xFC, 0x66, 0x66, 0x7C, 0x62, 0x66, 0x6F,
              0x66, 0x66, 0xF3, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x0E, 0x1B, 0x18, 0x18, 0x18, 0x7E, 0x18,
              0x18, 0x18, 0x18, 0xD8, 0x70, 0x00, 0x00, 0x00,
              0x00, 0x0C, 0x18, 0x30, 0x00, 0x3C, 0x06, 0x3E,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x0C, 0x18, 0x30, 0x00, 0x38, 0x18, 0x18,
              0x18, 0x18, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x0C, 0x18, 0x30, 0x00, 0x3E, 0x63, 0x63,
              0x63, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x0C, 0x18, 0x30, 0x00, 0x66, 0x66, 0x66,
              0x66, 0x66, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x3B, 0x6E, 0x00, 0x6E, 0x33, 0x33,
              0x33, 0x33, 0x33, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x3B, 0x6E, 0x00, 0x63, 0x73, 0x7B, 0x7F, 0x6F,
              0x67, 0x63, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x3C, 0x6C, 0x6C, 0x3E, 0x00, 0x7E, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x38, 0x6C, 0x6C, 0x38, 0x00, 0x7C, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x00, 0x18, 0x18, 0x30,
              0x63, 0x63, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F, 0x60,
              0x60, 0x60, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x7F, 0x03,
              0x03, 0x03, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x60, 0xE0, 0x63, 0x66, 0x6C, 0x18, 0x30,
              0x6E, 0xC3, 0x06, 0x0C, 0x1F, 0x00, 0x00, 0x00,
              0x00, 0x60, 0xE0, 0x63, 0x66, 0x6C, 0x18, 0x33,
              0x67, 0xCF, 0x1F, 0x03, 0x03, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x00, 0x18, 0x18, 0x3C,
              0x3C, 0x3C, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x1B, 0x36, 0x6C, 0x36,
              0x1B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x6C, 0x36, 0x1B, 0x36,
              0x6C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x11, 0x44, 0x11, 0x44, 0x11, 0x44, 0x11, 0x44,
              0x11, 0x44, 0x11, 0x44, 0x11, 0x44, 0x00, 0x00,
              0x55, 0xAA, 0x55, 0xAA, 0x55, 0xAA, 0x55, 0xAA,
              0x55, 0xAA, 0x55, 0xAA, 0x55, 0xAA, 0x00, 0x00,
              0xDD, 0x77, 0xDD, 0x77, 0xDD, 0x77, 0xDD, 0x77,
              0xDD, 0x77, 0xDD, 0x77, 0xDD, 0x77, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0xF8,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0xF8, 0x18, 0xF8,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0xF6,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFE,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xF8, 0x18, 0xF8,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0xF6, 0x06, 0xF6,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x36,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xFE, 0x06, 0xF6,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0xF6, 0x06, 0xFE,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0xFE,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0xF8, 0x18, 0xF8,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xF8,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x1F,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0xFF,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x1F,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0xFF,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x1F, 0x18, 0x1F,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x37,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x37, 0x30, 0x3F,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x3F, 0x30, 0x37,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0xF7, 0x00, 0xFF,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0xF7,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x37, 0x30, 0x37,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0xFF,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0xF7, 0x00, 0xF7,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0xFF, 0x00, 0xFF,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0xFF,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0xFF,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x3F,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x1F, 0x18, 0x1F,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x1F, 0x18, 0x1F,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x3F,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0xFF,
              0x36, 0x36, 0x36, 0x36, 0x36, 0x36, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0xFF, 0x18, 0xFF,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0xF8,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x1F,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF,
              0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xFF,
              0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00, 0x00,
              0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0,
              0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0xF0, 0x00, 0x00,
              0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F,
              0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x0F, 0x00, 0x00,
              0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x3B, 0x6E, 0x6C,
              0x6C, 0x6E, 0x3B, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x3E, 0x63, 0x7E, 0x63,
              0x63, 0x7E, 0x60, 0x60, 0x20, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7F, 0x63, 0x63, 0x60, 0x60, 0x60,
              0x60, 0x60, 0x60, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x7F, 0x36, 0x36, 0x36,
              0x36, 0x36, 0x36, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7F, 0x63, 0x30, 0x18, 0x0C, 0x18,
              0x30, 0x63, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x3F, 0x6C, 0x6C,
              0x6C, 0x6C, 0x38, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x33, 0x33, 0x33, 0x33,
              0x3E, 0x30, 0x30, 0x60, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x3B, 0x6E, 0x0C, 0x0C,
              0x0C, 0x0C, 0x0C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x7E, 0x18, 0x3C, 0x66, 0x66, 0x66,
              0x3C, 0x18, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x1C, 0x36, 0x63, 0x63, 0x7F, 0x63,
              0x63, 0x36, 0x1C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x1C, 0x36, 0x63, 0x63, 0x63, 0x36,
              0x36, 0x36, 0x77, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x1E, 0x30, 0x18, 0x0C, 0x3E, 0x66,
              0x66, 0x66, 0x3C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x7E, 0xDB, 0xDB,
              0x7E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x03, 0x06, 0x7E, 0xDB, 0xDB, 0xF3,
              0x7E, 0x60, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x1C, 0x30, 0x60, 0x60, 0x7C, 0x60,
              0x60, 0x30, 0x1C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x3E, 0x63, 0x63, 0x63, 0x63,
              0x63, 0x63, 0x63, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x7F, 0x00, 0x00, 0x7F, 0x00,
              0x00, 0x7F, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x18, 0xFF, 0x18, 0x18,
              0x18, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x30, 0x18, 0x0C, 0x06, 0x0C, 0x18,
              0x30, 0x00, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x0C, 0x18, 0x30, 0x60, 0x30, 0x18,
              0x0C, 0x00, 0x7E, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x0E, 0x1B, 0x1B, 0x18, 0x18, 0x18,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x00, 0x00,
              0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18, 0x18,
              0xD8, 0xD8, 0x70, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x18, 0x18, 0x00, 0x00, 0xFF, 0x00,
              0x00, 0x18, 0x18, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x3B, 0x6E, 0x00, 0x3B,
              0x6E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x38, 0x6C, 0x6C, 0x38, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x18, 0x18,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x18,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x0F, 0x0C, 0x0C, 0x0C, 0x0C, 0x0C, 0xEC,
              0x6C, 0x3C, 0x1C, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0xD8, 0x6C, 0x6C, 0x6C, 0x6C, 0x6C, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x70, 0xD8, 0x30, 0x60, 0xC8, 0xF8, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x3E, 0x3E, 0x3E, 0x3E,
              0x3E, 0x3E, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
              0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            };

            if (args.Length > 0) {
                if (("/?" == args[0]) || ("--help" == args[0]) || ("-" == args[0]))
                {
                    Console.WriteLine("BANNER : Cette commande permet d''afficher une bannière.");
                    Console.WriteLine();
                    Console.WriteLine("Syntaxe : BANNER message");
                }
                else
                {
                    const int Height = 16;
                    char[,] TB = new char[Height,80];
                    for(int p = 0; p < args.Length; p++) {
                        string CurrString = args[p];
                        if(CurrString.Length > 10) CurrString = CurrString.Substring(0, 10);
                        for(int I = 0; I < Height; I++) for(int J = 0; J < 80; J++) TB[I, J] = ' ';
                        for(int J = 0; J < CurrString.Length; J++) for (int I = 0; I < Height - 1;I++) {
                                int Masque = Matrix8x16[Height * CurrString[J] + I];
                                for (int K = 0; K < 7; K++) {
                                    if((Masque & 128) != 0) TB[I,J * 8 + K] = '#';
                                    Masque = Masque << 1;
                                }
                        }
                        for(int J = 0; J < Height-1; J++) { 
                            for(int I = 0; I < CurrString.Length * 8 - 1;I++) Console.Write(TB[J,I]);
                            Console.WriteLine();
                        }

                    }
                }
            }

        }
    }
}
