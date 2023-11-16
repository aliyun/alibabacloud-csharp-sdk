// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddSasContainerWebDefenseRuleRequest : TeaModel {
        [NameInMap("PathConfDTOList")]
        [Validation(Required=false)]
        public List<AddSasContainerWebDefenseRuleRequestPathConfDTOList> PathConfDTOList { get; set; }
        public class AddSasContainerWebDefenseRuleRequestPathConfDTOList : TeaModel {
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

            [NameInMap("ProcessPathList")]
            [Validation(Required=false)]
            public List<string> ProcessPathList { get; set; }

        }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
