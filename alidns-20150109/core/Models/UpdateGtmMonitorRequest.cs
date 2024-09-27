// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmMonitorRequest : TeaModel {
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
        /// <para>The health check interval. Unit: seconds. Set the value to 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The monitored nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<UpdateGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class UpdateGtmMonitorRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The code of the city where the monitored node is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>572</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <list type="bullet">
            /// <item><description>The code of the Internet service provider (ISP) to which the monitored node belongs. For more information about specific values, see the response parameters of DescribeGtmMonitorAvailableConfig.</description></item>
            /// <item><description>If the value of the GroupType parameter is BGP or OVERSEAS, IspCode is optional. The default value is 465.</description></item>
            /// <item><description>If the value of the GroupType parameter is not BGP or OVERSEAS, IspCode is required and is used together with CityCode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>465</para>
            /// </summary>
            [NameInMap("IspCode")]
            [Validation(Required=false)]
            public string IspCode { get; set; }

        }

        /// <summary>
        /// <para>The language of the values of specific response parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the health check configuration.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;:200,\&quot;path\&quot;:\&quot;\\index.htm\&quot;,\&quot;host\&quot;:\&quot;aliyun.com\&quot;}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// <para>The protocol used for the health check.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The health check timeout period. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
