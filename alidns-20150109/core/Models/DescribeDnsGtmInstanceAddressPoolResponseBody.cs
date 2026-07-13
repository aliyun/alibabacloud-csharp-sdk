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
        /// <para>test*****</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public DescribeDnsGtmInstanceAddressPoolResponseBodyAddrs Addrs { get; set; }
        public class DescribeDnsGtmInstanceAddressPoolResponseBodyAddrs : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmInstanceAddressPoolResponseBodyAddrsAddr> Addr { get; set; }
            public class DescribeDnsGtmInstanceAddressPoolResponseBodyAddrsAddr : TeaModel {
                [NameInMap("Addr")]
                [Validation(Required=false)]
                public string Addr { get; set; }

                [NameInMap("AlertStatus")]
                [Validation(Required=false)]
                public string AlertStatus { get; set; }

                [NameInMap("AttributeInfo")]
                [Validation(Required=false)]
                public string AttributeInfo { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("LbaWeight")]
                [Validation(Required=false)]
                public int? LbaWeight { get; set; }

                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

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
        /// <para>The time when the address pool was created. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The load balancing policy.</para>
        /// <list type="bullet">
        /// <item><description><para>ALL_RR: Returns all addresses.</para>
        /// </description></item>
        /// <item><description><para>RATIO: Returns addresses by weight.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL_RR</para>
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
        /// <para>The health check status of the address pool.</para>
        /// <list type="bullet">
        /// <item><description><para>OPEN: Enabled</para>
        /// </description></item>
        /// <item><description><para>CLOSE: Disabled</para>
        /// </description></item>
        /// <item><description><para>UNCONFIGURED: Not configured</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN</para>
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
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6856BCF6-11D6-4D7E-AC53-FD579933522B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The type of the address pool.</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4: IPv4 address</para>
        /// </description></item>
        /// <item><description><para>IPV6: IPv6 address</para>
        /// </description></item>
        /// <item><description><para>DOMAIN: Domain name</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPV4</para>
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
        /// <para>The time when the address pool was last updated. This value is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
