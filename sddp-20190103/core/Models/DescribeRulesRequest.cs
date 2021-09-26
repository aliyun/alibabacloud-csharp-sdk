// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeRulesRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("CustomType")]
        [Validation(Required=false)]
        public int? CustomType { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public int? Category { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public int? ProductCode { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("WarnLevel")]
        [Validation(Required=false)]
        public int? WarnLevel { get; set; }

        [NameInMap("ContentCategory")]
        [Validation(Required=false)]
        public int? ContentCategory { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("KeywordCompatible")]
        [Validation(Required=false)]
        public bool? KeywordCompatible { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

    }

}
