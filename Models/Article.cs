﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lonefire.Models
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [StringLength(128, ErrorMessage = "{0} must have a length between {1} and {2} ", MinimumLength = 0)]
        public string Title { get; set; }

        [StringLength(128, ErrorMessage = "{0} must have a length between {1} and {2} ", MinimumLength = 0)]
        public string TitleZh { get; set; }

        [Required]
        public Guid Owner { get; set; }

        public string Content { get; set; }

        public Status Status { get; set; }

        public Image HeaderImg { get; set; }

        [DefaultValue(0)]
        public int ViewCount { get; set; }

        [DefaultValue(0)]
        public int LikeCount { get; set; }

        public List<Image> Images;
        public List<Comment> Comments;
        public List<Tag> Tags;

        public DateTimeOffset CreateTime { get; set; }
        public DateTimeOffset EditTime { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Title == null && TitleZh == null)
                yield return new ValidationResult("Title must not be empty");
        }
    }
}