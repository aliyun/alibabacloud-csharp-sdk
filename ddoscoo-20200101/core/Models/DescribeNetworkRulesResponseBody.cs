// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the port forwarding rules.</para>
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public List<DescribeNetworkRulesResponseBodyNetworkRules> NetworkRules { get; set; }
        public class DescribeNetworkRulesResponseBodyNetworkRules : TeaModel {
            /// <summary>
            /// <para>The port of the origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("BackendPort")]
            [Validation(Required=false)]
            public int? BackendPort { get; set; }

            /// <summary>
            /// <para>The forwarding port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddoscoo-cn-mp91j1ao****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the port forwarding rule is automatically created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAutoCreate")]
            [Validation(Required=false)]
            public bool? IsAutoCreate { get; set; }

            /// <summary>
            /// <para>Indicates whether the payload filtering rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: enabled.</description></item>
            /// <item><description>0: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PayloadRuleEnable")]
            [Validation(Required=false)]
            public long? PayloadRuleEnable { get; set; }

            /// <summary>
            /// <para>The forwarding protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tcp</b></description></item>
            /// <item><description><b>udp</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tcp</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>Indicates whether the traffic diversion switch is on. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: on.</description></item>
            /// <item><description>1: off.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ProxyEnable")]
            [Validation(Required=false)]
            public long? ProxyEnable { get; set; }

            /// <summary>
            /// <para>The status of traffic diversion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>on: Traffic diversion takes effect.</description></item>
            /// <item><description>off: Traffic diversion does not take effect.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            /// <summary>
            /// <para>The IP addresses of origin servers.</para>
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

            /// <summary>
            /// <para>The remarks of the port forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8597F235-FA5E-4FC7-BAD9-E4C0B01BC771</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned port forwarding rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
