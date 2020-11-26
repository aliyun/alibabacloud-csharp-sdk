// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeOssUploadTokenResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("OssUploadToken")]
        [Validation(Required=true)]
        public DescribeOssUploadTokenResponseOssUploadToken OssUploadToken { get; set; }
        public class DescribeOssUploadTokenResponseOssUploadToken : TeaModel {
            [NameInMap("Bucket")]
            [Validation(Required=true)]
            public string Bucket { get; set; }
            [NameInMap("EndPoint")]
            [Validation(Required=true)]
            public string EndPoint { get; set; }
            [NameInMap("Path")]
            [Validation(Required=true)]
            public string Path { get; set; }
            [NameInMap("Expired")]
            [Validation(Required=true)]
            public long Expired { get; set; }
            [NameInMap("Secret")]
            [Validation(Required=true)]
            public string Secret { get; set; }
            [NameInMap("Key")]
            [Validation(Required=true)]
            public string Key { get; set; }
            [NameInMap("Token")]
            [Validation(Required=true)]
            public string Token { get; set; }
        };

    }

}
