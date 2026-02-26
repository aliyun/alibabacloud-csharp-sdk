// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ImageScore : TeaModel {
        /// <summary>
        /// <para>The score for the overall image quality. The image is automatically evaluated by AI. The evaluation is mainly based on subjective aesthetics and is affected by various factors, such as composition, brightness, contrast, color, and definition.</para>
        /// <para>Valid values: 0 to 1. A higher value indicates better quality.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.736</para>
        /// </summary>
        [NameInMap("OverallQualityScore")]
        [Validation(Required=false)]
        public float? OverallQualityScore { get; set; }

    }

}
