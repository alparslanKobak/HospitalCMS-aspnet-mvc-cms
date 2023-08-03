﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Data.Entity
{
	public class Image : BaseEntity
	{
        [MaxLength(200, ErrorMessage = "The {0} cannot exceed 200 characters."), MinLength(1, ErrorMessage = "The {0} must be at least 1 characters."), Required(ErrorMessage = "The {0} field cannot be left blank!"), DataType(DataType.ImageUrl), Column(TypeName ="nvarchar(200)")]
        public string? ImagePath { get; set; }

        public Title? ImageTitle { get; set; }

        public enum Title
        {
            Empty, Profile, Post, Department
        }
    }
}
