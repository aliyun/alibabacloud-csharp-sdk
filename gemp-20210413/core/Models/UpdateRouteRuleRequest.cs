// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateRouteRuleRequest : TeaModel {
        /// <summary>
        /// 事件分派对象ID（服务组ID 或用户ID）
        /// </summary>
        [NameInMap("assignObjectId")]
        [Validation(Required=false)]
        public long? AssignObjectId { get; set; }

        /// <summary>
        /// 事件分派对象类型 SERVICEGROUP服务组  USER 单个用户
        /// </summary>
        [NameInMap("assignObjectType")]
        [Validation(Required=false)]
        public string AssignObjectType { get; set; }

        /// <summary>
        /// AND
        /// </summary>
        [NameInMap("childRuleRelation")]
        [Validation(Required=false)]
        public string ChildRuleRelation { get; set; }

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
        /// 事件级别 1-P1 2-P2 3-P3 4-P4
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
        /// 通知渠道    SMS 短信  EMAIL  邮件  PHONE  电话  WEIXIN_GROUP 企微群 DING_GROUP 钉钉群
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
        public List<UpdateRouteRuleRequestRouteChildRules> RouteChildRules { get; set; }
        public class UpdateRouteRuleRequestRouteChildRules : TeaModel {
            /// <summary>
            /// 子条件计算关系
            /// </summary>
            [NameInMap("childConditionRelation")]
            [Validation(Required=false)]
            public long? ChildConditionRelation { get; set; }

            /// <summary>
            /// 子规则ID 不填表示新增
            /// </summary>
            [NameInMap("childRouteRuleId")]
            [Validation(Required=false)]
            public long? ChildRouteRuleId { get; set; }

            /// <summary>
            /// 条件
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<UpdateRouteRuleRequestRouteChildRulesConditions> Conditions { get; set; }
            public class UpdateRouteRuleRequestRouteChildRulesConditions : TeaModel {
                /// <summary>
                /// 字段
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// 操作符
                /// </summary>
                [NameInMap("operationSymbol")]
                [Validation(Required=false)]
                public string OperationSymbol { get; set; }

                /// <summary>
                /// 字段取值
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// true  删除子规则  false编辑子规则
            /// </summary>
            [NameInMap("isValidChildRule")]
            [Validation(Required=false)]
            public bool? IsValidChildRule { get; set; }

            /// <summary>
            /// 监控源ID
            /// </summary>
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

        }

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
        /// 时间窗口
        /// </summary>
        [NameInMap("timeWindow")]
        [Validation(Required=false)]
        public int? TimeWindow { get; set; }

        /// <summary>
        /// 时间窗口单位 MINUTE 分钟  SECOND 秒
        /// </summary>
        [NameInMap("timeWindowUnit")]
        [Validation(Required=false)]
        public string TimeWindowUnit { get; set; }

    }

}
