// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CapacityPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E91B7129-A669-4D9D-A743-F90A0FF1F5EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the request.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CapacityPlanResponseBodyResult Result { get; set; }
        public class CapacityPlanResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The extended configuration information.</para>
            /// </summary>
            [NameInMap("ExtendConfigs")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class CapacityPlanResponseBodyResultExtendConfigs : TeaModel {
                /// <summary>
                /// <para>The configuration type. The only valid value is sharedDisk.</para>
                /// <remarks>
                /// <para>This extendConfigs property may appear when the planned instance type is Advanced Edition (advanced).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>sharedDisk</para>
                /// </summary>
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// <para>The disk size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                /// <summary>
                /// <para>The disk type. The only valid value is CPFS_PREMIUM.</para>
                /// <remarks>
                /// <para>This extendConfigs property may appear when the planned instance type is Advanced Edition (advanced).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>CPFS_PREMIUM</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

            }

            /// <summary>
            /// <para>The edition type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>advanced: Advanced Edition</para>
            /// </description></item>
            /// <item><description><para>x-pack: Commercial Edition</para>
            /// </description></item>
            /// <item><description><para>community: Community Edition.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>advanced</para>
            /// </summary>
            [NameInMap("InstanceCategory")]
            [Validation(Required=false)]
            public string InstanceCategory { get; set; }

            /// <summary>
            /// <para>The node information.</para>
            /// </summary>
            [NameInMap("NodeConfigurations")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultNodeConfigurations> NodeConfigurations { get; set; }
            public class CapacityPlanResponseBodyResultNodeConfigurations : TeaModel {
                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// <para>The number of CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }

                /// <summary>
                /// <para>The disk size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                /// <summary>
                /// <para>The disk type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>cloud_essd: ESSD</para>
                /// </description></item>
                /// <item><description><para>cloud_ssd: standard SSD</para>
                /// </description></item>
                /// <item><description><para>cloud_efficiency: ultra cloud disk</para>
                /// </description></item>
                /// <item><description><para>local_ssd: local SSD</para>
                /// </description></item>
                /// <item><description><para>local_efficiency: local ultra disk.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_ssd</para>
                /// </summary>
                [NameInMap("DiskType")]
                [Validation(Required=false)]
                public string DiskType { get; set; }

                /// <summary>
                /// <para>The memory size of the specifications for the current node role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public long? Memory { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>WORKER: data node</para>
                /// </description></item>
                /// <item><description><para>WORKER_WARM: warm node</para>
                /// </description></item>
                /// <item><description><para>MASTER: dedicated master node</para>
                /// </description></item>
                /// <item><description><para>KIBANA: Kibana node</para>
                /// </description></item>
                /// <item><description><para>COORDINATING: client node</para>
                /// </description></item>
                /// <item><description><para>ELASTIC_WORKER: elastic node.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WORKER</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

            }

            /// <summary>
            /// <para>The result calculated based on capacity planning. No default value is available. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The cluster is oversized. The number of data nodes calculated by capacity planning exceeds the threshold of 50.</para>
            /// </description></item>
            /// <item><description><para>false: The number of data nodes calculated by capacity planning is within 50.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("OversizedCluster")]
            [Validation(Required=false)]
            public bool? OversizedCluster { get; set; }

        }

    }

}
