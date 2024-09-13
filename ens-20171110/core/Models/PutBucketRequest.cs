// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PutBucketRequest : TeaModel {
        /// <summary>
        /// The access control list (ACL) of the bucket. Valid values:
        /// 
        /// *   **private** (default)
        /// *   **public-read-write**
        /// *   **public-read**
        /// </summary>
        [NameInMap("BucketAcl")]
        [Validation(Required=false)]
        public string BucketAcl { get; set; }

        /// <summary>
        /// The name of the bucket. This parameter can contain 3 to 50 characters in length and can contain only lowercase letters, digits, and hyphens (-). The name cannot start or end with a hyphen (-).
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
        /// The scheduling scope. This parameter takes effect only when the value of the LogicalBucketType parameter is standard. Valid values:
        /// 
        /// *   **domestic**: Chinese mainland.
        /// *   **oversea**: outside the Chinese mainland.
        /// </summary>
        [NameInMap("DispatchScope")]
        [Validation(Required=false)]
        public string DispatchScope { get; set; }

        /// <summary>
        /// The region ID of the node. This parameter is required if the value of the LogicalBucketType parameter is sink.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The type of the bucket. Valid values:
        /// 
        /// *   **sink**: single-node bucket.
        /// *   **standard**: bucket for global scheduling.
        /// </summary>
        [NameInMap("LogicalBucketType")]
        [Validation(Required=false)]
        public string LogicalBucketType { get; set; }

    }

}
