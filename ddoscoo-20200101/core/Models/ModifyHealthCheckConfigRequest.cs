// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class ModifyHealthCheckConfigRequest : TeaModel {
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
        /// <para>The details of the health check configuration. This parameter is a JSON string. The string contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Type</b>: the protocol type. This field is required and must be of the STRING type. Valid values: <b>tcp</b> (Layer 4) and <b>http</b> (Layer 7).</para>
        /// </description></item>
        /// <item><description><para><b>Domain</b>: the domain name, which must be of the STRING type.</para>
        /// <para>**</para>
        /// <para><b>Note</b>This parameter is returned only when the Layer 7 health check configuration is queried.</para>
        /// </description></item>
        /// <item><description><para><b>Uri</b>: the check path, which must be of the STRING type.</para>
        /// <para>**</para>
        /// <para><b>Note</b>This parameter is returned only when the Layer 7 health check configuration is queried.</para>
        /// </description></item>
        /// <item><description><para><b>Timeout</b>: the response timeout period, which must be of the INTEGER type. Valid values: <b>1</b> to <b>30</b>. Unit: seconds.</para>
        /// </description></item>
        /// <item><description><para><b>Port</b>: the port on which you want to perform the health check, which must be of the INTEGER type.</para>
        /// </description></item>
        /// <item><description><para><b>Interval</b>: the health check interval, which must be of the INTEGER type. Valid values: <b>1</b> to <b>30</b>. Unit: seconds.</para>
        /// </description></item>
        /// <item><description><para><b>Up</b>: the number of consecutive successful health checks that must occur before declaring a port healthy, which must be of the INTEGER type. Valid values: <b>1</b> to <b>10</b>.</para>
        /// </description></item>
        /// <item><description><para><b>Down</b>: the number of consecutive failed health checks that must occur before declaring a port unhealthy, which must be of the INTEGER type. Valid values: <b>1</b> to <b>10</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Type&quot;:&quot;tcp&quot;,&quot;Timeout&quot;:10,&quot;Port&quot;:8080,&quot;Interval&quot;:10,&quot;Up&quot;:10,&quot;Down&quot;:40}</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

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

    }

}
