// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListRulesRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public string DbId { get; set; }

        [NameInMap("ForegroundType")]
        [Validation(Required=false)]
        public string ForegroundType { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        [NameInMap("RuleGroupId")]
        [Validation(Required=false)]
        public string RuleGroupId { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        [NameInMap("RuleQuote")]
        [Validation(Required=false)]
        public int? RuleQuote { get; set; }

        [NameInMap("RuleState")]
        [Validation(Required=false)]
        public int? RuleState { get; set; }

    }

}
