// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListTrendForSourceEventResponseBody : TeaModel {
        /// <summary>
        /// 统计列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListTrendForSourceEventResponseBodyData> Data { get; set; }
        public class ListTrendForSourceEventResponseBodyData : TeaModel {
            /// <summary>
            /// 收敛率
            /// </summary>
            [NameInMap("convergenceRate")]
            [Validation(Required=false)]
            public string ConvergenceRate { get; set; }

            /// <summary>
            /// 最大持续时长
            /// </summary>
            [NameInMap("maxSustainTime")]
            [Validation(Required=false)]
            public long? MaxSustainTime { get; set; }

            /// <summary>
            /// 是否跨天
            /// </summary>
            [NameInMap("skipDay")]
            [Validation(Required=false)]
            public bool? SkipDay { get; set; }

            /// <summary>
            /// 按监控源分组统计数据
            /// </summary>
            [NameInMap("sourceEventsStatMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> SourceEventsStatMap { get; set; }

            /// <summary>
            /// 时间单位
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
