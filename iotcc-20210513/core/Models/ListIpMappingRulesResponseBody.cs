// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListIpMappingRulesResponseBody : TeaModel {
        [NameInMap("IpMappingRules")]
        [Validation(Required=false)]
        public List<ListIpMappingRulesResponseBodyIpMappingRules> IpMappingRules { get; set; }
        public class ListIpMappingRulesResponseBodyIpMappingRules : TeaModel {
            [NameInMap("DestinationIp")]
            [Validation(Required=false)]
            public string DestinationIp { get; set; }

            [NameInMap("IoTCloudConnectorId")]
            [Validation(Required=false)]
            public string IoTCloudConnectorId { get; set; }

            [NameInMap("IpMappingRuleDescription")]
            [Validation(Required=false)]
            public string IpMappingRuleDescription { get; set; }

            [NameInMap("IpMappingRuleId")]
            [Validation(Required=false)]
            public string IpMappingRuleId { get; set; }

            [NameInMap("IpMappingRuleName")]
            [Validation(Required=false)]
            public string IpMappingRuleName { get; set; }

            [NameInMap("IpMappingRuleStatus")]
            [Validation(Required=false)]
            public string IpMappingRuleStatus { get; set; }

            [NameInMap("MappingIp")]
            [Validation(Required=false)]
            public string MappingIp { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
