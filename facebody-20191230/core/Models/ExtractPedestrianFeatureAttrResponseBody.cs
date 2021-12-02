// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ExtractPedestrianFeatureAttrResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExtractPedestrianFeatureAttrResponseBodyData Data { get; set; }
        public class ExtractPedestrianFeatureAttrResponseBodyData : TeaModel {
            [NameInMap("Age")]
            [Validation(Required=false)]
            public string Age { get; set; }
            [NameInMap("AgeScore")]
            [Validation(Required=false)]
            public float? AgeScore { get; set; }
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }
            [NameInMap("GenderScore")]
            [Validation(Required=false)]
            public float? GenderScore { get; set; }
            [NameInMap("Hair")]
            [Validation(Required=false)]
            public string Hair { get; set; }
            [NameInMap("HairScore")]
            [Validation(Required=false)]
            public float? HairScore { get; set; }
            [NameInMap("LowerColor")]
            [Validation(Required=false)]
            public string LowerColor { get; set; }
            [NameInMap("LowerColorScore")]
            [Validation(Required=false)]
            public float? LowerColorScore { get; set; }
            [NameInMap("LowerType")]
            [Validation(Required=false)]
            public string LowerType { get; set; }
            [NameInMap("LowerTypeScore")]
            [Validation(Required=false)]
            public float? LowerTypeScore { get; set; }
            [NameInMap("ObjType")]
            [Validation(Required=false)]
            public string ObjType { get; set; }
            [NameInMap("ObjTypeScore")]
            [Validation(Required=false)]
            public float? ObjTypeScore { get; set; }
            [NameInMap("Orientation")]
            [Validation(Required=false)]
            public string Orientation { get; set; }
            [NameInMap("OrientationScore")]
            [Validation(Required=false)]
            public float? OrientationScore { get; set; }
            [NameInMap("QualityScore")]
            [Validation(Required=false)]
            public float? QualityScore { get; set; }
            [NameInMap("UpperColor")]
            [Validation(Required=false)]
            public string UpperColor { get; set; }
            [NameInMap("UpperColorScore")]
            [Validation(Required=false)]
            public float? UpperColorScore { get; set; }
            [NameInMap("UpperType")]
            [Validation(Required=false)]
            public string UpperType { get; set; }
            [NameInMap("UpperTypeScore")]
            [Validation(Required=false)]
            public float? UpperTypeScore { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
