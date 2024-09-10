// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CursorShrinkRequest : TeaModel {
        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Unit: milliseconds.
        /// 
        /// > 
        /// 
        /// *   This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. For example, 2023-01-01T00:00:00Z indicates January 1, 2023, 00:00:00 UTC.
        /// 
        /// *   If you do not set the end time, the end time is infinite. You can leave this parameter empty in real-time export scenarios.
        /// *   In CloudMonitor, the TTL of monitoring data varies with the time granularity. Specify a proper time interval based on the TTL corresponding to the value of the `Period` parameter.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The dimension information of the metric.
        /// </summary>
        [NameInMap("Matchers")]
        [Validation(Required=false)]
        public string MatchersShrink { get; set; }

        /// <summary>
        /// The metric that is used to monitor the cloud service.
        /// 
        /// For more information about the metrics of cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// The namespace of the cloud service.
        /// 
        /// For more information about the namespaces of cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The time interval based on which the metric value is measured.
        /// 
        /// Unit: seconds.
        /// 
        /// >  Generally, the time interval is 60 seconds. For more information about specific values, see the `Period` parameter in [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. For example, 2023-01-01T00:00:00Z indicates January 1, 2023, 00:00:00 UTC.
        /// 
        /// >  In CloudMonitor, the TTL of monitoring data varies with the time granularity. Specify a proper time interval based on the TTL corresponding to the value of the `Period` parameter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
