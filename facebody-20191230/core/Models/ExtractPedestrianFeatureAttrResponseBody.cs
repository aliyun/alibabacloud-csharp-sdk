// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ExtractPedestrianFeatureAttrResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExtractPedestrianFeatureAttrResponseBodyData Data { get; set; }
        public class ExtractPedestrianFeatureAttrResponseBodyData : TeaModel {
            [NameInMap("QualityScore")]
            [Validation(Required=false)]
            public float? QualityScore { get; set; }
            [NameInMap("ObjType")]
            [Validation(Required=false)]
            public string ObjType { get; set; }
            [NameInMap("Feature")]
            [Validation(Required=false)]
            public string Feature { get; set; }
            [NameInMap("Gender")]
            [Validation(Required=false)]
            public string Gender { get; set; }
            [NameInMap("LowerColorScore")]
            [Validation(Required=false)]
            public float? LowerColorScore { get; set; }
            [NameInMap("ObjTypeScore")]
            [Validation(Required=false)]
            public float? ObjTypeScore { get; set; }
            [NameInMap("Age")]
            [Validation(Required=false)]
            public string Age { get; set; }
            [NameInMap("AgeScore")]
            [Validation(Required=false)]
            public float? AgeScore { get; set; }
            [NameInMap("UpperTypeScore")]
            [Validation(Required=false)]
            public float? UpperTypeScore { get; set; }
            [NameInMap("LowerTypeScore")]
            [Validation(Required=false)]
            public float? LowerTypeScore { get; set; }
            [NameInMap("LowerColor")]
            [Validation(Required=false)]
            public string LowerColor { get; set; }
            [NameInMap("Hair")]
            [Validation(Required=false)]
            public string Hair { get; set; }
            [NameInMap("UpperColor")]
            [Validation(Required=false)]
            public string UpperColor { get; set; }
            [NameInMap("GenderScore")]
            [Validation(Required=false)]
            public float? GenderScore { get; set; }
            [NameInMap("UpperType")]
            [Validation(Required=false)]
            public string UpperType { get; set; }
            [NameInMap("HairScore")]
            [Validation(Required=false)]
            public float? HairScore { get; set; }
            [NameInMap("LowerType")]
            [Validation(Required=false)]
            public string LowerType { get; set; }
            [NameInMap("UpperColorScore")]
            [Validation(Required=false)]
            public float? UpperColorScore { get; set; }
        };

    }

}
