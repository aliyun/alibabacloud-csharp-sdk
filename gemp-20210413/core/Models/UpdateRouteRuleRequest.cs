// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateRouteRuleRequest : TeaModel {
        [NameInMap("assignObjectId")]
        [Validation(Required=false)]
        public long? AssignObjectId { get; set; }

        [NameInMap("assignObjectType")]
        [Validation(Required=false)]
        public string AssignObjectType { get; set; }

        [NameInMap("childRuleRelation")]
        [Validation(Required=false)]
        public string ChildRuleRelation { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("coverageProblemLevels")]
        [Validation(Required=false)]
        public List<string> CoverageProblemLevels { get; set; }

        [NameInMap("effection")]
        [Validation(Required=false)]
        public string Effection { get; set; }

        [NameInMap("incidentLevel")]
        [Validation(Required=false)]
        public string IncidentLevel { get; set; }

        [NameInMap("matchCount")]
        [Validation(Required=false)]
        public long? MatchCount { get; set; }

        [NameInMap("notifyChannels")]
        [Validation(Required=false)]
        public List<string> NotifyChannels { get; set; }

        [NameInMap("problemEffectionServices")]
        [Validation(Required=false)]
        public List<long?> ProblemEffectionServices { get; set; }

        [NameInMap("problemLevelGroup")]
        [Validation(Required=false)]
        public Dictionary<string, ProblemLevelGroupValue> ProblemLevelGroup { get; set; }

        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        [NameInMap("routeChildRules")]
        [Validation(Required=false)]
        public List<UpdateRouteRuleRequestRouteChildRules> RouteChildRules { get; set; }
        public class UpdateRouteRuleRequestRouteChildRules : TeaModel {
            [NameInMap("childConditionRelation")]
            [Validation(Required=false)]
            public long? ChildConditionRelation { get; set; }

            [NameInMap("childRouteRuleId")]
            [Validation(Required=false)]
            public long? ChildRouteRuleId { get; set; }

            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<UpdateRouteRuleRequestRouteChildRulesConditions> Conditions { get; set; }
            public class UpdateRouteRuleRequestRouteChildRulesConditions : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("operationSymbol")]
                [Validation(Required=false)]
                public string OperationSymbol { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("isValidChildRule")]
            [Validation(Required=false)]
            public bool? IsValidChildRule { get; set; }

            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            [NameInMap("problemLevel")]
            [Validation(Required=false)]
            public string ProblemLevel { get; set; }

        }

        [NameInMap("routeRuleId")]
        [Validation(Required=false)]
        public long? RouteRuleId { get; set; }

        [NameInMap("routeType")]
        [Validation(Required=false)]
        public string RouteType { get; set; }

        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("timeWindow")]
        [Validation(Required=false)]
        public int? TimeWindow { get; set; }

        [NameInMap("timeWindowUnit")]
        [Validation(Required=false)]
        public string TimeWindowUnit { get; set; }

    }

}
