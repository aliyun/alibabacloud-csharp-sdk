// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyResubmitConfigRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the information about all AnalyticDB for MySQL clusters within a region, including cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The job resubmission rules.
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ModifyResubmitConfigRequestRules> Rules { get; set; }
        public class ModifyResubmitConfigRequestRules : TeaModel {
            /// <summary>
            /// Specifies whether to configure out-of-memory (OOM) check.
            /// </summary>
            [NameInMap("ExceedMemoryException")]
            [Validation(Required=false)]
            public bool? ExceedMemoryException { get; set; }

            /// <summary>
            /// The name of the source resource group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The peak memory usage.
            /// </summary>
            [NameInMap("PeakMemory")]
            [Validation(Required=false)]
            public string PeakMemory { get; set; }

            /// <summary>
            /// The duration of the SQL statement. Unit: milliseconds.
            /// </summary>
            [NameInMap("QueryTime")]
            [Validation(Required=false)]
            public string QueryTime { get; set; }

            /// <summary>
            /// The name of the destination resource group.
            /// </summary>
            [NameInMap("TargetGroupName")]
            [Validation(Required=false)]
            public string TargetGroupName { get; set; }

        }

    }

}
