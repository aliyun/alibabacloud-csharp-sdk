// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateDnsCacheDomainRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("UserClientIp")]
        [Validation(Required=false)]
        public string UserClientIp { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("CacheTtlMin")]
        [Validation(Required=false)]
        public int? CacheTtlMin { get; set; }

        [NameInMap("CacheTtlMax")]
        [Validation(Required=false)]
        public int? CacheTtlMax { get; set; }

        [NameInMap("SourceProtocol")]
        [Validation(Required=false)]
        public string SourceProtocol { get; set; }

        [NameInMap("SourceEdns")]
        [Validation(Required=false)]
        public string SourceEdns { get; set; }

        [NameInMap("SourceDnsServer")]
        [Validation(Required=false)]
        public List<UpdateDnsCacheDomainRequestSourceDnsServer> SourceDnsServer { get; set; }
        public class UpdateDnsCacheDomainRequestSourceDnsServer : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

        }

    }

}
