// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetSkillImportFileUrlResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetSkillImportFileUrlResponseBodyData Data { get; set; }
        public class GetSkillImportFileUrlResponseBodyData : TeaModel {
            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("MaxSize")]
            [Validation(Required=false)]
            public string MaxSize { get; set; }

            [NameInMap("OssObjectName")]
            [Validation(Required=false)]
            public string OssObjectName { get; set; }

            [NameInMap("UploadUrl")]
            [Validation(Required=false)]
            public string UploadUrl { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
