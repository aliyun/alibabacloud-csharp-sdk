// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The queried resource group information.
        /// </summary>
        [NameInMap("ResourceGroupItems")]
        [Validation(Required=false)]
        public DescribeDBResourceGroupResponseBodyResourceGroupItems ResourceGroupItems { get; set; }
        public class DescribeDBResourceGroupResponseBodyResourceGroupItems : TeaModel {
            [NameInMap("ResourceGroupItem")]
            [Validation(Required=false)]
            public List<DescribeDBResourceGroupResponseBodyResourceGroupItemsResourceGroupItem> ResourceGroupItem { get; set; }
            public class DescribeDBResourceGroupResponseBodyResourceGroupItemsResourceGroupItem : TeaModel {
                /// <summary>
                /// The configurations of the resource group.
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
                /// </summary>
                [NameInMap("ResourceGroupConfig")]
                [Validation(Required=false)]
                public string ResourceGroupConfig { get; set; }

                /// <summary>
                /// The name of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                /// <summary>
                /// The roles.
                /// </summary>
                [NameInMap("RoleList")]
                [Validation(Required=false)]
                public DescribeDBResourceGroupResponseBodyResourceGroupItemsResourceGroupItemRoleList RoleList { get; set; }
                public class DescribeDBResourceGroupResponseBodyResourceGroupItemsResourceGroupItemRoleList : TeaModel {
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public List<string> Role { get; set; }

                }

            }

        }

    }

}
