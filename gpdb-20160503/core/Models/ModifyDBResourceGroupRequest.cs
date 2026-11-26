// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyDBResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specified region, including instance IDs.</para>
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
        /// <para>The details of the resource groups.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceGroupItems")]
        [Validation(Required=false)]
        public List<ModifyDBResourceGroupRequestResourceGroupItems> ResourceGroupItems { get; set; }
        public class ModifyDBResourceGroupRequestResourceGroupItems : TeaModel {
            /// <summary>
            /// <para>The configuration of the resource group.</para>
            /// <remarks>
            /// <ol>
            /// <item><description>CpuRateLimit: the percentage of CPU resources available to the resource group. Unit: %.</description></item>
            /// <item><description>MemoryLimit: the percentage of memory resources available to the resource group. Unit: %.</description></item>
            /// <item><description>MemorySharedQuota: the percentage of memory resources shared among transactions submitted to the resource group. Unit: %. Default value: 80.</description></item>
            /// <item><description>MemorySpillRatio: the memory usage threshold for memory-intensive transactions. When a transaction reaches this threshold, it spills to disk. Unit: %. Default value: 0.</description></item>
            /// <item><description>Concurrency: the maximum concurrency allowed for the resource group. Default value: 20.</description></item>
            /// </ol>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;CpuRateLimit&quot;:10,&quot;MemoryLimit&quot;:12,&quot;MemorySharedQuota&quot;:20,&quot;MemorySpillRatio&quot;:75,&quot;Concurrency&quot;:3}</para>
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
