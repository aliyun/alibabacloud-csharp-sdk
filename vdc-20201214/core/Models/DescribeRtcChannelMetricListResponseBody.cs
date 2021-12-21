// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeRtcChannelMetricListResponseBody : TeaModel {
        /// <summary>
        /// 指标列表
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<DescribeRtcChannelMetricListResponseBodyMetrics> Metrics { get; set; }
        public class DescribeRtcChannelMetricListResponseBodyMetrics : TeaModel {
            /// <summary>
            /// 指标键值对,指标发生时间:指标值
            /// </summary>
            [NameInMap("KVs")]
            [Validation(Required=false)]
            public Dictionary<string, object> KVs { get; set; }

            /// <summary>
            /// 指标ID
            /// </summary>
            [NameInMap("Mid")]
            [Validation(Required=false)]
            public int? Mid { get; set; }

            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
