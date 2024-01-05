// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribePatternPerformanceRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the information about all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region, including cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The SQL pattern ID.
        /// 
        /// >  You can call the [DescribeSQLPatterns](~~321868~~) operation to query the information about all SQL patterns in an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster within a period of time, including SQL pattern IDs.
        /// </summary>
        [NameInMap("PatternId")]
        [Validation(Required=false)]
        public string PatternId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mm:ssZ* format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   If the current date is August 22, 2022 (UTC+8), you can query the data of August 9, 2022 (2022-08-08T16:00:00Z) to the earliest extent. If you want to query the data that is earlier than August 9, 2022 (2022-08-08T16:00:00Z), null is returned.
        /// 
        /// *   The maximum time range that can be specified is 24 hours.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
