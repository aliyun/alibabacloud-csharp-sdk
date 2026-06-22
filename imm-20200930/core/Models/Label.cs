// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Label : TeaModel {
        /// <summary>
        /// <para>The centric score of the tag. This indicates whether the tag is the main subject in the image. The value ranges from 0 to 1. A higher value indicates higher confidence that the tag is the main subject of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.877</para>
        /// </summary>
        [NameInMap("CentricScore")]
        [Validation(Required=false)]
        public float? CentricScore { get; set; }

        /// <summary>
        /// <para>Event clips.</para>
        /// </summary>
        [NameInMap("Clips")]
        [Validation(Required=false)]
        public List<Clip> Clips { get; set; }

        /// <summary>
        /// <para>The tag alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>座椅</para>
        /// </summary>
        [NameInMap("LabelAlias")]
        [Validation(Required=false)]
        public string LabelAlias { get; set; }

        /// <summary>
        /// <para>The tag confidence level. The value ranges from 0 (lowest confidence) to 1 (highest confidence).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.95</para>
        /// </summary>
        [NameInMap("LabelConfidence")]
        [Validation(Required=false)]
        public float? LabelConfidence { get; set; }

        /// <summary>
        /// <para>The tag level. Valid values are 1, 2, and 3, representing first-level, second-level, and third-level tags, respectively.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LabelLevel")]
        [Validation(Required=false)]
        public long? LabelLevel { get; set; }

        /// <summary>
        /// <para>The tag name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>椅子</para>
        /// </summary>
        [NameInMap("LabelName")]
        [Validation(Required=false)]
        public string LabelName { get; set; }

        /// <summary>
        /// <para>The tag language, in BCP 47 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-Hans</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The parent tag name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>家具</para>
        /// </summary>
        [NameInMap("ParentLabelName")]
        [Validation(Required=false)]
        public string ParentLabelName { get; set; }

    }

}
