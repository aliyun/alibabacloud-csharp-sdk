// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetChatappUploadAuthorizationResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetChatappUploadAuthorizationResponseBodyData Data { get; set; }
        public class GetChatappUploadAuthorizationResponseBodyData : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            [NameInMap("Dir")]
            [Validation(Required=false)]
            public string Dir { get; set; }

            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            [NameInMap("Expire")]
            [Validation(Required=false)]
            public int? Expire { get; set; }

            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
