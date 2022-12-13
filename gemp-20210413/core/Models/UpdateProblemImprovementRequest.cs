// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateProblemImprovementRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("customProblemReason")]
        [Validation(Required=false)]
        public string CustomProblemReason { get; set; }

        [NameInMap("discoverSource")]
        [Validation(Required=false)]
        public long? DiscoverSource { get; set; }

        [NameInMap("dutyDepartmentId")]
        [Validation(Required=false)]
        public long? DutyDepartmentId { get; set; }

        [NameInMap("dutyDepartmentName")]
        [Validation(Required=false)]
        public string DutyDepartmentName { get; set; }

        [NameInMap("dutyUserId")]
        [Validation(Required=false)]
        public long? DutyUserId { get; set; }

        [NameInMap("injectionMode")]
        [Validation(Required=false)]
        public string InjectionMode { get; set; }

        [NameInMap("monitorSourceName")]
        [Validation(Required=false)]
        public string MonitorSourceName { get; set; }

        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

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

        [NameInMap("userReport")]
        [Validation(Required=false)]
        public long? UserReport { get; set; }

    }

}
