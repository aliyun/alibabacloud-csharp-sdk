// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitDeviceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public InitDeviceResponseBodyResultObject ResultObject { get; set; }
        public class InitDeviceResponseBodyResultObject : TeaModel {
            [NameInMap("OssEndPoint")]
            [Validation(Required=false)]
            public string OssEndPoint { get; set; }
            [NameInMap("RetCodeSub")]
            [Validation(Required=false)]
            public string RetCodeSub { get; set; }
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }
            [NameInMap("CertifyId")]
            [Validation(Required=false)]
            public string CertifyId { get; set; }
            [NameInMap("ExtParams")]
            [Validation(Required=false)]
            public string ExtParams { get; set; }
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }
            [NameInMap("PresignedUrl")]
            [Validation(Required=false)]
            public string PresignedUrl { get; set; }
            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }
            [NameInMap("FileNamePrefix")]
            [Validation(Required=false)]
            public string FileNamePrefix { get; set; }
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }
            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }
            [NameInMap("RetMessageSub")]
            [Validation(Required=false)]
            public string RetMessageSub { get; set; }
            [NameInMap("RetCode")]
            [Validation(Required=false)]
            public string RetCode { get; set; }
        };

    }

}
