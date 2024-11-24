﻿using System.ComponentModel.DataAnnotations;

namespace YumBlazor.Entities;

public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Please enter name..")]
    public string? Name { get; set; }
}
