// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorComputeSummaryRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The resource types, which are used to filter query results. Valid values:
        /// 
        /// *   engine: filters results by engine.
        /// *   queue: filters results by queue.
        /// *   cluster: displays the results at the cluster level.
        /// 
        /// If you do not specify this parameter, the information at the cluster level is displayed by default. Currently, only one resource type is supported. If you specify multiple resource types, the first resource type is used by default.
        /// </summary>
        [NameInMap("ComponentTypes")]
        [Validation(Required=false)]
        public List<string> ComponentTypes { get; set; }

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
        /// The basis on which you want to sort the query results. Valid values:
        /// 
        /// 1.  vcoreSeconds: the total CPU consumption over time in seconds.
        /// 2.  memSeconds: the total memory consumption over time in seconds.
        /// 3.  vcoreUtilization: the average CPU utilization. The meaning is the same as the %CPU parameter in the output of the top command in Linux.
        /// 4.  memUtilization: the average memory usage.
        /// 5.  vcoreSecondsDayGrowthRatio: the day-to-day growth rate of the total CPU consumption over time in seconds.
        /// 6.  memSecondsDayGrowthRatio: the day-to-day growth rate of the total memory consumption over time in seconds.
        /// 7.  readSize: the total amount of data read from the file system.
        /// 8.  writeSize: the total amount of data written to the file system.
        /// 9.  healthyJobCount: the total number of healthy jobs.
        /// 10. subHealthyJobCount: the total number of sub-healthy jobs.
        /// 11. unhealthyJobCount: the total number of unhealthy jobs.
        /// 12. needAttentionJobCount: the total number of jobs that require attention.
        /// 13. score: the score for jobs.
        /// 14. scoreDayGrowthRatio: the day-to-day growth rate of the score for jobs.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The order in which you want to sort the query results. Valid values:
        /// 
        /// *   ASC: in ascending order.
        /// *   DESC: in descending order.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
