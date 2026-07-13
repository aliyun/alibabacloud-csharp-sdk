// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the domain name was registered with Alibaba Cloud.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AliDomain")]
        [Validation(Required=false)]
        public bool? AliDomain { get; set; }

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
        /// <para>00efd71a-7************</para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The status of the logging feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CLOSE：关闭状态
        /// OPEN：开启状态</para>
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
        /// <para>2***</para>
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
        /// <para>Indicates whether blackhole filtering is activated for the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("InBlackHole")]
        [Validation(Required=false)]
        public bool? InBlackHole { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name is being scrubbed.</para>
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
        /// <para>i-7**</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of the DNS request source line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>region_province</para>
        /// </summary>
        [NameInMap("LineType")]
        [Validation(Required=false)]
        public string LineType { get; set; }

        /// <summary>
        /// <para>The minimum TTL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinTtl")]
        [Validation(Required=false)]
        public long? MinTtl { get; set; }

        /// <summary>
        /// <para>The Punycode for the Chinese domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("PunyCode")]
        [Validation(Required=false)]
        public string PunyCode { get; set; }

        /// <summary>
        /// <para>The list of DNS request source lines in a tree structure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;default&quot;:{},&quot;unicom&quot;:{},&quot;telecom&quot;:{},&quot;mobile&quot;:{},&quot;edu&quot;:{},&quot;oversea&quot;:{},&quot;baidu&quot;:{},&quot;biying&quot;:{},&quot;google&quot;:{}}</para>
        /// </summary>
        [NameInMap("RecordLineTreeJson")]
        [Validation(Required=false)]
        public string RecordLineTreeJson { get; set; }

        [NameInMap("RecordLines")]
        [Validation(Required=false)]
        public DescribeDomainInfoResponseBodyRecordLines RecordLines { get; set; }
        public class DescribeDomainInfoResponseBodyRecordLines : TeaModel {
            [NameInMap("RecordLine")]
            [Validation(Required=false)]
            public List<DescribeDomainInfoResponseBodyRecordLinesRecordLine> RecordLine { get; set; }
            public class DescribeDomainInfoResponseBodyRecordLinesRecordLine : TeaModel {
                [NameInMap("FatherCode")]
                [Validation(Required=false)]
                public string FatherCode { get; set; }

                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                [NameInMap("LineDisplayName")]
                [Validation(Required=false)]
                public string LineDisplayName { get; set; }

                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the line is a regional line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RegionLines")]
        [Validation(Required=false)]
        public bool? RegionLines { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
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
        /// <para>rg-aek3dj3******</para>
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
        /// <para>Indicates whether the queried domain is a hosted subdomain. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public bool? SubDomain { get; set; }

        /// <summary>
        /// <para>The edition ID of Alibaba Cloud DNS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>version_enterprise_advanced: Ultimate Edition</para>
        /// </description></item>
        /// <item><description><para>version_personal: Personal Edition</para>
        /// </description></item>
        /// <item><description><para>mianfei: Free Edition</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mianfei</para>
        /// </summary>
        [NameInMap("VersionCode")]
        [Validation(Required=false)]
        public string VersionCode { get; set; }

        /// <summary>
        /// <para>The name of the Alibaba Cloud DNS edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业旗舰版</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
