// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetRumOcuStatisticDataShrinkRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The filter condition. Three types of filter conditions are provided:
        /// 
        /// *   Application name: pid (Note that the application name is displayed, but the application ID is actually specified)
        /// *   Application type: siteType
        /// *   Data type: dataType
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// The grouping fields. Valid values:
        /// 
        /// *   siteType: The total number of OCUs is grouped by application type.
        /// *   dataType: The total number of OCUs is grouped by data type.
        /// *   pid: The total number of OCUs is grouped by application ID.
        /// *   appName: The total number of OCUs is grouped by application name.
        /// *   startTime: The total number of OCUs is grouped by start time.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public string GroupShrink { get; set; }

        /// <summary>
        /// The page number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the query. To query non-time series data, set the value to INSTANT. To query time series data, set the value to TIME_SERIES.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
