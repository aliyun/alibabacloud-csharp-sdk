// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebCcProtectSwitchResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ProtectSwitchList")]
        [Validation(Required=false)]
        public List<DescribeWebCcProtectSwitchResponseBodyProtectSwitchList> ProtectSwitchList { get; set; }
        public class DescribeWebCcProtectSwitchResponseBodyProtectSwitchList : TeaModel {
            [NameInMap("BlackWhiteListEnable")]
            [Validation(Required=false)]
            public int? BlackWhiteListEnable { get; set; }

            [NameInMap("AiTemplate")]
            [Validation(Required=false)]
            public string AiTemplate { get; set; }

            [NameInMap("PreciseRuleEnable")]
            [Validation(Required=false)]
            public int? PreciseRuleEnable { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("AiMode")]
            [Validation(Required=false)]
            public string AiMode { get; set; }

            [NameInMap("AiRuleEnable")]
            [Validation(Required=false)]
            public int? AiRuleEnable { get; set; }

            [NameInMap("RegionBlockEnable")]
            [Validation(Required=false)]
            public int? RegionBlockEnable { get; set; }

            [NameInMap("CcTemplate")]
            [Validation(Required=false)]
            public string CcTemplate { get; set; }

            [NameInMap("CcCustomRuleEnable")]
            [Validation(Required=false)]
            public int? CcCustomRuleEnable { get; set; }

            [NameInMap("CcEnable")]
            [Validation(Required=false)]
            public int? CcEnable { get; set; }

        }

    }

}
