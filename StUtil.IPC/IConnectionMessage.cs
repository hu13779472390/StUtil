﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StUtil.IPC
{
    public interface IConnectionMessage
    {
        byte[] ToRawData();
    }
}
