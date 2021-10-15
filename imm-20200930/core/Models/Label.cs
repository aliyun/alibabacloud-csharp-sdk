// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Label : TeaModel {
        /// <summary>
        /// LabelConfidence
        /// </summary>
        [NameInMap("LabelConfidence")]
        [Validation(Required=false)]
        public float? LabelConfidence { get; set; }

        /// <summary>
        /// LabelLevel
        /// </summary>
        [NameInMap("LabelLevel")]
        [Validation(Required=false)]
        public long? LabelLevel { get; set; }

        /// <summary>
        /// LabelName
        /// </summary>
        [NameInMap("LabelName")]
        [Validation(Required=false)]
        public string LabelName { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
