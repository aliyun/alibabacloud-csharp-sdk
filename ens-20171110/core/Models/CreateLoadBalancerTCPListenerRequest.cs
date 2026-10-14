// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerTCPListenerRequest : TeaModel {
        /// <summary>
        /// <para>The port used by backend servers. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// <para>The description of the listener. The description must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <para>The description cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>The timeout period for established connections, in seconds. Valid values: <b>10</b> to <b>900</b>. Default value: <b>900</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. If you do not specify this parameter, the port specified by <c>BackendServerPort</c> is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The maximum time to wait for a health check response. If a backend ENS instance does not respond within this timeout period, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: 5.</para>
        /// </description></item>
        /// <item><description><para>Valid values: <b>1</b> to <b>300</b>.</para>
        /// </description></item>
        /// <item><description><para>Unit: seconds.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value of this parameter is less than the value of <c>HealthCheckInterval</c>, this parameter is ignored and the value of <c>HealthCheckInterval</c> is used as the timeout period.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status codes that indicate a successful health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>http_2xx</b> (default)</para>
        /// </description></item>
        /// <item><description><para><b>http_3xx</b></para>
        /// </description></item>
        /// <item><description><para><b>http_4xx</b></para>
        /// </description></item>
        /// <item><description><para><b>http_5xx</b></para>
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
        /// <para>The interval between health checks, in seconds. Valid values: <b>1</b> to <b>50</b>. Default value: <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The health check type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tcp</b> (default)</para>
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
        /// <para>The URI for health checks. The URI must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <para>The URI must start with a forward slash (/) but cannot be only a forward slash (/).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/checkpreload.htm</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required for a backend server to be considered healthy (from a <c>fail</c> to <c>success</c> state). Valid values: <b>2</b> to <b>10</b>. Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The listener port that receives and forwards requests to backend servers. Valid values: <b>1</b> to <b>65535</b>.</para>
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
        /// <para>lb-5ovkn1piwqmoqrfjdyhq4****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The timeout period for session persistence.</para>
        /// <list type="bullet">
        /// <item><description><para>Default value: <b>0</b>, which indicates that session persistence is disabled.</para>
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
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>wrr</b> (default): Weighted Round Robin. Requests are distributed to backend servers based on their weights. Backend servers with higher weights receive more requests.</para>
        /// </description></item>
        /// <item><description><para><b>wlc</b>: Weighted Least Connections. Requests are distributed to backend servers based on both their weights and the number of connections. If multiple backend servers have the same weight, the one with the fewest connections receives more requests.</para>
        /// </description></item>
        /// <item><description><para><b>rr</b>: Round Robin. Requests are distributed to backend servers in sequential order.</para>
        /// </description></item>
        /// <item><description><para><b>sch</b>: Source IP Hash. Requests are routed based on a consistent hash of the source IP address, ensuring that requests from the same source IP address are sent to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>tch</b>: Four-tuple Hash. Requests are routed based on a consistent hash of a four-tuple (source IP address, destination IP address, source port, and destination port), ensuring that requests from the same flow are sent to the same backend server.</para>
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
        /// <para>The number of consecutive failed health checks required for a backend server to be considered unhealthy (from a <c>success</c> to <c>fail</c> state). Valid values: <b>2</b> to <b>10</b>. Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
