// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmMonitorConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the health check configuration was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-28T13:08Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the health check configuration was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
        /// <para>1</para>
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

        /// <summary>
        /// <para>The health check nodes.</para>
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeDnsGtmMonitorConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeDnsGtmMonitorConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmMonitorConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeDnsGtmMonitorConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>572</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The display name of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Qingdao</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The code of the country or region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>001</para>
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <para>The display name of the country or region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <para>The Internet service provider (ISP) code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>The display name of the ISP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alibaba</para>
                /// </summary>
                [NameInMap("IspName")]
                [Validation(Required=false)]
                public string IspName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the health check configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MonitorConfigId1</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// <para>The extended information. The required parameters vary based on the value of ProtocolType.</para>
        /// <list type="bullet">
        /// <item><description><para>HTTP or HTTPS</para>
        /// <list type="bullet">
        /// <item><description><para>port: the port that you want to check</para>
        /// </description></item>
        /// <item><description><para>host: the host settings</para>
        /// </description></item>
        /// <item><description><para>path: the URL path</para>
        /// </description></item>
        /// <item><description><para>code: the response code. The health check result is deemed abnormal if the returned value is greater than the specified value.</para>
        /// </description></item>
        /// <item><description><para>failureRate: the failure rate</para>
        /// </description></item>
        /// <item><description><para>sni: specifies whether to enable server name indication (SNI). This parameter is available only when ProtocolType is set to HTTPS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables SNI.</description></item>
        /// <item><description>false: disables SNI.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>nodeType: the type of the node for monitoring when the address pool type is domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>PING:</para>
        /// <list type="bullet">
        /// <item><description><para>failureRate: the failure rate</para>
        /// </description></item>
        /// <item><description><para>packetNum: the number of ping packets</para>
        /// </description></item>
        /// <item><description><para>packetLossRate: the loss rate of ping packets</para>
        /// </description></item>
        /// <item><description><para>nodeType: the type of the node for monitoring when the address pool type is domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>TCP</para>
        /// <list type="bullet">
        /// <item><description><para>port: the port that you want to check</para>
        /// </description></item>
        /// <item><description><para>failureRate: the failure rate</para>
        /// </description></item>
        /// <item><description><para>nodeType: the type of the node for monitoring when the address pool type is domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>IPV4</description></item>
        /// <item><description>IPV6</description></item>
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
        /// <item><description>HTTP</description></item>
        /// <item><description>HTTPS</description></item>
        /// <item><description>PING</description></item>
        /// <item><description>TCP</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
        /// <para>The time when the health check configuration was updated. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-01-03T08:57Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The time when the health check configuration was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
