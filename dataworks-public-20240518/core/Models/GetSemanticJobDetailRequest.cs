// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSemanticJobDetailRequest : TeaModel {
        /// <summary>
        /// <para>The executor job ID. Use the Data.ExecutorJobId from the RunSemanticJob response or the ExecutorJobId from a ListSemanticJobRuns record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-job-demo</para>
        /// </summary>
        [NameInMap("ExecutorJobId")]
        [Validation(Required=false)]
        public string ExecutorJobId { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID to which the job belongs. Use the ProjectId from the CreateSemanticJob response or a ListSemanticJobs list item.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

    }

}
