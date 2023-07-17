// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class DescribeUploadTokenResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeUploadTokenResponseBodyData Data { get; set; }
        public class DescribeUploadTokenResponseBodyData : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public int? Expiration { get; set; }

            [NameInMap("FileNamePrefix")]
            [Validation(Required=false)]
            public string FileNamePrefix { get; set; }

            [NameInMap("OssInternalEndPoint")]
            [Validation(Required=false)]
            public string OssInternalEndPoint { get; set; }

            [NameInMap("OssInternetEndPoint")]
            [Validation(Required=false)]
            public string OssInternetEndPoint { get; set; }

            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
