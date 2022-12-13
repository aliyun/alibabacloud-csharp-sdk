// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProblemResponseBodyData Data { get; set; }
        public class GetProblemResponseBodyData : TeaModel {
            [NameInMap("cancelProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataCancelProblemOperateLogs> CancelProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataCancelProblemOperateLogs : TeaModel {
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                [NameInMap("actionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

            }

            [NameInMap("cancelReason")]
            [Validation(Required=false)]
            public long? CancelReason { get; set; }

            [NameInMap("cancelReasonDescription")]
            [Validation(Required=false)]
            public string CancelReasonDescription { get; set; }

            [NameInMap("coordinationGroups")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataCoordinationGroups> CoordinationGroups { get; set; }
            public class GetProblemResponseBodyDataCoordinationGroups : TeaModel {
                [NameInMap("isValid")]
                [Validation(Required=false)]
                public long? IsValid { get; set; }

                [NameInMap("serviceGroupId")]
                [Validation(Required=false)]
                public long? ServiceGroupId { get; set; }

                [NameInMap("serviceGroupName")]
                [Validation(Required=false)]
                public string ServiceGroupName { get; set; }

            }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("discoverTime")]
            [Validation(Required=false)]
            public string DiscoverTime { get; set; }

            [NameInMap("durationTime")]
            [Validation(Required=false)]
            public long? DurationTime { get; set; }

            [NameInMap("effectionServices")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataEffectionServices> EffectionServices { get; set; }
            public class GetProblemResponseBodyDataEffectionServices : TeaModel {
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("effectionLevel")]
                [Validation(Required=false)]
                public long? EffectionLevel { get; set; }

                [NameInMap("effectionServiceId")]
                [Validation(Required=false)]
                public long? EffectionServiceId { get; set; }

                [NameInMap("effectionStatus")]
                [Validation(Required=false)]
                public int? EffectionStatus { get; set; }

                [NameInMap("serviceDeleteType")]
                [Validation(Required=false)]
                public int? ServiceDeleteType { get; set; }

                [NameInMap("serviceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            [NameInMap("feedback")]
            [Validation(Required=false)]
            public string Feedback { get; set; }

            [NameInMap("handingProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataHandingProblemOperateLogs> HandingProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataHandingProblemOperateLogs : TeaModel {
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                [NameInMap("actionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("userIsValid")]
                [Validation(Required=false)]
                public long? UserIsValid { get; set; }

            }

            [NameInMap("incidentId")]
            [Validation(Required=false)]
            public long? IncidentId { get; set; }

            [NameInMap("incidentNumber")]
            [Validation(Required=false)]
            public string IncidentNumber { get; set; }

            [NameInMap("mainHandler")]
            [Validation(Required=false)]
            public long? MainHandler { get; set; }

            [NameInMap("mainHandlerId")]
            [Validation(Required=false)]
            public long? MainHandlerId { get; set; }

            [NameInMap("mainHandlerIsValid")]
            [Validation(Required=false)]
            public long? MainHandlerIsValid { get; set; }

            [NameInMap("mainHandlerPhone")]
            [Validation(Required=false)]
            public string MainHandlerPhone { get; set; }

            [NameInMap("preliminaryReason")]
            [Validation(Required=false)]
            public string PreliminaryReason { get; set; }

            /// <summary>
            /// ID
            /// </summary>
            [NameInMap("problemId")]
            [Validation(Required=false)]
            public long? ProblemId { get; set; }

            [NameInMap("problemLevel")]
            [Validation(Required=false)]
            public int? ProblemLevel { get; set; }

            [NameInMap("problemName")]
            [Validation(Required=false)]
            public string ProblemName { get; set; }

            [NameInMap("problemNumber")]
            [Validation(Required=false)]
            public string ProblemNumber { get; set; }

            [NameInMap("problemStatus")]
            [Validation(Required=false)]
            public int? ProblemStatus { get; set; }

            [NameInMap("progressSummary")]
            [Validation(Required=false)]
            public string ProgressSummary { get; set; }

            [NameInMap("progressSummaryRichTextId")]
            [Validation(Required=false)]
            public long? ProgressSummaryRichTextId { get; set; }

            [NameInMap("recoveryTime")]
            [Validation(Required=false)]
            public string RecoveryTime { get; set; }

            [NameInMap("relatedServiceId")]
            [Validation(Required=false)]
            public long? RelatedServiceId { get; set; }

            [NameInMap("replayProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataReplayProblemOperateLogs> ReplayProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataReplayProblemOperateLogs : TeaModel {
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                [NameInMap("actionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("userIsValid")]
                [Validation(Required=false)]
                public long? UserIsValid { get; set; }

            }

            [NameInMap("replayingProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataReplayingProblemOperateLogs> ReplayingProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataReplayingProblemOperateLogs : TeaModel {
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                [NameInMap("actionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("userIsValid")]
                [Validation(Required=false)]
                public long? UserIsValid { get; set; }

            }

            [NameInMap("restoredProblemOperateLogs")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataRestoredProblemOperateLogs> RestoredProblemOperateLogs { get; set; }
            public class GetProblemResponseBodyDataRestoredProblemOperateLogs : TeaModel {
                [NameInMap("actionName")]
                [Validation(Required=false)]
                public string ActionName { get; set; }

                [NameInMap("actionTime")]
                [Validation(Required=false)]
                public string ActionTime { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                [NameInMap("userIsValid")]
                [Validation(Required=false)]
                public long? UserIsValid { get; set; }

            }

            /// <summary>
            /// serviceDeleteType
            /// </summary>
            [NameInMap("serviceDeleteType")]
            [Validation(Required=false)]
            public int? ServiceDeleteType { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("timelines")]
            [Validation(Required=false)]
            public List<GetProblemResponseBodyDataTimelines> Timelines { get; set; }
            public class GetProblemResponseBodyDataTimelines : TeaModel {
                [NameInMap("keyNode")]
                [Validation(Required=false)]
                public string KeyNode { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
