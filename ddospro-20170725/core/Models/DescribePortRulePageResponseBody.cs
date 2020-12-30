// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DDoSPro20170725.Models
{
    public class DescribePortRulePageResponseBody : TeaModel {
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<DescribePortRulePageResponseBodyRuleList> RuleList { get; set; }
        public class DescribePortRulePageResponseBodyRuleList : TeaModel {
            [NameInMap("BackProtocol")]
            [Validation(Required=false)]
            public string BackProtocol { get; set; }

            [NameInMap("BackPort")]
            [Validation(Required=false)]
            public int? BackPort { get; set; }

            [NameInMap("LbId")]
            [Validation(Required=false)]
            public string LbId { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("LvsType")]
            [Validation(Required=false)]
            public string LvsType { get; set; }

            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

            [NameInMap("FrontPort")]
            [Validation(Required=false)]
            public int? FrontPort { get; set; }

            [NameInMap("FrontProtocol")]
            [Validation(Required=false)]
            public string FrontProtocol { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

    }

}
