﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagsCloudContainer.Visualizers
{
    interface IVisualizer
    {
        Bitmap VisualizeCloud(List<WordToken> wordTokens);
    }
}
