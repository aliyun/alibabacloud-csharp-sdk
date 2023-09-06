// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteJobsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to use an asynchronous link to delete the jobs.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The list of jobs that you want to delete. Maximum number of jobs: 100. Minimum number of jobs: 1.
        /// 
        /// Format: `[{"Id": "0.sched****"},{"Id": "1.sched****"}]`. Separate multiple jobs with commas (,).
        /// 
        /// You can call the [ListJobs](~~87251~~) operation to query the job ID.
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public string Jobs { get; set; }

    }

}
