// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class UpdateProblemImprovementRequest : TeaModel {
        /// <summary>
        /// 幂等校验token
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 发现来源 码表:PROBLEM_DISCOVER_SOURCE
        /// </summary>
        [NameInMap("discoverSource")]
        [Validation(Required=false)]
        public long? DiscoverSource { get; set; }

        /// <summary>
        /// 故障责任部门ID
        /// </summary>
        [NameInMap("dutyDepartmentId")]
        [Validation(Required=false)]
        public long? DutyDepartmentId { get; set; }

        /// <summary>
        /// 故障责任部门
        /// </summary>
        [NameInMap("dutyDepartmentName")]
        [Validation(Required=false)]
        public string DutyDepartmentName { get; set; }

        /// <summary>
        /// 故障责任人id
        /// </summary>
        [NameInMap("dutyUserId")]
        [Validation(Required=false)]
        public long? DutyUserId { get; set; }

        /// <summary>
        /// 注入方式 码表:PROBLEM_INJECTION_MODE
        /// </summary>
        [NameInMap("injectionMode")]
        [Validation(Required=false)]
        public string InjectionMode { get; set; }

        /// <summary>
        /// 监控源
        /// </summary>
        [NameInMap("monitorSourceName")]
        [Validation(Required=false)]
        public string MonitorSourceName { get; set; }

        /// <summary>
        /// 故障ID
        /// </summary>
        [NameInMap("problemId")]
        [Validation(Required=false)]
        public long? ProblemId { get; set; }

        /// <summary>
        /// 故障原因
        /// </summary>
        [NameInMap("problemReason")]
        [Validation(Required=false)]
        public string ProblemReason { get; set; }

        /// <summary>
        /// 最近活动 码表:PROBLEM_RECENT_ACTIVITY
        /// </summary>
        [NameInMap("recentActivity")]
        [Validation(Required=false)]
        public string RecentActivity { get; set; }

        /// <summary>
        /// 恢复方式  码表:PROBLEM_RECOVERY_MODE
        /// </summary>
        [NameInMap("recoveryMode")]
        [Validation(Required=false)]
        public string RecoveryMode { get; set; }

        /// <summary>
        /// 关联变更
        /// </summary>
        [NameInMap("relationChanges")]
        [Validation(Required=false)]
        public string RelationChanges { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// 复盘负责人id
        /// </summary>
        [NameInMap("replayDutyUserId")]
        [Validation(Required=false)]
        public long? ReplayDutyUserId { get; set; }

        /// <summary>
        /// 用户上报 码表:PROBLEM_USER_REPORT
        /// </summary>
        [NameInMap("userReport")]
        [Validation(Required=false)]
        public long? UserReport { get; set; }

    }

}
