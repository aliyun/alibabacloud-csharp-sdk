// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetGpuClusterTopologyRequest : TeaModel {
        /// <summary>
        /// <para>Used when viewing collective communication topology. Specifies the topology relationship for a given channel ID within a communication group, such as the inter-rank communication topology (tree or ring topology). Must be used together with communication_id and topo_type.</para>
        /// <para>⚠️ Use the channel filter parameter of the GetGpuClusterArgsOptions operation to retrieve the list of channel_id values for a specified communication_id.</para>
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
        /// <para>The cluster name. Select a cluster from the cluster list returned by the GetListGpuCluster operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;cluster1&quot;</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Used when viewing collective communication topology. Specifies the topology relationship for a given communication group ID, such as the inter-rank communication topology (tree or ring topology) within a communication group. Must be used together with channel_id and topo_type.</para>
        /// <para>⚠️ Use the communication filter type of the GetGpuClusterArgsOptions operation to retrieve the list of communication_id values.</para>
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
        /// <para>The GPU topology information for the specified list of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;instance1&quot;, &quot;instance2&quot;,&quot;instance3&quot;]</para>
        /// </summary>
        [NameInMap("instanceIdList")]
        [Validation(Required=false)]
        public object InstanceIdList { get; set; }

        /// <summary>
        /// <para>The GPU topology information for the specified list of pods.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;pod1&quot;, &quot;pod2&quot;,&quot;pod3&quot;]</para>
        /// </summary>
        [NameInMap("podList")]
        [Validation(Required=false)]
        public object PodList { get; set; }

        /// <summary>
        /// <para>The timestamp for the query. Defaults to the current time. Must be a second-level timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1709740800</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The GPU topology information for the specified list of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;task1&quot;, &quot;task2&quot;]</para>
        /// </summary>
        [NameInMap("taskIdList")]
        [Validation(Required=false)]
        public object TaskIdList { get; set; }

        /// <summary>
        /// <para>Used when viewing collective communication topology. Specifies the topology relationship for a given topology type within a communication group and channel, such as the inter-rank communication topology (tree or ring topology). Must be used together with communication_id and channel_id.</para>
        /// <para>⚠️ Use the topoType filter parameter of the GetGpuClusterArgsOptions operation to retrieve the list of topo_type values for a specified communication_id and channel_id.</para>
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
