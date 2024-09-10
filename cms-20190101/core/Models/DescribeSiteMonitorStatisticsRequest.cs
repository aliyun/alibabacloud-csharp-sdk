// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorStatisticsRequest : TeaModel {
        /// <summary>
        /// The name of the metric. Valid values:
        /// 
        /// *   Availability
        /// *   ErrorRate
        /// *   ResponseTime
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The timestamp that specifies the beginning of the time range to query.
        /// 
        /// Unit: milliseconds. The default value is 1 hour ahead of the current time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The ID of the site monitoring task.
        /// 
        /// For more information about how to obtain the ID of a site monitoring task, see [DescribeSiteMonitorList](https://help.aliyun.com/document_detail/115052.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The statistical period.
        /// 
        /// Unit: minutes. Default value: 1440 (1 day). Maximum value: 43200 (30 days).
        /// </summary>
        [NameInMap("TimeRange")]
        [Validation(Required=false)]
        public string TimeRange { get; set; }

    }

}
