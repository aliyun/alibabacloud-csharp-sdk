// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeLifecyclePoliciesResponseBody : TeaModel {
        /// <summary>
        /// The queried lifecycle policies.
        /// </summary>
        [NameInMap("LifecyclePolicies")]
        [Validation(Required=false)]
        public List<DescribeLifecyclePoliciesResponseBodyLifecyclePolicies> LifecyclePolicies { get; set; }
        public class DescribeLifecyclePoliciesResponseBodyLifecyclePolicies : TeaModel {
            /// <summary>
            /// The time when the lifecycle policy was created.
            /// 
            /// The time follows the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the file system.
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// The name of the lifecycle policy.
            /// </summary>
            [NameInMap("LifecyclePolicyName")]
            [Validation(Required=false)]
            public string LifecyclePolicyName { get; set; }

            /// <summary>
            /// The management rule that is associated with the lifecycle policy.
            /// 
            /// Valid values:
            /// 
            /// *   DEFAULT_ATIME_14: Files that are not accessed in the last 14 days are dumped to the IA storage medium.
            /// *   DEFAULT_ATIME_30: Files that are not accessed in the last 30 days are dumped to the IA storage medium.
            /// *   DEFAULT_ATIME_60: Files that are not accessed in the last 60 days are dumped to the IA storage medium.
            /// *   DEFAULT_ATIME_90: Files that are not accessed in the last 90 days are dumped to the IA storage medium.
            /// </summary>
            [NameInMap("LifecycleRuleName")]
            [Validation(Required=false)]
            public string LifecycleRuleName { get; set; }

            /// <summary>
            /// The absolute path of a directory with which the lifecycle policy is associated.
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// The absolute paths to multiple directories associated with the lifecycle policy.
            /// </summary>
            [NameInMap("Paths")]
            [Validation(Required=false)]
            public List<string> Paths { get; set; }

            /// <summary>
            /// The storage type of the data that is dumped to the IA storage medium.
            /// 
            /// Default value: InfrequentAccess (IA).
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of lifecycle policies.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
