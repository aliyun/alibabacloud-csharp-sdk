// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeRuleSnapshotRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("ruleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("snapshotVersion")]
        [Validation(Required=false)]
        public string SnapshotVersion { get; set; }

    }

}
