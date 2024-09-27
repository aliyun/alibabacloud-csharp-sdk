// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmInstanceAddressPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of addresses in the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AddrCount")]
        [Validation(Required=false)]
        public int? AddrCount { get; set; }

        /// <summary>
        /// <para>The ID of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpool1</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The addresses in the address pool.</para>
        /// </summary>
        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceAddressPoolResponseBodyAddrs Addrs { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolResponseBodyAddrs : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmInstanceAddressPoolResponseBodyAddrsAddr> Addr { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolResponseBodyAddrsAddr : TeaModel {
                /// <summary>
                /// <para>The address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public string Addr { get; set; }

                /// <summary>
                /// <para>The status of the last health check on the address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OK: No active alerts are triggered.</description></item>
                /// <item><description>ALERT: Alerts are triggered based on the alert rules.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("AlertStatus")]
                [Validation(Required=false)]
                public string AlertStatus { get; set; }

                /// <summary>
                /// <para>The source region of the address.</para>
                /// <list type="bullet">
                /// <item><description>lineCode: the line code of the source region of the address. This parameter is deprecated, and lineCodes prevails.</description></item>
                /// <item><description>lineName: the line name of the source region of the address. This parameter is deprecated.</description></item>
                /// <item><description>lineCodes: the line codes of the source regions of the address.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;lineCode&quot;:&quot;aliyun_r_cn-zhangjiakou&quot;, &quot;lineName&quot;: &quot;Alibaba Cloud_China (Zhangjiakou)&quot;, &quot;lineCodes&quot;: [&quot;aliyun_r_cn-zhangjiakou&quot;]</para>
                /// </summary>
                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public string AttributeInfo { get; set; }

                /// <summary>
                /// <para>The time when the address was added into the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-28T13:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates the time when the address was added into the address pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The weight of the address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LbaWeight")]
                [Validation(Required=false)]
                public int? LbaWeight { get; set; }

                /// <summary>
                /// <para>The mode of the address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SMART: smart return</description></item>
                /// <item><description>ONLINE: always online</description></item>
                /// <item><description>OFFLINE: always offline</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The description of the address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// <para>The time when the address was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-28T13:08Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>The timestamp that indicates the time when the address was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

        }

        /// <summary>
        /// <para>The time when the address pool was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-28T13:08Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the time when the address pool was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The load balancing policy for the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL_RR: returns all addresses.</description></item>
        /// <item><description>RATIO: returns addresses by weight.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all_rr</para>
        /// </summary>
        [NameInMap("LbaStrategy")]
        [Validation(Required=false)]
        public string LbaStrategy { get; set; }

        /// <summary>
        /// <para>The ID of the health check configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// <para>Indicates the status of the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OPEN: The health check is enabled.</description></item>
        /// <item><description>CLOSE: The health check is disabled.</description></item>
        /// <item><description>UNCONFIGURED: The health check is not configured.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("MonitorStatus")]
        [Validation(Required=false)]
        public string MonitorStatus { get; set; }

        /// <summary>
        /// <para>The name of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4: IPv4 address</description></item>
        /// <item><description>IPV6: IPv6 address</description></item>
        /// <item><description>DOMAIN: domain name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The time when the address pool was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-28T13:08Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the time when the address pool was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
