// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-28T13:08Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The number of consecutive failures.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the health check configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monit*********</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// <para>The extended information. The parameters vary by protocol.</para>
        /// <list type="bullet">
        /// <item><description><para>For HTTP and HTTPS:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>host: The Host header.</para>
        /// </description></item>
        /// <item><description><para>path: The URL path.</para>
        /// </description></item>
        /// <item><description><para>code: The expected HTTP status code.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>sni: Specifies whether to enable Server Name Indication (SNI). This parameter is valid only when the protocol is set to HTTPS.</para>
        /// <list type="bullet">
        /// <item><description><para>true: enables SNI.</para>
        /// </description></item>
        /// <item><description><para>false: disables SNI.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the monitoring node for the health check when the address pool type is DOMAIN.</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For PING:</para>
        /// <list type="bullet">
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>packetNum: The number of ping packets.</para>
        /// </description></item>
        /// <item><description><para>packetLossRate: The packet loss rate.</para>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the monitoring node for the health check when the address pool type is DOMAIN.</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>For TCP:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>nodeType: The type of the monitoring node for the health check when the address pool type is DOMAIN.</para>
        /// <list type="bullet">
        /// <item><description><para>IPV4</para>
        /// </description></item>
        /// <item><description><para>IPV6</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;:200,\&quot;path\&quot;:\&quot;\\index.htm\&quot;,\&quot;host\&quot;:\&quot;aliyun.com\&quot;}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// <para>The health check protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP</para>
        /// </description></item>
        /// <item><description><para>HTTPS</para>
        /// </description></item>
        /// <item><description><para>PING</para>
        /// </description></item>
        /// <item><description><para>TCP</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

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
        /// <para>The timeout period. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The time when the configuration was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-03T08:57Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates when the configuration was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
