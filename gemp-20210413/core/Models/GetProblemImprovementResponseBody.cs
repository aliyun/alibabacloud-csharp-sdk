// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetProblemImprovementResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetProblemImprovementResponseBodyData Data { get; set; }
        public class GetProblemImprovementResponseBodyData : TeaModel {
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
                public string CheckStandard { get; set; }
                public long? CheckUserId { get; set; }
                public string CheckUserName { get; set; }
                public string Content { get; set; }
                public long? DirectorId { get; set; }
                public string DirectorName { get; set; }
                public long? MeasureId { get; set; }
                public string PlanFinishTime { get; set; }
                public long? StalkerId { get; set; }
                public string StalkerName { get; set; }
                public string Status { get; set; }
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
            [NameInMap("replayDutyUserName")]
            [Validation(Required=false)]
            public string ReplayDutyUserName { get; set; }
            [NameInMap("replayDutyUserPhone")]
            [Validation(Required=false)]
            public string ReplayDutyUserPhone { get; set; }
            [NameInMap("userReport")]
            [Validation(Required=false)]
            public long? UserReport { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
