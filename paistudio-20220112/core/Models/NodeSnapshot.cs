// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeSnapshot : TeaModel {
        /// <summary>
        /// <para>The number of workloads using ancestor quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AncestorQuotaWorkloadNum")]
        [Validation(Required=false)]
        public int? AncestorQuotaWorkloadNum { get; set; }

        /// <summary>
        /// <para>The number of workloads using descendant quotas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DescendantQuotaWorkloadNum")]
        [Validation(Required=false)]
        public int? DescendantQuotaWorkloadNum { get; set; }

        /// <summary>
        /// <para>The node name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>trains930928remn-master-0</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The CPU usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public string RequestCPU { get; set; }

        /// <summary>
        /// <para>The GPU usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public string RequestGPU { get; set; }

        /// <summary>
        /// <para>The memory usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        /// <summary>
        /// <para>The number of workloads using the current quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SelfQuotaWorkloadNum")]
        [Validation(Required=false)]
        public int? SelfQuotaWorkloadNum { get; set; }

        /// <summary>
        /// <para>The number of node workloads.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("WorkloadNum")]
        [Validation(Required=false)]
        public int? WorkloadNum { get; set; }

        /// <summary>
        /// <para>The node workload snapshot.</para>
        /// </summary>
        [NameInMap("Workloads")]
        [Validation(Required=false)]
        public List<NodeSnapshotWorkloads> Workloads { get; set; }
        public class NodeSnapshotWorkloads : TeaModel {
            /// <summary>
            /// <para>The corresponding queue unit name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dlc1yhisjtmqh15s-master-0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The workload ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dlcxxxx</para>
            /// </summary>
            [NameInMap("WorkloadId")]
            [Validation(Required=false)]
            public string WorkloadId { get; set; }

            /// <summary>
            /// <para>The workload type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dlc</para>
            /// </summary>
            [NameInMap("WorkloadType")]
            [Validation(Required=false)]
            public string WorkloadType { get; set; }

        }

    }

}
