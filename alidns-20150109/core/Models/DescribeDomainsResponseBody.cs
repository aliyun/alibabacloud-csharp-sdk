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
                [NameInMap("AliDomain")]
                [Validation(Required=false)]
                public bool? AliDomain { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("DnsServers")]
                [Validation(Required=false)]
                public DescribeDomainsResponseBodyDomainsDomainDnsServers DnsServers { get; set; }
                public class DescribeDomainsResponseBodyDomainsDomainDnsServers : TeaModel {
                    [NameInMap("DnsServer")]
                    [Validation(Required=false)]
                    public List<string> DnsServer { get; set; }

                }

                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                [NameInMap("DomainLoggingSwitchStatus")]
                [Validation(Required=false)]
                public string DomainLoggingSwitchStatus { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                [NameInMap("InstanceEndTime")]
                [Validation(Required=false)]
                public string InstanceEndTime { get; set; }

                [NameInMap("InstanceExpired")]
                [Validation(Required=false)]
                public bool? InstanceExpired { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("PunyCode")]
                [Validation(Required=false)]
                public string PunyCode { get; set; }

                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                [NameInMap("RegistrantEmail")]
                [Validation(Required=false)]
                public string RegistrantEmail { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SlaveDnsStatus")]
                [Validation(Required=false)]
                public string SlaveDnsStatus { get; set; }

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

                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68386699-8B9E-4D5B-BC4C-75A28F6C2A00</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
