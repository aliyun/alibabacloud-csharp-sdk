// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateEscalationPlanRequest : TeaModel {
        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 升级计划描述
        /// </summary>
        [NameInMap("escalationPlanDescription")]
        [Validation(Required=false)]
        public string EscalationPlanDescription { get; set; }

        /// <summary>
        /// 升级计划名称
        /// </summary>
        [NameInMap("escalationPlanName")]
        [Validation(Required=false)]
        public string EscalationPlanName { get; set; }

        /// <summary>
        /// 升级计划规则列表
        /// </summary>
        [NameInMap("escalationPlanRules")]
        [Validation(Required=false)]
        public List<CreateEscalationPlanRequestEscalationPlanRules> EscalationPlanRules { get; set; }
        public class CreateEscalationPlanRequestEscalationPlanRules : TeaModel {
            /// <summary>
            /// 升级条件
            /// </summary>
            [NameInMap("escalationPlanConditions")]
            [Validation(Required=false)]
            public List<CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions> EscalationPlanConditions { get; set; }
            public class CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions : TeaModel {
                /// <summary>
                /// 影响等级
                /// </summary>
                [NameInMap("effection")]
                [Validation(Required=false)]
                public string Effection { get; set; }

                /// <summary>
                /// 事件等级
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            /// <summary>
            /// 升级策略
            /// </summary>
            [NameInMap("escalationPlanStrategies")]
            [Validation(Required=false)]
            public List<CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies> EscalationPlanStrategies { get; set; }
            public class CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies : TeaModel {
                /// <summary>
                /// 升级通知策略
                /// </summary>
                [NameInMap("noticeChannels")]
                [Validation(Required=false)]
                public List<string> NoticeChannels { get; set; }

                /// <summary>
                /// 升级通知对象id列表
                /// </summary>
                [NameInMap("noticeObjects")]
                [Validation(Required=false)]
                public List<long?> NoticeObjects { get; set; }

                /// <summary>
                /// 通知时间
                /// </summary>
                [NameInMap("noticeTime")]
                [Validation(Required=false)]
                public string NoticeTime { get; set; }

            }

            /// <summary>
            /// 升级类型
            /// </summary>
            [NameInMap("escalationPlanType")]
            [Validation(Required=false)]
            public string EscalationPlanType { get; set; }

        }

        /// <summary>
        /// 升级计划范围对象列表
        /// </summary>
        [NameInMap("escalationPlanScopeObjects")]
        [Validation(Required=false)]
        public List<CreateEscalationPlanRequestEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
        public class CreateEscalationPlanRequestEscalationPlanScopeObjects : TeaModel {
            /// <summary>
            /// 范围对象类型
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// 范围对象id
            /// </summary>
            [NameInMap("scopeObjectId")]
            [Validation(Required=false)]
            public long? ScopeObjectId { get; set; }

        }

    }

}
