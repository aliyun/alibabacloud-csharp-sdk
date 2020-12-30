// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth_console20190219.Models
{
    public class DescribeOssOauthResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOssOauthResponseBodyData Data { get; set; }
        public class DescribeOssOauthResponseBodyData : TeaModel {
            [NameInMap("OssServe")]
            [Validation(Required=false)]
            public bool? OssServe { get; set; }
            [NameInMap("BucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }
            [NameInMap("OpenOssService")]
            [Validation(Required=false)]
            public bool? OpenOssService { get; set; }
            [NameInMap("OssAuthorized")]
            [Validation(Required=false)]
            public bool? OssAuthorized { get; set; }
            [NameInMap("OpenOssTime")]
            [Validation(Required=false)]
            public long? OpenOssTime { get; set; }
        };

    }

}
