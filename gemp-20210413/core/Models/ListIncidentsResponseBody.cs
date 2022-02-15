// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListIncidentsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListIncidentsResponseBodyData> Data { get; set; }
        public class ListIncidentsResponseBodyData : TeaModel {
            /// <summary>
            /// 分派的用户ID
            /// </summary>
            [NameInMap("assignUserId")]
            [Validation(Required=false)]
            public long? AssignUserId { get; set; }

            /// <summary>
            /// 分派的用户姓名
            /// </summary>
            [NameInMap("assignUserName")]
            [Validation(Required=false)]
            public string AssignUserName { get; set; }

            /// <summary>
            /// 分派人手机号
            /// </summary>
            [NameInMap("assignUserPhone")]
            [Validation(Required=false)]
            public string AssignUserPhone { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 影响等级 高：HIGH 低 LOW
            /// </summary>
            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

            /// <summary>
            /// 事件级别 P1 P2 P3 P4
            /// </summary>
            [NameInMap("incidentLevel")]
            [Validation(Required=false)]
            public string IncidentLevel { get; set; }

            /// <summary>
            /// 事件编号
            /// </summary>
            [NameInMap("incidentNumber")]
            [Validation(Required=false)]
            public string IncidentNumber { get; set; }

            /// <summary>
            /// 事件状态 0已分派 1已响应 2已完结
            /// </summary>
            [NameInMap("incidentStatus")]
            [Validation(Required=false)]
            public string IncidentStatus { get; set; }

            /// <summary>
            /// 事件标题
            /// </summary>
            [NameInMap("incidentTitle")]
            [Validation(Required=false)]
            public string IncidentTitle { get; set; }

            /// <summary>
            /// 事件来源 是=手动 否=自动
            /// </summary>
            [NameInMap("isManual")]
            [Validation(Required=false)]
            public bool? IsManual { get; set; }

            /// <summary>
            /// 关联服务ID
            /// </summary>
            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public long? RelatedServiceId { get; set; }

            /// <summary>
            /// 关联服务名称
            /// </summary>
            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            /// <summary>
            /// 流转规则ID
            /// </summary>
            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }

            /// <summary>
            /// 流转规则
            /// </summary>
            [NameInMap("routeRuleName")]
            [Validation(Required=false)]
            public string RouteRuleName { get; set; }

        }

        /// <summary>
        /// 页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// 行
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
