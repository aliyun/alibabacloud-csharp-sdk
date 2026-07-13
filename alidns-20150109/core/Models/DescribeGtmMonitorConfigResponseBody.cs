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
        /// <para>The UNIX timestamp that indicates when the health check configuration was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The number of consecutive health checks.</para>
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

        [NameInMap("IspCityNodes")]
        [Validation(Required=false)]
        public DescribeGtmMonitorConfigResponseBodyIspCityNodes IspCityNodes { get; set; }
        public class DescribeGtmMonitorConfigResponseBodyIspCityNodes : TeaModel {
            [NameInMap("IspCityNode")]
            [Validation(Required=false)]
            public List<DescribeGtmMonitorConfigResponseBodyIspCityNodesIspCityNode> IspCityNode { get; set; }
            public class DescribeGtmMonitorConfigResponseBodyIspCityNodesIspCityNode : TeaModel {
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
        /// <para>1234abc</para>
        /// </summary>
        [NameInMap("MonitorConfigId")]
        [Validation(Required=false)]
        public string MonitorConfigId { get; set; }

        /// <summary>
        /// <para>The extended information. The parameters vary based on the protocol.</para>
        /// <para>For HTTP and HTTPS:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>code: The return code. A response is considered abnormal if its status code is greater than the specified value. Valid values: 400 and 500.</para>
        /// </description></item>
        /// <item><description><para>host: The Host header of the request.</para>
        /// </description></item>
        /// <item><description><para>path: The path of the URL.</para>
        /// </description></item>
        /// </list>
        /// <para>For PING:</para>
        /// <list type="bullet">
        /// <item><description><para>packetNum: The number of ping packets.</para>
        /// </description></item>
        /// <item><description><para>packetLossRate: The packet loss rate.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// </list>
        /// <para>For TCP:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
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
        /// <para>The protocol used for the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
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
        /// <para>The timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.</para>
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
        /// <para>The UNIX timestamp that indicates when the health check configuration was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1527690629357</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
