// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketRequest : TeaModel {
        /// <summary>
        /// The access control list (ACL) of the bucket.
        /// 
        /// *   **private** (default)
        /// *   **public-read-write**
        /// *   **public-read**
        /// </summary>
        [NameInMap("BucketAcl")]
        [Validation(Required=false)]
        public string BucketAcl { get; set; }

        /// <summary>
        /// The name of the bucket.
        /// 
        /// This parameter can contain 3 to 50 characters in length and can contain only lowercase letters, digits, and hyphens (-). The name cannot start or end with a hyphen (-).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("BucketName")]
        [Validation(Required=false)]
        public string BucketName { get; set; }

        /// <summary>
        /// The remarks. The remarks are 0 to 128 characters in length.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the region where the node is located. If this parameter is not specified, the node is the global default node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// Single-node storage. Set the value to sink.
        /// </summary>
        [NameInMap("LogicalBucketType")]
        [Validation(Required=false)]
        public string LogicalBucketType { get; set; }

    }

}
