// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddDnsCacheDomainRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("CacheTtlMin")]
        [Validation(Required=true)]
        public int? CacheTtlMin { get; set; }

        [NameInMap("CacheTtlMax")]
        [Validation(Required=true)]
        public int? CacheTtlMax { get; set; }

        [NameInMap("SourceProtocol")]
        [Validation(Required=true)]
        public string SourceProtocol { get; set; }

        [NameInMap("SourceEdns")]
        [Validation(Required=true)]
        public string SourceEdns { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("SourceDnsServer")]
        [Validation(Required=true)]
        public List<AddDnsCacheDomainRequestSourceDnsServer> SourceDnsServer { get; set; }
        public class AddDnsCacheDomainRequestSourceDnsServer : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=true)]
            public string Host { get; set; }

            [NameInMap("Port")]
            [Validation(Required=true)]
            public string Port { get; set; }

        }

    }

}
