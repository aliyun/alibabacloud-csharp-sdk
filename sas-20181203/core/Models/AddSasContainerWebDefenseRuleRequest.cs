// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddSasContainerWebDefenseRuleRequest : TeaModel {
        /// <summary>
        /// The paths that you want to protect.
        /// </summary>
        [NameInMap("PathConfDTOList")]
        [Validation(Required=false)]
        public List<AddSasContainerWebDefenseRuleRequestPathConfDTOList> PathConfDTOList { get; set; }
        public class AddSasContainerWebDefenseRuleRequestPathConfDTOList : TeaModel {
            /// <summary>
            /// The backup path.
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
            /// The path that you want to protect.
            /// </summary>
            [NameInMap("DefensePath")]
            [Validation(Required=false)]
            public string DefensePath { get; set; }

            /// <summary>
            /// The file that you want to exclude.
            /// </summary>
            [NameInMap("ExcludeFile")]
            [Validation(Required=false)]
            public string ExcludeFile { get; set; }

            /// <summary>
            /// The path to the file that you want to exclude.
            /// </summary>
            [NameInMap("ExcludeFilePath")]
            [Validation(Required=false)]
            public string ExcludeFilePath { get; set; }

            /// <summary>
            /// The type of the file that you want to exclude.
            /// </summary>
            [NameInMap("ExcludeFileType")]
            [Validation(Required=false)]
            public string ExcludeFileType { get; set; }

            /// <summary>
            /// The protecion mode. Valid values:
            /// 
            /// *   **0**: basic mode (whitelist)
            /// *   **1**: complex mode (blacklist)
            /// </summary>
            [NameInMap("GuardType")]
            [Validation(Required=false)]
            public int? GuardType { get; set; }

            /// <summary>
            /// The file that you want to include.
            /// </summary>
            [NameInMap("IncludeFile")]
            [Validation(Required=false)]
            public string IncludeFile { get; set; }

            /// <summary>
            /// The type of the file that you want to include.
            /// </summary>
            [NameInMap("IncludeFileType")]
            [Validation(Required=false)]
            public string IncludeFileType { get; set; }

            /// <summary>
            /// The processes that you want to add to the whitelist.
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

    }

}
