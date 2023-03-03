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

        [NameInMap("escalationPlanDescription")]
        [Validation(Required=false)]
        public string EscalationPlanDescription { get; set; }

        [NameInMap("escalationPlanName")]
        [Validation(Required=false)]
        public string EscalationPlanName { get; set; }

        [NameInMap("escalationPlanRules")]
        [Validation(Required=false)]
        public List<CreateEscalationPlanRequestEscalationPlanRules> EscalationPlanRules { get; set; }
        public class CreateEscalationPlanRequestEscalationPlanRules : TeaModel {
            [NameInMap("escalationPlanConditions")]
            [Validation(Required=false)]
            public List<CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions> EscalationPlanConditions { get; set; }
            public class CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanConditions : TeaModel {
                [NameInMap("effection")]
                [Validation(Required=false)]
                public string Effection { get; set; }

                [NameInMap("level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            [NameInMap("escalationPlanStrategies")]
            [Validation(Required=false)]
            public List<CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies> EscalationPlanStrategies { get; set; }
            public class CreateEscalationPlanRequestEscalationPlanRulesEscalationPlanStrategies : TeaModel {
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

        [NameInMap("escalationPlanScopeObjects")]
        [Validation(Required=false)]
        public List<CreateEscalationPlanRequestEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
        public class CreateEscalationPlanRequestEscalationPlanScopeObjects : TeaModel {
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("scopeObjectId")]
            [Validation(Required=false)]
            public long? ScopeObjectId { get; set; }

        }

    }

}
