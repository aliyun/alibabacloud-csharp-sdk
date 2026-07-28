// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetExecuteStateResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Your account does not have enough balance to order postpaid product.</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The run log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;tf-plan.run.log&quot;:&quot;xxx&quot;}</para>
        /// </summary>
        [NameInMap("logFile")]
        [Validation(Required=false)]
        public Dictionary<string, object> LogFile { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4672AE3-C313-5B7A-BB24-45345570D398</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The state file content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;version&quot;: 4, &quot;terraform_version&quot;: &quot;1.5.7&quot;, &quot;serial&quot;: 3, &quot;lineage&quot;: &quot;cb71b0b2-1ec2-6483-d409-8cae23186ec6&quot;,  &quot;outputs&quot;: {}, &quot;resources&quot;: [], &quot;check_results&quot;: null}</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Pending: ready to start.</description></item>
        /// <item><description>PlanQueued: the plan task has been created but is waiting in the queue because no workflow is available.</description></item>
        /// <item><description>ApplyQueued: the apply task has been created but is waiting in the queue because no workflow is available.</description></item>
        /// <item><description>Planning: the plan phase is being executed.</description></item>
        /// <item><description>Planned: the plan execution is complete.</description></item>
        /// <item><description>Confirmed: the plan has been confirmed after execution.</description></item>
        /// <item><description>PlannedAndFinished: the plan execution is complete and no diff was found. The job is in a terminal state.</description></item>
        /// <item><description>Applying: the apply phase is being executed.</description></item>
        /// <item><description>Applied: the apply execution is complete.</description></item>
        /// <item><description>Discarded: the task has been discarded. This is a terminal state.</description></item>
        /// <item><description>Errored: the execution encountered an error. This is a terminal state.</description></item>
        /// <item><description>Canceled: the execution has been canceled. This is a terminal state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Pending</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
