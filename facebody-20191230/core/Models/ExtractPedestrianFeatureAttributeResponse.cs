// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class ExtractPedestrianFeatureAttributeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ExtractPedestrianFeatureAttributeResponseData Data { get; set; }
        public class ExtractPedestrianFeatureAttributeResponseData : TeaModel {
            [NameInMap("ObjType")]
            [Validation(Required=true)]
            public string ObjType { get; set; }
            [NameInMap("ObjTypeScore")]
            [Validation(Required=true)]
            public float? ObjTypeScore { get; set; }
            [NameInMap("Feature")]
            [Validation(Required=true)]
            public string Feature { get; set; }
            [NameInMap("QualityScore")]
            [Validation(Required=true)]
            public float? QualityScore { get; set; }
            [NameInMap("UpperColor")]
            [Validation(Required=true)]
            public string UpperColor { get; set; }
            [NameInMap("UpperColorScore")]
            [Validation(Required=true)]
            public float? UpperColorScore { get; set; }
            [NameInMap("UpperType")]
            [Validation(Required=true)]
            public string UpperType { get; set; }
            [NameInMap("UpperTypeScore")]
            [Validation(Required=true)]
            public float? UpperTypeScore { get; set; }
            [NameInMap("LowerColor")]
            [Validation(Required=true)]
            public string LowerColor { get; set; }
            [NameInMap("LowerColorScore")]
            [Validation(Required=true)]
            public float? LowerColorScore { get; set; }
            [NameInMap("LowerType")]
            [Validation(Required=true)]
            public string LowerType { get; set; }
            [NameInMap("LowerTypeScore")]
            [Validation(Required=true)]
            public float? LowerTypeScore { get; set; }
            [NameInMap("Gender")]
            [Validation(Required=true)]
            public string Gender { get; set; }
            [NameInMap("GenderScore")]
            [Validation(Required=true)]
            public float? GenderScore { get; set; }
            [NameInMap("Hair")]
            [Validation(Required=true)]
            public string Hair { get; set; }
            [NameInMap("HairScore")]
            [Validation(Required=true)]
            public float? HairScore { get; set; }
            [NameInMap("Age")]
            [Validation(Required=true)]
            public string Age { get; set; }
            [NameInMap("AgeScore")]
            [Validation(Required=true)]
            public float? AgeScore { get; set; }
            [NameInMap("Elements")]
            [Validation(Required=true)]
            public List<ExtractPedestrianFeatureAttributeResponseDataElements> Elements { get; set; }
            public class ExtractPedestrianFeatureAttributeResponseDataElements : TeaModel {
                public string ObjType { get; set; }
                public float? ObjTypeScore { get; set; }
                public string Feature { get; set; }
                public float? QualityScore { get; set; }
                public string UpperColor { get; set; }
                public float? UpperColorScore { get; set; }
                public string UpperType { get; set; }
                public float? UpperTypeScore { get; set; }
                public string LowerColor { get; set; }
                public float? LowerColorScore { get; set; }
                public string LowerType { get; set; }
                public float? LowerTypeScore { get; set; }
                public string Gender { get; set; }
                public float? GenderScore { get; set; }
                public string Hair { get; set; }
                public float? HairScore { get; set; }
                public string Age { get; set; }
                public float? AgeScore { get; set; }
            }
        };

    }

}
