// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryCommercialUsageRequest : TeaModel {
        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("AdvancedFilters")]
        [Validation(Required=false)]
        public List<QueryCommercialUsageRequestAdvancedFilters> AdvancedFilters { get; set; }
        public class QueryCommercialUsageRequestAdvancedFilters : TeaModel {
            /// <summary>
            /// The key of the filter condition.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The operator. Valid values: eq and in.
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            /// <summary>
            /// The value of the filter condition.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The dimensions of the metric that you want to query. Valid values:
        /// 
        /// *   dataType: data type
        /// *   productType: product type
        /// *   instanceId: instance ID
        /// *   instanceName: instance name
        /// *   instanceType: instance type
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<string> Dimensions { get; set; }

        /// <summary>
        /// The end of the time range to query. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The time interval between data slices. Unit: seconds. Minimum value: 3600.
        /// 
        /// Valid values:
        /// 
        /// *   3600: hours
        /// *   86400: days
        /// </summary>
        [NameInMap("IntervalInSec")]
        [Validation(Required=false)]
        public int? IntervalInSec { get; set; }

        /// <summary>
        /// The measures of the metric that you want to query.
        /// </summary>
        [NameInMap("Measures")]
        [Validation(Required=false)]
        public List<string> Measures { get; set; }

        /// <summary>
        /// The name of the metric. Valid value: USAGEFEE.STAT.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// The order in which data is sorted. Valid value:
        /// 
        /// *   `ASC`: ascending order
        /// *   `DESC`: descending order
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The dimension by which data is sorted.
        /// 
        /// Valid value:
        /// 
        /// *   dataType
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The data type. Valid values:
        /// 
        /// *   instantQuery: non-time series
        /// *   timeSeriesQuery: time series
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// The start of the time range to query. Unit: milliseconds.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
