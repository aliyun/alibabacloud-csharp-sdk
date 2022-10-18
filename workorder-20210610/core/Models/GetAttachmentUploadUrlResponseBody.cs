// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class GetAttachmentUploadUrlResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAttachmentUploadUrlResponseBodyData Data { get; set; }
        public class GetAttachmentUploadUrlResponseBodyData : TeaModel {
            [NameInMap("GetSignedUrl")]
            [Validation(Required=false)]
            public string GetSignedUrl { get; set; }

            [NameInMap("ObjectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            [NameInMap("PutSignedUrl")]
            [Validation(Required=false)]
            public string PutSignedUrl { get; set; }

        }

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
