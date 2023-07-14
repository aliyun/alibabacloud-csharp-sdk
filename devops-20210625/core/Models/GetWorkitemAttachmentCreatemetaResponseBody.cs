// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkitemAttachmentCreatemetaResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("uploadInfo")]
        [Validation(Required=false)]
        public GetWorkitemAttachmentCreatemetaResponseBodyUploadInfo UploadInfo { get; set; }
        public class GetWorkitemAttachmentCreatemetaResponseBodyUploadInfo : TeaModel {
            [NameInMap("accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }

            [NameInMap("dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

    }

}
