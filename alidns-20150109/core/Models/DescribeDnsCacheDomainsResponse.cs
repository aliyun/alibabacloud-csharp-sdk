// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsCacheDomainsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long? TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public long? PageSize { get; set; }

        [NameInMap("Domains")]
        [Validation(Required=true)]
        public List<DescribeDnsCacheDomainsResponseDomains> Domains { get; set; }
        public class DescribeDnsCacheDomainsResponseDomains : TeaModel {
            [NameInMap("DomainId")]
            [Validation(Required=true)]
            public string DomainId { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("VersionCode")]
            [Validation(Required=true)]
            public string VersionCode { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=true)]
            public string Remark { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }

            [NameInMap("UpdateTimestamp")]
            [Validation(Required=true)]
            public long? UpdateTimestamp { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=true)]
            public long? CreateTimestamp { get; set; }

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

            [NameInMap("ExpireTime")]
            [Validation(Required=true)]
            public string ExpireTime { get; set; }

            [NameInMap("ExpireTimestamp")]
            [Validation(Required=true)]
            public long? ExpireTimestamp { get; set; }

            [NameInMap("SourceDnsServers")]
            [Validation(Required=true)]
            public List<DescribeDnsCacheDomainsResponseDomainsSourceDnsServers> SourceDnsServers { get; set; }
            public class DescribeDnsCacheDomainsResponseDomainsSourceDnsServers : TeaModel {
                [NameInMap("Host")]
                [Validation(Required=true)]
                public string Host { get; set; }

                [NameInMap("Port")]
                [Validation(Required=true)]
                public string Port { get; set; }

            }

        }

    }

}
