// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyADConnectorDirectoryRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=true)]
        public string DirectoryId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainUserName")]
        [Validation(Required=false)]
        public string DomainUserName { get; set; }

        [NameInMap("DomainPassword")]
        [Validation(Required=false)]
        public string DomainPassword { get; set; }

        [NameInMap("DnsAddress")]
        [Validation(Required=false)]
        public List<string> DnsAddress { get; set; }

        [NameInMap("DirectoryName")]
        [Validation(Required=false)]
        public string DirectoryName { get; set; }

        [NameInMap("SubDomainDnsAddress")]
        [Validation(Required=false)]
        public List<string> SubDomainDnsAddress { get; set; }

        [NameInMap("SubDomainName")]
        [Validation(Required=false)]
        public string SubDomainName { get; set; }

        [NameInMap("MfaEnabled")]
        [Validation(Required=false)]
        public bool? MfaEnabled { get; set; }

    }

}
