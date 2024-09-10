// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectRuleResponseBody : TeaModel {
        /// <summary>
        /// The details of returned data.
        /// </summary>
        [NameInMap("FileProtectList")]
        [Validation(Required=false)]
        public List<ListFileProtectRuleResponseBodyFileProtectList> FileProtectList { get; set; }
        public class ListFileProtectRuleResponseBodyFileProtectList : TeaModel {
            /// <summary>
            /// The handling method of the rule. Valid values:
            /// 
            /// *   pass: allow
            /// *   alert
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

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
            public string AlertLevel { get; set; }

            /// <summary>
            /// The total number of affected assets.
            /// </summary>
            [NameInMap("EffectInstanceCount")]
            [Validation(Required=false)]
            public long? EffectInstanceCount { get; set; }

            /// <summary>
            /// The operations performed on the files.
            /// </summary>
            [NameInMap("FileOps")]
            [Validation(Required=false)]
            public List<string> FileOps { get; set; }

            /// <summary>
            /// The paths to the monitored files. Wildcard characters are supported.
            /// </summary>
            [NameInMap("FilePaths")]
            [Validation(Required=false)]
            public List<string> FilePaths { get; set; }

            /// <summary>
            /// The time when the rule was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The time when the rule was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

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
            /// The paths to the monitored processes. Wildcard characters are supported.
            /// </summary>
            [NameInMap("ProcPaths")]
            [Validation(Required=false)]
            public List<string> ProcPaths { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// *   0: disabled
            /// *   1: enabled
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

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListFileProtectRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListFileProtectRuleResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
