// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListDNSServiceRulesRequest : TeaModel {
        [NameInMap("DNSServiceRuleIds")]
        [Validation(Required=false)]
        public List<string> DNSServiceRuleIds { get; set; }

        [NameInMap("DNSServiceRuleName")]
        [Validation(Required=false)]
        public List<string> DNSServiceRuleName { get; set; }

        [NameInMap("DNSServiceRuleStatus")]
        [Validation(Required=false)]
        public List<string> DNSServiceRuleStatus { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public List<string> Destination { get; set; }

        [NameInMap("IoTCloudConnectorId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public List<string> Source { get; set; }

    }

}
