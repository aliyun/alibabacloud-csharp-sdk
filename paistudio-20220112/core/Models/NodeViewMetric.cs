// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeViewMetric : TeaModel {
        /// <summary>
        /// <para>The CPU utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>59</para>
        /// </summary>
        [NameInMap("CPUUsageRate")]
        [Validation(Required=false)]
        public string CPUUsageRate { get; set; }

        /// <summary>
        /// <para>The node import time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-08-25T15:20:56Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// <para>The disk read rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("DiskReadRate")]
        [Validation(Required=false)]
        public string DiskReadRate { get; set; }

        /// <summary>
        /// <para>The disk write rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("DiskWriteRate")]
        [Validation(Required=false)]
        public string DiskWriteRate { get; set; }

        /// <summary>
        /// <para>The GPU model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V100</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The machine group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mg1</para>
        /// </summary>
        [NameInMap("MachineGroupID")]
        [Validation(Required=false)]
        public string MachineGroupID { get; set; }

        /// <summary>
        /// <para>The memory utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MemoryUsageRate")]
        [Validation(Required=false)]
        public string MemoryUsageRate { get; set; }

        /// <summary>
        /// <para>The network inbound rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkInputRate")]
        [Validation(Required=false)]
        public string NetworkInputRate { get; set; }

        /// <summary>
        /// <para>The network outbound rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NetworkOutputRate")]
        [Validation(Required=false)]
        public string NetworkOutputRate { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-i121212node</para>
        /// </summary>
        [NameInMap("NodeID")]
        [Validation(Required=false)]
        public string NodeID { get; set; }

        /// <summary>
        /// <para>The node status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("NodeStatus")]
        [Validation(Required=false)]
        public string NodeStatus { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.large</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The used CPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public long? RequestCPU { get; set; }

        /// <summary>
        /// <para>The used GPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public long? RequestGPU { get; set; }

        /// <summary>
        /// <para>The used memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>102400000</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public long? RequestMemory { get; set; }

        /// <summary>
        /// <para>The node tasks.</para>
        /// </summary>
        [NameInMap("TaskIdMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> TaskIdMap { get; set; }

        /// <summary>
        /// <para>The total CPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCPU")]
        [Validation(Required=false)]
        public long? TotalCPU { get; set; }

        /// <summary>
        /// <para>The total GPU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalGPU")]
        [Validation(Required=false)]
        public long? TotalGPU { get; set; }

        /// <summary>
        /// <para>The total memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10240</para>
        /// </summary>
        [NameInMap("TotalMemory")]
        [Validation(Required=false)]
        public long? TotalMemory { get; set; }

        /// <summary>
        /// <para>The total number of node tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalTasks")]
        [Validation(Required=false)]
        public long? TotalTasks { get; set; }

        /// <summary>
        /// <para>The user list.</para>
        /// </summary>
        [NameInMap("UserIDs")]
        [Validation(Required=false)]
        public List<string> UserIDs { get; set; }

        /// <summary>
        /// <para>The total number of users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UserNumber")]
        [Validation(Required=false)]
        public string UserNumber { get; set; }

    }

}
