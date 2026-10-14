// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetLoadBalancerUDPListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the listener. The name must be <b>1</b> to <b>80</b> characters long.</para>
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
        /// <para>Specifies whether to enable EIP passthrough. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables EIP passthrough.</para>
        /// </description></item>
        /// <item><description><para><b>off</b> (default): Disables EIP passthrough.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("EipTransmit")]
        [Validation(Required=false)]
        public string EipTransmit { get; set; }

        /// <summary>
        /// <para>The timeout for established connections, in seconds. The value must be an integer from <b>10</b> to <b>900</b>. The default value is <b>900</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. Defaults to the backend server port (<c>BackendServerPort</c>) if not specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout for a health check response. If a backend ENS instance does not respond within this timeout period, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 5</para>
        /// </description></item>
        /// <item><description><para>Valid values: <b>1</b> to <b>300</b></para>
        /// </description></item>
        /// <item><description><para>Unit: seconds</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value of <c>HealthCheckConnectTimeout</c> is less than the value of <c>HealthCheckInterval</c>, the system ignores <c>HealthCheckConnectTimeout</c> and uses the value of <c>HealthCheckInterval</c> as the timeout period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The expected response string for a UDP listener health check. The string can contain only letters and digits and must be at most 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

        /// <summary>
        /// <para>The interval, in seconds, between consecutive health checks. Valid values: <b>1</b> to <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The request string for a UDP listener health check. The string can contain only letters and digits and must be at most 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("HealthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required to mark an unhealthy backend server as healthy. Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The listener port to modify. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The ID of the load balancer instance.</para>
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
        /// <item><description><para><b>wrr</b>: Weighted Round Robin. Backend servers with higher weights receive a larger proportion of requests.</para>
        /// </description></item>
        /// <item><description><para><b>wlc</b>: Weighted Least Connections. Requests are distributed based on both the weights and the number of active connections of backend servers. If servers have the same weight, the server with the fewest active connections receives more requests.</para>
        /// </description></item>
        /// <item><description><para><b>rr</b>: Round Robin. Requests are distributed to backend servers in sequence.</para>
        /// </description></item>
        /// <item><description><para><b>sch</b>: Source IP Hash. A consistent hash based on the source IP address. Requests from the same source IP address are routed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>tch</b>: 4-Tuple Hash. A consistent hash based on the 4-tuple (source IP, destination IP, source port, and destination port). Flows with the same 4-tuple are routed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>qch</b>: QUIC Connection ID Hash. A consistent hash based on the QUIC Connection ID. Requests with the same QUIC Connection ID are routed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>iqch</b>: iQUIC CID Hash. A consistent hash based on three specific bytes (from the second to the fourth byte) of the iQUIC CID. Requests with identical values in these three bytes are routed to the same backend server.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks required to mark a healthy backend server as unhealthy. Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
