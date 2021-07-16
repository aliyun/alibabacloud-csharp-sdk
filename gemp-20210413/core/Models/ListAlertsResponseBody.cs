// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListAlertsResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListAlertsResponseBodyData> Data { get; set; }
        public class ListAlertsResponseBodyData : TeaModel {
            /// <summary>
            /// 报警ID
            /// </summary>
            [NameInMap("alertId")]
            [Validation(Required=false)]
            public long? AlertId { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 关联服务名称
            /// </summary>
            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            /// <summary>
            /// 告警优先级  1，2，3，4  对应 p1,p2,p3,p4
            /// </summary>
            [NameInMap("alertLevel")]
            [Validation(Required=false)]
            public string AlertLevel { get; set; }

            /// <summary>
            /// 报警标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// 收敛量
            /// </summary>
            [NameInMap("sourceEventCount")]
            [Validation(Required=false)]
            public long? SourceEventCount { get; set; }

        }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
