// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricLastRequest : TeaModel {
        /// <summary>
        /// The monitoring dimensions of the specified resource.
        /// 
        /// Set the value to a collection of `key:value` pairs. Example: `{"userId":"120886317861****"}` or `{"instanceId":"i-2ze2d6j5uhg20x47****"}`.
        /// 
        /// >  You can query a maximum of 50 instances in each request.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// The end of the time range to query monitoring data.
        /// 
        /// *   For second-level data, the start time is obtained by comparing the time that is specified by the StartTime parameter and 20 minutes earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.
        /// *   For minute-level data, the start time is obtained by comparing the time that is specified by the StartTime parameter and 2 hours earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.
        /// *   For hour-level data, the start time is obtained by comparing the time that is specified by the StartTime parameter and two days earlier of the time that is specified by the EndTime parameter. The earlier one of the compared points in time is used as the start time.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The expression that is used to calculate the query results in real time.
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// 
        /// Default value: 1000. This value indicates that a maximum of 1,000 entries of monitoring data can be returned on each page.
        /// 
        /// >  The maximum value of the Length parameter for each request is 1440.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// The metric that is used to monitor the cloud service.
        /// 
        /// For more information about metric names, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
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
        /// The pagination token.
        /// 
        /// *   If the number of results exceeds the maximum number of entries allowed on a single page, a pagination token is returned.
        /// *   This token can be used as an input parameter to obtain the next page of results. If all results are obtained, no token is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The statistical period of the monitoring data.
        /// 
        /// Valid values: 15, 60, 900, and 3600.
        /// 
        /// Unit: seconds.
        /// 
        /// > 
        /// 
        /// *   If this parameter is not specified, monitoring data is queried based on the period in which metric values are reported. The statistical period of metrics (`MetricName`) varies for each cloud service. The statistical period of metrics is displayed in the `MinPeriods` column on the **Metrics** page for each cloud service. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The start of the time range to query monitoring data.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
