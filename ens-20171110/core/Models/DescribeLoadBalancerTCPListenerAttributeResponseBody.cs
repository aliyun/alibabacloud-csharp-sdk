// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerTCPListenerAttributeResponseBody : TeaModel {
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
        /// <para>The peak bandwidth of the load balancing instance. Default value: -1, which indicates that no bandwidth throttling is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The name of the listener.</para>
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
        /// <item><description><b>on</b>: enabled</description></item>
        /// <item><description><b>off</b> (default): disabled</description></item>
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
        /// <para>Specifies whether to enable the health check feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enabled</description></item>
        /// <item><description><b>off</b>: disabled</description></item>
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
        /// <para>8000</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout period for receiving a health check response. If a backend ENS instance does not respond within the specified timeout period, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 5.</description></item>
        /// <item><description>Valid values: <b>1</b> to <b>300</b>.</description></item>
        /// <item><description>Unit: seconds.<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when HealthCheck is set to on.</description></item>
        /// <item><description>If the value of HealthCheckConnectTimeout is less than the value of HealthCheckInterval, HealthCheckConnectTimeout becomes invalid and the timeout period is the value of HealthCheckInterval.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The domain name used for health checks.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
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
        /// <item><description><b>http_5xx</b></description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The health check type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>tcp</b> (default)</description></item>
        /// <item><description><b>http</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The URI used for health checks. The URI must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The URI cannot contain only a forward slash (<c>/</c>), but it must start with a forward slash.</description></item>
        /// <item><description>This parameter takes effect only when HealthCheck is set to on.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/example/index.html</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required to change the health check status of a backend server from fail (unreachable) to success (reachable). Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The frontend port used by the load balancing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The timeout period for session persistence.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 0, which indicates that session persistence is disabled.</description></item>
        /// <item><description>Valid values: <b>0</b> to <b>3600</b>.</description></item>
        /// <item><description>Unit: seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PersistenceTimeout")]
        [Validation(Required=false)]
        public int? PersistenceTimeout { get; set; }

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
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b>: Backend servers with higher weights are polled more frequently.</description></item>
        /// <item><description><b>wlc</b>: Backend servers are polled based on their weights and actual loads (number of connections). If weights are the same, backend servers with fewer current connections are polled more frequently.</description></item>
        /// <item><description><b>rr</b>: External requests are distributed to backend servers in sequence.</description></item>
        /// <item><description><b>sch</b>: Consistent hashing is based on source IP addresses. Requests from the same source IP address are scheduled to the same backend server.</description></item>
        /// <item><description><b>tch</b>: Consistent hashing is based on quadruples (source IP address, destination IP address, source port, and destination port). Requests from the same stream are scheduled to the same backend server.</description></item>
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
        /// <item><description><b>Running</b>: running normally</description></item>
        /// <item><description><b>Stopped</b>: stopped</description></item>
        /// <item><description><b>Starting</b>: starting</description></item>
        /// <item><description><b>Configuring</b>: configuring</description></item>
        /// <item><description><b>Stopping</b>: stopping</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks required to change the health check status of a backend server from success (reachable) to fail (unreachable). Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when HealthCheck is set to on.</para>
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
