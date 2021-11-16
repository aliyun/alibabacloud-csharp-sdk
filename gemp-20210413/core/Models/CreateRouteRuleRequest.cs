// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateRouteRuleRequest : TeaModel {
        /// <summary>
        /// 事件分派对象ID（服务组ID 或用户ID）
        /// </summary>
        [NameInMap("assignObjectId")]
        [Validation(Required=false)]
        public long? AssignObjectId { get; set; }

        /// <summary>
        /// 事件分派对象类型 SERVICEGROUP服务组 USER 单个用户
        /// </summary>
        [NameInMap("assignObjectType")]
        [Validation(Required=false)]
        public string AssignObjectType { get; set; }

        /// <summary>
        /// 幂等号
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 影响程度 LOW-一般 HIGH-严重
        /// </summary>
        [NameInMap("effection")]
        [Validation(Required=false)]
        public string Effection { get; set; }

        /// <summary>
        /// 启用状态
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
        public int? MatchCount { get; set; }

        /// <summary>
        /// 通知渠道。 SMS 短信  EMAIL 邮件  PHONE电话  WEIXIN_GROUP 企微群 DING_GROUP钉钉群
        /// </summary>
        [NameInMap("notifyChannels")]
        [Validation(Required=false)]
        public List<string> NotifyChannels { get; set; }

        /// <summary>
        /// 关联服务ID
        /// </summary>
        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        /// <summary>
        /// 子规则
        /// </summary>
        [NameInMap("routeChildRules")]
        [Validation(Required=false)]
        public List<CreateRouteRuleRequestRouteChildRules> RouteChildRules { get; set; }
        public class CreateRouteRuleRequestRouteChildRules : TeaModel {
            /// <summary>
            /// 条件
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<CreateRouteRuleRequestRouteChildRulesConditions> Conditions { get; set; }
            public class CreateRouteRuleRequestRouteChildRulesConditions : TeaModel {
                /// <summary>
                /// 字段名称
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 操作符号：notContain 不包含；contain 包含；equals 等于；notEquals 不等于；
                /// </summary>
                [NameInMap("operationSymbol")]
                [Validation(Required=false)]
                public string OperationSymbol { get; set; }

                /// <summary>
                /// 字段值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// 监控源ID
            /// </summary>
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

        }

        /// <summary>
        /// 路由类型：INCIDENT 触发事件 ALERT仅触发报警
        /// </summary>
        [NameInMap("routeType")]
        [Validation(Required=false)]
        public string RouteType { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public byte[] RuleName { get; set; }

        /// <summary>
        /// 时间窗口
        /// </summary>
        [NameInMap("timeWindow")]
        [Validation(Required=false)]
        public long? TimeWindow { get; set; }

        /// <summary>
        /// 时间窗口单位 MINUTE  分钟  SECOND 秒
        /// </summary>
        [NameInMap("timeWindowUnit")]
        [Validation(Required=false)]
        public string TimeWindowUnit { get; set; }

    }

}
