// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImageQuality : TeaModel {
        /// <summary>
        /// <para>The overall quality score of the image. The image is automatically evaluated by AI. The evaluation is mainly based on subjective aesthetics and is affected by various factors, such as composition, brightness, contrast, color, and definition. Valid values: 0 to 1. The higher the score, the better the quality.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.736</para>
        /// </summary>
        [NameInMap("overall_score")]
        [Validation(Required=false)]
        public double? OverallScore { get; set; }

    }

}
