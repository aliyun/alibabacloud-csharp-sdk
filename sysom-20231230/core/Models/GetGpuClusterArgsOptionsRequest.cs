// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetGpuClusterArgsOptionsRequest : TeaModel {
        /// <summary>
        /// <ol>
        /// <item><description><para>Query the machine list of a cluster
        /// Set the retrieval type to comm_instance_id_list or instance_id_list.
        /// comm_instance_id_list: retrieves only the machines that participate in collective communication in the specified cluster.
        /// instance_id_list: retrieves all machines in the specified cluster.</para>
        /// </description></item>
        /// <item><description><para>Query the AI task list of a cluster
        /// Set the retrieval type to comm_task_id_list or task_id_list.
        /// comm_task_id_list: retrieves only the tasks that involve collective communication in the specified cluster.
        /// task_id_list: retrieves all tasks in the specified cluster.</para>
        /// </description></item>
        /// <item><description><para>Query the AI job pod list of a cluster
        /// Set the retrieval type to comm_pod_list or pod_list.
        /// comm_pod_list: retrieves only the pods that participate in collective communication in the specified cluster.
        /// pod_list: retrieves all pods in the specified cluster.</para>
        /// </description></item>
        /// <item><description><para>Query the collective communication topology
        /// communication: retrieves all communication group IDs.
        /// channel: retrieves the channel list under the specified communication group ID.
        /// topoType: retrieves the topology type under the specified channel of the specified communication group ID.</para>
        /// </description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance_id_list</para>
        /// </summary>
        [NameInMap("filterType")]
        [Validation(Required=false)]
        public string FilterType { get; set; }

        /// <summary>
        /// <para>The filter conditions. The value is a JSON object. The cluster_id field is required. The following optional filter conditions are supported:</para>
        /// <list type="bullet">
        /// <item><description>instance_id_list</description></item>
        /// <item><description>comm_instance_id_list</description></item>
        /// <item><description>pod_list</description></item>
        /// <item><description>comm_pod_list</description></item>
        /// <item><description>communication</description></item>
        /// <item><description>task_id_list</description></item>
        /// <item><description>comm_task_id_list</description></item>
        /// <item><description>channel</description></item>
        /// <item><description>topoType</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{
        /// &quot;cluster_id&quot;: &quot;cluster1&quot;
        /// }</para>
        /// </summary>
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public object FilterValues { get; set; }

    }

}
