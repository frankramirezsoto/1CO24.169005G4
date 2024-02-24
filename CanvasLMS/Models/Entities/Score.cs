﻿using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace CanvasLMS.Models.Entities
{
    [PrimaryKey(nameof(StudentId), nameof(EvaluationTaskId))]
    public class Score
    {
        public int StudentId { get; set; }
        public int EvaluationTaskId { get; set; }
        [Precision(10, 2)]
        public decimal ScorePercentage { get; set; }

        public EvaluationTask? EvaluationTask { get; set; }
        public Student? Student { get; set; }
    }
}
