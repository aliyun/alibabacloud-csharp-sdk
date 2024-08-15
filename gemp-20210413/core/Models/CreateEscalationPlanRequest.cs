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
        /// This parameter is required.
        /// </summary>
        [NameInMap("escalationPlanDescription")]
        [Validation(Required=false)]
        public string EscalationPlanDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("escalationPlanName")]
        [Validation(Required=false)]
        public string EscalationPlanName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("escalationPlanRules")]
        [Validation(Required=false)]
        public List<CreateEscalationPlanRequestEscalationPlanRules> EscalationPlanRules { get; set; }
        public class CreateEscalationPlanRequestEscalationPlanRules : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("escalationPlanConditions")]
            [Validation(Required=false)]
            public List<CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions> EscalationPlanConditions { get; set; }
            public class CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("effection")]
                [Validation(Required=false)]
                public string Effection { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("escalationPlanStrategies")]
            [Validation(Required=false)]
            public List<CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies> EscalationPlanStrategies { get; set; }
            public class CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("enableWebhook")]
                [Validation(Required=false)]
                public bool? EnableWebhook { get; set; }

                [NameInMap("escalationPlanType")]
                [Validation(Required=false)]
                public string EscalationPlanType { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("noticeChannels")]
                [Validation(Required=false)]
                public List<string> NoticeChannels { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("noticeObjects")]
                [Validation(Required=false)]
                public List<long?> NoticeObjects { get; set; }

                [NameInMap("noticeRoleList")]
                [Validation(Required=false)]
                public List<long?> NoticeRoleList { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("noticeTime")]
                [Validation(Required=false)]
                public string NoticeTime { get; set; }

                [NameInMap("serviceGroupIds")]
                [Validation(Required=false)]
                public List<long?> ServiceGroupIds { get; set; }

            }

            [NameInMap("escalationPlanType")]
            [Validation(Required=false)]
            public string EscalationPlanType { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("escalationPlanScopeObjects")]
        [Validation(Required=false)]
        public List<CreateEscalationPlanRequestEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
        public class CreateEscalationPlanRequestEscalationPlanScopeObjects : TeaModel {
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("scopeObjectId")]
            [Validation(Required=false)]
            public long? ScopeObjectId { get; set; }

        }

        [NameInMap("isGlobal")]
        [Validation(Required=false)]
        public bool? IsGlobal { get; set; }

    }

}
