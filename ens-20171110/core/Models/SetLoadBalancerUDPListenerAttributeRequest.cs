// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class SetLoadBalancerUDPListenerAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the listener. The valuemust be <b>1</b> to <b>80</b> characters in length.</para>
        /// <remarks>
        /// <para> The value cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Elastic IP address (EIP) pass-through. Valid values:</para>
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
        /// <para>The timeout period of a connection. Valid values: <b>10</b> to <b>900</b>. Default value: <b>900</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks. Valid values: <b>1</b> to <b>65535</b>. If you leave this parameter empty, the port specified for BackendServerPort is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check response. If the backend ENS does not respond within the specified time, the health check fails.</para>
        /// <list type="bullet">
        /// <item><description>Default value: 5.</description></item>
        /// <item><description>Valid values: <b>1</b> to <b>300</b>.</description></item>
        /// <item><description>Unit: seconds.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the value of the HealthCheckTimeout property is smaller than the value of the HealthCheckInterval property, the timeout period specified by the HealthCheckTimeout property becomes invalid and the value of the HealthCheckInterval property is used as the timeout period.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// <para>The response string for UDP listener health checks. The string can be up to 64 characters in length and can contain only letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("HealthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

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
        /// <para>The request string for UDP listener health checks. The string can be up to 64 characters in length and can contain only letters and digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hello</para>
        /// </summary>
        [NameInMap("HealthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks that must occur before an unhealthy and inaccessible backend server is declared healthy and accessible. Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The listener port whose attributes are to be modified. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The ID of the Edge Load Balancer (ELB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-5pzipr2fszqtl2xf64uy5****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The routing algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>wrr</b>: Backend servers with higher weights receive more requests than those with lower weights.</description></item>
        /// <item><description><b>wlc</b>: Requests are distributed based on the weight and load of each backend server. The load refers to the number of connections on a backend server. If two backend servers have the same weight, the backend server that has fewer connections receives more requests.</description></item>
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
        /// <para>The number of consecutive failed health checks that must occur before a healthy and accessible backend server is declared unhealthy and inaccessible. Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
