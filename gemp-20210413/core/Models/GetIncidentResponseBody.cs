// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetIncidentResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetIncidentResponseBodyData Data { get; set; }
        public class GetIncidentResponseBodyData : TeaModel {
            [NameInMap("assignToWhoIsValid")]
            [Validation(Required=false)]
            public int? AssignToWhoIsValid { get; set; }

            [NameInMap("assignUserId")]
            [Validation(Required=false)]
            public long? AssignUserId { get; set; }

            [NameInMap("assignUserName")]
            [Validation(Required=false)]
            public string AssignUserName { get; set; }

            [NameInMap("assignUserPhone")]
            [Validation(Required=false)]
            public string AssignUserPhone { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("defaultAssignToWho")]
            [Validation(Required=false)]
            public int? DefaultAssignToWho { get; set; }

            [NameInMap("defaultAssignToWhoIsValid")]
            [Validation(Required=false)]
            public int? DefaultAssignToWhoIsValid { get; set; }

            [NameInMap("defaultAssignToWhoName")]
            [Validation(Required=false)]
            public string DefaultAssignToWhoName { get; set; }

            [NameInMap("durationTime")]
            [Validation(Required=false)]
            public long? DurationTime { get; set; }

            [NameInMap("effect")]
            [Validation(Required=false)]
            public string Effect { get; set; }

            [NameInMap("incidentDescription")]
            [Validation(Required=false)]
            public string IncidentDescription { get; set; }

            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

            [NameInMap("incidentLevel")]
            [Validation(Required=false)]
            public string IncidentLevel { get; set; }

            [NameInMap("incidentNumber")]
            [Validation(Required=false)]
            public string IncidentNumber { get; set; }

            [NameInMap("incidentStatus")]
            [Validation(Required=false)]
            public string IncidentStatus { get; set; }

            [NameInMap("incidentTitle")]
            [Validation(Required=false)]
            public string IncidentTitle { get; set; }

            [NameInMap("isManual")]
            [Validation(Required=false)]
            public bool? IsManual { get; set; }

            [NameInMap("isUpgrade")]
            [Validation(Required=false)]
            public bool? IsUpgrade { get; set; }

            [NameInMap("notifyChannels")]
            [Validation(Required=false)]
            public List<string> NotifyChannels { get; set; }

            [NameInMap("problemId")]
            [Validation(Required=false)]
            public long? ProblemId { get; set; }

            [NameInMap("problemNumber")]
            [Validation(Required=false)]
            public string ProblemNumber { get; set; }

            [NameInMap("relRouteRuleDeleteType")]
            [Validation(Required=false)]
            public int? RelRouteRuleDeleteType { get; set; }

            [NameInMap("relServiceDeleteType")]
            [Validation(Required=false)]
            public int? RelServiceDeleteType { get; set; }

            [NameInMap("relServiceGroupIsValid")]
            [Validation(Required=false)]
            public int? RelServiceGroupIsValid { get; set; }

            [NameInMap("relatedServiceDescription")]
            [Validation(Required=false)]
            public string RelatedServiceDescription { get; set; }

            [NameInMap("relatedServiceGroupId")]
            [Validation(Required=false)]
            public long? RelatedServiceGroupId { get; set; }

            [NameInMap("relatedServiceGroupName")]
            [Validation(Required=false)]
            public string RelatedServiceGroupName { get; set; }

            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public long? RelatedServiceId { get; set; }

            [NameInMap("relatedServiceName")]
            [Validation(Required=false)]
            public string RelatedServiceName { get; set; }

            [NameInMap("routeRuleId")]
            [Validation(Required=false)]
            public long? RouteRuleId { get; set; }

            [NameInMap("routeRuleName")]
            [Validation(Required=false)]
            public string RouteRuleName { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
