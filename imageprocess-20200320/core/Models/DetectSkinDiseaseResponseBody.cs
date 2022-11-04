// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageprocess20200320.Models
{
    public class DetectSkinDiseaseResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectSkinDiseaseResponseBodyData Data { get; set; }
        public class DetectSkinDiseaseResponseBodyData : TeaModel {
            [NameInMap("BodyPart")]
            [Validation(Required=false)]
            public string BodyPart { get; set; }

            [NameInMap("ImageQuality")]
            [Validation(Required=false)]
            public float? ImageQuality { get; set; }

            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public Dictionary<string, object> Results { get; set; }

            [NameInMap("ResultsEnglish")]
            [Validation(Required=false)]
            public Dictionary<string, object> ResultsEnglish { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
