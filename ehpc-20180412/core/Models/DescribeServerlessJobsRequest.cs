// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeServerlessJobsRequest : TeaModel {
        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The list of serverless job IDs or the subtask IDs (array jobs).
        /// 
        /// > 
        /// 
        /// *   If the serverless job is an array job, you can specify only the subtask ID. Specify the subtask ID in the format of \<array job ID>\_< subtask index>. For example, 10\_3 indicates the subtask whose index is 3 in the array job whose ID is 10.
        /// 
        /// *   You can specify only a single ID in one request.
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<string> JobIds { get; set; }

    }

}
