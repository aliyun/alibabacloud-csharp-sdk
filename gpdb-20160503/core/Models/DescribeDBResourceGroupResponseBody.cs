// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The queried resource group information.</para>
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
                /// <para>The configurations of the resource group.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>CpuRateLimit: the percentage of CPU resources that are available for the resource group. Unit: %.</para>
                /// </description></item>
                /// <item><description><para>MemoryLimit: the percentage of memory resources that are available for the resource group. Unit: %.</para>
                /// </description></item>
                /// <item><description><para>MemorySharedQuota: the percentage of memory resources shared among transactions that are submitted to the resource group. Unit: %. Default value: 80.</para>
                /// </description></item>
                /// <item><description><para>MemorySpillRatio: the memory spill ratio for memory-intensive transactions. When the memory that is used by memory-intensive transactions reaches this value, data is spilled to disks. Unit: %. Default value: 0.</para>
                /// </description></item>
                /// <item><description><para>Concurrency: the maximum number of concurrent transactions or parallel queries that are allowed for a resource group. Default value: 20.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;CpuRateLimit&quot;:&quot;10&quot;,&quot;MemoryLimit&quot;:&quot;12&quot;,&quot;MemorySharedQuota&quot;:&quot;20&quot;,&quot;MemorySpillRatio&quot;:&quot;75&quot;,&quot;Concurrency&quot;:&quot;3&quot;}</para>
                /// </summary>
                [NameInMap("ResourceGroupConfig")]
                [Validation(Required=false)]
                public string ResourceGroupConfig { get; set; }

                /// <summary>
                /// <para>The name of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testgroup</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                /// <summary>
                /// <para>The roles.</para>
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
