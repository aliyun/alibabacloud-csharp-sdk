// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleHitRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("ruleSnapshotId")]
        [Validation(Required=false)]
        public string RuleSnapshotId { get; set; }

        [NameInMap("sRequestId")]
        [Validation(Required=false)]
        public string SRequestId { get; set; }

    }

}
