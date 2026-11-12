// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetLoadBalancerUDPListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The port used by the backend server of the load balancing instance. Valid values: 1 to 65535.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// <para>The name of the listener. The name must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <para>The name cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable EIP pass-through. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: Enables EIP pass-through.</description></item>
        /// <item><description><b>off</b>: Disables EIP pass-through. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("EipTransmit")]
        [Validation(Required=false)]
        public string EipTransmit { get; set; }

        /// <summary>
        /// <para>The connection timeout period. Valid values: <b>10</b> to <b>900</b>. Default value: <b>900</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. If you do not specify this parameter in the Settings, the backend service port (BackendServerPort) is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout period for a health check response. If a backend ENS instance does not respond within the specified timeout period, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 5.</description></item>
        /// <item><description>Valid values: <b>1</b> to <b>300</b>.</description></item>
        /// <item><description>Unit: seconds.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value of HealthCheckConnectTimeout is less than the value of HealthCheckInterval, HealthCheckConnectTimeout is ignored and the value of HealthCheckInterval is used as the timeout period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The response string for UDP health checks. The string can contain only letters and digits and can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive health checks. Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The request string for UDP health checks. The string can contain only letters and digits and can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("HealthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks that must occur before a backend server is declared healthy (from fail to success). Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The frontend port of the listener whose attributes you want to modify. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The ID of the load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5pzipr2fszqtl2xf64uy5****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b>: Backend servers with higher weights receive more requests.</description></item>
        /// <item><description><b>wlc</b>: Requests are distributed based on the weights and actual loads (connections) of backend servers. If two backend servers have the same weight, the backend server with fewer connections receives more requests.</description></item>
        /// <item><description><b>rr</b>: Requests are evenly and sequentially distributed to backend servers.</description></item>
        /// <item><description><b>sch</b>: Consistent hashing based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</description></item>
        /// <item><description><b>tch</b>: Consistent hashing based on quadruples (source IP address, destination IP address, source port, and destination port). Requests from the same stream are distributed to the same backend server.</description></item>
        /// <item><description><b>qch</b>: Consistent hashing based on QUIC Connection IDs. Requests with the same QUIC Connection ID are distributed to the same backend server.</description></item>
        /// <item><description><b>iqch</b>: Consistent hashing based on specific three bytes of the iQUIC CID. Requests with the same 2nd to 4th bytes are distributed to the same backend server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks that must occur before a backend server is declared unhealthy (from success to fail). Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
