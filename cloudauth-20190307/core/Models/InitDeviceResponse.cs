// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class InitDeviceResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ResultObject")]
        [Validation(Required=true)]
        public InitDeviceResponseResultObject ResultObject { get; set; }
        public class InitDeviceResponseResultObject : TeaModel {
            [NameInMap("CertifyId")]
            [Validation(Required=true)]
            public string CertifyId { get; set; }
            [NameInMap("Protocol")]
            [Validation(Required=true)]
            public string Protocol { get; set; }
            [NameInMap("ExtParams")]
            [Validation(Required=true)]
            public string ExtParams { get; set; }
            [NameInMap("RetCode")]
            [Validation(Required=true)]
            public string RetCode { get; set; }
            [NameInMap("RetCodeSub")]
            [Validation(Required=true)]
            public string RetCodeSub { get; set; }
            [NameInMap("RetMessageSub")]
            [Validation(Required=true)]
            public string RetMessageSub { get; set; }
            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }
            [NameInMap("OssEndPoint")]
            [Validation(Required=true)]
            public string OssEndPoint { get; set; }
            [NameInMap("AccessKeyId")]
            [Validation(Required=true)]
            public string AccessKeyId { get; set; }
            [NameInMap("AccessKeySecret")]
            [Validation(Required=true)]
            public string AccessKeySecret { get; set; }
            [NameInMap("SecurityToken")]
            [Validation(Required=true)]
            public string SecurityToken { get; set; }
            [NameInMap("BucketName")]
            [Validation(Required=true)]
            public string BucketName { get; set; }
            [NameInMap("FileNamePrefix")]
            [Validation(Required=true)]
            public string FileNamePrefix { get; set; }
            [NameInMap("FileName")]
            [Validation(Required=true)]
            public string FileName { get; set; }
            [NameInMap("PresignedUrl")]
            [Validation(Required=true)]
            public string PresignedUrl { get; set; }
        };

    }

}
