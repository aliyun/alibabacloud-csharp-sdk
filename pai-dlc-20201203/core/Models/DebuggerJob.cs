// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerJob : TeaModel {
        /// <summary>
        /// debugger分析作业ID
        /// </summary>
        [NameInMap("DebuggerJobId")]
        [Validation(Required=false)]
        public string DebuggerJobId { get; set; }

        /// <summary>
        /// 作业显示名
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 作业运行的时长（单位秒）
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// 创建时间（UTC）
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 失败时间（UTC）
        /// </summary>
        [NameInMap("GmtFailedTime")]
        [Validation(Required=false)]
        public string GmtFailedTime { get; set; }

        /// <summary>
        /// 任务完成时间（UTC）
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// 运行开始时间（UTC）
        /// </summary>
        [NameInMap("GmtRunningTime")]
        [Validation(Required=false)]
        public string GmtRunningTime { get; set; }

        /// <summary>
        /// 结束时间（UTC）
        /// </summary>
        [NameInMap("GmtStoppedTime")]
        [Validation(Required=false)]
        public string GmtStoppedTime { get; set; }

        /// <summary>
        /// 提交时间（UTC）
        /// </summary>
        [NameInMap("GmtSubmittedTime")]
        [Validation(Required=false)]
        public string GmtSubmittedTime { get; set; }

        /// <summary>
        /// 成功结束时间（UTC）
        /// </summary>
        [NameInMap("GmtSucceedTime")]
        [Validation(Required=false)]
        public string GmtSucceedTime { get; set; }

        /// <summary>
        /// 作业运行状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// 作业所属的运行工作空间
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// 作业所属的运行工作空间名称
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
