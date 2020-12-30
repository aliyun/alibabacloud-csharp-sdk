// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetJobDataUploadParamsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadParams")]
        [Validation(Required=false)]
        public GetJobDataUploadParamsResponseBodyUploadParams UploadParams { get; set; }
        public class GetJobDataUploadParamsResponseBodyUploadParams : TeaModel {
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public string Folder { get; set; }
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }
            [NameInMap("Expire")]
            [Validation(Required=false)]
            public int? Expire { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
