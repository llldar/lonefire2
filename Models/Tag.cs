﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using lonefire.Models.HelperModels;

namespace lonefire.Models
{
    public class Tag : IEntityDate
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [NotMapped]
        public string IdBase64 { get => Id.Base64UrlEncode(); }

        public string TagName { get; set; }

        public string TagNameZh { get; set; }

        public string Description { get; set; }

        public string DescriptionZh { get; set; }

        [DefaultValue(0)]
        public int TagCount { get; set; }

        public DateTimeOffset CreateTime { get; set; }
        public DateTimeOffset EditTime { get; set; }

        //Navigation
        public virtual List<ArticleTag> ArticleTags { get; set; }
        public virtual List<NoteTag> NoteTags { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (TagName == null && TagNameZh == null)
                yield return new ValidationResult("TagName must not be empty");
        }

    }
}
