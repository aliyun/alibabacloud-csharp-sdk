// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class PutBucketHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        [NameInMap("x-oss-acl")]
        [Validation(Required=false)]
        public string Acl { get; set; }

        [NameInMap("x-oss-resource-group-id")]
        [Validation(Required=false)]
        public string XOssResourceGroupId { get; set; }

    }

}
