﻿using System;
using AcademicXXI.Helpers;

namespace AcademicXXI.ViewModel.ViewModel
{
    public abstract class BaseDomain
    {
        public Status Status { get; set; }
        public DateTime Created { get; set; }

    }
}
