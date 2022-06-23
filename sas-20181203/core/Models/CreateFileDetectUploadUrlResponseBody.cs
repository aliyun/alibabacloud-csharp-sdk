// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileDetectUploadUrlResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadUrlList")]
        [Validation(Required=false)]
        public List<CreateFileDetectUploadUrlResponseBodyUploadUrlList> UploadUrlList { get; set; }
        public class CreateFileDetectUploadUrlResponseBodyUploadUrlList : TeaModel {
            [NameInMap("Context")]
            [Validation(Required=false)]
            public CreateFileDetectUploadUrlResponseBodyUploadUrlListContext Context { get; set; }
            public class CreateFileDetectUploadUrlResponseBodyUploadUrlListContext : TeaModel {
                [NameInMap("AccessId")]
                [Validation(Required=false)]
                public string AccessId { get; set; }
                [NameInMap("OssKey")]
                [Validation(Required=false)]
                public string OssKey { get; set; }
                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }
                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }
            };

            [NameInMap("Expire")]
            [Validation(Required=false)]
            public string Expire { get; set; }

            [NameInMap("FileExist")]
            [Validation(Required=false)]
            public bool? FileExist { get; set; }

            [NameInMap("HashKey")]
            [Validation(Required=false)]
            public string HashKey { get; set; }

            [NameInMap("InternalUrl")]
            [Validation(Required=false)]
            public string InternalUrl { get; set; }

            [NameInMap("PublicUrl")]
            [Validation(Required=false)]
            public string PublicUrl { get; set; }

        }

    }

}
