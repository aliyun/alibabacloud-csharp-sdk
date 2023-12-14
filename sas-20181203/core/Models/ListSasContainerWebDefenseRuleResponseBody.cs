// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSasContainerWebDefenseRuleResponseBody : TeaModel {
        /// <summary>
        /// The rules for container tamper-proofing.
        /// </summary>
        [NameInMap("ContainerWebDefenseRuleList")]
        [Validation(Required=false)]
        public List<ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleList> ContainerWebDefenseRuleList { get; set; }
        public class ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleList : TeaModel {
            /// <summary>
            /// The user ID.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// The number of the applications.
            /// </summary>
            [NameInMap("ApptotalCount")]
            [Validation(Required=false)]
            public int? ApptotalCount { get; set; }

            /// <summary>
            /// The creation time. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The timestamp when the alert event was last modified. Unit: milliseconds.
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
            /// The paths that are protected.
            /// </summary>
            [NameInMap("PathConfDTOList")]
            [Validation(Required=false)]
            public List<ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleListPathConfDTOList> PathConfDTOList { get; set; }
            public class ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleListPathConfDTOList : TeaModel {
                /// <summary>
                /// The backup paths.
                /// </summary>
                [NameInMap("BackupPath")]
                [Validation(Required=false)]
                public string BackupPath { get; set; }

                /// <summary>
                /// The prevention mode. Valid values:
                /// 
                /// *   **block**
                /// *   **audit**
                /// </summary>
                [NameInMap("DefenseMode")]
                [Validation(Required=false)]
                public string DefenseMode { get; set; }

                /// <summary>
                /// The protected path.
                /// </summary>
                [NameInMap("DefensePath")]
                [Validation(Required=false)]
                public string DefensePath { get; set; }

                /// <summary>
                /// The file that is excluded.
                /// </summary>
                [NameInMap("ExcludeFile")]
                [Validation(Required=false)]
                public string ExcludeFile { get; set; }

                /// <summary>
                /// The path to the file that is excluded.
                /// </summary>
                [NameInMap("ExcludeFilePath")]
                [Validation(Required=false)]
                public string ExcludeFilePath { get; set; }

                /// <summary>
                /// The type of the file that is excluded.
                /// </summary>
                [NameInMap("ExcludeFileType")]
                [Validation(Required=false)]
                public string ExcludeFileType { get; set; }

                /// <summary>
                /// The protection mode. Valid values:
                /// 
                /// *   **0**: basic mode (whitelist)
                /// *   **1**: complex mode (blacklist)
                /// </summary>
                [NameInMap("GuardType")]
                [Validation(Required=false)]
                public int? GuardType { get; set; }

                /// <summary>
                /// The file that is included.
                /// </summary>
                [NameInMap("IncludeFile")]
                [Validation(Required=false)]
                public string IncludeFile { get; set; }

                /// <summary>
                /// The type of the file that is included.
                /// </summary>
                [NameInMap("IncludeFileType")]
                [Validation(Required=false)]
                public string IncludeFileType { get; set; }

                /// <summary>
                /// The processes that are added to the whitelist.
                /// </summary>
                [NameInMap("ProcessPathList")]
                [Validation(Required=false)]
                public List<string> ProcessPathList { get; set; }

            }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The status of the rule. Valid values:
            /// 
            /// *   **1**: enabled
            /// *   **0**: disabled
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public int? RuleStatus { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListSasContainerWebDefenseRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListSasContainerWebDefenseRuleResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on the current page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

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
        /// The request ID, which is used to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
