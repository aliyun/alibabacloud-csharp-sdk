// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateFileProtectRuleRequest : TeaModel {
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
        /// The operations performed on the files.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FileOps")]
        [Validation(Required=false)]
        public List<string> FileOps { get; set; }

        /// <summary>
        /// The paths to the monitored files. Wildcard characters are supported.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FilePaths")]
        [Validation(Required=false)]
        public List<string> FilePaths { get; set; }

        /// <summary>
        /// The ID of the rule.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The paths to the monitored processes.
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
        /// The status of the rule. Valid values:
        /// 
        /// *   **0**: disabled
        /// *   **1**: enabled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
