// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyADConnectorOfficeSiteRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        [NameInMap("DomainPassword")]
        [Validation(Required=false)]
        public string DomainPassword { get; set; }

        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        [NameInMap("SubDomainName")]
        [Validation(Required=false)]
        public string SubDomainName { get; set; }

        [NameInMap("MfaEnabled")]
        [Validation(Required=false)]
        public bool? MfaEnabled { get; set; }

        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        [NameInMap("SubDomainDnsAddress")]
        [Validation(Required=false)]
        public List<string> SubDomainDnsAddress { get; set; }

    }

}
