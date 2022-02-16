// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListGroupDNSServiceRulesResponseBody : TeaModel {
        [NameInMap("DNSServiceRules")]
        [Validation(Required=false)]
        public List<ListGroupDNSServiceRulesResponseBodyDNSServiceRules> DNSServiceRules { get; set; }
        public class ListGroupDNSServiceRulesResponseBodyDNSServiceRules : TeaModel {
            [NameInMap("DNSServiceRuleDescription")]
            [Validation(Required=false)]
            public string DNSServiceRuleDescription { get; set; }

            [NameInMap("DNSServiceRuleId")]
            [Validation(Required=false)]
            public string DNSServiceRuleId { get; set; }

            [NameInMap("DNSServiceRuleName")]
            [Validation(Required=false)]
            public string DNSServiceRuleName { get; set; }

            [NameInMap("DNSServiceRuleStatus")]
            [Validation(Required=false)]
            public string DNSServiceRuleStatus { get; set; }

            [NameInMap("Destination")]
            [Validation(Required=false)]
            public string Destination { get; set; }

            [NameInMap("IoTCloudConnectorGroupId")]
            [Validation(Required=false)]
            public string IoTCloudConnectorGroupId { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public string ServiceType { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

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
