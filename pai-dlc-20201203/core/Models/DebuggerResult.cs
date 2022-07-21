// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerResult : TeaModel {
        /// <summary>
        /// 配置项细节，json结构
        /// </summary>
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        /// <summary>
        /// 规则报告细节信息
        /// </summary>
        [NameInMap("DebuggerJobIssues")]
        [Validation(Required=false)]
        public string DebuggerJobIssues { get; set; }

        /// <summary>
        /// debugger job运行状态描述
        /// </summary>
        [NameInMap("DebuggerJobStatus")]
        [Validation(Required=false)]
        public string DebuggerJobStatus { get; set; }

        /// <summary>
        /// 报告文件下载地址
        /// </summary>
        [NameInMap("DebuggerReportURL")]
        [Validation(Required=false)]
        public string DebuggerReportURL { get; set; }

        /// <summary>
        /// 作业显示名
        /// </summary>
        [NameInMap("JobDisplayName")]
        [Validation(Required=false)]
        public string JobDisplayName { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [NameInMap("JobUserId")]
        [Validation(Required=false)]
        public string JobUserId { get; set; }

    }

}
