// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeVerifyTokenResponseBody : TeaModel {
        [NameInMap("VerifyPageUrl")]
        [Validation(Required=false)]
        public string VerifyPageUrl { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OssUploadToken")]
        [Validation(Required=false)]
        public DescribeVerifyTokenResponseBodyOssUploadToken OssUploadToken { get; set; }
        public class DescribeVerifyTokenResponseBodyOssUploadToken : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("Secret")]
            [Validation(Required=false)]
            public string Secret { get; set; }
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public long? Expired { get; set; }
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }
            [NameInMap("Bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
        };

        [NameInMap("VerifyToken")]
        [Validation(Required=false)]
        public string VerifyToken { get; set; }

    }

}
