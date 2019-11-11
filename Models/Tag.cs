﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lonefire.Models
{
    public class Tag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string TagName { get; set; }

        public string TagNameZh { get; set; }

        public string Description { get; set; }

        public string DescriptionZh { get; set; }

        [DefaultValue(0)]
        public int TagCount { get; set; }

        public DateTimeOffset CreateTime { get; set; }
        public DateTimeOffset EditTime { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (TagName == null && TagNameZh == null)
                yield return new ValidationResult($"{Startup.Localizer["TagName"]} {Startup.Localizer["must not be empty"]}");
        }

    }
}
