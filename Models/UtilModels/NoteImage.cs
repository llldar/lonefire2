﻿using System;
namespace lonefire.Models.UtilModels
{
    public class NoteImage
    {
        public Guid NoteId { get; set; }

        public Note Note { get; set; }

        public Guid ImageId { get; set; }

        public Image Image { get; set; }
    }
}
