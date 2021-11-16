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
                public List<GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanConditions> EscalationPlanConditions { get; set; }
                public class GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanConditions : TeaModel {
                    public string Effection { get; set; }
                    public string Level { get; set; }
                }
                public long? EscalationPlanRuleId { get; set; }
                public List<GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategies> EscalationPlanStrategies { get; set; }
                public class GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategies : TeaModel {
                    public string EscalationPlanType { get; set; }
                    public string NoticeChannels { get; set; }
                    public List<GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategiesNoticeObjectList> NoticeObjectList { get; set; }
                    public class GetEscalationPlanResponseBodyDataEscalationPlanRulesEscalationPlanStrategiesNoticeObjectList : TeaModel {
                        public long? NoticeObjectId { get; set; }
                        public string NoticeObjectName { get; set; }
                    }
                    public long? NoticeTime { get; set; }
                }
            }
            [NameInMap("escalationPlanScopeObjects")]
            [Validation(Required=false)]
            public List<GetEscalationPlanResponseBodyDataEscalationPlanScopeObjects> EscalationPlanScopeObjects { get; set; }
            public class GetEscalationPlanResponseBodyDataEscalationPlanScopeObjects : TeaModel {
                public string Scope { get; set; }
                public long? ScopeObjectId { get; set; }
                public string ScopeObjectName { get; set; }
            }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
