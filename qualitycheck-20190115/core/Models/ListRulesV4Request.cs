// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ListRulesV4Request : TeaModel {
        [NameInMap("BusinessName")]
        [Validation(Required=false)]
        public string BusinessName { get; set; }

        [NameInMap("BusinessRange")]
        [Validation(Required=false)]
        public int? BusinessRange { get; set; }

        [NameInMap("CategoryName")]
        [Validation(Required=false)]
        public string CategoryName { get; set; }

        [NameInMap("CountTotal")]
        [Validation(Required=false)]
        public bool? CountTotal { get; set; }

        [NameInMap("CreateEmpid")]
        [Validation(Required=false)]
        public string CreateEmpid { get; set; }

        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public long? CreateUserId { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("LastUpdateEmpid")]
        [Validation(Required=false)]
        public string LastUpdateEmpid { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequireInfos")]
        [Validation(Required=false)]
        public List<string> RequireInfos { get; set; }

        [NameInMap("Rid")]
        [Validation(Required=false)]
        public long? Rid { get; set; }

        [NameInMap("RuleIdOrRuleName")]
        [Validation(Required=false)]
        public string RuleIdOrRuleName { get; set; }

        [NameInMap("RuleScoreSingleType")]
        [Validation(Required=false)]
        public int? RuleScoreSingleType { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        [NameInMap("SchemeId")]
        [Validation(Required=false)]
        public long? SchemeId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public int? SourceType { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        [NameInMap("UpdateEndTime")]
        [Validation(Required=false)]
        public string UpdateEndTime { get; set; }

        [NameInMap("UpdateStartTime")]
        [Validation(Required=false)]
        public string UpdateStartTime { get; set; }

        [NameInMap("UpdateUserId")]
        [Validation(Required=false)]
        public long? UpdateUserId { get; set; }

    }

}
