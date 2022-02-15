// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListDataReportForServiceGroupResponseBody : TeaModel {
        /// <summary>
        /// 统计数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataReportForServiceGroupResponseBodyData> Data { get; set; }
        public class ListDataReportForServiceGroupResponseBodyData : TeaModel {
            /// <summary>
            /// 升级事件数量
            /// </summary>
            [NameInMap("escalationIncidentCount")]
            [Validation(Required=false)]
            public long? EscalationIncidentCount { get; set; }

            /// <summary>
            /// 事件完结数
            /// </summary>
            [NameInMap("finishIncidentCount")]
            [Validation(Required=false)]
            public long? FinishIncidentCount { get; set; }

            /// <summary>
            /// 完结率
            /// </summary>
            [NameInMap("finishProportion")]
            [Validation(Required=false)]
            public string FinishProportion { get; set; }

            /// <summary>
            /// 事件数量
            /// </summary>
            [NameInMap("incidentCount")]
            [Validation(Required=false)]
            public long? IncidentCount { get; set; }

            /// <summary>
            /// MRRA
            /// </summary>
            [NameInMap("meanTimeToAcknowledge")]
            [Validation(Required=false)]
            public long? MeanTimeToAcknowledge { get; set; }

            /// <summary>
            /// MTTR
            /// </summary>
            [NameInMap("meanTimeToRepair")]
            [Validation(Required=false)]
            public long? MeanTimeToRepair { get; set; }

            /// <summary>
            /// 服务组ID
            /// </summary>
            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }

            /// <summary>
            /// 服务组名字
            /// </summary>
            [NameInMap("serviceGroupName")]
            [Validation(Required=false)]
            public string ServiceGroupName { get; set; }

            /// <summary>
            /// 未响应升级事件数量
            /// </summary>
            [NameInMap("unAcknowledgedEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnAcknowledgedEscalationIncidentCount { get; set; }

            /// <summary>
            /// 未完成升级事件数量
            /// </summary>
            [NameInMap("unFinishEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnFinishEscalationIncidentCount { get; set; }

        }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [NameInMap("pageSIze")]
        [Validation(Required=false)]
        public long? PageSIze { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
