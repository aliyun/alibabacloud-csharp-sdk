// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelUserMetricsResponseBody : TeaModel {
        /// <summary>
        /// 指标数据列表。
        /// </summary>
        [NameInMap("MetricDatas")]
        [Validation(Required=false)]
        public List<DescribeChannelUserMetricsResponseBodyMetricDatas> MetricDatas { get; set; }
        public class DescribeChannelUserMetricsResponseBodyMetricDatas : TeaModel {
            /// <summary>
            /// 指标类型，取值：ALL_NUM：累计用户数量。PUB_NUM：累计发布用户数量。SUB_NUM：累计订阅用户数量。JOIN_FAIL_NUM：累计加入频道异常用户数量。BAD_EXP_NUM：累计通信体验异常用户。
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 指标趋势图坐标点列表。
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeChannelUserMetricsResponseBodyMetricDatasNodes> Nodes { get; set; }
            public class DescribeChannelUserMetricsResponseBodyMetricDatasNodes : TeaModel {
                /// <summary>
                /// 指标趋势图中x轴横坐标。
                /// </summary>
                [NameInMap("X")]
                [Validation(Required=false)]
                public string X { get; set; }

                /// <summary>
                /// 指标趋势图中y轴纵坐标。
                /// </summary>
                [NameInMap("Y")]
                [Validation(Required=false)]
                public string Y { get; set; }

                /// <summary>
                /// 拓展属性
                /// </summary>
                [NameInMap("Ext")]
                [Validation(Required=false)]
                public Dictionary<string, object> Ext { get; set; }

            }

        }

        /// <summary>
        /// 总览数据
        /// </summary>
        [NameInMap("OverallData")]
        [Validation(Required=false)]
        public DescribeChannelUserMetricsResponseBodyOverallData OverallData { get; set; }
        public class DescribeChannelUserMetricsResponseBodyOverallData : TeaModel {
            [NameInMap("TotalUserNum")]
            [Validation(Required=false)]
            public long? TotalUserNum { get; set; }
            [NameInMap("TotalPubUserNum")]
            [Validation(Required=false)]
            public long? TotalPubUserNum { get; set; }
            [NameInMap("TotalSubUserNum")]
            [Validation(Required=false)]
            public long? TotalSubUserNum { get; set; }
            [NameInMap("TotalJoinFailNum")]
            [Validation(Required=false)]
            public long? TotalJoinFailNum { get; set; }
            [NameInMap("TotalBadExpNum")]
            [Validation(Required=false)]
            public long? TotalBadExpNum { get; set; }
        };

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
