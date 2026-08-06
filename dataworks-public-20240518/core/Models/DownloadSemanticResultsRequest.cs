// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DownloadSemanticResultsRequest : TeaModel {
        /// <summary>
        /// <para>The job name. You can obtain this value from Data.Name in the CreateSemanticJob response, Name in the ListSemanticJobs response, or JobName in the ListSemanticJobRuns response.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>semantic-job-demo</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The optional run ID. If you specify the JobRunId from the RunSemanticJob response (Data.JobRunId) or the ListSemanticJobRuns response, only the artifacts of the specified run are returned. If you do not specify this parameter, the artifacts of the most recent run of the job are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01H00000000000000000000000</para>
        /// </summary>
        [NameInMap("JobRunId")]
        [Validation(Required=false)]
        public string JobRunId { get; set; }

    }

}
