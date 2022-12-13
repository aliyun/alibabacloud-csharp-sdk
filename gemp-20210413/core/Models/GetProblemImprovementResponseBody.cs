// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemImprovementResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProblemImprovementResponseBodyData Data { get; set; }
        public class GetProblemImprovementResponseBodyData : TeaModel {
            [NameInMap("customProblemReason")]
            [Validation(Required=false)]
            public string CustomProblemReason { get; set; }

            [NameInMap("discoverSource")]
            [Validation(Required=false)]
            public string DiscoverSource { get; set; }

            [NameInMap("dutyDepartmentId")]
            [Validation(Required=false)]
            public string DutyDepartmentId { get; set; }

            [NameInMap("dutyDepartmentName")]
            [Validation(Required=false)]
            public string DutyDepartmentName { get; set; }

            [NameInMap("dutyUserId")]
            [Validation(Required=false)]
            public long? DutyUserId { get; set; }

            [NameInMap("dutyUserIsValid")]
            [Validation(Required=false)]
            public long? DutyUserIsValid { get; set; }

            [NameInMap("dutyUserName")]
            [Validation(Required=false)]
            public string DutyUserName { get; set; }

            [NameInMap("dutyUserPhone")]
            [Validation(Required=false)]
            public string DutyUserPhone { get; set; }

            [NameInMap("injectionMode")]
            [Validation(Required=false)]
            public string InjectionMode { get; set; }

            [NameInMap("isManual")]
            [Validation(Required=false)]
            public bool? IsManual { get; set; }

            [NameInMap("measureList")]
            [Validation(Required=false)]
            public List<GetProblemImprovementResponseBodyDataMeasureList> MeasureList { get; set; }
            public class GetProblemImprovementResponseBodyDataMeasureList : TeaModel {
                [NameInMap("checkStandard")]
                [Validation(Required=false)]
                public string CheckStandard { get; set; }

                [NameInMap("checkUserId")]
                [Validation(Required=false)]
                public long? CheckUserId { get; set; }

                [NameInMap("checkUserIsValid")]
                [Validation(Required=false)]
                public int? CheckUserIsValid { get; set; }

                [NameInMap("checkUserName")]
                [Validation(Required=false)]
                public string CheckUserName { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("directorId")]
                [Validation(Required=false)]
                public long? DirectorId { get; set; }

                [NameInMap("directorIsValid")]
                [Validation(Required=false)]
                public int? DirectorIsValid { get; set; }

                [NameInMap("directorName")]
                [Validation(Required=false)]
                public string DirectorName { get; set; }

                [NameInMap("measureId")]
                [Validation(Required=false)]
                public long? MeasureId { get; set; }

                [NameInMap("planFinishTime")]
                [Validation(Required=false)]
                public string PlanFinishTime { get; set; }

                [NameInMap("stalkerId")]
                [Validation(Required=false)]
                public long? StalkerId { get; set; }

                [NameInMap("stalkerIsValid")]
                [Validation(Required=false)]
                public int? StalkerIsValid { get; set; }

                [NameInMap("stalkerName")]
                [Validation(Required=false)]
                public string StalkerName { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

            }

            [NameInMap("monitorSourceName")]
            [Validation(Required=false)]
            public string MonitorSourceName { get; set; }

            [NameInMap("problemId")]
            [Validation(Required=false)]
            public string ProblemId { get; set; }

            [NameInMap("problemReason")]
            [Validation(Required=false)]
            public string ProblemReason { get; set; }

            [NameInMap("recentActivity")]
            [Validation(Required=false)]
            public string RecentActivity { get; set; }

            [NameInMap("recoveryMode")]
            [Validation(Required=false)]
            public string RecoveryMode { get; set; }

            [NameInMap("relationChanges")]
            [Validation(Required=false)]
            public string RelationChanges { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("replayDutyUserId")]
            [Validation(Required=false)]
            public long? ReplayDutyUserId { get; set; }

            [NameInMap("replayDutyUserIsValid")]
            [Validation(Required=false)]
            public long? ReplayDutyUserIsValid { get; set; }

            [NameInMap("replayDutyUserName")]
            [Validation(Required=false)]
            public string ReplayDutyUserName { get; set; }

            [NameInMap("replayDutyUserPhone")]
            [Validation(Required=false)]
            public string ReplayDutyUserPhone { get; set; }

            [NameInMap("userReport")]
            [Validation(Required=false)]
            public long? UserReport { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
