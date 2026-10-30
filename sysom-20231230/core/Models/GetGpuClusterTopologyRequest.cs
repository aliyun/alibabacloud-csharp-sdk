// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetGpuClusterTopologyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the channel. Used to view the collective communication topology and the topology relationships of a specified channel ID under a specified communication group, such as the communication, tree, or ring topology among ranks within a communication group. This parameter must be used together with communication_id and topo_type. You can call the GetGpuClusterArgsOptions operation with the channel filter parameter to obtain the list of channel_id values under a specified communication_id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>communicationId =0x412523235123
        /// channelId=1
        /// topoType=ring</para>
        /// </summary>
        [NameInMap("channelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The name of the cluster. You can select a cluster from the cluster list obtained by calling the GetListGpuCluster operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;cluster1&quot;</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the communication group. Used to view the collective communication topology and the topology relationships of a specified communication group ID, such as the communication, tree, or ring topology among ranks within a communication group. This parameter must be used together with channel_id and topo_type. You can call the GetGpuClusterArgsOptions operation with the communication filter type to obtain the list of communication_id values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>communicationId =0x412523235123
        /// channelId=1
        /// topoType=ring</para>
        /// </summary>
        [NameInMap("communicationId")]
        [Validation(Required=false)]
        public string CommunicationId { get; set; }

        /// <summary>
        /// <para>The list of instances for which to query GPU topology information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;instance1&quot;, &quot;instance2&quot;,&quot;instance3&quot;]</para>
        /// </summary>
        [NameInMap("instanceIdList")]
        [Validation(Required=false)]
        public object InstanceIdList { get; set; }

        /// <summary>
        /// <para>The list of pods for which to query GPU topology information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;pod1&quot;, &quot;pod2&quot;,&quot;pod3&quot;]</para>
        /// </summary>
        [NameInMap("podList")]
        [Validation(Required=false)]
        public object PodList { get; set; }

        /// <summary>
        /// <para>The query timestamp. Default value: the current time. The timestamp must be accurate to seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1709740800</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The list of tasks for which to query GPU topology information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;task1&quot;, &quot;task2&quot;]</para>
        /// </summary>
        [NameInMap("taskIdList")]
        [Validation(Required=false)]
        public object TaskIdList { get; set; }

        /// <summary>
        /// <para>The topology type. Used to view the collective communication topology and the topology relationships of a specified topology type under a specified communication group and channel ID, such as the communication, tree, or ring topology among ranks within a communication group. This parameter must be used together with communication_id and channel_id. You can call the GetGpuClusterArgsOptions operation with the topoType filter parameter to obtain the list of topo_type values under a specified communication_id and channel_id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>communicationId =0x412523235123
        /// channelId=1
        /// topoType=ring</para>
        /// </summary>
        [NameInMap("topoType")]
        [Validation(Required=false)]
        public string TopoType { get; set; }

    }

}
