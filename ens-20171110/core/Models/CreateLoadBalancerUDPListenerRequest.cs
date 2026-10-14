// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerUDPListenerRequest : TeaModel {
        /// <summary>
        /// <para>The port used by the backend servers. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

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
        /// <para>Specifies whether EIP pass-through is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enables EIP pass-through.</para>
        /// </description></item>
        /// <item><description><para><b>off</b> (default): Disables EIP pass-through.</para>
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
        /// <para>The timeout for established connections. Valid values: <b>10</b> to <b>900</b>. Default value: <b>900</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. If you do not specify this parameter, the port specified by <c>BackendServerPort</c> is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The maximum time to wait for a response to a health check. A health check fails if a backend ENS instance does not respond within this time.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 5.</para>
        /// </description></item>
        /// <item><description><para>Valid values: <b>1</b> to <b>300</b>.</para>
        /// </description></item>
        /// <item><description><para>Unit: seconds.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this timeout is shorter than the health check interval (<c>HealthCheckInterval</c>), the interval value is used for the timeout instead.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The expected response string for UDP health checks. The string must be up to 64 characters long and contain only letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

        /// <summary>
        /// <para>The interval between health checks, in seconds. Valid values: <b>1</b> to <b>50</b>. Default value: <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The request string for UDP health checks. The string must be up to 64 characters long and contain only letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("HealthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required for a backend server to be considered healthy. Valid values: <b>2</b> to <b>10</b>. Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The listener port used to receive requests and forward them to backend servers. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para>For UDP listeners, ports 250, 4789, and 4790 are system-reserved and not available for use.</para>
        /// </remarks>
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
        /// <para>lb-5q73cv04zeyh43lh74lp4****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>wrr</b> (default): Weighted Round Robin. Backend servers with a higher weight receive more requests.</para>
        /// </description></item>
        /// <item><description><para><b>wlc</b>: Weighted Least Connections. Requests are distributed based on both the weight and the number of current connections of each backend server. If multiple backend servers have the same weight, the one with the fewest active connections receives the next request.</para>
        /// </description></item>
        /// <item><description><para><b>rr</b>: Round Robin. Requests are distributed to backend servers sequentially.</para>
        /// </description></item>
        /// <item><description><para><b>sch</b>: Source IP Hash. Requests from the same source IP address are routed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>tch</b>: Four-tuple Hash. Requests are routed to backend servers based on a hash of four values: source IP address, destination IP address, source port, and destination port. Flows with the same four values are routed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>qch</b>: QUIC Connection ID Hash. Requests with the same QUIC Connection ID are routed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>iqch</b>: A consistent hash algorithm for iQUIC Connection IDs. Flows with the same second, third, and fourth bytes in the iQUIC CID are routed to the same backend server.</para>
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
        /// <para>The number of consecutive failed health checks required for a backend server to be considered unhealthy. Valid values: <b>2</b> to <b>10</b>. Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
