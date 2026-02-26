// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Label : TeaModel {
        /// <summary>
        /// <para>The central value of the label. This value indicates the confidence that the label is the majority component of the image. Valid values: 0 to 1. A higher value indicates greater confidence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.7319999933242798</para>
        /// </summary>
        [NameInMap("CentricScore")]
        [Validation(Required=false)]
        public float? CentricScore { get; set; }

        [NameInMap("Clips")]
        [Validation(Required=false)]
        public List<Clip> Clips { get; set; }

        [NameInMap("LabelAlias")]
        [Validation(Required=false)]
        public string LabelAlias { get; set; }

        /// <summary>
        /// <para>The confidence level of the label. Valid values: 0 to 1. A higher value indicates greater confidence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9891784601980591</para>
        /// </summary>
        [NameInMap("LabelConfidence")]
        [Validation(Required=false)]
        public float? LabelConfidence { get; set; }

        /// <summary>
        /// <para>The label level. Valid values: 1, 2, and 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LabelLevel")]
        [Validation(Required=false)]
        public long? LabelLevel { get; set; }

        /// <summary>
        /// <para>The label name.</para>
        /// </summary>
        [NameInMap("LabelName")]
        [Validation(Required=false)]
        public string LabelName { get; set; }

        /// <summary>
        /// <para>The label language, which is represented as a BCP 47 language tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-Hans</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the parent label.</para>
        /// </summary>
        [NameInMap("ParentLabelName")]
        [Validation(Required=false)]
        public string ParentLabelName { get; set; }

    }

}
