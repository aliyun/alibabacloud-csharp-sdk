// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateIngressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the <b>CLB</b> certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the <b>LoadBalanceType</b> is <b>clb</b>, use this field to configure the HTTPS listener certificate.</description></item>
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

        [NameInMap("CorsConfig")]
        [Validation(Required=false)]
        public string CorsConfig { get; set; }

        /// <summary>
        /// <para>The default forwarding rule. Forwards traffic to a specified application through a specified port based on the IP address. The following table describes the parameters.</para>
        /// <list type="bullet">
        /// <item><description><b>appId</b>: the ID of the application.</description></item>
        /// <item><description><b>containerPort</b>: the container port of the application.</description></item>
        /// </list>
        /// <remarks>
        /// <para> All requests that do not match the forwarding rules specified for Rules are forwarded over the port to the application.</para>
        /// </remarks>
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
        /// <para>ingress-sae-test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableGzip")]
        [Validation(Required=false)]
        public bool? EnableGzip { get; set; }

        [NameInMap("EnableXForwardedFor")]
        [Validation(Required=false)]
        public bool? EnableXForwardedFor { get; set; }

        [NameInMap("EnableXForwardedForClientSrcPort")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForClientSrcPort { get; set; }

        [NameInMap("EnableXForwardedForProto")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForProto { get; set; }

        [NameInMap("EnableXForwardedForSlbId")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForSlbId { get; set; }

        [NameInMap("EnableXForwardedForSlbPort")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForSlbPort { get; set; }

        /// <summary>
        /// <para>The timeout period of idle connections. Unit: seconds.</para>
        /// <remarks>
        /// <para> A value of 0 indicates that the default value is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the routing rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87</para>
        /// </summary>
        [NameInMap("IngressId")]
        [Validation(Required=false)]
        public long? IngressId { get; set; }

        /// <summary>
        /// <para>The SLB listening port. This port cannot be occupied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public string ListenerPort { get; set; }

        /// <summary>
        /// <para>The protocol that is used to forward requests. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP</b>: HTTP is suitable for applications that need to identify transmitted data.</description></item>
        /// <item><description><b>HTTPS</b>: HTTPS is suitable for applications that require encrypted data transmission.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The parameter is deprecated and cannot be updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("LoadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        /// <summary>
        /// <para>The request timed out. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
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
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;<a href="http://www.sae.site%22,%22path%22:%22/path1%22%7D,%7B%22appId%22:%22666403ce-d25b-47cf-87fe-497565d2****%22,%22containerPort%22:8080,%22domain%22:%22sae.site%22,%22path%22:%22/path2%22%7D%5D">www.sae.site&quot;,&quot;path&quot;:&quot;/path1&quot;},{&quot;appId&quot;:&quot;666403ce-d25b-47cf-87fe-497565d2****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;sae.site&quot;,&quot;path&quot;:&quot;/path2&quot;}]</a></para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>The ID of a security policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_2_strict_with_1_3</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

    }

}
