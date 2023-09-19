// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternAttributeRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the information about all AnalyticDB for MySQL clusters within a region, including cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
        /// 
        /// > The end time must be later than the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The language of file titles and error messages. Valid values:
        /// 
        /// *   **zh**: simplified Chinese.
        /// *   **en**: English.
        /// *   **ja**: Japanese.
        /// *   **zh-tw**: traditional Chinese.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The SQL pattern ID.
        /// 
        /// > You can call the [DescribeSQLPatterns](~~321868~~) operation to query the information about all SQL patterns in an AnalyticDB for MySQL cluster within a period of time, including SQL pattern IDs.
        /// </summary>
        [NameInMap("PatternId")]
        [Validation(Required=false)]
        public long? PatternId { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
        /// 
        /// > You can query the data only within the last 15 days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
