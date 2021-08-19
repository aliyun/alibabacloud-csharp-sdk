// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class BeautifyBodyShrinkRequest : TeaModel {
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("OriginalWidth")]
        [Validation(Required=false)]
        public long? OriginalWidth { get; set; }

        [NameInMap("OriginalHeight")]
        [Validation(Required=false)]
        public long? OriginalHeight { get; set; }

        [NameInMap("Custom")]
        [Validation(Required=false)]
        public long? Custom { get; set; }

        [NameInMap("MaleLiquifyDegree")]
        [Validation(Required=false)]
        public float? MaleLiquifyDegree { get; set; }

        [NameInMap("FemaleLiquifyDegree")]
        [Validation(Required=false)]
        public float? FemaleLiquifyDegree { get; set; }

        [NameInMap("LengthenDegree")]
        [Validation(Required=false)]
        public float? LengthenDegree { get; set; }

        [NameInMap("AgeRange")]
        [Validation(Required=false)]
        public string AgeRangeShrink { get; set; }

        [NameInMap("BodyBoxes")]
        [Validation(Required=false)]
        public string BodyBoxesShrink { get; set; }

        [NameInMap("FaceList")]
        [Validation(Required=false)]
        public string FaceListShrink { get; set; }

        [NameInMap("PoseList")]
        [Validation(Required=false)]
        public string PoseListShrink { get; set; }

    }

}
