// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerHTTPListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The port used by the backend server of the load balancing instance. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// <para>The peak bandwidth of load balancing. Default value: -1, which indicates that bandwidth is not limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The description of the listener. The description must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <para>It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The forwarding port for HTTP-to-HTTPS listeners.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002</para>
        /// </summary>
        [NameInMap("ForwardPort")]
        [Validation(Required=false)]
        public int? ForwardPort { get; set; }

        /// <summary>
        /// <para>Indicates whether health checks are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. If this parameter is not specified, the backend server port (BackendServerPort) is used.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The domain name used for health checks.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status code that indicates a successful health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>http_2xx</b> (default)</description></item>
        /// <item><description><b>http_3xx</b></description></item>
        /// <item><description><b>http_4xx</b></description></item>
        /// <item><description><b>http_5xx</b><remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The interval between two consecutive health checks. Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The HTTP method used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>head</b>: Requests only the header of the page.</description></item>
        /// <item><description><b>get</b>: Requests the specified page information and returns the entity body.<remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>head</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The timeout period for a health check response. If a backend ENS instance does not respond within the specified timeout period, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 5.</description></item>
        /// <item><description>Valid values: <b>1</b> to <b>300</b>.</description></item>
        /// <item><description>Unit: seconds.<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when HealthCheck is set to on.</description></item>
        /// <item><description>If the value of HealthCheckTimeout is less than the value of HealthCheckInterval, HealthCheckTimeout becomes invalid and the timeout period equals the value of HealthCheckInterval.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The URI used for health checks. The URI must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The URI cannot be only a forward slash (<c>/</c>), but it must start with a forward slash (<c>/</c>).</description></item>
        /// <item><description>This parameter takes effect only when HealthCheck is set to on.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/checkpreload.htm</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks that must occur before the health check status of a backend server is changed from fail (unreachable) to success (reachable). Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The idle connection timeout period. Default value: 15. Valid values: <b>1</b> to <b>60</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para>If no request is received within the specified timeout period, load balancing temporarily interrupts the current connection and establishes a new connection when the next request arrives.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>Indicates whether HTTP-to-HTTPS forwarding is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled.</description></item>
        /// <item><description><b>off</b> (default): disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("ListenerForward")]
        [Validation(Required=false)]
        public string ListenerForward { get; set; }

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
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request timeout period. Default value: 60. Valid values: <b>1</b> to <b>180</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para>If a backend server does not return a response within the specified timeout period, load balancing stops waiting and returns an HTTP 504 error code to the client.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b>: Backend servers with higher weights receive more requests.</description></item>
        /// <item><description><b>wlc</b>: Requests are distributed based on the weights and actual loads (connections) of backend servers. If two backend servers have the same weight, the backend server with fewer connections receives more requests.</description></item>
        /// <item><description><b>rr</b>: Requests are evenly and sequentially distributed to backend servers.</description></item>
        /// <item><description><b>sch</b>: Consistent hashing based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</description></item>
        /// <item><description><b>qch</b>: Consistent hashing based on QUIC Connection IDs. Requests with the same QUIC Connection ID are distributed to the same backend server.</description></item>
        /// <item><description><b>iqch</b>: Consistent hashing based on specific three bytes of the iQUIC CID. Requests with the same second to fourth bytes are distributed to the same backend server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The ID of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6027667</para>
        /// </summary>
        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// <para>The status of the listener. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Running</b>: The listener is running.</description></item>
        /// <item><description><b>Stopped</b>: The listener is stopped.</description></item>
        /// <item><description><b>Starting</b>: The listener is starting.</description></item>
        /// <item><description><b>Configuring</b>: The listener is being configured.</description></item>
        /// <item><description><b>Stopping</b>: The listener is being stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks that must occur before the health check status of a backend server is changed from success (reachable) to fail (unreachable). Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// <para>Indicates whether the X-Forwarded-For header is used to retrieve the originating IP addresses of clients. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b> (default): enabled.</description></item>
        /// <item><description><b>off</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("XForwardedFor")]
        [Validation(Required=false)]
        public string XForwardedFor { get; set; }

    }

}
