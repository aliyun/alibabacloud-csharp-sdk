// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerUDPListenerAttributeResponseBody : TeaModel {
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
        /// <para>The peak bandwidth of the load balancer. A value of -1 indicates that no rate limit is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The listener name.</para>
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
        /// <item><description><para><b>on</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b> (default): Disabled.</para>
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
        /// <para>The connection timeout period. Valid values: <b>10</b> to <b>900</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. If you do not specify this parameter, the value of <c>BackendServerPort</c> is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout period for a health check response. If a backend ENS instance does not respond within the specified timeout period, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 5.</para>
        /// </description></item>
        /// <item><description><para>Valid values: <b>1</b> to <b>300</b>.</para>
        /// </description></item>
        /// <item><description><para>Unit: seconds.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when <c>HealthCheck</c> is set to <c>on</c>.</para>
        /// </description></item>
        /// <item><description><para>If the value of <c>HealthCheckConnectTimeout</c> is less than the value of <c>HealthCheckInterval</c>, the value of <c>HealthCheckInterval</c> is used as the timeout period.</para>
        /// </description></item>
        /// </list>
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
        /// <para>The interval between health checks. Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>HealthCheck</c> is set to <c>on</c>.</para>
        /// </remarks>
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
        /// <para>The number of consecutive successful health checks that must occur before a backend server can be declared healthy. Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>HealthCheck</c> is set to <c>on</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The listener port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D7597CF-1630-54EC-A945-624A33F2E7E8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>wrr</b> (Weighted Round Robin): Backend servers with higher weights receive a larger proportion of requests.</para>
        /// </description></item>
        /// <item><description><para><b>wlc</b> (Weighted Least Connections): Requests are distributed based on both the weight and the current connection count of each backend server. If backend servers have the same weight, the server with the fewest connections receives more new requests.</para>
        /// </description></item>
        /// <item><description><para><b>rr</b> (Round Robin): Requests are distributed to backend servers sequentially.</para>
        /// </description></item>
        /// <item><description><para><b>sch</b> (Source IP Hash): Routes requests from the same source IP address to the same backend server by using a consistent hash of the source IP address.</para>
        /// </description></item>
        /// <item><description><para><b>tch</b> (4-tuple Hash): Routes packets from the same flow to the same backend server by using a consistent hash of the 4-tuple (source IP address, destination IP address, source port, and destination port).</para>
        /// </description></item>
        /// <item><description><para><b>qch</b> (QUIC Connection ID Hash): Uses a consistent hashing algorithm on the QUIC Connection ID to ensure that requests with the same connection ID are always routed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>iqch</b> (iQUIC CID Hash): Uses a consistent hashing algorithm on bytes 2, 3, and 4 of the iQUIC CID. Requests where these three bytes are the same are routed to the same backend server.</para>
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
        /// <para>The status of the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Running</b>: The listener is running.</para>
        /// </description></item>
        /// <item><description><para><b>Stopped</b>: The listener is stopped.</para>
        /// </description></item>
        /// <item><description><para><b>Starting</b>: The listener is starting.</para>
        /// </description></item>
        /// <item><description><para><b>Configuring</b>: The listener is being configured.</para>
        /// </description></item>
        /// <item><description><para><b>Stopping</b>: The listener is being stopped.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks that must occur before a backend server can be declared unhealthy. Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>HealthCheck</c> is set to <c>on</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
