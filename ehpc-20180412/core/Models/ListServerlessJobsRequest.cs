// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListServerlessJobsRequest : TeaModel {
        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The list of serverless job IDs or subtask IDs (array jobs).
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public List<string> JobIds { get; set; }

        /// <summary>
        /// The names of the serverless jobs.
        /// </summary>
        [NameInMap("JobNames")]
        [Validation(Required=false)]
        public List<string> JobNames { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Maximum value: 100. Default value: 20.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The region ID. You can call the [ListRegions](~~188593~~) operation to query the list of regions where E-HPC is supported.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to sort the serverless jobs by the job start time. Valid values:
        /// 
        /// *   Asc: ascending order.
        /// *   Desc: descending order.
        /// </summary>
        [NameInMap("StartOrder")]
        [Validation(Required=false)]
        public string StartOrder { get; set; }

        /// <summary>
        /// The status of the serverless job. Valid values:
        /// 
        /// *   All
        /// *   Pending
        /// *   Running
        /// *   Succeeded
        /// *   Canceled
        /// *   Failed
        /// 
        /// Default value: All.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// Specifies whether to sort the serverless jobs by the job submission time. Valid values:
        /// 
        /// *   Asc: ascending order.
        /// *   Desc: descending order.
        /// </summary>
        [NameInMap("SubmitOrder")]
        [Validation(Required=false)]
        public string SubmitOrder { get; set; }

        /// <summary>
        /// The latest time at which the job is submitted.
        /// 
        /// >  You can use this parameter to query the job list based on the job submission time.
        /// </summary>
        [NameInMap("SubmitTimeEnd")]
        [Validation(Required=false)]
        public string SubmitTimeEnd { get; set; }

        /// <summary>
        /// The earliest time at which the job is submitted.
        /// 
        /// >  You can use this parameter to query the job list based on the job submission time.
        /// </summary>
        [NameInMap("SubmitTimeStart")]
        [Validation(Required=false)]
        public string SubmitTimeStart { get; set; }

    }

}
