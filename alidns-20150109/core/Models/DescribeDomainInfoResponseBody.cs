// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the domain name was registered in Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AliDomain")]
        [Validation(Required=false)]
        public bool? AliDomain { get; set; }

        /// <summary>
        /// <para>The available time to live (TTL) values that can be configured for the domain name. Available TTL values are not returned by default. If you want to query such information, set NeedDetailAttributes to true.</para>
        /// </summary>
        [NameInMap("AvailableTtls")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyAvailableTtls AvailableTtls { get; set; }
        public class DescribeDomainInfoResponseBodyAvailableTtls : TeaModel {
            [NameInMap("AvailableTtl")]
            [Validation(Required=false)]
            public List<string> AvailableTtl { get; set; }

        }

        /// <summary>
        /// <para>The time when the domain name was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2015-12-12T09:23Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The DNS servers that are used to resolve the domain name.</para>
        /// </summary>
        [NameInMap("DnsServers")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyDnsServers DnsServers { get; set; }
        public class DescribeDomainInfoResponseBodyDnsServers : TeaModel {
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
        /// <para>Indicates whether the DNS traffic analysis feature is enabled. Valid values:</para>
        /// </summary>
        [NameInMap("DomainLoggingSwitchStatus")]
        [Validation(Required=false)]
        public string DomainLoggingSwitchStatus { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
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
        /// <para>Indicates whether blackhole filtering was triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InBlackHole")]
        [Validation(Required=false)]
        public bool? InBlackHole { get; set; }

        /// <summary>
        /// <para>Indicates whether traffic scrubbing was in progress.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InClean")]
        [Validation(Required=false)]
        public bool? InClean { get; set; }

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
        /// <para>The type of the DNS request line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>region_province</para>
        /// </summary>
        [NameInMap("LineType")]
        [Validation(Required=false)]
        public string LineType { get; set; }

        /// <summary>
        /// <para>The minimum TTL value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinTtl")]
        [Validation(Required=false)]
        public long? MinTtl { get; set; }

        /// <summary>
        /// <para>The Punycode for the domain name. This parameter is returned only for Chinese domain names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("PunyCode")]
        [Validation(Required=false)]
        public string PunyCode { get; set; }

        /// <summary>
        /// <para>The tree-structure DNS request lines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;default&quot;:{},&quot;unicom&quot;:{},&quot;telecom&quot;:{},&quot;mobile&quot;:{},&quot;edu&quot;:{},&quot;oversea&quot;:{},&quot;baidu&quot;:{},&quot;biying&quot;:{},&quot;google&quot;:{}}</para>
        /// </summary>
        [NameInMap("RecordLineTreeJson")]
        [Validation(Required=false)]
        public string RecordLineTreeJson { get; set; }

        /// <summary>
        /// <para>The DNS request lines.</para>
        /// </summary>
        [NameInMap("RecordLines")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyRecordLines RecordLines { get; set; }
        public class DescribeDomainInfoResponseBodyRecordLines : TeaModel {
            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public List<DescribeDomainInfoResponseBodyRecordLinesRecordLine> RecordLine { get; set; }
            public class DescribeDomainInfoResponseBodyRecordLinesRecordLine : TeaModel {
                /// <summary>
                /// <para>The code of the parent line. This parameter is not returned if the line has no parent line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>internal</para>
                /// </summary>
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                /// <summary>
                /// <para>The code of the line.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn_region_xibei</para>
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// <para>The name of the parent line.</para>
                /// </summary>
                [NameInMap("LineDisplayName")]
                [Validation(Required=false)]
                public string LineDisplayName { get; set; }

                /// <summary>
                /// <para>The name of the line.</para>
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the DNS request lines are regional lines.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RegionLines")]
        [Validation(Required=false)]
        public bool? RegionLines { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>536E9CAD-DB30-4647-AC87-AA5CC38C5382</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek3dj3wvclgcxo</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether secondary DNS is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SlaveDns")]
        [Validation(Required=false)]
        public bool? SlaveDns { get; set; }

        /// <summary>
        /// <para>Indicates whether the queried domain name is a hosted subdomain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public bool? SubDomain { get; set; }

        /// <summary>
        /// <para>The version ID of Alibaba Cloud DNS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>version1</para>
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
