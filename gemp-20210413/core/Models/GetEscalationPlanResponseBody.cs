// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetEscalationPlanResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetEscalationPlanResponseBodyData Data { get; set; }
        public class GetEscalationPlanResponseBodyData : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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
            public List<GetEscalationPlanResponseBodyDataEscalationPlanRules> EscalationPlanRules { get; set; }
            public class GetEscalationPlanResponseBodyDataEscalationPlanRules : TeaModel {
                [NameInMap("escalationPlanConditions")]
                [Validation(Required=false)]
                public List<GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanConditions> EscalationPlanConditions { get; set; }
                public class GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanConditions : TeaModel {
                    [NameInMap("effection")]
                    [Validation(Required=false)]
                    public string Effection { get; set; }

                    [NameInMap("level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

                [NameInMap("escalationPlanRuleId")]
                [Validation(Required=false)]
                public long? EscalationPlanRuleId { get; set; }

                [NameInMap("escalationPlanStrategies")]
                [Validation(Required=false)]
                public List<GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategies> EscalationPlanStrategies { get; set; }
                public class GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategies : TeaModel {
                    [NameInMap("enableWebhook")]
                    [Validation(Required=false)]
                    public bool? EnableWebhook { get; set; }

                    [NameInMap("escalationPlanType")]
                    [Validation(Required=false)]
                    public string EscalationPlanType { get; set; }

                    [NameInMap("noticeChannels")]
                    [Validation(Required=false)]
                    public string NoticeChannels { get; set; }

                    [NameInMap("noticeObjectList")]
                    [Validation(Required=false)]
                    public List<GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategiesNoticeObjectList> NoticeObjectList { get; set; }
                    public class GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategiesNoticeObjectList : TeaModel {
                        [NameInMap("noticeObjectId")]
                        [Validation(Required=false)]
                        public long? NoticeObjectId { get; set; }

                        [NameInMap("noticeObjectName")]
                        [Validation(Required=false)]
                        public string NoticeObjectName { get; set; }

                    }

                    [NameInMap("noticeTime")]
                    [Validation(Required=false)]
                    public long? NoticeTime { get; set; }

                    [NameInMap("serviceGroups")]
                    [Validation(Required=false)]
                    public List<GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategiesServiceGroups> ServiceGroups { get; set; }
                    public class GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategiesServiceGroups : TeaModel {
                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("serviceGroupName")]
                        [Validation(Required=false)]
                        public string ServiceGroupName { get; set; }

                    }

                }

            }

            [NameInMap("escalationPlanScopeObjects")]
            [Validation(Required=false)]
            public List<GetEscalationPlanResponseBodyDataEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
            public class GetEscalationPlanResponseBodyDataEscalationPlanScopeObjects : TeaModel {
                [NameInMap("escalationPlanScopeObjects")]
                [Validation(Required=false)]
                public int? EscalationPlanScopeObjects { get; set; }

                [NameInMap("scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

                [NameInMap("scopeObjectDeletedType")]
                [Validation(Required=false)]
                public int? ScopeObjectDeletedType { get; set; }

                [NameInMap("scopeObjectId")]
                [Validation(Required=false)]
                public long? ScopeObjectId { get; set; }

                [NameInMap("scopeObjectName")]
                [Validation(Required=false)]
                public string ScopeObjectName { get; set; }

            }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
