// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class UpdateGtmMonitorRequest : TeaModel {
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
        /// <para>The interval between health checks. Unit: seconds. The value must be 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The list of monitoring nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<UpdateGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class UpdateGtmMonitorRequestIspCityNode : TeaModel {
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
            /// <list type="bullet">
            /// <item><description><para>For more information about the valid values, see the response of the DescribeGtmMonitorAvailableConfig operation.</para>
            /// </description></item>
            /// <item><description><para>If GroupType is set to Border Gateway Protocol (BGP) or Overseas, IspCityNode.N.IspCode is optional. The default value is 465.</para>
            /// </description></item>
            /// <item><description><para>If GroupType is not set to BGP or Overseas, IspCityNode.N.IspCode is required. You must specify a value that matches the value of IspCityNode.N.CityCode.</para>
            /// </description></item>
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
        /// <para>The language of the response.</para>
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
        /// <para>The extended information. The parameters vary based on the protocol.</para>
        /// <para>HTTP and HTTPS:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// <item><description><para>code: The return code. A response with a status code greater than the specified value is considered abnormal. Valid values: 400 and 500.</para>
        /// </description></item>
        /// <item><description><para>host: The host settings.</para>
        /// </description></item>
        /// <item><description><para>path: The URL path.</para>
        /// </description></item>
        /// </list>
        /// <para>PING:</para>
        /// <list type="bullet">
        /// <item><description><para>packetNum: The number of ping packets.</para>
        /// </description></item>
        /// <item><description><para>packetLossRate: The packet loss rate.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
        /// </list>
        /// <para>TCP:</para>
        /// <list type="bullet">
        /// <item><description><para>port: The health check port.</para>
        /// </description></item>
        /// <item><description><para>failureRate: The failure rate.</para>
        /// </description></item>
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
        /// <para>The health check protocol.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The timeout period for a health check. Unit: milliseconds. Valid values: 2000, 3000, 5000, and 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
