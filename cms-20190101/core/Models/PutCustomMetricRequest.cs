// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutCustomMetricRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<PutCustomMetricRequestMetricList> MetricList { get; set; }
        public class PutCustomMetricRequestMetricList : TeaModel {
            /// <summary>
            /// The dimensions that specify the resources whose monitoring data you want to query. Valid values of N: 1 to 21.
            /// 
            /// Set the value to a collection of key-value pairs. Format:`{"Key":"Value"}`.
            /// 
            /// The key or value must be 1 to 64 bytes in length. Excessive characters are truncated.
            /// 
            /// The key or value can contain letters, digits, periods (.), hyphens (-), underscores (_), forward slashes (/), and backslashes (\\\\).
            /// 
            /// >  Dimensions must be formatted as a JSON string in a specified order.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Dimensions")]
            [Validation(Required=false)]
            public string Dimensions { get; set; }

            /// <summary>
            /// The ID of the application group. Valid values of N: 1 to 21.
            /// 
            /// >  If the metric does not belong to any application group, enter 0.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The name of the metric. Valid values of N: 1 to 21. For more information, see [Appendix 1: Metrics](https://help.aliyun.com/document_detail/163515.html).
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// The aggregation period. Valid values of N: 1 to 21. Unit: seconds. Valid values: 60 and 300.
            /// 
            /// >  If the MetricList.N.Type parameter is set to 1, the MetricList.N.Period parameter is required.
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public string Period { get; set; }

            /// <summary>
            /// The timestamp when the metric data is generated. Valid values of N: 1 to 21. The timestamp can be in one of the following formats:
            /// 
            /// *   The UTC timestamp that is in the YYYY-MM-DDThh:mm:ssZ format. Example: 20171012T132456.888+0800.
            /// *   The UNIX timestamp of the LONG type. Example: 1508136760000.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The type of the reported data. Valid values of N: 1 to 21. Valid values:
            /// 
            /// *   0: reports raw data
            /// *   1: reports aggregate data
            /// 
            /// >  We recommend that you report aggregate data in both the aggregation periods of 60s and 300s. Otherwise, you cannot query monitoring data in a time span that is more than seven days.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The collection of metric values. Valid values of N: 1 to 21.
            /// 
            /// >  If the MetricList.N.Type parameter is set to 0, the keys in this parameter must be set to the specified value. CloudMonitor aggregates raw data in each aggregation period to generate multiple statistical values, such as the maximum value, the count, and the total value.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public string Values { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
