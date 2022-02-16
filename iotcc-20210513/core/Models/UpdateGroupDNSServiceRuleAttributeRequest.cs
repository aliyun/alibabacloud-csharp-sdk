// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class UpdateGroupDNSServiceRuleAttributeRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DNSServiceRuleDescription")]
        [Validation(Required=false)]
        public string DNSServiceRuleDescription { get; set; }

        [NameInMap("DNSServiceRuleId")]
        [Validation(Required=false)]
        public string DNSServiceRuleId { get; set; }

        [NameInMap("DNSServiceRuleName")]
        [Validation(Required=false)]
        public string DNSServiceRuleName { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("IoTCloudConnectorGroupId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorGroupId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
