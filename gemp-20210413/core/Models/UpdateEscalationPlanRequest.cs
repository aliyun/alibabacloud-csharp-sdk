// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateEscalationPlanRequest : TeaModel {
        /// <summary>
        /// 升级计划id
        /// </summary>
        [NameInMap("escalationPlanId")]
        [Validation(Required=false)]
        public long? EscalationPlanId { get; set; }

        /// <summary>
        /// 升级计划名称
        /// </summary>
        [NameInMap("escalationPlanName")]
        [Validation(Required=false)]
        public string EscalationPlanName { get; set; }

        /// <summary>
        /// 升级计划描述
        /// </summary>
        [NameInMap("escalationPlanDescription")]
        [Validation(Required=false)]
        public string EscalationPlanDescription { get; set; }

        /// <summary>
        /// 关联范围列表（服务）
        /// </summary>
        [NameInMap("escalationPlanScopeObjects")]
        [Validation(Required=false)]
        public List<UpdateEscalationPlanRequestEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
        public class UpdateEscalationPlanRequestEscalationPlanScopeObjects : TeaModel {
            /// <summary>
            /// 主键
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// 范围对象id
            /// </summary>
            [NameInMap("scopeObjectId")]
            [Validation(Required=false)]
            public long? ScopeObjectId { get; set; }

            /// <summary>
            /// 范围对象类型
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

        /// <summary>
        /// 升级计划规则
        /// </summary>
        [NameInMap("escalationPlanRules")]
        [Validation(Required=false)]
        public List<UpdateEscalationPlanRequestEscalationPlanRules> EscalationPlanRules { get; set; }
        public class UpdateEscalationPlanRequestEscalationPlanRules : TeaModel {
            /// <summary>
            /// 主键
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// UN_ACKNOWLEDGE 未响应 UN_FINISH 未完结
            /// </summary>
            [NameInMap("escalationPlanType")]
            [Validation(Required=false)]
            public string EscalationPlanType { get; set; }

            /// <summary>
            /// 升级计划条件列表
            /// </summary>
            [NameInMap("escalationPlanConditions")]
            [Validation(Required=false)]
            public List<UpdateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions> EscalationPlanConditions { get; set; }
            public class UpdateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions : TeaModel {
                /// <summary>
                /// P1 P2 P3 P4
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// LOW HIGH
                /// </summary>
                [NameInMap("effection")]
                [Validation(Required=false)]
                public string Effection { get; set; }

            }

            /// <summary>
            /// 升级策略列表
            /// </summary>
            [NameInMap("escalationPlanStrategies")]
            [Validation(Required=false)]
            public List<UpdateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies> EscalationPlanStrategies { get; set; }
            public class UpdateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies : TeaModel {
                /// <summary>
                /// 通知时间
                /// </summary>
                [NameInMap("noticeTime")]
                [Validation(Required=false)]
                public long? NoticeTime { get; set; }

                /// <summary>
                /// 通知对象id
                /// </summary>
                [NameInMap("noticeObjects")]
                [Validation(Required=false)]
                public List<long?> NoticeObjects { get; set; }

                /// <summary>
                /// 通知渠道
                /// </summary>
                [NameInMap("noticeChannels")]
                [Validation(Required=false)]
                public List<string> NoticeChannels { get; set; }

            }

        }

        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
