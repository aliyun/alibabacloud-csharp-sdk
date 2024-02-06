// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketAclRequest : TeaModel {
        /// <summary>
        /// The ACL of the bucket.
        /// 
        /// *   **public-read-write**
        /// *   **public-read**
        /// *   **private** (default)
        /// </summary>
        [NameInMap("BucketAcl")]
        [Validation(Required=false)]
        public string BucketAcl { get; set; }

        /// <summary>
        /// The name of the bucket.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

    }

}
