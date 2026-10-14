// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerTCPListenerAttributeResponseBody : TeaModel {
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
        /// <para>The peak bandwidth of the load balancer. The default value is -1, which indicates unlimited bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The description of the listener.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether EIP passthrough is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>on</b>: enable</para>
        /// </description></item>
        /// <item><description><para><b>off</b> (Default): disable</para>
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
        /// <para>The connection timeout. Valid values: <b>10</b> to <b>900</b>. Unit: seconds.</para>
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
        /// <item><description><para><b>on</b>: enable</para>
        /// </description></item>
        /// <item><description><para><b>off</b>: disable</para>
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
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. If this parameter is not specified, the value of <c>BackendServerPort</c> is used.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the HealthCheck parameter is set to <c>on</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The response timeout for a health check. If a backend ENS instance does not respond within this timeout period, the health check fails.</para>
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
        /// <item><description><para>This parameter takes effect only when the HealthCheck parameter is set to <c>on</c>.</para>
        /// </description></item>
        /// <item><description><para>If this value is less than the <c>HealthCheckInterval</c> value, the <c>HealthCheckInterval</c> value is used as the timeout period instead.</para>
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
        /// <para>The domain name used for health checks.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the HealthCheck parameter is set to <c>on</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status codes that indicate a successful health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>http_2xx</b> (Default)</para>
        /// </description></item>
        /// <item><description><para><b>http_3xx</b></para>
        /// </description></item>
        /// <item><description><para><b>http_4xx</b></para>
        /// </description></item>
        /// <item><description><para><b>http_5xx</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the HealthCheck parameter is set to <c>on</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The interval between health checks. Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
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
        /// <item><description><para><b>tcp</b> (Default)</para>
        /// </description></item>
        /// <item><description><para><b>http</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// <para>The URI used for health checks. Length: <b>1</b> to <b>80</b> characters.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>The URI must start with <c>/</c> but cannot consist solely of <c>/</c>.</para>
        /// </description></item>
        /// <item><description><para>This parameter takes effect only when the HealthCheck parameter is set to <c>on</c>.</para>
        /// </description></item>
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
        /// <para>The number of consecutive successful health checks required to change the health status of a backend server from <c>fail</c> (unhealthy) to <c>success</c> (healthy). Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the HealthCheck parameter is set to <c>on</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The frontend port used by the load balancer instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The session persistence timeout.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 0. A value of 0 indicates that session persistence is disabled.</para>
        /// </description></item>
        /// <item><description><para>Valid values: <b>0</b> to <b>3600</b>.</para>
        /// </description></item>
        /// <item><description><para>Unit: seconds.</para>
        /// </description></item>
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
        /// <item><description><para><b>wrr</b>: Weighted Round Robin. Backend servers with higher weights receive more requests.</para>
        /// </description></item>
        /// <item><description><para><b>wlc</b>: Weighted Least Connections. In addition to weights, the system considers the number of active connections to each backend server. If multiple backend servers have the same weight, the system selects the backend server with the fewest active connections.</para>
        /// </description></item>
        /// <item><description><para><b>rr</b>: Round Robin. The system distributes requests sequentially to the backend servers.</para>
        /// </description></item>
        /// <item><description><para><b>sch</b>: Source IP Hash. The system routes requests from the same source IP address to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>tch</b>: 4-Tuple Hash. The system routes requests that share the same 4-tuple (source IP address, destination IP address, source port, and destination port) to the same backend server.</para>
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
        /// <item><description><para><b>Starting</b>: The listener is being started.</para>
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
        /// <para>The number of consecutive failed health checks required to change the health status of a backend server from <c>success</c> (healthy) to <c>fail</c> (unhealthy). Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the HealthCheck parameter is set to <c>on</c>.</para>
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
