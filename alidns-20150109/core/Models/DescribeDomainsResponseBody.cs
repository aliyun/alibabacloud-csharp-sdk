// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        /// <summary>
        /// The list of domain names queried by this operation.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeDomainsResponseBodyDomains : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public List<DescribeDomainsResponseBodyDomainsDomain> Domain { get; set; }
            public class DescribeDomainsResponseBodyDomainsDomain : TeaModel {
                /// <summary>
                /// Indicates whether the domain name is an Alibaba Cloud HiChina domain name.
                /// </summary>
                [NameInMap("AliDomain")]
                [Validation(Required=false)]
                public bool? AliDomain { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The list of DNS servers of the domain name in the DNS system.
                /// </summary>
                [NameInMap("DnsServers")]
                [Validation(Required=false)]
                public DescribeDomainsResponseBodyDomainsDomainDnsServers DnsServers { get; set; }
                public class DescribeDomainsResponseBodyDomainsDomainDnsServers : TeaModel {
                    [NameInMap("DnsServer")]
                    [Validation(Required=false)]
                    public List<string> DnsServer { get; set; }

                }

                /// <summary>
                /// The ID of the domain name.
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The ID of the domain name group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the domain name group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The expiration time of the instance.
                /// </summary>
                [NameInMap("InstanceEndTime")]
                [Validation(Required=false)]
                public string InstanceEndTime { get; set; }

                /// <summary>
                /// Indicates whether the instance expired.
                /// </summary>
                [NameInMap("InstanceExpired")]
                [Validation(Required=false)]
                public bool? InstanceExpired { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud DNS instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The punycode is returned for Chinese domain names and is left blank for English domain names.
                /// </summary>
                [NameInMap("PunyCode")]
                [Validation(Required=false)]
                public string PunyCode { get; set; }

                /// <summary>
                /// The number of DNS records of the domain name.
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                /// <summary>
                /// The email address of the registrant.
                /// </summary>
                [NameInMap("RegistrantEmail")]
                [Validation(Required=false)]
                public string RegistrantEmail { get; set; }

                /// <summary>
                /// The description.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether to query the starmark of the domain name.
                /// </summary>
                [NameInMap("Starmark")]
                [Validation(Required=false)]
                public bool? Starmark { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                /// <summary>
                /// The version code of the Alibaba Cloud DNS instance.
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                /// <summary>
                /// The version name of the Alibaba Cloud DNS instance.
                /// </summary>
                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of domain names.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
