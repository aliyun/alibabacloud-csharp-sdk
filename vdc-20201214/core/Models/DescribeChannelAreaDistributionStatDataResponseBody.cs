// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdc20201214.Models
{
    public class DescribeChannelAreaDistributionStatDataResponseBody : TeaModel {
        /// <summary>
        /// 地域统计列表。
        /// </summary>
        [NameInMap("AreaStatList")]
        [Validation(Required=false)]
        public List<DescribeChannelAreaDistributionStatDataResponseBodyAreaStatList> AreaStatList { get; set; }
        public class DescribeChannelAreaDistributionStatDataResponseBodyAreaStatList : TeaModel {
            /// <summary>
            /// 地域名称，例如：中国_浙江省_杭州市。
            /// </summary>
            [NameInMap("AreaName")]
            [Validation(Required=false)]
            public string AreaName { get; set; }

            /// <summary>
            /// 通信人数。
            /// </summary>
            [NameInMap("CallUserCount")]
            [Validation(Required=false)]
            public int? CallUserCount { get; set; }

            /// <summary>
            /// 优质传输率，用小数表示，例如0.9999表示优质传输率为99.99%。
            /// </summary>
            [NameInMap("HighQualityTransmissionRate")]
            [Validation(Required=false)]
            public string HighQualityTransmissionRate { get; set; }

            /// <summary>
            /// 发布端人数。
            /// </summary>
            [NameInMap("PubUserCount")]
            [Validation(Required=false)]
            public int? PubUserCount { get; set; }

            /// <summary>
            /// 订阅端人数。
            /// </summary>
            [NameInMap("SubUserCount")]
            [Validation(Required=false)]
            public int? SubUserCount { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
