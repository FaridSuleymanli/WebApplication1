﻿using System;

public class CommentDto
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public int? StockId { get; set; }
}
