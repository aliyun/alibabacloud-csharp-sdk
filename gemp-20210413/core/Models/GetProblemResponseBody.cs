// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemResponseBody : TeaModel {
        /// <summary>
        /// 详情
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProblemResponseBodyData Data { get; set; }
        public class GetProblemResponseBodyData : TeaModel {
            [NameInMap("problemId")]
            [Validation(Required=false)]
            public long? ProblemId { get; set; }
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("incidentNumber")]
            [Validation(Required=false)]
            public string IncidentNumber { get; set; }
            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }
            [NameInMap("problemNumber")]
            [Validation(Required=false)]
            public string ProblemNumber { get; set; }
            [NameInMap("problemName")]
            [Validation(Required=false)]
            public string ProblemName { get; set; }
            [NameInMap("problemStatus")]
            [Validation(Required=false)]
            public int? ProblemStatus { get; set; }
            [NameInMap("problemLevel")]
            [Validation(Required=false)]
            public int? ProblemLevel { get; set; }
            [NameInMap("discoverTime")]
            [Validation(Required=false)]
            public string DiscoverTime { get; set; }
            [NameInMap("recoveryTime")]
            [Validation(Required=false)]
            public string RecoveryTime { get; set; }
            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public long? RelatedServiceId { get; set; }
            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
            [NameInMap("progressSummary")]
            [Validation(Required=false)]
            public string ProgressSummary { get; set; }
            [NameInMap("preliminaryReason")]
            [Validation(Required=false)]
            public string PreliminaryReason { get; set; }
            [NameInMap("mainHandler")]
            [Validation(Required=false)]
            public long? MainHandler { get; set; }
            [NameInMap("mainHandlerId")]
            [Validation(Required=false)]
            public long? MainHandlerId { get; set; }
            [NameInMap("mainHandlerPhone")]
            [Validation(Required=false)]
            public string MainHandlerPhone { get; set; }
            [NameInMap("feedback")]
            [Validation(Required=false)]
            public string Feedback { get; set; }
            [NameInMap("cancelReasonDescription")]
            [Validation(Required=false)]
            public string CancelReasonDescription { get; set; }
            [NameInMap("cancelReason")]
            [Validation(Required=false)]
            public long? CancelReason { get; set; }
            [NameInMap("handingProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataHandingProblemOperateLogs> HandingProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataHandingProblemOperateLogs : TeaModel {
                public string Operator { get; set; }
                public string ActionName { get; set; }
                public string ActionTime { get; set; }
            }
            [NameInMap("restoredProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataRestoredProblemOperateLogs> RestoredProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataRestoredProblemOperateLogs : TeaModel {
                public string Operator { get; set; }
                public string ActionName { get; set; }
                public string ActionTime { get; set; }
            }
            [NameInMap("replayingProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataReplayingProblemOperateLogs> ReplayingProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataReplayingProblemOperateLogs : TeaModel {
                public string Operator { get; set; }
                public string ActionName { get; set; }
                public string ActionTime { get; set; }
            }
            [NameInMap("replayProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataReplayProblemOperateLogs> ReplayProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataReplayProblemOperateLogs : TeaModel {
                public string Operator { get; set; }
                public string ActionName { get; set; }
                public string ActionTime { get; set; }
            }
            [NameInMap("effectionServices")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataEffectionServices> EffectionServices { get; set; }
            public class GetProblemResponseBodyDataEffectionServices : TeaModel {
                public long? EffectionServiceId { get; set; }
                public long? EffectionLevel { get; set; }
                public int? EffectionStatus { get; set; }
                public string Description { get; set; }
                public string ServiceName { get; set; }
            }
            [NameInMap("coordinationGroups")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataCoordinationGroups> CoordinationGroups { get; set; }
            public class GetProblemResponseBodyDataCoordinationGroups : TeaModel {
                public long? ServiceGroupId { get; set; }
                public string ServiceGroupName { get; set; }
            }
            [NameInMap("timelines")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataTimelines> Timelines { get; set; }
            public class GetProblemResponseBodyDataTimelines : TeaModel {
                public string KeyNode { get; set; }
            }
            [NameInMap("cancelProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataCancelProblemOperateLogs> CancelProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataCancelProblemOperateLogs : TeaModel {
                public string Operator { get; set; }
                public string ActionName { get; set; }
                public string ActionTime { get; set; }
            }
        };

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
