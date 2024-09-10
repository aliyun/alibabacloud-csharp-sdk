// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateFileProtectRuleRequest : TeaModel {
        /// <summary>
        /// The severity of alerts. Valid values:
        /// 
        /// *   0: does not generate alerts
        /// *   1: sends notifications
        /// *   2: suspicious
        /// *   3: high-risk
        /// </summary>
        [NameInMap("AlertLevel")]
        [Validation(Required=false)]
        public int? AlertLevel { get; set; }

        /// <summary>
        /// The operations that you want to perform on the files.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileOps")]
        [Validation(Required=false)]
        public List<string> FileOps { get; set; }

        /// <summary>
        /// The paths to the files that you want to monitor. Wildcard characters are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FilePaths")]
        [Validation(Required=false)]
        public List<string> FilePaths { get; set; }

        /// <summary>
        /// The type of the operating system. Valid values:
        /// 
        /// *   **windows**: Windows
        /// *   **linux**: Linux
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// The paths to the processes that you want to monitor. Wildcard characters are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProcPaths")]
        [Validation(Required=false)]
        public List<string> ProcPaths { get; set; }

        /// <summary>
        /// The handling method of the rule. Valid values:
        /// 
        /// *   pass: allow
        /// *   alert
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        /// <summary>
        /// The name of the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// Specifies whether to enable the rule. Valid values:
        /// 
        /// *   **1**: yes
        /// *   **0**: no
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// The switch ID of the rule.
        /// </summary>
        [NameInMap("SwitchId")]
        [Validation(Required=false)]
        public string SwitchId { get; set; }

    }

}
