// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateExperimentRunRequest : TeaModel {
        /// <summary>
        /// <para>The experiment completion time. A millisecond-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784719989371</para>
        /// </summary>
        [NameInMap("completedAt")]
        [Validation(Required=false)]
        public long? CompletedAt { get; set; }

        /// <summary>
        /// <para>The number of completed tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("completedTasks")]
        [Validation(Required=false)]
        public int? CompletedTasks { get; set; }

        /// <summary>
        /// <para>The experiment execution time. A millisecond-level UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1784719439255</para>
        /// </summary>
        [NameInMap("executedAt")]
        [Validation(Required=false)]
        public long? ExecutedAt { get; set; }

        /// <summary>
        /// <para>The number of failed tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("failedTasks")]
        [Validation(Required=false)]
        public int? FailedTasks { get; set; }

        /// <summary>
        /// <para>The experiment record name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rca_benchmark_eval_experiment 2026/07/22 19:23:59</para>
        /// </summary>
        [NameInMap("recordName")]
        [Validation(Required=false)]
        public string RecordName { get; set; }

        /// <summary>
        /// <para>The experiment record status. Set to cancelled to cancel execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
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
