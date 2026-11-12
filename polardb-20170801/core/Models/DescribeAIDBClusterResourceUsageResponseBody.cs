// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeAIDBClusterResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the cluster was created, in ISO 8601 UTC format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-13T15:45:27Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the AI database cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zeu0t5v0p98*****</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The database engine of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AI</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The list of resource usage details for the nodes in the cluster.</para>
        /// </summary>
        [NameInMap("NodeItems")]
        [Validation(Required=false)]
        public List<DescribeAIDBClusterResourceUsageResponseBodyNodeItems> NodeItems { get; set; }
        public class DescribeAIDBClusterResourceUsageResponseBodyNodeItems : TeaModel {
            /// <summary>
            /// <para>The total CPU resources of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("CPU")]
            [Validation(Required=false)]
            public string CPU { get; set; }

            /// <summary>
            /// <para>The amount of CPU resources used on the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CPUUsed")]
            [Validation(Required=false)]
            public string CPUUsed { get; set; }

            /// <summary>
            /// <para>The ID of the database node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pi-2ze7sztqv1*****</para>
            /// </summary>
            [NameInMap("DBNodeId")]
            [Validation(Required=false)]
            public string DBNodeId { get; set; }

            /// <summary>
            /// <para>The total GPU resources of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GPU")]
            [Validation(Required=false)]
            public string GPU { get; set; }

            /// <summary>
            /// <para>The GPU model of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NVIDIA A10</para>
            /// </summary>
            [NameInMap("GPUModel")]
            [Validation(Required=false)]
            public string GPUModel { get; set; }

            /// <summary>
            /// <para>The amount of GPU resources used on the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GPUUsed")]
            [Validation(Required=false)]
            public string GPUUsed { get; set; }

            /// <summary>
            /// <para>The total memory of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16Gi</para>
            /// </summary>
            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The amount of memory used on the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8Gi</para>
            /// </summary>
            [NameInMap("MemoryUsed")]
            [Validation(Required=false)]
            public string MemoryUsed { get; set; }

            /// <summary>
            /// <para>The list of resource information for the pods on the node.</para>
            /// </summary>
            [NameInMap("PodItems")]
            [Validation(Required=false)]
            public List<DescribeAIDBClusterResourceUsageResponseBodyNodeItemsPodItems> PodItems { get; set; }
            public class DescribeAIDBClusterResourceUsageResponseBodyNodeItemsPodItems : TeaModel {
                /// <summary>
                /// <para>The time when the pod was created, in ISO 8601 UTC format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-09-13T15:45:27Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ai-db-pod-001</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The namespace to which the pod belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("NameSpace")]
                [Validation(Required=false)]
                public string NameSpace { get; set; }

                /// <summary>
                /// <para>The IP address of the pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.0.12</para>
                /// </summary>
                [NameInMap("PodIP")]
                [Validation(Required=false)]
                public string PodIP { get; set; }

                /// <summary>
                /// <para>The resource configuration requested by the pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cpu=1,memory=2Gi</para>
                /// </summary>
                [NameInMap("ResourceRequest")]
                [Validation(Required=false)]
                public string ResourceRequest { get; set; }

                /// <summary>
                /// <para>The running status of the pod.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the virtual node corresponding to the database node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vnode-001</para>
            /// </summary>
            [NameInMap("VNodeId")]
            [Validation(Required=false)]
            public string VNodeId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2921D843-433A-5FB3-A03B-4EC093B219F8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
