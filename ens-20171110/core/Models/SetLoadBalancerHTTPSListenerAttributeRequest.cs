// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetLoadBalancerHTTPSListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the listener. The name must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <para>It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Listener description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables the health check.</description></item>
        /// <item><description><b>off</b>: disables the health check.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. If the Settings for this parameter are not specified, the backend service port (BackendServerPort) is used.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7001</para>
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
        /// <para>The HTTP status codes that indicate a successful health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>http_2xx</b> (default).</description></item>
        /// <item><description><b>http_3xx</b>.</description></item>
        /// <item><description><b>http_4xx</b>.</description></item>
        /// <item><description><b>http_5xx</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
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
        /// <para>2</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The HTTP method used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>head</b> (default): requests only the header of the page.</description></item>
        /// <item><description><b>get</b>: requests the specified page information and returns the entity body.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>get</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The timeout period for a health check response. If a backend server does not respond within the specified timeout period, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 5.</description></item>
        /// <item><description>Valid values: <b>1</b> to <b>300</b>.</description></item>
        /// <item><description>Unit: seconds.<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when HealthCheck is set to on.</description></item>
        /// <item><description>If the value of HealthCheckTimeout is less than the value of HealthCheckInterval, HealthCheckTimeout is invalid and the timeout period is the value of HealthCheckInterval.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The URI used for health checks. The URI must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The URI cannot be only <c>/</c>, but must start with <c>/</c>.</description></item>
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
        /// <para>The number of consecutive successful health checks that must occur before the health check status of a backend server changes from fail (unreachable) to success (reachable). Valid values: <b>2</b> to <b>10</b>.</para>
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
        /// <para>If there is no access request within the timeout period, load balancing temporarily breaks the current connection until a new connection is established when the next request arrives.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The frontend port of the listener whose attributes you want to modify. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The ID of the load balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5snthcyu1x10g7tywj7iu****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The request timeout period. Default value: 60. Valid values: <b>1</b> to <b>180</b>. Unit: seconds.</para>
        /// <remarks>
        /// <para>If a backend server does not send a response within the timeout period, load balancing stops waiting and returns an HTTP 504 error code to the client.</para>
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
        /// <item><description><b>wlc</b>: Requests are distributed based on the weights and actual loads (connections) of backend servers. If the weights are the same, backend servers with fewer connections receive more requests.</description></item>
        /// <item><description><b>rr</b>: Requests are evenly distributed to backend servers in sequence.</description></item>
        /// <item><description><b>sch</b>: Consistent hashing based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</description></item>
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
        /// <para>The ID of the server certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6027667</para>
        /// </summary>
        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks that must occur before the health check status of a backend server changes from success (reachable) to fail (unreachable). Valid values: <b>2</b> to <b>10</b>.</para>
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

    }

}
