// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerTCPListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend port that is used by the ELB instance. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the elastic IP address (EIP). Default value: 5. Valid values: <b>5</b> to <b>10000</b>. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
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
        /// <para>Indicates whether EIP pass-through is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("EipTransmit")]
        [Validation(Required=false)]
        public string EipTransmit { get; set; }

        /// <summary>
        /// <para>The timeout period of a connection. Valid values: <b>10</b> to <b>900</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>Indicates whether the health check feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>on</b></description></item>
        /// <item><description><b>off</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>on</para>
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks. Valid values: <b>1</b> to <b>65535</b>. If an empty string is returned for this parameter, the port specified by BackendServerPort is used for health checks.</para>
        /// <remarks>
        /// <para> This parameter is returned only if you set HealthCheck to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check response. If a backend server does not respond within the specified timeout period, the server fails to pass the health check.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 5.</description></item>
        /// <item><description>Valid values: <b>1</b> to <b>300</b>.</description></item>
        /// <item><description>Unit: seconds.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is returned only if you set HealthCheck to on.</para>
        /// </description></item>
        /// <item><description><para>If the value of the HealthCheckConnectTimeout parameter is smaller than that of the HealthCheckInterval parameter, the timeout period specified by the HealthCheckConnectTimeout parameter becomes invalid and the value of the HealthCheckInterval parameter is used as the timeout period.</para>
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
        /// <para>The domain name that is used for health checks.</para>
        /// <remarks>
        /// <para> This parameter is returned only if you set HealthCheck to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// <para>The HTTP status codes for a successful health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>http_2xx</b> (default)</description></item>
        /// <item><description><b>http_3xx</b></description></item>
        /// <item><description><b>http_4xx</b></description></item>
        /// <item><description><b>http_5xx</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is returned only if you set HealthCheck to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http_2xx</para>
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// <para>The interval at which health checks are performed. Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The type of health checks. Valid values:</para>
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
        /// <para>The Uniform Resource Identifier (URI) that is used for health checks. The URI must be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The URL must start with a forward slash (<c>/</c>) and contain characters other than forward slashes (<c>/</c>).</para>
        /// </description></item>
        /// <item><description><para>This parameter is returned only if you set HealthCheck to on.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/example/index.html</para>
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks that must occur before an unhealthy and inaccessible backend server is declared healthy and accessible. Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para> This parameter is returned only if you set HealthCheck to on.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The frontend port that is used by the ELB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The timeout period of session persistence.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 0. If the default value is used, the system disables session persistence.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The routing algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b>: Backend servers with higher weights receive more requests than those with lower weights.</description></item>
        /// <item><description><b>wlc</b>: Requests are distributed based on the weight and load of each backend server. The load refers to the number of connections to a backend server. If two backend servers have the same weight, the backend server that has fewer connections receives more requests.</description></item>
        /// <item><description><b>rr</b>: Requests are distributed to backend servers in sequence.</description></item>
        /// <item><description><b>sch</b>: consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.</description></item>
        /// <item><description><b>qch</b>: consistent hashing that is based on QUIC connection IDs. Requests that contain the same QUIC connection ID are distributed to the same backend server.</description></item>
        /// <item><description><b>iqch</b>: consistent hashing that is based on specific three bytes of the iQUIC CIDs. Requests whose second to fourth bytes are the same are distributed to the same backend server.</description></item>
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
        /// <item><description><b>Running</b></description></item>
        /// <item><description><b>Stopped</b></description></item>
        /// <item><description><b>Starting</b></description></item>
        /// <item><description><b>Configuring</b></description></item>
        /// <item><description><b>Stopping</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of consecutive failed health checks that must occur before a healthy and accessible backend server is declared unhealthy and inaccessible. Valid values: <b>2</b> to <b>10</b>.</para>
        /// <remarks>
        /// <para> This parameter is returned only if you set HealthCheck to on.</para>
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
