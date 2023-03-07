// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class RerunJobsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to use an asynchronous link to rerun the job.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The list of jobs that you want to run. Maximum number of jobs: 100. Minimum number of jobs: 1.
        /// 
        /// Format: `[{"Id": "0.sched****"},{"Id": "1.sched****"}]`. Separate multiple jobs with commas (,).
        /// 
        /// You can call the [ListJobs](~~87251~~) operation to query the job ID.
        /// 
        /// >  You can rerun only jobs that are in the RUNNING or QUEUED state.
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public string Jobs { get; set; }

    }

}
