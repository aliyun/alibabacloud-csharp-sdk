// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class StopServerlessJobsRequest : TeaModel {
        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The serverless job IDs or subtask IDs (array jobs).
        /// 
        /// *   If you specify the job ID of an array job, all subtasks under the array job are stopped.
        /// *   If you specify the ID of a subtask of an array job, only the subtask is stopped.
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<string> JobIds { get; set; }

    }

}
