﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses;

public class CreatedTaskResponse
{
    public string Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedDate { get; set; }
}