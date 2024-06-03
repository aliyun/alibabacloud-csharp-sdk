// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorApplicationsRequest : TeaModel {
        /// <summary>
        /// The IDs of jobs that are submitted to YARN.
        /// </summary>
        [NameInMap("AppIds")]
        [Validation(Required=false)]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specify the date in the ISO 8601 standard. For example, 2023-01-01 represents January 1, 2023.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DateTime")]
        [Validation(Required=false)]
        public string DateTime { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The field that you use to sort the query results. Valid values:
        /// 
        /// 1.  startTime: the time when the job starts
        /// 2.  endTime: the time when the job ends
        /// 3.  vcoreUtilization: the vCPU utilization of the job
        /// 4.  memUtilization: the memory usage of the job
        /// 5.  vcoreSeconds: the aggregated number of vCPUs that are allocated to the job multiplied by the number of seconds the job has been running
        /// 6.  memSeconds: the aggregated amount of memory that is allocated to the job multiplied by the number of seconds the job has been running
        /// 7.  score: the score of the job
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The order in which you want to sort the query results. Valid values:
        /// 
        /// *   ASC: the ascending order
        /// *   DESC: the descending order
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The YARN queues to which the jobs are submitted.
        /// </summary>
        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<string> Queues { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The YARN engines to which the jobs are submitted.
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public List<string> Types { get; set; }

        /// <summary>
        /// The users who submit the jobs.
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
