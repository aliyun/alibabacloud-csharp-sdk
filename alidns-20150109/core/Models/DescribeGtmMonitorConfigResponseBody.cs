// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmMonitorConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the health check configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-28T13:08Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the time when the health check configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The maximum number of consecutive exceptions detected. If the number of consecutive exceptions detected reaches the maximum number, the application service is deemed abnormal.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: seconds. The value is 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The monitored nodes.</para>
        /// </summary>
        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeGtmMonitorConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeGtmMonitorConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeGtmMonitorConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeGtmMonitorConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
                /// <summary>
                /// <para>The code of the city where the monitored node is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>503</para>
                /// </summary>
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The display name of the city where the monitored node is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhangjiakou</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The code of the country where the monitored node is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>001</para>
                /// </summary>
                [NameInMap("CountryCode")]
                [Validation(Required=false)]
                public string CountryCode { get; set; }

                /// <summary>
                /// <para>The display name of the country where the monitored node is deployed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

                /// <summary>
                /// <para>The code of the Internet service provider (ISP) to which the monitored node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>465</para>
                /// </summary>
                [NameInMap("IspCode")]
                [Validation(Required=false)]
                public string IspCode { get; set; }

                /// <summary>
                /// <para>The display name of the ISP to which the monitored node belongs.</para>
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
        /// <para>1234abc</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// <para>The extended information, that is, the parameters required for the protocol. Different protocols require different parameters:</para>
        /// <para>HTTP or HTTPS:</para>
        /// <list type="bullet">
        /// <item><description>port: the port to check.</description></item>
        /// <item><description>failureRate: the failure rate.</description></item>
        /// <item><description>code: the status code threshold. If the returned status code is greater than the specified threshold, the application service is deemed abnormal. Valid values: 400 and 500.</description></item>
        /// <item><description>host: the host configuration.</description></item>
        /// <item><description>path: the health check URL.</description></item>
        /// </list>
        /// <para>PING:</para>
        /// <list type="bullet">
        /// <item><description>packetNum: the number of ping packets.</description></item>
        /// <item><description>packetLossRate: the loss rate of ping packets.</description></item>
        /// <item><description>failureRate: the failure rate.</description></item>
        /// </list>
        /// <para>TCP:</para>
        /// <list type="bullet">
        /// <item><description>port: the port to check.</description></item>
        /// <item><description>failureRate: the failure rate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;:200,\&quot;path\&quot;:\&quot;\\index.htm\&quot;,\&quot;host\&quot;:\&quot;aliyun.com\&quot;}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// <para>The protocol used for the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

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
        /// <para>The health check timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The time when the health check configuration was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-28T13:08Z</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the time when the health check configuration was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
