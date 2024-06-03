// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorJobsStatsRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The range of end time. You can filter jobs whose end time falls within the specified time range.
        /// </summary>
        [NameInMap("EndRange")]
        [Validation(Required=false)]
        public ListDoctorJobsStatsRequestEndRange EndRange { get; set; }
        public class ListDoctorJobsStatsRequestEndRange : TeaModel {
            /// <summary>
            /// The end of the time range during which jobs ended. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The beginning of the time range during which jobs ended. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// The fields that are used for grouping data.
        /// 
        /// Currently, only the first value is used for grouping data. Combinations of multiple values will be supported in the future.
        /// </summary>
        [NameInMap("GroupBy")]
        [Validation(Required=false)]
        public List<string> GroupBy { get; set; }

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
        /// *   vcoreSeconds: the aggregated number of vCPUs that are allocated to the job multiplied by the number of seconds the job has been running
        /// *   memSeconds: the aggregated amount of memory that is allocated to the job multiplied by the number of seconds the job has been running
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The order in which you want to sort the query results. Valid values:
        /// 
        /// *   ASC: in ascending order
        /// *   DESC: in descending order
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

        /// <summary>
        /// The range of start time. You can filter jobs whose start time falls within the specified time range.
        /// </summary>
        [NameInMap("StartRange")]
        [Validation(Required=false)]
        public ListDoctorJobsStatsRequestStartRange StartRange { get; set; }
        public class ListDoctorJobsStatsRequestStartRange : TeaModel {
            /// <summary>
            /// The end of the time range during which jobs were submitted. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The beginning of the time range during which jobs were submitted. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

    }

}
