// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class UpdateDNSServiceRuleAttributeRequest : TeaModel {
        [NameInMap("AuthorizationRuleDescription")]
        [Validation(Required=false)]
        public string AuthorizationRuleDescription { get; set; }

        [NameInMap("AuthorizationRuleName")]
        [Validation(Required=false)]
        public string AuthorizationRuleName { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DNSServiceRuleId")]
        [Validation(Required=false)]
        public string DNSServiceRuleId { get; set; }

        [NameInMap("Destination")]
        [Validation(Required=false)]
        public string Destination { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("IoTCloudConnectorId")]
        [Validation(Required=false)]
        public string IoTCloudConnectorId { get; set; }

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
