// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableMetricsResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// Details of the Enhanced Monitoring metric.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAvailableMetricsResponseBodyItems> Items { get; set; }
        public class DescribeAvailableMetricsResponseBodyItems : TeaModel {
            /// <summary>
            /// The description of the Enhanced Monitoring metric.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The category of the Enhanced Monitoring metric. Valid values:
            /// 
            /// *   **os**: OS metric
            /// *   **db**: database metric
            /// </summary>
            [NameInMap("Dimension")]
            [Validation(Required=false)]
            public string Dimension { get; set; }

            /// <summary>
            /// The key of the group to which the Enhanced Monitoring metric belongs.
            /// </summary>
            [NameInMap("GroupKey")]
            [Validation(Required=false)]
            public string GroupKey { get; set; }

            /// <summary>
            /// The name of the group to which the Enhanced Monitoring metric belongs.
            /// </summary>
            [NameInMap("GroupKeyType")]
            [Validation(Required=false)]
            public string GroupKeyType { get; set; }

            /// <summary>
            /// The method that is used to aggregate the monitoring data of the Enhanced Monitoring metric. Valid values:
            /// 
            /// *   **avg**: The system calculates the average value of the Enhanced Monitoring metric.
            /// *   **min**: The system calculates the minimum value of the Enhanced Monitoring metric.
            /// *   **max**: The system calculates the maximum value of the Enhanced Monitoring metric.
            /// </summary>
            [NameInMap("Method")]
            [Validation(Required=false)]
            public string Method { get; set; }

            /// <summary>
            /// The key of the Enhanced Monitoring metric.
            /// </summary>
            [NameInMap("MetricsKey")]
            [Validation(Required=false)]
            public string MetricsKey { get; set; }

            /// <summary>
            /// The alias of the Enhanced Monitoring metric.
            /// </summary>
            [NameInMap("MetricsKeyAlias")]
            [Validation(Required=false)]
            public string MetricsKeyAlias { get; set; }

            /// <summary>
            /// The serial number of the Enhanced Monitoring metric.
            /// </summary>
            [NameInMap("SortRule")]
            [Validation(Required=false)]
            public int? SortRule { get; set; }

            /// <summary>
            /// The unit of the Enhanced Monitoring metric.
            /// </summary>
            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of enhanced monitoring metrics that are available for the instance.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
