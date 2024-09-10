// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricDataRequest : TeaModel {
        /// <summary>
        /// The dimensions based on which the resources are queried.
        /// 
        /// Set the value to a collection of key-value pairs. A typical key-value pair is `instanceId:i-2ze2d6j5uhg20x47****`.
        /// 
        /// >  You can query a maximum of 50 instances in a single request.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// The end of the time range to query monitoring data.
        /// 
        /// *   If the `StartTime` and `EndTime` parameters are not specified, the monitoring data of the last statistical period is queried.``
        /// 
        /// *   If the `StartTime` and `EndTime` parameters are specified, the monitoring data of the last statistical period in the specified time range is queried.```` The following examples demonstrate how to determine the period in which monitoring data is queried:
        /// 
        ///     *   If you set the `Period` parameter to 15, the specified time range must be less than or equal to 20 minutes. For example, if you set the StartTime parameter to 2021-05-08 08:10:00 and the EndTime parameter to 2021-05-08 08:30:00, the monitoring data of the last 15 seconds in the time range is queried.
        ///     *   If you set the `Period` to 60 or 900, the specified time range must be less than or equal to 2 hours. For example, if you set the Period parameter to 60, the StartTime parameter to 2021-05-08 08:00:00, and the EndTime parameter to 2021-05-08 10:00:00, the monitoring data of the last 60 seconds in the time range is queried.
        ///     *   If you set the `Period` parameter to 3600, the specified time range must be less than or equal to 2 days. For example, if you set the StartTime parameter to 2021-05-08 08:00:00 and the EndTime parameter to 2021-05-10 08:00:00, the monitoring data of the last 3,600 seconds in the time range is queried.
        /// 
        /// The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 UTC on Thursday, January 1, 1970.
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format.
        /// 
        /// >  We recommend that you use UNIX timestamps to prevent time zone-related issues.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The expression that is used to compute the query results in real time.
        /// 
        /// >  Only the `groupby` expression is supported. This expression is similar to the `GROUP BY` statement that is used in databases.
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Default value: 1000.
        /// 
        /// >  The maximum value of the Length parameter in a request is 1440.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// The metric that is used to monitor the cloud service.
        /// 
        /// For more information about the metrics of cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

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
        /// The statistical period of the metric.
        /// 
        /// Valid values: 15, 60, 900, and 3600.
        /// 
        /// Unit: seconds.
        /// 
        /// > 
        /// 
        /// *   If this parameter is not specified, monitoring data is queried based on the period in which metric values are reported.
        /// 
        /// *   For more information about the statistical period of a metric that is specified by the `MetricName` parameter, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The start of the time range to query monitoring data.
        /// 
        /// *   If the `StartTime` and `EndTime` parameters are not specified, the monitoring data of the last statistical period is queried.``
        /// 
        /// *   If the `StartTime` and `EndTime` parameters are specified, the monitoring data of the last statistical period in the specified time range is queried.```` The following examples demonstrate how to determine the period in which monitoring data is queried:
        /// 
        ///     *   If you set the `Period` parameter to 15, the specified time range must be less than or equal to 20 minutes. For example, if you set the StartTime parameter to 2021-05-08 08:10:00 and the EndTime parameter to 2021-05-08 08:30:00, the monitoring data of the last 15 seconds in the time range is queried.
        ///     *   If you set the `Period` to 60 or 900, the specified time range must be less than or equal to 2 hours. For example, if you set the Period parameter to 60, the StartTime parameter to 2021-05-08 08:00:00, and the EndTime parameter to 2021-05-08 10:00:00, the monitoring data of the last 60 seconds in the time range is queried.
        ///     *   If you set the `Period` parameter to 3600, the specified time range must be less than or equal to 2 days. For example, if you set the StartTime parameter to 2021-05-08 08:00:00 and the EndTime parameter to 2021-05-10 08:00:00, the monitoring data of the last 3,600 seconds in the time range is queried.
        /// 
        /// The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 UTC on Thursday, January 1, 1970.
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format.
        /// 
        /// > 
        /// 
        /// *   You must set the `StartTime` parameter to a point in time that is later than 00:00:00 UTC on Thursday, January 1, 1970. Otherwise, this parameter is invalid.
        /// 
        /// *   We recommend that you use UNIX timestamps to prevent time zone-related issues.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
