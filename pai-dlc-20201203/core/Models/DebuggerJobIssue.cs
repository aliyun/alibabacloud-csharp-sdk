// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class DebuggerJobIssue : TeaModel {
        /// <summary>
        /// 规则报告的具体json描述
        /// </summary>
        [NameInMap("DebuggerJobIssue")]
        [Validation(Required=false)]
        public string DebuggerJobIssue_ { get; set; }

        /// <summary>
        /// 创建时间（UTC）
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// event的全局唯一ID
        /// </summary>
        [NameInMap("JobDebuggerIssueId")]
        [Validation(Required=false)]
        public string JobDebuggerIssueId { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// 规则触发原因的编码
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// 规则触发的原因
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
