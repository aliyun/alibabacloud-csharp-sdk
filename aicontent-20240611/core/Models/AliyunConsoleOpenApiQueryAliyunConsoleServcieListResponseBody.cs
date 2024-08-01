// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponseBodyData> Data { get; set; }
        public class AliyunConsoleOpenApiQueryAliyunConsoleServcieListResponseBodyData : TeaModel {
            [NameInMap("FreeConcurrencyCount")]
            [Validation(Required=false)]
            public int? FreeConcurrencyCount { get; set; }

            [NameInMap("FreeCount")]
            [Validation(Required=false)]
            public int? FreeCount { get; set; }

            [NameInMap("ServiceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
