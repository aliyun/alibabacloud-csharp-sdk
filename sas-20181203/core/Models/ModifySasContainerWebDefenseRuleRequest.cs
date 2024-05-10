// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// The paths that are protected.
        /// </summary>
        [NameInMap("PathConfDTOList")]
        [Validation(Required=false)]
        public List<ModifySasContainerWebDefenseRuleRequestPathConfDTOList> PathConfDTOList { get; set; }
        public class ModifySasContainerWebDefenseRuleRequestPathConfDTOList : TeaModel {
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
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DefenseMode")]
            [Validation(Required=false)]
            public string DefenseMode { get; set; }

            /// <summary>
            /// The path that is protected.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DefensePath")]
            [Validation(Required=false)]
            public string DefensePath { get; set; }

            /// <summary>
            /// The files that are excluded.
            /// </summary>
            [NameInMap("ExcludeFile")]
            [Validation(Required=false)]
            public string ExcludeFile { get; set; }

            /// <summary>
            /// The paths to the files that are excluded.
            /// </summary>
            [NameInMap("ExcludeFilePath")]
            [Validation(Required=false)]
            public string ExcludeFilePath { get; set; }

            /// <summary>
            /// The types of the files that are excluded.
            /// </summary>
            [NameInMap("ExcludeFileType")]
            [Validation(Required=false)]
            public string ExcludeFileType { get; set; }

            /// <summary>
            /// The protection mode. Valid values:
            /// 
            /// *   **0**: basic mode (whitelist)
            /// *   **1**: complex mode (blacklist)
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("GuardType")]
            [Validation(Required=false)]
            public int? GuardType { get; set; }

            /// <summary>
            /// The files that are included.
            /// </summary>
            [NameInMap("IncludeFile")]
            [Validation(Required=false)]
            public string IncludeFile { get; set; }

            /// <summary>
            /// The type of the files that are included.
            /// </summary>
            [NameInMap("IncludeFileType")]
            [Validation(Required=false)]
            public string IncludeFileType { get; set; }

            /// <summary>
            /// The path ID.
            /// </summary>
            [NameInMap("PathConfId")]
            [Validation(Required=false)]
            public long? PathConfId { get; set; }

            /// <summary>
            /// The processes that are added to the whitelist.
            /// </summary>
            [NameInMap("ProcessPathList")]
            [Validation(Required=false)]
            public List<string> ProcessPathList { get; set; }

        }

        /// <summary>
        /// The ID of the rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// The name of the rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
