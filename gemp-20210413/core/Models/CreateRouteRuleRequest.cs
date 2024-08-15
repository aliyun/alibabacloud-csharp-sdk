// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class CreateRouteRuleRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("assignObjectId")]
        [Validation(Required=false)]
        public long? AssignObjectId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("assignObjectType")]
        [Validation(Required=false)]
        public string AssignObjectType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("childRuleRelation")]
        [Validation(Required=false)]
        public string ChildRuleRelation { get; set; }

        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("convergenceFields")]
        [Validation(Required=false)]
        public List<string> ConvergenceFields { get; set; }

        [NameInMap("convergenceType")]
        [Validation(Required=false)]
        public int? ConvergenceType { get; set; }

        [NameInMap("coverageProblemLevels")]
        [Validation(Required=false)]
        public List<string> CoverageProblemLevels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("effection")]
        [Validation(Required=false)]
        public string Effection { get; set; }

        [NameInMap("enableStatus")]
        [Validation(Required=false)]
        public string EnableStatus { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("incidentLevel")]
        [Validation(Required=false)]
        public string IncidentLevel { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("matchCount")]
        [Validation(Required=false)]
        public int? MatchCount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("notifyChannels")]
        [Validation(Required=false)]
        public List<string> NotifyChannels { get; set; }

        [NameInMap("problemEffectionServices")]
        [Validation(Required=false)]
        public List<long?> ProblemEffectionServices { get; set; }

        [NameInMap("problemLevelGroup")]
        [Validation(Required=false)]
        public Dictionary<string, ProblemLevelGroupValue> ProblemLevelGroup { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("relatedServiceId")]
        [Validation(Required=false)]
        public long? RelatedServiceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("routeChildRules")]
        [Validation(Required=false)]
        public List<CreateRouteRuleRequestRouteChildRules> RouteChildRules { get; set; }
        public class CreateRouteRuleRequestRouteChildRules : TeaModel {
            [NameInMap("childConditionRelation")]
            [Validation(Required=false)]
            public long? ChildConditionRelation { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<CreateRouteRuleRequestRouteChildRulesConditions> Conditions { get; set; }
            public class CreateRouteRuleRequestRouteChildRulesConditions : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("operationSymbol")]
                [Validation(Required=false)]
                public string OperationSymbol { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("monitorSourceId")]
            [Validation(Required=false)]
            public long? MonitorSourceId { get; set; }

            [NameInMap("problemLevel")]
            [Validation(Required=false)]
            public string ProblemLevel { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("routeType")]
        [Validation(Required=false)]
        public string RouteType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ruleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timeWindow")]
        [Validation(Required=false)]
        public long? TimeWindow { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("timeWindowUnit")]
        [Validation(Required=false)]
        public string TimeWindowUnit { get; set; }

    }

}
