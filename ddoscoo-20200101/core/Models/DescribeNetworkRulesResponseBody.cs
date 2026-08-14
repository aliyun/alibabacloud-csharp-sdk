// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRulesResponseBody : TeaModel {
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public List<DescribeNetworkRulesResponseBodyNetworkRules> NetworkRules { get; set; }
        public class DescribeNetworkRulesResponseBodyNetworkRules : TeaModel {
            [NameInMap("BackendPort")]
            [Validation(Required=false)]
            public int? BackendPort { get; set; }

            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IpMode")]
            [Validation(Required=false)]
            public string IpMode { get; set; }

            [NameInMap("IsAutoCreate")]
            [Validation(Required=false)]
            public bool? IsAutoCreate { get; set; }

            [NameInMap("PayloadRuleEnable")]
            [Validation(Required=false)]
            public long? PayloadRuleEnable { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("ProxyEnable")]
            [Validation(Required=false)]
            public long? ProxyEnable { get; set; }

            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
