// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeDomainsResponseBodyDomains : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<DescribeDomainsResponseBodyDomainsDomain> Domain { get; set; }
            public class DescribeDomainsResponseBodyDomainsDomain : TeaModel {
                public string Remark { get; set; }
                public string CreateTime { get; set; }
                public long? RecordCount { get; set; }
                public DescribeDomainsResponseBodyDomainsDomainTags Tags { get; set; }
                public class DescribeDomainsResponseBodyDomainsDomainTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDomainsResponseBodyDomainsDomainTagsTag> Tag { get; set; }
                    public class DescribeDomainsResponseBodyDomainsDomainTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string InstanceId { get; set; }
                public string DomainName { get; set; }
                public string DomainId { get; set; }
                public bool? AliDomain { get; set; }
                public string GroupId { get; set; }
                public string GroupName { get; set; }
                public string ResourceGroupId { get; set; }
                public string InstanceEndTime { get; set; }
                public bool? InstanceExpired { get; set; }
                public string VersionName { get; set; }
                public DescribeDomainsResponseBodyDomainsDomainDnsServers DnsServers { get; set; }
                public class DescribeDomainsResponseBodyDomainsDomainDnsServers : TeaModel {
                    [NameInMap("DnsServer")]
                    [Validation(Required=false)]
                    public List<string> DnsServer { get; set; }

                }
                public string VersionCode { get; set; }
                public string PunyCode { get; set; }
                public string RegistrantEmail { get; set; }
                public long? CreateTimestamp { get; set; }
                public bool? Starmark { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
