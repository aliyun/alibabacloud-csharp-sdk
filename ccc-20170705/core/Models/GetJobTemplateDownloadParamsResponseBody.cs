// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetJobTemplateDownloadParamsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DownloadParams")]
        [Validation(Required=false)]
        public GetJobTemplateDownloadParamsResponseBodyDownloadParams DownloadParams { get; set; }
        public class GetJobTemplateDownloadParamsResponseBodyDownloadParams : TeaModel {
            [NameInMap("SignatureUrl")]
            [Validation(Required=false)]
            public string SignatureUrl { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
