// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20200801.Models
{
    public class GetAttachmentUploadUrlResponseBody : TeaModel {
        [NameInMap("AccessFileUrl")]
        [Validation(Required=false)]
        public string AccessFileUrl { get; set; }

        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        [NameInMap("PutObjectUrl")]
        [Validation(Required=false)]
        public string PutObjectUrl { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
