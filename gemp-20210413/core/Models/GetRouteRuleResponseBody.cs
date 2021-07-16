// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetRouteRuleResponseBody : TeaModel {
        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 规则详情
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetRouteRuleResponseBodyData Data { get; set; }
        public class GetRouteRuleResponseBodyData : TeaModel {
            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }
            [NameInMap("ruleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }
            [NameInMap("timeWindow")]
            [Validation(Required=false)]
            public int? TimeWindow { get; set; }
            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }
            [NameInMap("enableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }
            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public long? RelatedServiceId { get; set; }
            [NameInMap("routeType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }
            [NameInMap("incidentLevel")]
            [Validation(Required=false)]
            public string IncidentLevel { get; set; }
            [NameInMap("assignObjectId")]
            [Validation(Required=false)]
            public long? AssignObjectId { get; set; }
            [NameInMap("assignObjectType")]
            [Validation(Required=false)]
            public string AssignObjectType { get; set; }
            [NameInMap("effection")]
            [Validation(Required=false)]
            public string Effection { get; set; }
            [NameInMap("matchCount")]
            [Validation(Required=false)]
            public long? MatchCount { get; set; }
            [NameInMap("eventRouteChildRules")]
            [Validation(Required=false)]
            public List<GetRouteRuleResponseBodyDataEventRouteChildRules> EventRouteChildRules { get; set; }
            public class GetRouteRuleResponseBodyDataEventRouteChildRules : TeaModel {
                public long? ChildRouteRuleId { get; set; }
                public bool? IsValidChildRule { get; set; }
                public long? ParentRuleId { get; set; }
                public long? MonitorSourceId { get; set; }
                public long? MonitorIntegrationConfigId { get; set; }
                public string MonitorSourceName { get; set; }
                public List<GetRouteRuleResponseBodyDataEventRouteChildRulesConditions> Conditions { get; set; }
                public class GetRouteRuleResponseBodyDataEventRouteChildRulesConditions : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                    public string OperationSymbol { get; set; }
                }
            }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }
            [NameInMap("notifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }
            [NameInMap("notifyChannelNames")]
            [Validation(Required=false)]
            public List<string> NotifyChannelNames { get; set; }
            [NameInMap("assignObjectName")]
            [Validation(Required=false)]
            public string AssignObjectName { get; set; }
        };

    }

}
