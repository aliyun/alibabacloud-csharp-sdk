// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetAccountingReportRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The layers at which you want to query the bandwidth and traffic data. Valid values:
        /// 
        /// *   user: Query by user.
        /// *   queue: Query by queue.
        /// *   instance: Query by instance.
        /// </summary>
        [NameInMap("Dim")]
        [Validation(Required=false)]
        public string Dim { get; set; }

        /// <summary>
        /// The end of the time range to query. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public int? EndTime { get; set; }

        /// <summary>
        /// The actual name of the dimension to be queried. Valid values:
        /// 
        /// *   If you set the value of the parameter Dim to user, the value of FilterValue is the name of the specified user.
        /// *   If you set the value of the parameter Dim to queue, the value of FilterValue is the name of the specified queue.
        /// *   If you set the value of the parameter Dim to instance, the value of FilterValue is the instance name.
        /// </summary>
        [NameInMap("FilterValue")]
        [Validation(Required=false)]
        public string FilterValue { get; set; }

        /// <summary>
        /// The ID of the job.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The query type. Valid values:
        /// 
        /// *   total_report: Queries the number of CPU cores in different dimensions.
        /// *   job_report: Collects the historical node data of a node.
        /// *   number_report: Queries job information in different dimensions.
        /// </summary>
        [NameInMap("ReportType")]
        [Validation(Required=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. This value is a UNIX timestamp representing the number of seconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public int? StartTime { get; set; }

    }

}
