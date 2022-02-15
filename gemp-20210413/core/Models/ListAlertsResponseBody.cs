// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListAlertsResponseBody : TeaModel {
        /// <summary>
        /// 报警列表
        /// </summary>
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
            /// 告警优先级  1，2，3，4  对应 p1,p2,p3,p4
            /// </summary>
            [NameInMap("alertLevel")]
            [Validation(Required=false)]
            public string AlertLevel { get; set; }

            /// <summary>
            /// 报警编号
            /// </summary>
            [NameInMap("alertNumber")]
            [Validation(Required=false)]
            public string AlertNumber { get; set; }

            /// <summary>
            /// 报警源
            /// </summary>
            [NameInMap("alertSourceName")]
            [Validation(Required=false)]
            public string AlertSourceName { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 第一次告警上报时间
            /// </summary>
            [NameInMap("firstEventTime")]
            [Validation(Required=false)]
            public string FirstEventTime { get; set; }

            /// <summary>
            /// 关联服务名称
            /// </summary>
            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            /// <summary>
            /// 关联流转规则ID
            /// </summary>
            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }

            /// <summary>
            /// 流转规则名字
            /// </summary>
            [NameInMap("routeRuleName")]
            [Validation(Required=false)]
            public string RouteRuleName { get; set; }

            /// <summary>
            /// 收敛量
            /// </summary>
            [NameInMap("sourceEventCount")]
            [Validation(Required=false)]
            public long? SourceEventCount { get; set; }

            /// <summary>
            /// 报警标题
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// 当前页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 页的大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// 请求ID
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
