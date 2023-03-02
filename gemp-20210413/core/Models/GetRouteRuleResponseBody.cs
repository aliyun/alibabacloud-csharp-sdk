// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetRouteRuleResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRouteRuleResponseBodyData Data { get; set; }
        public class GetRouteRuleResponseBodyData : TeaModel {
            [NameInMap("assignObjectId")]
            [Validation(Required=false)]
            public long? AssignObjectId { get; set; }

            [NameInMap("assignObjectName")]
            [Validation(Required=false)]
            public string AssignObjectName { get; set; }

            [NameInMap("assignObjectType")]
            [Validation(Required=false)]
            public string AssignObjectType { get; set; }

            [NameInMap("childRuleRelation")]
            [Validation(Required=false)]
            public string ChildRuleRelation { get; set; }

            [NameInMap("convergenceFields")]
            [Validation(Required=false)]
            public List<string> ConvergenceFields { get; set; }

            [NameInMap("convergenceType")]
            [Validation(Required=false)]
            public int? ConvergenceType { get; set; }

            [NameInMap("coverageProblemLevels")]
            [Validation(Required=false)]
            public List<string> CoverageProblemLevels { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("effection")]
            [Validation(Required=false)]
            public string Effection { get; set; }

            [NameInMap("enableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            [NameInMap("eventRouteChildRules")]
            [Validation(Required=false)]
            public List<GetRouteRuleResponseBodyDataEventRouteChildRules> EventRouteChildRules { get; set; }
            public class GetRouteRuleResponseBodyDataEventRouteChildRules : TeaModel {
                [NameInMap("childConditionRelation")]
                [Validation(Required=false)]
                public long? ChildConditionRelation { get; set; }

                [NameInMap("childRouteRuleId")]
                [Validation(Required=false)]
                public long? ChildRouteRuleId { get; set; }

                [NameInMap("conditions")]
                [Validation(Required=false)]
                public List<GetRouteRuleResponseBodyDataEventRouteChildRulesConditions> Conditions { get; set; }
                public class GetRouteRuleResponseBodyDataEventRouteChildRulesConditions : TeaModel {
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

                [NameInMap("monitorIntegrationConfigId")]
                [Validation(Required=false)]
                public long? MonitorIntegrationConfigId { get; set; }

                [NameInMap("monitorSourceId")]
                [Validation(Required=false)]
                public long? MonitorSourceId { get; set; }

                [NameInMap("monitorSourceName")]
                [Validation(Required=false)]
                public string MonitorSourceName { get; set; }

                [NameInMap("parentRuleId")]
                [Validation(Required=false)]
                public long? ParentRuleId { get; set; }

                [NameInMap("problemLevel")]
                [Validation(Required=false)]
                public string ProblemLevel { get; set; }

            }

            [NameInMap("incidentLevel")]
            [Validation(Required=false)]
            public string IncidentLevel { get; set; }

            [NameInMap("matchCount")]
            [Validation(Required=false)]
            public long? MatchCount { get; set; }

            [NameInMap("notifyChannelNames")]
            [Validation(Required=false)]
            public List<string> NotifyChannelNames { get; set; }

            [NameInMap("notifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }

            [NameInMap("problemEffectionServices")]
            [Validation(Required=false)]
            public List<long?> ProblemEffectionServices { get; set; }

            [NameInMap("problemLevelGroup")]
            [Validation(Required=false)]
            public Dictionary<string, DataProblemLevelGroupValue> ProblemLevelGroup { get; set; }

            [NameInMap("relServiceDeleteType")]
            [Validation(Required=false)]
            public int? RelServiceDeleteType { get; set; }

            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public long? RelatedServiceId { get; set; }

            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

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

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
