﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication6.Models
{
    public enum Size

    {
        [Display(Name = "10x10")]
        S1 = 1,
        [Display(Name = "10x20")]
        S2 = 2,
        [Display(Name = "10x30")]
        S3 = 3,
        [Display(Name = "10x60")]
        S4 = 4,
        [Display(Name = "11x90")]
        S5 = 5,
        [Display(Name = "15x30")]
        S6 = 6,
        [Display(Name = "15x30-30x60")]
        S7 = 7,
        [Display(Name = "15x40")]
        S8 = 8,
        [Display(Name = "15x60")]
        S9 = 9,
        [Display(Name = "15x60-15x90-20x120")]
        S10 = 10,
        [Display(Name = "15x90")]
        S11 = 11,
        [Display(Name = "20X20")]
        S12 = 12,
        [Display(Name = "20x40")]
        S13 = 13,
        [Display(Name = "20x50")]
        S14 = 14,
        [Display(Name = "15x30-30x60")]
        S15 = 15,
        [Display(Name = "22,5x22,5-45x45")]
        S16 = 16,
        [Display(Name = "22,5x45")]
        S17 = 17,
        [Display(Name = "24,5x10,5")]
        S18 = 18,
        [Display(Name = "24,5x12,5")]
        S19 = 19,
        [Display(Name = "25x45")]
        S20 = 20,
        [Display(Name = "25x50")]
        S21 = 21,
        [Display(Name = "25x65")]
        S22 = 22,
        [Display(Name = "28x28")]
        S23 = 23,
        [Display(Name = "29,8x29,8")]
        S24 = 24,
        [Display(Name = "29,8x30,5")]
        S25 = 25,
        [Display(Name = "29,9x30,5")]
        S26 = 26,
        [Display(Name = "29.8x29.8")]
        S27 = 27,
        [Display(Name = "29.8x30.5")]
        S28 = 28,
        [Display(Name = "299x305")]
        S29 = 29,
        [Display(Name = "2x24")]
        S30 = 30,
        [Display(Name = "2x60")]
        S31 = 31,
        [Display(Name = "2x65")]
        S32 = 32,
        [Display(Name = "30,5x30,5")]
        S33 = 33,
        [Display(Name = "30.5x30.5")]
        S34 =34,
        [Display(Name = "30x30")]
        S35 = 35,
        [Display(Name = "30x30-45x45")]
        S36 = 36,
        [Display(Name = "30x34")]
        S37 = 37,
        [Display(Name = "30x60")]
        S38 = 38,
        [Display(Name = "15x30-30x60")]
        S39 = 39,
        [Display(Name = "30x60-45x90")]
        S40 = 40,
        [Display(Name = "30x90")]
        S41 = 41,
        [Display(Name = "33x33")]
        S42 = 42,
        [Display(Name = "33x33-40x60-45x45")]
        S43 = 43,
        [Display(Name = "33x33-45x45")]
        S44 = 44,
        [Display(Name = "33x33-45x45-60x60")]
        S45 = 45,
        [Display(Name = "3x50")]
        S46 = 46,
        [Display(Name = "3x60")]
        S47 = 47,
        [Display(Name = "3x65")]
        S48 = 48,
        [Display(Name = "4,5x65")]
        S49 = 49,
        [Display(Name = "4.5x65")]
        S50 = 50,
        [Display(Name = "40x40")]
        S51 = 51,
        [Display(Name = "40x60")]
        S52 = 52,
        [Display(Name = "40x80")]
        S53 = 53,
        [Display(Name = "45x45")]
        S54 = 54,
        [Display(Name = "45x45-60x60")]
        S55 = 55,
        [Display(Name = "45x90")]
        S56 = 56,
        [Display(Name = "50x50")]
        S57 = 57,
        [Display(Name = "5x40")]
        S58 = 58,
        [Display(Name = "5x50")]
        S59 = 59,
        [Display(Name = "60x120")]
        S60 = 60,
        [Display(Name = "60x60")]
        S61 = 61,
        [Display(Name = "60x60-80x80-60x120")]
        S62 = 62,
        [Display(Name = "2x60")]
        S63 = 63,
        [Display(Name = "6x20")]
        S64 = 64,
        [Display(Name = "6x25")]
        S65 = 65,
        [Display(Name = "6x50")]
        S66 = 66,
        [Display(Name = "6x60")]
        S67 = 67,
        [Display(Name = "6x65")]
        S68= 68,
        [Display(Name = "7,5x15-10x20")]
        S69 = 69,
        [Display(Name = "7.5x25")]
        S70 = 70,
        [Display(Name = "7.5x40")]
        S71 = 71,
        [Display(Name = "7x25")]
        S72 = 72,
        [Display(Name = "80x80")]
        S73 = 73,
        [Display(Name = "8x65")]
        S74 = 74
    }

}
