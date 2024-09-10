// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricListRequest : TeaModel {
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
        /// The end of the time range to query. The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The expression that is used to compute the query results in real time.
        /// 
        /// >  Only the groupby expression is supported. This expression is similar to the GROUP BY statement that is used in databases.
        /// </summary>
        [NameInMap("Express")]
        [Validation(Required=false)]
        public string Express { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// >  The maximum value of the Length parameter in a request is 1440.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public string Length { get; set; }

        /// <summary>
        /// The name of the metric.
        /// 
        /// For more information about metric names, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// The namespace of the cloud service. Format: acs_service name.
        /// 
        /// For more information about the namespaces of cloud services, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The paging token.
        /// 
        /// >  If this parameter is not specified, the data on the first page is returned. A return value other than Null of this parameter indicates that not all entries have been returned. You can use this value as an input parameter to obtain entries on the next page. The value Null indicates that all query results have been returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The interval at which the monitoring data is queried.
        /// 
        /// Valid values: 60, 300, and 900.
        /// 
        /// Unit: seconds.
        /// 
        /// >  Configure this parameter based on your business scenario.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The beginning of the time range to query. The following formats are supported:
        /// 
        /// *   UNIX timestamp: the number of milliseconds that have elapsed since 00:00:00 Thursday, January 1, 1970
        /// *   UTC time: the UTC time that follows the YYYY-MM-DDThh:mm:ssZ format
        /// 
        /// >  The specified period includes the end time and excludes the start time. The start time must be earlier than the end time.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
