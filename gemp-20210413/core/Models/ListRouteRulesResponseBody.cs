// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListRouteRulesResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListRouteRulesResponseBodyData> Data { get; set; }
        public class ListRouteRulesResponseBodyData : TeaModel {
            [NameInMap("assignObjectId")]
            [Validation(Required=false)]
            public long? AssignObjectId { get; set; }

            [NameInMap("assignObjectType")]
            [Validation(Required=false)]
            public string AssignObjectType { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("effection")]
            [Validation(Required=false)]
            public string Effection { get; set; }

            [NameInMap("enableStatus")]
            [Validation(Required=false)]
            public string EnableStatus { get; set; }

            [NameInMap("incidentLevel")]
            [Validation(Required=false)]
            public string IncidentLevel { get; set; }

            [NameInMap("isValid")]
            [Validation(Required=false)]
            public int? IsValid { get; set; }

            [NameInMap("matchCount")]
            [Validation(Required=false)]
            public long? MatchCount { get; set; }

            [NameInMap("monitorSourceNames")]
            [Validation(Required=false)]
            public string MonitorSourceNames { get; set; }

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

            [NameInMap("tenantRamId")]
            [Validation(Required=false)]
            public long? TenantRamId { get; set; }

            [NameInMap("timeWindow")]
            [Validation(Required=false)]
            public long? TimeWindow { get; set; }

            [NameInMap("timeWindowUnit")]
            [Validation(Required=false)]
            public long? TimeWindowUnit { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
