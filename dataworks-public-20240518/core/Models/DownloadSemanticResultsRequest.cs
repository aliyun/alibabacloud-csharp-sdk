// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class DownloadSemanticResultsRequest : TeaModel {
        /// <summary>
        /// <para>The node name. Use the Data.Name value from the CreateSemanticJob response, the Name value from a ListSemanticJobs list item, or the JobName value from a ListSemanticJobRuns record.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>semantic-job-demo</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The optional run ID. If you specify the Data.JobRunId value from the RunSemanticJob response or the JobRunId value from a ListSemanticJobRuns record, only the artifacts of that specific run are returned. If you do not specify this parameter, the artifacts of the latest run of the node are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01H00000000000000000000000</para>
        /// </summary>
        [NameInMap("JobRunId")]
        [Validation(Required=false)]
        public string JobRunId { get; set; }

    }

}
