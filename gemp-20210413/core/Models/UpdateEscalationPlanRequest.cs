// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateEscalationPlanRequest : TeaModel {
        /// <summary>
        /// clientToken
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("escalationPlanDescription")]
        [Validation(Required=false)]
        public string EscalationPlanDescription { get; set; }

        [NameInMap("escalationPlanId")]
        [Validation(Required=false)]
        public long? EscalationPlanId { get; set; }

        [NameInMap("escalationPlanName")]
        [Validation(Required=false)]
        public string EscalationPlanName { get; set; }

        [NameInMap("escalationPlanRules")]
        [Validation(Required=false)]
        public List<UpdateEscalationPlanRequestEscalationPlanRules> EscalationPlanRules { get; set; }
        public class UpdateEscalationPlanRequestEscalationPlanRules : TeaModel {
            [NameInMap("escalationPlanConditions")]
            [Validation(Required=false)]
            public List<UpdateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions> EscalationPlanConditions { get; set; }
            public class UpdateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions : TeaModel {
                /// <summary>
                /// LOW HIGH
                /// </summary>
                [NameInMap("effection")]
                [Validation(Required=false)]
                public string Effection { get; set; }

                /// <summary>
                /// P1 P2 P3 P4
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            [NameInMap("escalationPlanStrategies")]
            [Validation(Required=false)]
            public List<UpdateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies> EscalationPlanStrategies { get; set; }
            public class UpdateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies : TeaModel {
                [NameInMap("enableWebhook")]
                [Validation(Required=false)]
                public bool? EnableWebhook { get; set; }

                [NameInMap("escalationPlanType")]
                [Validation(Required=false)]
                public string EscalationPlanType { get; set; }

                [NameInMap("noticeChannels")]
                [Validation(Required=false)]
                public List<string> NoticeChannels { get; set; }

                [NameInMap("noticeObjects")]
                [Validation(Required=false)]
                public List<long?> NoticeObjects { get; set; }

                [NameInMap("noticeRoleList")]
                [Validation(Required=false)]
                public List<long?> NoticeRoleList { get; set; }

                [NameInMap("noticeTime")]
                [Validation(Required=false)]
                public long? NoticeTime { get; set; }

                [NameInMap("serviceGroupIds")]
                [Validation(Required=false)]
                public List<long?> ServiceGroupIds { get; set; }

            }

            [NameInMap("escalationPlanType")]
            [Validation(Required=false)]
            public string EscalationPlanType { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("escalationPlanScopeObjects")]
        [Validation(Required=false)]
        public List<UpdateEscalationPlanRequestEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
        public class UpdateEscalationPlanRequestEscalationPlanScopeObjects : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("scopeObjectId")]
            [Validation(Required=false)]
            public long? ScopeObjectId { get; set; }

        }

        [NameInMap("isGlobal")]
        [Validation(Required=false)]
        public bool? IsGlobal { get; set; }

    }

}
