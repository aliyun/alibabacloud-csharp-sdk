// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyDBResourceGroupRequest : TeaModel {
        /// <summary>
        /// The instance ID.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The information about the resource group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceGroupItems")]
        [Validation(Required=false)]
        public List<ModifyDBResourceGroupRequestResourceGroupItems> ResourceGroupItems { get; set; }
        public class ModifyDBResourceGroupRequestResourceGroupItems : TeaModel {
            /// <summary>
            /// The configurations of the resource group to which you want to modify.
            /// 
            /// > 
            /// 
            /// *   CpuRateLimit: the percentage of CPU resources that are available for the resource group. Unit: %.
            /// 
            /// *   MemoryLimit: the percentage of memory resources that are available for the resource group. Unit: %.
            /// 
            /// *   MemorySharedQuota: the percentage of memory resources shared among transactions that are submitted to the resource group. Unit: %. Default value: 80.
            /// 
            /// *   MemorySpillRatio: the memory spill ratio for memory-intensive transactions. When the memory that is used by memory-intensive transactions reaches this value, data is spilled to disks. Unit: %. Default value: 0.
            /// 
            /// *   Concurrency: the maximum number of concurrent transactions or parallel queries that are allowed for a resource group. Default value: 20.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceGroupConfig")]
            [Validation(Required=false)]
            public string ResourceGroupConfig { get; set; }

            /// <summary>
            /// The name of the resource group.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

        }

    }

}
