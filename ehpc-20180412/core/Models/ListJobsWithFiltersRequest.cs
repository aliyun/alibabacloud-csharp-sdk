// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobsWithFiltersRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable asynchronous query.
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
        /// The latest time when a job is submitted. The value is a UNIX timestamp, which represents the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("CreateTimeEnd")]
        [Validation(Required=false)]
        public string CreateTimeEnd { get; set; }

        /// <summary>
        /// The earliest time when a job is submitted. The value is a UNIX timestamp, which represents the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("CreateTimeStart")]
        [Validation(Required=false)]
        public string CreateTimeStart { get; set; }

        /// <summary>
        /// The order in which jobs are sorted based on the execution time. Valid values:
        /// 
        /// *   asc: ascending order
        /// *   desc: descending order
        /// </summary>
        [NameInMap("ExecuteOrder")]
        [Validation(Required=false)]
        public string ExecuteOrder { get; set; }

        /// <summary>
        /// The name of the job. Fuzzy match is supported.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// The status of the job. Valid values:
        /// 
        /// *   all
        /// *   finished
        /// *   notfinish
        /// 
        /// Default value: all
        /// </summary>
        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 50.
        /// 
        /// Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The order in which jobs are sorted based on the time when they queue. Valid values:
        /// 
        /// *   asc: ascending order
        /// *   desc: descending order
        /// </summary>
        [NameInMap("PendOrder")]
        [Validation(Required=false)]
        public string PendOrder { get; set; }

        [NameInMap("Queues")]
        [Validation(Required=false)]
        public List<string> Queues { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// You can call the [ListRegions](~~188593~~) operation to query the list of regions where E-HPC is supported.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The order in which jobs are sorted based on the time when they are submitted. Valid values:
        /// 
        /// *   asc: ascending order
        /// *   desc: descending order
        /// </summary>
        [NameInMap("SubmitOrder")]
        [Validation(Required=false)]
        public string SubmitOrder { get; set; }

        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<string> Users { get; set; }

    }

}
