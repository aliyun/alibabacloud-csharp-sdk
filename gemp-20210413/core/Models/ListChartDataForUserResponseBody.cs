// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListChartDataForUserResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListChartDataForUserResponseBodyData> Data { get; set; }
        public class ListChartDataForUserResponseBodyData : TeaModel {
            /// <summary>
            /// 根据影响等级时间等级分组统计数量
            /// </summary>
            [NameInMap("effectionLevel")]
            [Validation(Required=false)]
            public Dictionary<string, object> EffectionLevel { get; set; }

            /// <summary>
            /// 升级事件数
            /// </summary>
            [NameInMap("escalationIncidentCount")]
            [Validation(Required=false)]
            public long? EscalationIncidentCount { get; set; }

            /// <summary>
            /// 时间总数
            /// </summary>
            [NameInMap("incidentCount")]
            [Validation(Required=false)]
            public long? IncidentCount { get; set; }

            /// <summary>
            /// 当日平均响应时间单位秒
            /// </summary>
            [NameInMap("meanTimeToAcknowledge")]
            [Validation(Required=false)]
            public long? MeanTimeToAcknowledge { get; set; }

            /// <summary>
            /// 当日平均完结时间单位秒
            /// </summary>
            [NameInMap("meanTimeToRepair")]
            [Validation(Required=false)]
            public long? MeanTimeToRepair { get; set; }

            /// <summary>
            /// 时间
            /// </summary>
            [NameInMap("time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// 总平均响应时间
            /// </summary>
            [NameInMap("totalMeanTimeToAcknowledge")]
            [Validation(Required=false)]
            public long? TotalMeanTimeToAcknowledge { get; set; }

            /// <summary>
            /// 总平均完结时间
            /// </summary>
            [NameInMap("totalMeanTimeToRepair")]
            [Validation(Required=false)]
            public long? TotalMeanTimeToRepair { get; set; }

            /// <summary>
            /// 未响应升级事件数
            /// </summary>
            [NameInMap("unAcknowledgedEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnAcknowledgedEscalationIncidentCount { get; set; }

            /// <summary>
            /// 未完结升级事件数
            /// </summary>
            [NameInMap("unFinishEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnFinishEscalationIncidentCount { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
