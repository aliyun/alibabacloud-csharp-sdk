// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListMessageMetricsResponseBody : TeaModel {
        /// <summary>
        /// 返回数据
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMessageMetricsResponseBodyData Data { get; set; }
        public class ListMessageMetricsResponseBodyData : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<ListMessageMetricsResponseBodyDataMetrics> Metrics { get; set; }
            public class ListMessageMetricsResponseBodyDataMetrics : TeaModel {
                public string Date { get; set; }
                public int? Fail { get; set; }
                public int? Pending { get; set; }
                public float? Rate { get; set; }
                public int? Success { get; set; }
                public int? Total { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

    }

}
