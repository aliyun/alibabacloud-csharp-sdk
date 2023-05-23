// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListMessageMetricsResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMessageMetricsResponseBodyData Data { get; set; }
        public class ListMessageMetricsResponseBodyData : TeaModel {
            /// <summary>
            /// 分页返回的统计数据条目列表。
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<ListMessageMetricsResponseBodyDataMetrics> Metrics { get; set; }
            public class ListMessageMetricsResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// 发送日期。
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// 发送失败。
                /// </summary>
                [NameInMap("Fail")]
                [Validation(Required=false)]
                public int? Fail { get; set; }

                /// <summary>
                /// 发送中。
                /// </summary>
                [NameInMap("Pending")]
                [Validation(Required=false)]
                public int? Pending { get; set; }

                /// <summary>
                /// 发送成功率。
                /// </summary>
                [NameInMap("Rate")]
                [Validation(Required=false)]
                public float? Rate { get; set; }

                /// <summary>
                /// 发送成功。
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public int? Success { get; set; }

                /// <summary>
                /// 总计短信数量。
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

            }

            /// <summary>
            /// 分页数，从1开始，默认为1。
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// 分页大小，默认为10。
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// 总统计数据条目数量。
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
