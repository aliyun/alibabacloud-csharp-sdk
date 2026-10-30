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
        /// <item><description>Query cluster machine list scenario: Set the retrieval type to comm_instance_id_list or instance_id_list. comm_instance_id_list: Retrieves only the list of machines in the specified cluster that participate in collective communication. instance_id_list: Retrieves the list of all machines in the specified cluster.</description></item>
        /// <item><description>Query cluster AI task list scenario: Set the retrieval type to comm_task_id_list or task_id_list. comm_task_id_list: Retrieves only the list of tasks in the specified cluster that involve collective communication. task_id_list: Retrieves the list of all tasks in the specified cluster.</description></item>
        /// <item><description>Query cluster AI job pod list scenario: Set the retrieval type to comm_pod_list or pod_list. comm_pod_list: Retrieves only the list of pods in the specified cluster that participate in collective communication. pod_list: Retrieves the list of all pods in the specified cluster.</description></item>
        /// <item><description>Query collective communication topology scenario: communication: Retrieves all communication group IDs. channel: Retrieves the channel list under the specified communication group ID. topoType: Retrieves the topology type under the specified channel of the specified communication group ID.</description></item>
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
        /// <para>The filter conditions, which is a JSON object. The cluster_id field is required. Other filter conditions support the following values:</para>
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
