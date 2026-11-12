// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetLoadBalancerTCPListenerAttributeRequest : TeaModel {
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
        /// <para>Specifies whether to enable EIP pass-through. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b>: enables EIP pass-through.</description></item>
        /// <item><description><b>off</b> (default): disables EIP pass-through.</description></item>
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
        /// <para>The port used for health checks. Valid values: <b>1</b> to <b>65535</b>. If you do not configure the Settings for this parameter, the backend service port (BackendServerPort) is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The maximum timeout period for a health check response. If a backend ENS instance does not respond within the specified period, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 5.</description></item>
        /// <item><description>Valid values: <b>1</b> to <b>300</b>.</description></item>
        /// <item><description>Unit: seconds.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the value of HealthCheckConnectTimeout is less than the value of HealthCheckInterval, HealthCheckConnectTimeout is ignored and the timeout period is the value of HealthCheckInterval.</para>
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
        /// <item><description><b>http_2xx</b> (default)</description></item>
        /// <item><description><b>http_3xx</b></description></item>
        /// <item><description><b>http_4xx</b></description></item>
        /// <item><description><b>http_5xx</b></description></item>
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
        /// <para>The URI cannot be only <c>/</c>, but must start with <c>/</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/aliyundoc/index.html</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks that must occur before the health check status of a backend server changes from fail (unreachable) to success (reachable). Valid values: <b>2</b> to <b>10</b>.</para>
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
        /// <para>lb-5snthcyu1x10g7tywj7iu****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The timeout period for session persistence.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 0. This value indicates that session persistence is disabled.</description></item>
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
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b>: Backend servers with higher weights receive more requests.</description></item>
        /// <item><description><b>wlc</b>: Requests are distributed based on the weights and actual loads (number of connections) of backend servers. If two backend servers have the same weight, the backend server with fewer connections receives more requests.</description></item>
        /// <item><description><b>rr</b>: Requests are evenly and sequentially distributed to backend servers.</description></item>
        /// <item><description><b>sch</b>: Consistent hashing based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</description></item>
        /// <item><description><b>tch</b>: Consistent hashing based on four tuples (source IP address, destination IP address, source port, and destination port). Requests from the same stream are distributed to the same backend server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks that must occur before the health check status of a backend server changes from success (reachable) to fail (unreachable). Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
