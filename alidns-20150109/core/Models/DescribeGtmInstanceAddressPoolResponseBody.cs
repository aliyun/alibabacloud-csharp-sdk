// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmInstanceAddressPoolResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of addresses in the address pool queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AddrCount")]
        [Validation(Required=false)]
        public int? AddrCount { get; set; }

        /// <summary>
        /// <para>The ID of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234abc</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The addresses in the address pool.</para>
        /// </summary>
        [NameInMap("Addrs")]
        [Validation(Required=false)]
        public DescribeGtmInstanceAddressPoolResponseBodyAddrs Addrs { get; set; }
        public class DescribeGtmInstanceAddressPoolResponseBodyAddrs : TeaModel {
            [NameInMap("Addr")]
            [Validation(Required=false)]
            public List<DescribeGtmInstanceAddressPoolResponseBodyAddrsAddr> Addr { get; set; }
            public class DescribeGtmInstanceAddressPoolResponseBodyAddrsAddr : TeaModel {
                /// <summary>
                /// <para>The ID of the address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("AddrId")]
                [Validation(Required=false)]
                public long? AddrId { get; set; }

                /// <summary>
                /// <para>Indicates whether health check was enabled for the address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b>: Normal</description></item>
                /// <item><description><b>ALERT</b>: Alert</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("AlertStatus")]
                [Validation(Required=false)]
                public string AlertStatus { get; set; }

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
                /// <item><description><b>SMART</b>: Intelligent return</description></item>
                /// <item><description><b>ONLINE</b>: Always online</description></item>
                /// <item><description><b>OFFLINE</b>: Always offline</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SMART</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The last time when the address was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-28T13:08Z</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

                /// <summary>
                /// <para>A timestamp that indicates the last time when the address was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1527690629357</para>
                /// </summary>
                [NameInMap("UpdateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

                /// <summary>
                /// <para>The address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.1.1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

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
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The minimum number of available addresses in the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? MinAvailableAddrNum { get; set; }

        /// <summary>
        /// <para>The health check ID of the address pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100abc</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// <para>Indicates whether health check was enabled for the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>OPEN</b>: Enabled</description></item>
        /// <item><description><b>CLOSE</b>: Disabled</description></item>
        /// <item><description><b>UNCONFIGURED</b>: Not configured</description></item>
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
        /// <para>The availability status of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AVAILABLE</b>: Available</description></item>
        /// <item><description><b>NOT_AVAILABLE</b>: Unavailable</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVAILABLE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the address pool. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IP</b>: IP address</description></item>
        /// <item><description><b>DOMAIN</b>: Domain name</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IP</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The last time when the address pool was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-28T13:08Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>A timestamp that indicates the last time the address pool was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
