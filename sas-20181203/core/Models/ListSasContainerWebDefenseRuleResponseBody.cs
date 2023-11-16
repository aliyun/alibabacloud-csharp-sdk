// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSasContainerWebDefenseRuleResponseBody : TeaModel {
        [NameInMap("ContainerWebDefenseRuleList")]
        [Validation(Required=false)]
        public List<ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleList> ContainerWebDefenseRuleList { get; set; }
        public class ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleList : TeaModel {
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            [NameInMap("ApptotalCount")]
            [Validation(Required=false)]
            public int? ApptotalCount { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("PathConfDTOList")]
            [Validation(Required=false)]
            public List<ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleListPathConfDTOList> PathConfDTOList { get; set; }
            public class ListSasContainerWebDefenseRuleResponseBodyContainerWebDefenseRuleListPathConfDTOList : TeaModel {
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

            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public int? RuleStatus { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListSasContainerWebDefenseRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListSasContainerWebDefenseRuleResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
