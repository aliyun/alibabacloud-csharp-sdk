// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Facebody20191230.Models
{
    public class DetectCelebrityResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DetectCelebrityResponseBodyData Data { get; set; }
        public class DetectCelebrityResponseBodyData : TeaModel {
            [NameInMap("FaceRecognizeResults")]
            [Validation(Required=false)]
            public List<DetectCelebrityResponseBodyDataFaceRecognizeResults> FaceRecognizeResults { get; set; }
            public class DetectCelebrityResponseBodyDataFaceRecognizeResults : TeaModel {
                /// <summary>
                /// 1
                /// </summary>
                [NameInMap("FaceBoxes")]
                [Validation(Required=false)]
                public List<float?> FaceBoxes { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
