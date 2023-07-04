// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeDefaultIPSConfigResponseBody : TeaModel {
        [NameInMap("AiRules")]
        [Validation(Required=false)]
        public int? AiRules { get; set; }

        [NameInMap("BasicRules")]
        [Validation(Required=false)]
        public int? BasicRules { get; set; }

        [NameInMap("CtiRules")]
        [Validation(Required=false)]
        public int? CtiRules { get; set; }

        [NameInMap("EnableAllPatch")]
        [Validation(Required=false)]
        public int? EnableAllPatch { get; set; }

        [NameInMap("EnableDefault")]
        [Validation(Required=false)]
        public int? EnableDefault { get; set; }

        [NameInMap("PatchRules")]
        [Validation(Required=false)]
        public int? PatchRules { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RuleClass")]
        [Validation(Required=false)]
        public int? RuleClass { get; set; }

        [NameInMap("RunMode")]
        [Validation(Required=false)]
        public int? RunMode { get; set; }

    }

}
