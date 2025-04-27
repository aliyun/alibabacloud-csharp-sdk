// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CapacityPlanResponseBody : TeaModel {
        /// <summary>
        /// <para>ID of the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E91B7129-A669-4D9D-A743-F90A0FF1F5EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned result of the request.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public CapacityPlanResponseBodyResult Result { get; set; }
        public class CapacityPlanResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Extended configuration information.</para>
            /// </summary>
            [NameInMap("ExtendConfigs")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultExtendConfigs> ExtendConfigs { get; set; }
            public class CapacityPlanResponseBodyResultExtendConfigs : TeaModel {
                /// <summary>
                /// <para>Configuration type, with a single value: sharedDisk.</para>
                /// <remarks>
                /// <para>This extendConfigs attribute may appear when the planned instance type is Advanced.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>sharedDisk</para>
                /// </summary>
                [NameInMap("ConfigType")]
                [Validation(Required=false)]
                public string ConfigType { get; set; }

                /// <summary>
                /// <para>Disk size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2048</para>
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                /// <summary>
                /// <para>Disk type, with a single value: CPFS_PREMIUM.</para>
                /// <remarks>
                /// <para>This extendConfigs attribute may appear when the planned instance type is Advanced.</para>
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
            /// <para>Edition type, with values meaning as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>advanced: Enhanced Edition</para>
            /// </description></item>
            /// <item><description><para>x-pack: Commercial Edition</para>
            /// </description></item>
            /// <item><description><para>community: Community Edition</para>
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
            /// <para>Node information.</para>
            /// </summary>
            [NameInMap("NodeConfigurations")]
            [Validation(Required=false)]
            public List<CapacityPlanResponseBodyResultNodeConfigurations> NodeConfigurations { get; set; }
            public class CapacityPlanResponseBodyResultNodeConfigurations : TeaModel {
                /// <summary>
                /// <para>Number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Amount")]
                [Validation(Required=false)]
                public long? Amount { get; set; }

                /// <summary>
                /// <para>Number of CPUs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public long? Cpu { get; set; }

                /// <summary>
                /// <para>Disk size, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Disk")]
                [Validation(Required=false)]
                public long? Disk { get; set; }

                /// <summary>
                /// <para>Disk type, with meanings as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>cloud_essd: ESSD Cloud Disk</para>
                /// </description></item>
                /// <item><description><para>cloud_ssd: SSD Cloud Disk</para>
                /// </description></item>
                /// <item><description><para>cloud_efficiency: Efficient Cloud Disk</para>
                /// </description></item>
                /// <item><description><para>local_ssd: Local SSD Disk</para>
                /// </description></item>
                /// <item><description><para>local_efficiency: Local Efficient Disk</para>
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
                /// <para>Specified memory size for the current node role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public long? Memory { get; set; }

                /// <summary>
                /// <para>Node type, with supported types as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>WORKER: Data Node</para>
                /// </description></item>
                /// <item><description><para>WORKER_WARM: Cold Data Node</para>
                /// </description></item>
                /// <item><description><para>MASTER: Dedicated Master Node</para>
                /// </description></item>
                /// <item><description><para>KIBANA: Kibana Node</para>
                /// </description></item>
                /// <item><description><para>COORDINATING: Coordinator Node</para>
                /// </description></item>
                /// <item><description><para>ELASTIC_WORKER: Elastic Node</para>
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
            /// <para>Based on the capacity planning calculation, there is no default value. The meanings of the values are as follows:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Represents an oversized cluster, indicating that the number of data nodes calculated by the capacity planning exceeds the threshold of 50.</para>
            /// </description></item>
            /// <item><description><para>false: The number of data nodes calculated by the capacity planning is within 50.</para>
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
