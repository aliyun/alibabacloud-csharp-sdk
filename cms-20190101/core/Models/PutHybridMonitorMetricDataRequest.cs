// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutHybridMonitorMetricDataRequest : TeaModel {
        /// <summary>
        /// The monitoring data.
        /// 
        /// Valid values of N: 1 to 100.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<PutHybridMonitorMetricDataRequestMetricList> MetricList { get; set; }
        public class PutHybridMonitorMetricDataRequestMetricList : TeaModel {
            /// <summary>
            /// The tags of the metric.
            /// 
            /// Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<PutHybridMonitorMetricDataRequestMetricListLabels> Labels { get; set; }
            public class PutHybridMonitorMetricDataRequestMetricListLabels : TeaModel {
                /// <summary>
                /// The tag key of the metric.
                /// 
                /// Valid values of N: 1 to 100.
                /// 
                /// The key can contain letters, digits, and underscores (_). The key must start with a letter or an underscore (_).
                /// 
                /// >  You must specify both the Key and Value parameters.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value of the metric.
                /// 
                /// Valid values of N: 1 to 100.
                /// 
                /// >  You must specify both the Key and Value parameters.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The metric name.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// The name can contain letters, digits, and underscores (_). The name must start with a letter.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The time when the monitoring data is imported. The value is a timestamp.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// Unit: milliseconds. By default, the current time is used.
            /// </summary>
            [NameInMap("TS")]
            [Validation(Required=false)]
            public long? TS { get; set; }

            /// <summary>
            /// The value of the metric.
            /// 
            /// Valid values of N: 1 to 100.
            /// 
            /// The value must be an integer or a floating-point number.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// For information about how to obtain the name of a namespace, see [DescribeHybridMonitorNamespaceList](https://help.aliyun.com/document_detail/428880.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
