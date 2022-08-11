// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class MigrateClusterRequest : TeaModel {
        [NameInMap("oss_bucket_endpoint")]
        [Validation(Required=false)]
        public string OssBucketEndpoint { get; set; }

        [NameInMap("oss_bucket_name")]
        [Validation(Required=false)]
        public string OssBucketName { get; set; }

    }

}
