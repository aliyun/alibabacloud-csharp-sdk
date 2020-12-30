// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class GetRenderResultResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRenderResultResponseBodyData Data { get; set; }
        public class GetRenderResultResponseBodyData : TeaModel {
            [NameInMap("ResultData")]
            [Validation(Required=false)]
            public GetRenderResultResponseBodyDataResultData ResultData { get; set; }
            public class GetRenderResultResponseBodyDataResultData : TeaModel {
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

            }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public float? Progress { get; set; }
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
