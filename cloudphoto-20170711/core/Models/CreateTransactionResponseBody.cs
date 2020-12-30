// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class CreateTransactionResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Transaction")]
        [Validation(Required=false)]
        public CreateTransactionResponseBodyTransaction Transaction { get; set; }
        public class CreateTransactionResponseBodyTransaction : TeaModel {
            [NameInMap("Upload")]
            [Validation(Required=false)]
            public CreateTransactionResponseBodyTransactionUpload Upload { get; set; }
            public class CreateTransactionResponseBodyTransactionUpload : TeaModel {
                [NameInMap("ObjectKey")]
                [Validation(Required=false)]
                public string ObjectKey { get; set; }

                [NameInMap("AccessKeySecret")]
                [Validation(Required=false)]
                public string AccessKeySecret { get; set; }

                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                [NameInMap("AccessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                [NameInMap("StsToken")]
                [Validation(Required=false)]
                public string StsToken { get; set; }

                [NameInMap("OssEndpoint")]
                [Validation(Required=false)]
                public string OssEndpoint { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
