// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateExperimentRunRequest : TeaModel {
        /// <summary>
        /// <para>The completion time. The value is a millisecond-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784721811392</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// <para>The number of completed tasks. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("completedTasks")]
        [Validation(Required=false)]
        public int? CompletedTasks { get; set; }

        /// <summary>
        /// <para>The execution time. The value is a millisecond-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784721775379</para>
        /// </summary>
        [NameInMap("executedAt")]
        [Validation(Required=false)]
        public long? ExecutedAt { get; set; }

        /// <summary>
        /// <para>The experiment plan ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-plan-0242d983f5d340fd8479cf2c19eb279e</para>
        /// </summary>
        [NameInMap("experimentPlanId")]
        [Validation(Required=false)]
        public string ExperimentPlanId { get; set; }

        /// <summary>
        /// <para>The number of failed tasks. Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("failedTasks")]
        [Validation(Required=false)]
        public int? FailedTasks { get; set; }

        /// <summary>
        /// <para>The list of offline experiment configurations. This parameter is required when the plan type is offline. You can specify 1 to 5 configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;label&quot;: &quot;experimentA&quot;, &quot;name&quot;: &quot;experimentA&quot;}]</para>
        /// </summary>
        [NameInMap("offlineExperiments")]
        [Validation(Required=false)]
        public List<OfflineExperimentConfig> OfflineExperiments { get; set; }

        /// <summary>
        /// <para>The experiment record name. If not specified, the default value is the plan name followed by a timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arms_agent_experiment 2026/07/22 20:02:55</para>
        /// </summary>
        [NameInMap("recordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The initial status. Default value: <c>pending</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pending</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of tasks. For online experiments, if not specified, the value is calculated based on the number of generated tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("totalTasks")]
        [Validation(Required=false)]
        public int? TotalTasks { get; set; }

        /// <summary>
        /// <para>Optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
