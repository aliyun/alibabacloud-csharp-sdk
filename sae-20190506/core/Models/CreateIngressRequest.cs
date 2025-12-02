// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateIngressRequest : TeaModel {
        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the <b>CLB</b> certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>LoadBalanceType</b> to <b>clb</b>, you can use CertId to configure a certificate for the HTTPS listener.</description></item>
        /// </list>
        /// <para>For more information about how to use SSL certificate IDs for CLB, see <a href="https://help.aliyun.com/document_detail/90792.html">Manage certificates (CLB)</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>188077086902****_176993d****_181437****_108724****</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The ID of the multi-certificate <b>ALB</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the <b>LoadBalanceType</b> is <b>alb</b>, use this field to configure multiple certificates for HTTPS listeners. Separate multiple certificate IDs with commas (,).</description></item>
        /// <item><description>The ID of the SSL certificate used by ALB must be obtained from the digital certificate product. For example, in the configuration <c>756***-cn-hangzhou</c>, the <c>756***</c> is the certificate ID obtained from the product page, and the <c>-cn-hangzhou</c> is a fixed suffix. For more information, see <a href="https://help.aliyun.com/document_detail/209076.html">Manage certificates</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>87<em><b>35-cn-hangzhou,812</b></em>3-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("CorsConfig")]
        [Validation(Required=false)]
        public string CorsConfig { get; set; }

        /// <summary>
        /// <para>The default forwarding rule. Forwards traffic to a specified application through a specified port based on the IP address. The following table describes the parameters.</para>
        /// <list type="bullet">
        /// <item><description><b>appId</b>: the ID of the application.</description></item>
        /// <item><description><b>containerPort</b>: The port of the application instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para> All requests that do not match or satisfy <b>Rules</b> forwarding rules are forwarded to the specified application.</para>
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
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnableGzip")]
        [Validation(Required=false)]
        public bool? EnableGzip { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnableXForwardedFor")]
        [Validation(Required=false)]
        public bool? EnableXForwardedFor { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnableXForwardedForClientSrcPort")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForClientSrcPort { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnableXForwardedForProto")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForProto { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnableXForwardedForSlbId")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForSlbId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnableXForwardedForSlbPort")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForSlbPort { get; set; }

        /// <summary>
        /// <para>Specifies the connection idle timeout period. Unit: seconds. Valid values: 1 to 60. If there is no access request within the timeout period, the SLB will temporarily interrupt the current connection until the next request comes to re-establish a new connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The SLB listening port. This port cannot be occupied.</para>
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
        /// <item><description><b>HTTP</b>: suitable for applications that need to identify data content.</description></item>
        /// <item><description><b>HTTPS</b>: suitable for applications that require encrypted transmission.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>SLB the type of the SLB instance. It depends on the type that you entered when you created the routing rule and cannot be changed when you update it. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>clb</b>: traditional SLB CLB (formerly SLB).</description></item>
        /// <item><description><b>alb</b>: Applied SLB ALB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("LoadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        /// <summary>
        /// <para>The ID of the namespace where the application resides. Currently, cross-namespace applications are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:sae-test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>Specifies the request timeout period. Unit: seconds. Valid values: 1 to 180. If the backend server does not respond within the timeout period, the SLB abandons the wait and returns an HTTP 504 error code to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The forwarding rule. Forwards traffic to a specified application through a specified port based on the domain name and request path. The following table describes the parameters.</para>
        /// <list type="bullet">
        /// <item><description><b>appId</b>: the ID of the application.</description></item>
        /// <item><description><b>containerPort</b>: The port of the application instance.</description></item>
        /// <item><description><b>domain</b>: the domain name.</description></item>
        /// <item><description><b>path</b>: the request path.</description></item>
        /// <item><description><b>backendProtocol</b>: The backend service protocol. Valid values: http, https, and grpc. Default value: http.</description></item>
        /// <item><description><b>rewritePath</b>: Rewrite the path.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Only ALB allows you to set the RewritePath feature. CLB does not support this feature.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;<a href="http://www.sae.site%22,%22path%22:%22/path1%22%7D,%7B%22appId%22:%22666403ce-d25b-47cf-87fe-497565d2****%22,%22containerPort%22:8080,%22domain%22:%22sae.site%22,%22path%22:%22/path2%22%7D%5D">www.sae.site&quot;,&quot;path&quot;:&quot;/path1&quot;},{&quot;appId&quot;:&quot;666403ce-d25b-47cf-87fe-497565d2****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;sae.site&quot;,&quot;path&quot;:&quot;/path2&quot;}]</a></para>
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
        /// <para>The Server Load Balancer (SLB) instance that is used by the routing rule.</para>
        /// <remarks>
        /// <para> SLB SLB instances include CLB instances and ALB instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-uf6hucc7inlqrtcq5****</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public string ZoneMappings { get; set; }

    }

}
