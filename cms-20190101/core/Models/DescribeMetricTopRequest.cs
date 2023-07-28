// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricTopRequest : TeaModel {
        /// <summary>
        /// The dimensions that specify the resources whose monitoring data you want to query.
        /// 
        /// Set the value to a collection of key-value pairs. A typical key-value pair is `instanceId:i-2ze2d6j5uhg20x47****`.
        /// 
        /// >  You can query a maximum of 50 instances in a single request.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The statistical period of the monitoring data. Unit: seconds. Valid values: 15, 60, 900, and 3600.
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// The start of the time range to query monitoring data.
        /// 
        /// *   If the `StartTime` and `EndTime` parameters are not specified, the monitoring data of the last statistical period is queried.``
        /// 
        /// *   If the `StartTime` and `EndTime` parameters are specified, the monitoring data of the last statistical period in the specified time range is queried.```` The following examples demonstrate how to determine the period in which monitoring data is queried:
        /// 
        ///     *   If you set the `Period` parameter to 15, the specified time range must be less than or equal to 20 minutes. For example, if you set the StartTime parameter to 2021-05-08 08:10:00 and the EndTime parameter to 2021-05-08 08:30:00, the monitoring data of the last 15 seconds in the time range is queried.
        ///     *   If you set the `Period` parameter to 60 or 900, the specified time range must be less than or equal to 2 hours. For example, if you set the Period parameter to 60, the StartTime parameter to 2021-05-08 08:00:00, and the EndTime parameter to 2021-05-08 10:00:00, the monitoring data of the last 60 seconds in the time range is queried.
        ///     *   If you set the `Period` parameter to 3600, the specified time range must be less than or equal to two days. For example, if you set the StartTime parameter to 2021-05-08 08:00:00 and the EndTime parameter to 2021-05-10 08:00:00, the monitoring data of the last 3,600 seconds in the time range is queried.
        /// 
        /// The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format
        /// 
        /// > 
        /// 
        /// *   You must set the `StartTime` parameter to a point in time that is later than 00:00:00 Thursday, January 1, 1970. Otherwise, this parameter is invalid.
        /// *   We recommend that you use UNIX timestamps to prevent time zone-related issues.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **DescribeMetricTop**.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The statistical period of the monitoring data.
        /// 
        /// Valid values: 15, 60, 900, and 3600.
        /// 
        /// Unit: seconds.
        /// 
        /// > 
        /// 
        /// *   If this parameter is not specified, monitoring data is queried based on the period in which metric values are reported.
        /// *   Statistical periods vary based on metrics that are specified by `MetricName`. For more information, see [Appendix 1: Metrics](~~163515~~).
        /// </summary>
        [NameInMap("OrderDesc")]
        [Validation(Required=false)]
        public string OrderDesc { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Default value: 10.
        /// 
        /// >  The maximum value of the Length parameter in a request is 1440.
        /// </summary>
        [NameInMap("Orderby")]
        [Validation(Required=false)]
        public string Orderby { get; set; }

        /// <summary>
        /// The field based on which data is sorted. Valid values:
        /// 
        /// *   Average: the average value
        /// *   Minimum: the minimum value
        /// *   Maximum: the maximum value
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The end of the time range to query monitoring data.
        /// 
        /// *   If the `StartTime` and `EndTime` parameters are not specified, the monitoring data of the last statistical period is queried.``
        /// 
        /// *   If the `StartTime` and `EndTime` parameters are specified, the monitoring data of the last statistical period in the specified time range is queried.```` The following examples demonstrate how to determine the period in which monitoring data is queried:
        /// 
        ///     *   If you set the `Period` parameter to 15, the specified time range must be less than or equal to 20 minutes. For example, if you set the StartTime parameter to 2021-05-08 08:10:00 and the EndTime parameter to 2021-05-08 08:30:00, the monitoring data of the last 15 seconds in the time range is queried.
        ///     *   If you set the `Period` parameter to 60 or 900, the specified time range must be less than or equal to 2 hours. For example, if you set the Period parameter to 60, the StartTime parameter to 2021-05-08 08:00:00, and the EndTime parameter to 2021-05-08 10:00:00, the monitoring data of the last 60 seconds in the time range is queried.
        ///     *   If you set the `Period` parameter to 3600, the specified time range must be less than or equal to two days. For example, if you set the StartTime parameter to 2021-05-08 08:00:00 and the EndTime parameter to 2021-05-10 08:00:00, the monitoring data of the last 3,600 seconds in the time range is queried.
        /// 
        /// The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format
        /// 
        /// >  We recommend that you use UNIX timestamps to prevent time zone-related issues.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
