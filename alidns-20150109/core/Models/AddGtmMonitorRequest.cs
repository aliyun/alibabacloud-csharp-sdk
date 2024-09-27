// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddGtmMonitorRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the address pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("AddrPoolId")]
        [Validation(Required=false)]
        public string AddrPoolId { get; set; }

        /// <summary>
        /// <para>The number of consecutive failures.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The health check interval. Unit: seconds. Set the value to 60.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public int? Interval { get; set; }

        /// <summary>
        /// <para>The nodes for monitoring.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IspCityNode")]
        [Validation(Required=false)]
        public List<AddGtmMonitorRequestIspCityNode> IspCityNode { get; set; }
        public class AddGtmMonitorRequestIspCityNode : TeaModel {
            /// <summary>
            /// <para>The city code.</para>
            /// <para>Specify the parameter according to the value of CityCode returned by the DescribeGtmMonitorAvailableConfig operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>503</para>
            /// </summary>
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            /// <summary>
            /// <para>The Internet service provider (ISP) node. Specify the parameter according to the value of IspCode returned by the DescribeGtmMonitorAvailableConfig operation.</para>
            /// <list type="bullet">
            /// <item><description>If the return value of GroupType for the DescribeGtmMonitorAvailableConfig operation is BGP or Overseas, IspCode is not required and is set to 465 by default.</description></item>
            /// <item><description>If the return value of GroupType for the DescribeGtmMonitorAvailableConfig operation is not BGP or Overseas, IspCode is required. When IspCode is specified, CityCode is required.</description></item>
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
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The extended information. The required parameters vary based on the health check protocol.</para>
        /// <para>HTTP or HTTPS</para>
        /// <list type="bullet">
        /// <item><description>port: the port that you want to check</description></item>
        /// <item><description>failureRate: the failure rate</description></item>
        /// <item><description>code: the return code. The health check result is deemed abnormal if the returned value is greater than the specified value. Valid values: 400 and 500.</description></item>
        /// <item><description>host: the host settings</description></item>
        /// <item><description>path: the URL path</description></item>
        /// </list>
        /// <para>PING</para>
        /// <list type="bullet">
        /// <item><description>packetNum: the number of ping packets</description></item>
        /// <item><description>packetLossRate: the packet loss rate</description></item>
        /// <item><description>failureRate: the failure rate</description></item>
        /// </list>
        /// <para>TCP</para>
        /// <list type="bullet">
        /// <item><description>port: the port that you want to check</description></item>
        /// <item><description>failureRate: the failure rate</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;code\&quot;:200,\&quot;path\&quot;:\&quot;/index.htm\&quot;,\&quot;host\&quot;:\&quot;aliyun.com\&quot;}</para>
        /// </summary>
        [NameInMap("MonitorExtendInfo")]
        [Validation(Required=false)]
        public string MonitorExtendInfo { get; set; }

        /// <summary>
        /// <para>The protocol used for the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HTTP</description></item>
        /// <item><description>HTTPS</description></item>
        /// <item><description>PING</description></item>
        /// <item><description>TCP</description></item>
        /// </list>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
