// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyDBResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The information about the resource group.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceGroupItems")]
        [Validation(Required=false)]
        public List<ModifyDBResourceGroupRequestResourceGroupItems> ResourceGroupItems { get; set; }
        public class ModifyDBResourceGroupRequestResourceGroupItems : TeaModel {
            /// <summary>
            /// <para>The configurations of the resource group to which you want to modify.</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;CpuRateLimit&quot;:&quot;10&quot;,&quot;MemoryLimit&quot;:&quot;12&quot;,&quot;MemorySharedQuota&quot;:&quot;20&quot;,&quot;MemorySpillRatio&quot;:&quot;75&quot;,&quot;Concurrency&quot;:&quot;3&quot;}</para>
            /// </summary>
            [NameInMap("ResourceGroupConfig")]
            [Validation(Required=false)]
            public string ResourceGroupConfig { get; set; }

            /// <summary>
            /// <para>The name of the resource group.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testgroup</para>
            /// </summary>
            [NameInMap("ResourceGroupName")]
            [Validation(Required=false)]
            public string ResourceGroupName { get; set; }

        }

    }

}
