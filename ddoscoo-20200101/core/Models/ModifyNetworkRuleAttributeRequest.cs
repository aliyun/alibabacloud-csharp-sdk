// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyNetworkRuleAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The detailed settings of the port forwarding rule. This parameter is a JSON string and contains the following fields. The detailed settings of a TCP port forwarding rule contain the following fields.</para>
        /// <list type="bullet">
        /// <item><description><b>PersistenceTimeout</b>: the timeout period of session persistence. This field is required and of the integer type. Valid values: <b>30</b> to <b>3600</b>. Unit: seconds. Default value: <b>0</b>, which indicates that session persistence is disabled.</description></item>
        /// <item><description><b>Synproxy</b>: specifies whether to enable the false source feature in the DDoS mitigation policy. This field is required and of the string type. Valid values: off and on.</description></item>
        /// <item><description><b>NodataConn</b>: specifies whether to enable the empty connection feature in the DDoS mitigation policy. This field is required and of the string type. Valid values: off and on.</description></item>
        /// <item><description><b>Sla</b>: the settings of the speed limit for destination feature. This field is required and of the struct type. For more information, see the following description about Sla.</description></item>
        /// <item><description><b>Slimit</b>: the settings of the rate limit for source feature. This field is required and of the struct type. For more information, see the following description about Slimit.</description></item>
        /// <item><description><b>PayloadLen</b>: the settings of the packet length limit feature. This field is required and of the struct type. For more information, see the following description about PayloadLen.</description></item>
        /// </list>
        /// <para>Sla contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Cps</b>: the destination rate limit on new connections in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 100 to 100000.</description></item>
        /// <item><description><b>Maxconn</b>: the destination rate limit on concurrent connections in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 1000 to 1000000.</description></item>
        /// <item><description><b>CpsEnable</b>: specifies whether to enable Cps. This field is required and of the integer type. Valid values: 0 and 1. Default value: 1. The value 0 indicates that Cps is disabled, and the value 1 indicates that Cps is enabled.</description></item>
        /// <item><description><b>MaxconnEnable</b>: specifies whether to enable Maxconn. This field is required and of the integer type. Valid values: 0 and 1. Default value: 1. The value 0 indicates that Maxconn is disabled, and the value 1 indicates that Maxconn is enabled.</description></item>
        /// </list>
        /// <para>Slimit contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Cps</b>: the source rate limit on new connections in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 1 to 50000.</description></item>
        /// <item><description><b>Maxconn</b>: the source rate limit on concurrent connections in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 1 to 50000.</description></item>
        /// <item><description><b>CpsEnable</b>: specifies whether to enable Cps. This field is required and of the integer type. Valid values: 0 and 1. Default value: 1. The value 0 indicates that Cps is disabled, and the value 1 indicates that Cps is enabled.</description></item>
        /// <item><description><b>MaxconnEnable</b>: specifies whether to enable Maxconn. This field is required and of the integer type. Valid values: 0 and 1. Default value: 1. The value 0 indicates that Maxconn is disabled, and the value 1 indicates that Maxconn is enabled.</description></item>
        /// <item><description><b>CpsMode</b>: specifies whether to enable the source rate limit on new connections. This field is required and of the integer type. Valid values: 1 and 2. The value 1 indicates that the source rate limit is disabled. The value 2 indicates that the system determines whether to enable the source rate limit.</description></item>
        /// </list>
        /// <para>PayloadLen contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Min</b>: the minimum packet length in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 0 to 1500.</description></item>
        /// <item><description><b>Max</b>: the maximum packet length in the DDoS mitigation policy. This field is required and of the integer type. Valid values: 0 to 1500.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PersistenceTimeout&quot;:900}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The forwarding protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b></description></item>
        /// <item><description><b>udp</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

        /// <summary>
        /// <para>The forwarding port.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("FrontendPort")]
        [Validation(Required=false)]
        public int? FrontendPort { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/157459.html">DescribeInstanceIds</a> operation to query the IDs of all instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddoscoo-cn-mp91j1ao****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Module")]
        [Validation(Required=false)]
        public string Module { get; set; }

    }

}
