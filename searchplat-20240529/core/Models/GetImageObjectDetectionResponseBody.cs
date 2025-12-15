// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetImageObjectDetectionResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetImageObjectDetectionResponseBodyResult Result { get; set; }
        public class GetImageObjectDetectionResponseBodyResult : TeaModel {
            [NameInMap("objects")]
            [Validation(Required=false)]
            public List<GetImageObjectDetectionResponseBodyResultObjects> Objects { get; set; }
            public class GetImageObjectDetectionResponseBodyResultObjects : TeaModel {
                [NameInMap("confidence")]
                [Validation(Required=false)]
                public string Confidence { get; set; }

                [NameInMap("location")]
                [Validation(Required=false)]
                public GetImageObjectDetectionResponseBodyResultObjectsLocation Location { get; set; }
                public class GetImageObjectDetectionResponseBodyResultObjectsLocation : TeaModel {
                    [NameInMap("X")]
                    [Validation(Required=false)]
                    public int? X { get; set; }

                    [NameInMap("Y")]
                    [Validation(Required=false)]
                    public int? Y { get; set; }

                    [NameInMap("height")]
                    [Validation(Required=false)]
                    public int? Height { get; set; }

                    [NameInMap("width")]
                    [Validation(Required=false)]
                    public int? Width { get; set; }

                }

            }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetImageObjectDetectionResponseBodyUsage Usage { get; set; }
        public class GetImageObjectDetectionResponseBodyUsage : TeaModel {
            [NameInMap("image")]
            [Validation(Required=false)]
            public long? Image { get; set; }

        }

    }

}
