// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListDataReportForUserResponseBody : TeaModel {
        /// <summary>
        /// 个人统计数据
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListDataReportForUserResponseBodyData> Data { get; set; }
        public class ListDataReportForUserResponseBodyData : TeaModel {
            /// <summary>
            /// 分配事件数量
            /// </summary>
            [NameInMap("distributionIncidentCount")]
            [Validation(Required=false)]
            public long? DistributionIncidentCount { get; set; }

            /// <summary>
            /// 升级事件数量
            /// </summary>
            [NameInMap("escalationIncidentCount")]
            [Validation(Required=false)]
            public long? EscalationIncidentCount { get; set; }

            /// <summary>
            /// 完结事件数量
            /// </summary>
            [NameInMap("finishIncidentNumber")]
            [Validation(Required=false)]
            public long? FinishIncidentNumber { get; set; }

            /// <summary>
            /// 完结率
            /// </summary>
            [NameInMap("finishProportion")]
            [Validation(Required=false)]
            public string FinishProportion { get; set; }

            /// <summary>
            /// MRRA
            /// </summary>
            [NameInMap("meanTimeToAcknowledge")]
            [Validation(Required=false)]
            public string MeanTimeToAcknowledge { get; set; }

            /// <summary>
            /// MTTA
            /// </summary>
            [NameInMap("meanTimeToRepair")]
            [Validation(Required=false)]
            public string MeanTimeToRepair { get; set; }

            /// <summary>
            /// 未响应升级数
            /// </summary>
            [NameInMap("unAcknowledgedEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnAcknowledgedEscalationIncidentCount { get; set; }

            /// <summary>
            /// 非分配完结数
            /// </summary>
            [NameInMap("unDistributionIncidentCount")]
            [Validation(Required=false)]
            public long? UnDistributionIncidentCount { get; set; }

            /// <summary>
            /// 未完结事件数
            /// </summary>
            [NameInMap("unFinishEscalationIncidentCount")]
            [Validation(Required=false)]
            public long? UnFinishEscalationIncidentCount { get; set; }

            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// 用户名字
            /// </summary>
            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
