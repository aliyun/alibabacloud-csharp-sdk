// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The domain names.</para>
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
                /// <para>Indicates whether the domain name was registered with Alibaba Cloud.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AliDomain")]
                [Validation(Required=false)]
                public bool? AliDomain { get; set; }

                /// <summary>
                /// <para>The time when the domain name was added. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-01-30T05:25Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the domain name was added. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1660546144000</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The names of the DNS servers configured for the domain name assigned by Alibaba Cloud DNS.</para>
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
                /// <para>The ID of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00efd71a-770e-4255-b54e-6fe5659baffe</para>
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public string DomainId { get; set; }

                /// <summary>
                /// <para>Indicates whether the DNS traffic analysis feature is enabled for the domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OPEN</description></item>
                /// <item><description>CLOSE</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OPEN</para>
                /// </summary>
                [NameInMap("DomainLoggingSwitchStatus")]
                [Validation(Required=false)]
                public string DomainLoggingSwitchStatus { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The ID of the domain name group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2223</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the domain name group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mygroup</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The time when the Alibaba Cloud DNS instance expires. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-03-14T16:00Z</para>
                /// </summary>
                [NameInMap("InstanceEndTime")]
                [Validation(Required=false)]
                public string InstanceEndTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the Alibaba Cloud DNS instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InstanceExpired")]
                [Validation(Required=false)]
                public bool? InstanceExpired { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud DNS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-7bg</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The Punycode for the domain name. This parameter is returned only for Chinese domain names.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc.com</para>
                /// </summary>
                [NameInMap("PunyCode")]
                [Validation(Required=false)]
                public string PunyCode { get; set; }

                /// <summary>
                /// <para>The number of Domain Name System (DNS) records added for the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                /// <summary>
                /// <para>The email address of the registrant.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@example.com">test@example.com</a></para>
                /// </summary>
                [NameInMap("RegistrantEmail")]
                [Validation(Required=false)]
                public string RegistrantEmail { get; set; }

                /// <summary>
                /// <para>The description of the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>remark</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the domain name belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acf</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the domain name was added to favorites.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Starmark")]
                [Validation(Required=false)]
                public bool? Starmark { get; set; }

                /// <summary>
                /// <para>The tags added to the resource.</para>
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
                        /// <para>The key of tag N added to the resource.</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of tag N added to the resource.</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The edition code of Alibaba Cloud DNS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>version_enterprise_basic</para>
                /// </summary>
                [NameInMap("VersionCode")]
                [Validation(Required=false)]
                public string VersionCode { get; set; }

                /// <summary>
                /// <para>The edition of Alibaba Cloud DNS.</para>
                /// </summary>
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
