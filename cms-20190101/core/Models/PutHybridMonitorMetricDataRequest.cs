// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutHybridMonitorMetricDataRequest : TeaModel {
        /// <summary>
        /// 上报的监控数据
        /// </summary>
        [NameInMap("MetricList")]
        [Validation(Required=false)]
        public List<PutHybridMonitorMetricDataRequestMetricList> MetricList { get; set; }
        public class PutHybridMonitorMetricDataRequestMetricList : TeaModel {
            /// <summary>
            /// 标签，Key只能是英文字母、数字、下划线
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<PutHybridMonitorMetricDataRequestMetricListLabels> Labels { get; set; }
            public class PutHybridMonitorMetricDataRequestMetricListLabels : TeaModel {
                /// <summary>
                /// 只能是英文字母、数字、下划线
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 指标名，只能是英文字母、数字、下划线
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// 时间戳，unix毫秒数，如果不传会使用服务器时间
            /// </summary>
            [NameInMap("TS")]
            [Validation(Required=false)]
            public long? TS { get; set; }

            /// <summary>
            /// 监控值，浮点或整型
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
