// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectCelebrityResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectCelebrityResponseBodyData Data { get; set; }
        public class DetectCelebrityResponseBodyData : TeaModel {
            [NameInMap("FaceRecognizeResults")]
            [Validation(Required=false)]
            public List<DetectCelebrityResponseBodyDataFaceRecognizeResults> FaceRecognizeResults { get; set; }
            public class DetectCelebrityResponseBodyDataFaceRecognizeResults : TeaModel {
                public List<string> FaceBoxes { get; set; }
                public string Name { get; set; }
            }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }
        };

    }

}
