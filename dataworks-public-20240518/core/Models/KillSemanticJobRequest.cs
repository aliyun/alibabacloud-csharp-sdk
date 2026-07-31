// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class KillSemanticJobRequest : TeaModel {
        /// <summary>
        /// <para>The executor job ID of the run to stop. Use the Data.ExecutorJobId value from the RunSemanticJob response or the ExecutorJobId value from a ListSemanticJobRuns record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-job-demo</para>
        /// </summary>
        [NameInMap("ExecutorJobId")]
        [Validation(Required=false)]
        public string ExecutorJobId { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace to which the job belongs. Use the ProjectId value from the CreateSemanticJob response or a ListSemanticJobs list item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The number of retries when sending the stop request to the executor. This parameter is optional. If specified, use a non-negative integer. After the call, confirm the final status by calling GetSemanticJobDetail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RetryTimes")]
        [Validation(Required=false)]
        public int? RetryTimes { get; set; }

    }

}
