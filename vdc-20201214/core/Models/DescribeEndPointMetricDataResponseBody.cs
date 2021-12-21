// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeEndPointMetricDataResponseBody : TeaModel {
        /// <summary>
        /// 发布端用户指标数据。
        /// </summary>
        [NameInMap("PubMetrics")]
        [Validation(Required=false)]
        public List<DescribeEndPointMetricDataResponseBodyPubMetrics> PubMetrics { get; set; }
        public class DescribeEndPointMetricDataResponseBodyPubMetrics : TeaModel {
            /// <summary>
            /// 坐标点列表
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeEndPointMetricDataResponseBodyPubMetricsNodes> Nodes { get; set; }
            public class DescribeEndPointMetricDataResponseBodyPubMetricsNodes : TeaModel {
                /// <summary>
                /// 拓展属性
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// 发布端指标趋势图中x轴横坐标。
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// 发布端指标趋势图中y轴纵坐标。
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// 对应入参Metrics中的类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 用户ID。
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 订阅端用户指标数据。
        /// </summary>
        [NameInMap("SubMetrics")]
        [Validation(Required=false)]
        public List<DescribeEndPointMetricDataResponseBodySubMetrics> SubMetrics { get; set; }
        public class DescribeEndPointMetricDataResponseBodySubMetrics : TeaModel {
            /// <summary>
            /// 订阅端指标趋势图坐标点列表。
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeEndPointMetricDataResponseBodySubMetricsNodes> Nodes { get; set; }
            public class DescribeEndPointMetricDataResponseBodySubMetricsNodes : TeaModel {
                /// <summary>
                /// 拓展属性
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

                /// <summary>
                /// 订阅端指标趋势图中x轴横坐标。
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// 订阅端指标趋势图y轴纵坐标。
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

            }

            /// <summary>
            /// 对应入参Metrics中的类型
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 用户ID。
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
