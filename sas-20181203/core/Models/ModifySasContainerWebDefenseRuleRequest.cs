// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySasContainerWebDefenseRuleRequest : TeaModel {
        [NameInMap("PathConfDTOList")]
        [Validation(Required=false)]
        public List<ModifySasContainerWebDefenseRuleRequestPathConfDTOList> PathConfDTOList { get; set; }
        public class ModifySasContainerWebDefenseRuleRequestPathConfDTOList : TeaModel {
            [NameInMap("BackupPath")]
            [Validation(Required=false)]
            public string BackupPath { get; set; }

            [NameInMap("DefenseMode")]
            [Validation(Required=false)]
            public string DefenseMode { get; set; }

            [NameInMap("DefensePath")]
            [Validation(Required=false)]
            public string DefensePath { get; set; }

            [NameInMap("ExcludeFile")]
            [Validation(Required=false)]
            public string ExcludeFile { get; set; }

            [NameInMap("ExcludeFilePath")]
            [Validation(Required=false)]
            public string ExcludeFilePath { get; set; }

            [NameInMap("ExcludeFileType")]
            [Validation(Required=false)]
            public string ExcludeFileType { get; set; }

            [NameInMap("GuardType")]
            [Validation(Required=false)]
            public int? GuardType { get; set; }

            [NameInMap("IncludeFile")]
            [Validation(Required=false)]
            public string IncludeFile { get; set; }

            [NameInMap("IncludeFileType")]
            [Validation(Required=false)]
            public string IncludeFileType { get; set; }

            [NameInMap("PathConfId")]
            [Validation(Required=false)]
            public long? PathConfId { get; set; }

            [NameInMap("ProcessPathList")]
            [Validation(Required=false)]
            public List<string> ProcessPathList { get; set; }

        }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
