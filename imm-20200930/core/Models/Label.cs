// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Label : TeaModel {
        [NameInMap("CentricScore")]
        [Validation(Required=false)]
        public float? CentricScore { get; set; }

        [NameInMap("LabelConfidence")]
        [Validation(Required=false)]
        public float? LabelConfidence { get; set; }

        [NameInMap("LabelLevel")]
        [Validation(Required=false)]
        public long? LabelLevel { get; set; }

        [NameInMap("LabelName")]
        [Validation(Required=false)]
        public string LabelName { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("ParentLabelName")]
        [Validation(Required=false)]
        public string ParentLabelName { get; set; }

    }

}
