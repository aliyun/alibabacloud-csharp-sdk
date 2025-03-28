// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class ArtifactTempBucketToken : TeaModel {
        [NameInMap("credentials")]
        [Validation(Required=false)]
        public ArtifactTempBucketTokenCredentials Credentials { get; set; }
        public class ArtifactTempBucketTokenCredentials : TeaModel {
            [NameInMap("accessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("accessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("securityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        [NameInMap("ossBucketName")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

        [NameInMap("ossObjectName")]
        [Validation(Required=false)]
        public string OssObjectName { get; set; }

        [NameInMap("ossRegion")]
        [Validation(Required=false)]
        public string OssRegion { get; set; }

    }

}
