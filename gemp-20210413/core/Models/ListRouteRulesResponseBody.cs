// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListRouteRulesResponseBody : TeaModel {
        /// <summary>
        /// 规则列表
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListRouteRulesResponseBodyData> Data { get; set; }
        public class ListRouteRulesResponseBodyData : TeaModel {
            /// <summary>
            /// 事件分派对象ID（服务组ID 或用户ID）
            /// </summary>
            [NameInMap("assignObjectId")]
            [Validation(Required=false)]
            public long? AssignObjectId { get; set; }

            /// <summary>
            /// 事件分派对象类型 SERVICEGROUP 服务组  USER 单个用户
            /// </summary>
            [NameInMap("assignObjectType")]
            [Validation(Required=false)]
            public string AssignObjectType { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// 影响程度 LOW-一般 HIGH-严重
            /// </summary>
            [NameInMap("effection")]
            [Validation(Required=false)]
            public string Effection { get; set; }

            /// <summary>
            /// 是否启用  DISABLE禁用. ENABLE 启用
            /// </summary>
            [NameInMap("enableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            /// <summary>
            /// 事件级别 P1 P2 P3 P4
            /// </summary>
            [NameInMap("incidentLevel")]
            [Validation(Required=false)]
            public string IncidentLevel { get; set; }

            /// <summary>
            /// 命中次数
            /// </summary>
            [NameInMap("matchCount")]
            [Validation(Required=false)]
            public long? MatchCount { get; set; }

            /// <summary>
            /// 监控源名称
            /// </summary>
            [NameInMap("monitorSourceNames")]
            [Validation(Required=false)]
            public string MonitorSourceNames { get; set; }

            /// <summary>
            /// 关联服务ID
            /// </summary>
            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public long? RelatedServiceId { get; set; }

            /// <summary>
            /// 服务名称
            /// </summary>
            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            /// <summary>
            /// 规则ID
            /// </summary>
            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }

            /// <summary>
            /// 路由类型：INCIDENT 触发事件 ALERT 仅触发报警
            /// </summary>
            [NameInMap("routeType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

            /// <summary>
            /// 规则名称
            /// </summary>
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// 租户ID
            /// </summary>
            [NameInMap("tenantRamId")]
            [Validation(Required=false)]
            public long? TenantRamId { get; set; }

            /// <summary>
            /// 时间窗口
            /// </summary>
            [NameInMap("timeWindow")]
            [Validation(Required=false)]
            public long? TimeWindow { get; set; }

            /// <summary>
            /// 时间窗口单位 MINUTE 分钟  SECOND 秒
            /// </summary>
            [NameInMap("timeWindowUnit")]
            [Validation(Required=false)]
            public long? TimeWindowUnit { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// 第几页
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
