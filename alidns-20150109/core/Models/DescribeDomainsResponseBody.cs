// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        /// <summary>
        /// The domain names.
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
                /// Indicates whether the domain name was registered in Alibaba Cloud.
                /// </summary>
                [NameInMap("AliDomain")]
                [Validation(Required=false)]
                public bool? AliDomain { get; set; }

                /// <summary>
                /// The time when the domain name was added.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the domain name was added. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The names of the DNS servers configured for the domain name.
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

                [NameInMap("DomainLoggingSwitchStatus")]
                [Validation(Required=false)]
                public string DomainLoggingSwitchStatus { get; set; }

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
                /// The time when the Alibaba Cloud DNS instance expires.
                /// </summary>
                [NameInMap("InstanceEndTime")]
                [Validation(Required=false)]
                public string InstanceEndTime { get; set; }

                /// <summary>
                /// Indicates whether the Alibaba Cloud DNS instance expires.
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
                /// The Punycode for the domain name. This parameter is returned only for Chinese domain names.
                /// </summary>
                [NameInMap("PunyCode")]
                [Validation(Required=false)]
                public string PunyCode { get; set; }

                /// <summary>
                /// The number of Domain Name System (DNS) records added for the domain name.
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
                /// The description of the domain name.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The ID of the resource group to which the domain name belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the domain name was added to favorites.
                /// </summary>
                [NameInMap("Starmark")]
                [Validation(Required=false)]
                public bool? Starmark { get; set; }

                /// <summary>
                /// The tags added to the resource.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDomainsResponseBodyDomainsDomainTags Tags { get; set; }
                public class DescribeDomainsResponseBodyDomainsDomainTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDomainsResponseBodyDomainsDomainTagsTag> Tag { get; set; }
                    public class DescribeDomainsResponseBodyDomainsDomainTagsTag : TeaModel {
                        /// <summary>
                        /// The key of the tag added to the resource.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag added to the resource.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The edition code of Alibaba Cloud DNS.
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                /// <summary>
                /// The edition of Alibaba Cloud DNS.
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
