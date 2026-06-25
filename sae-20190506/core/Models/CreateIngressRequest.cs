// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateIngressRequest : TeaModel {
        /// <summary>
        /// <para>The address type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Internet</c>: A public address.</para>
        /// </description></item>
        /// <item><description><para><c>Intranet</c>: A private address.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the <b>CLB</b> certificate.</para>
        /// <list type="bullet">
        /// <item><description>If <c>LoadBalanceType</c> is set to <c>clb</c>, use this parameter to configure the HTTPS listener certificate.</description></item>
        /// </list>
        /// <para>For more information about how to use SSL certificate IDs for CLB, see <a href="https://help.aliyun.com/document_detail/90792.html">Manage Certificates (CLB)</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>188077086902****_176993d****_181437****_108724****</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The IDs of the <b>ALB</b> certificates.</para>
        /// <list type="bullet">
        /// <item><description><para>If <c>LoadBalanceType</c> is set to <c>alb</c>, use this parameter to configure multiple certificates for the HTTPS listener. Separate multiple certificate IDs with a comma (,).</para>
        /// </description></item>
        /// <item><description><para>Obtain the SSL certificate ID for an ALB instance from the digital certificate service. For example, if you configure <c>756***-cn-hangzhou</c>, <c>756***</c> is the certificate ID obtained from the product page and <c>-cn-hangzhou</c> is a fixed suffix. For more information, see <a href="https://help.aliyun.com/document_detail/209076.html">Manage Certificates (ALB)</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>87<em><b>35-cn-hangzhou,812</b></em>3-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        /// <summary>
        /// <para>Specifies the Cross-Origin Resource Sharing (CORS) configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Enable&quot;:&quot;true&quot;}</para>
        /// </summary>
        [NameInMap("CorsConfig")]
        [Validation(Required=false)]
        public string CorsConfig { get; set; }

        /// <summary>
        /// <para>The default forwarding rule. Requests that do not match any forwarding rule in the <c>Rules</c> parameter are forwarded to the application specified in this rule. The value is a JSON string with the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>appId</c>: The ID of the application.</para>
        /// </description></item>
        /// <item><description><para><c>containerPort</c>: The port of the application instance.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This rule serves as a catch-all for traffic that is not handled by other specific forwarding rules.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080}</para>
        /// </summary>
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public string DefaultRule { get; set; }

        /// <summary>
        /// <para>The name of the routing rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingress-for-sae-test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Gzip for data compression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableGzip")]
        [Validation(Required=false)]
        public bool? EnableGzip { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>X-Forwarded-For</c> header to retrieve the IP address of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedFor")]
        [Validation(Required=false)]
        public bool? EnableXForwardedFor { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>X-Forwarded-Port</c> header to retrieve the source port of the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedForClientSrcPort")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForClientSrcPort { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>X-Forwarded-Proto</c> header to retrieve the listener protocol of the load balancer instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedForProto")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForProto { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>SLB-ID</c> header to retrieve the ID of the load balancer instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedForSlbId")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForSlbId { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the <c>X-Forwarded-Port</c> header to retrieve the listener port of the load balancer instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedForSlbPort")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForSlbPort { get; set; }

        /// <summary>
        /// <para>The connection idle timeout, in seconds. Valid values: 1 to 60. If no request is received within the timeout period, the load balancer temporarily closes the connection. The connection is re-established when the next request is received.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The listener port for the SLB instance. This port must be available.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The request forwarding protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>HTTP</c>: for applications that do not require encryption.</para>
        /// </description></item>
        /// <item><description><para><c>HTTPS</c>: suitable for applications that require encrypted data transmission.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The type of the Server Load Balancer (SLB) instance. This parameter cannot be changed after the routing rule is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>clb</c>: Classic Load Balancer (CLB), formerly known as SLB.</para>
        /// </description></item>
        /// <item><description><para><c>alb</c>: Application Load Balancer (ALB).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("LoadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        /// <summary>
        /// <para>The edition of the Application Load Balancer (ALB) instance. Different editions have different features and billing policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Standard</c>: Standard edition.</para>
        /// </description></item>
        /// <item><description><para><c>StandardWithWaf</c>: WAF-enhanced edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        /// <summary>
        /// <para>The ID of the namespace where the application is located. Cross-namespace applications are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:sae-test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The request timeout, in seconds. Valid values: 1 to 180. If a backend server does not respond within the timeout period, the load balancer stops waiting and returns an HTTP 504 error to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The forwarding rules. These rules route traffic to a specified application based on the domain name and path. The value is a JSON string. Each rule contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>appId</c>: The ID of the application.</para>
        /// </description></item>
        /// <item><description><para><c>containerPort</c>: The port of the application instance.</para>
        /// </description></item>
        /// <item><description><para><c>domain</c>: The domain name.</para>
        /// </description></item>
        /// <item><description><para><c>path</c>: The request path.</para>
        /// </description></item>
        /// <item><description><para><c>backendProtocol</c>: The protocol used by backend servers. Valid values: <c>http</c>, <c>https</c>, and <c>grpc</c>. Default value: <c>http</c>.</para>
        /// </description></item>
        /// <item><description><para><c>rewritePath</c>: The rewritten path.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Only ALB supports path rewriting (<c>RewritePath</c>). CLB does not support this feature.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;<a href="http://www.sae.site%22,%22path%22:%22/path1%22%7D,%7B%22appId%22:%22666403ce-d25b-47cf-87fe-497565d2****%22,%22containerPort%22:8080,%22domain%22:%22sae.site%22,%22path%22:%22/sys/(.*)/(.*)/aaa%22,%22backendProtocol%22:%22http%22%7D%5D">www.sae.site&quot;,&quot;path&quot;:&quot;/path1&quot;},{&quot;appId&quot;:&quot;666403ce-d25b-47cf-87fe-497565d2****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;sae.site&quot;,&quot;path&quot;:&quot;/sys/(.*)/(.*)/aaa&quot;,&quot;backendProtocol&quot;:&quot;http&quot;}]</a></para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>The ID of the security policy instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-bp1bpn0kn9****</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// <para>The ID of the Server Load Balancer (SLB) instance associated with the routing rule.</para>
        /// <remarks>
        /// <para>Server Load Balancer (SLB) includes Classic Load Balancer (CLB) and Application Load Balancer (ALB) instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-uf6hucc7inlqrtcq5****</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <para>A JSON string that contains the mappings between availability zones and VSwitches. If the current region supports two or more availability zones, you must specify at least two. A ZoneMapping consists of the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>VSwitchId</c>: a string that specifies the ID of the VSwitch that corresponds to the availability zone. Each availability zone can have only one VSwitch and one subnet.</para>
        /// </description></item>
        /// <item><description><para><c>ZoneId</c>: a string that specifies the ID of the availability zone for the load balancer instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VSwitchId&quot;:&quot;vsw-wz9klui6icc08p6******&quot;,&quot;ZoneId&quot;:&quot;cn-shenzhen-c&quot;},{&quot;VSwitchId&quot;:&quot;vsw-wz9frrmoeuki2wp******&quot;,&quot;ZoneId&quot;:&quot;cn-shenzhen-e&quot;}]</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public string ZoneMappings { get; set; }

    }

}
