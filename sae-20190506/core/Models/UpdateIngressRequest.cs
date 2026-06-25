// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateIngressRequest : TeaModel {
        /// <summary>
        /// <para><b>CLB</b> certificate ID. Details are as follows:</para>
        /// <list type="bullet">
        /// <item><description>If <b>LoadBalanceType</b> is <b>clb</b>, use this field to configure the HTTPS listener certificate.</description></item>
        /// </list>
        /// <para>For more information about using SSL certificate IDs with CLB, see <a href="">Manage Certificates (CLB)</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>188077086902****_176993d****_181437****_108724****</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para><b>ALB</b> multiple certificate IDs. Details are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>LoadBalanceType</b> is <b>alb</b>, use this field to configure multiple HTTPS listener certificates. Separate multiple certificate IDs with commas.</para>
        /// </description></item>
        /// <item><description><para>Obtain the SSL certificate ID used by ALB from the digital certificate product. For example, configure <c>756***-cn-hangzhou</c>, where <c>756***</c> is the certificate ID obtained from the product page, and <c>-cn-hangzhou</c> is a fixed suffix. For more information, see <a href="">Manage Certificates (ALB)</a>.</para>
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
        /// <para>Cross-domain configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;Enable\&quot;:\&quot;true\&quot;}</para>
        /// </summary>
        [NameInMap("CorsConfig")]
        [Validation(Required=false)]
        public string CorsConfig { get; set; }

        /// <summary>
        /// <para>Default forwarding rule. Forward traffic to the specified application by IP address through the specified port. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>appId</b>: Application ID.</para>
        /// </description></item>
        /// <item><description><para><b>containerPort</b>: Application instance port.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>All requests that do not match or satisfy the <b>Rules</b> forwarding rule are forwarded to this specified application.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080}</para>
        /// </summary>
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public string DefaultRule { get; set; }

        /// <summary>
        /// <para>Routing rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingress-sae-test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Enable or disable data compression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableGzip")]
        [Validation(Required=false)]
        public bool? EnableGzip { get; set; }

        /// <summary>
        /// <para>Enable or disable obtaining the client IP address of the visitor through the X-Forwarded-For header field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedFor")]
        [Validation(Required=false)]
        public bool? EnableXForwardedFor { get; set; }

        /// <summary>
        /// <para>Obtain the listening port of the SLB instance through the X-Forwarded-Port header field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedForClientSrcPort")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForClientSrcPort { get; set; }

        /// <summary>
        /// <para>Specifies whether to determine the listener protocol of the SLB instance from the X-Forwarded-Proto header field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedForProto")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForProto { get; set; }

        /// <summary>
        /// <para>Obtain the SLB instance ID through the SLB-ID header field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedForSlbId")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForSlbId { get; set; }

        /// <summary>
        /// <para>Whether to obtain the listening port of the Server Load Balancer instance from the X-Forwarded-Port header field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableXForwardedForSlbPort")]
        [Validation(Required=false)]
        public bool? EnableXForwardedForSlbPort { get; set; }

        /// <summary>
        /// <para>Idle connection timeout, in seconds (s).</para>
        /// <remarks>
        /// <para>A value of 0 indicates that the default idle timeout is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>Routing rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>87</para>
        /// </summary>
        [NameInMap("IngressId")]
        [Validation(Required=false)]
        public long? IngressId { get; set; }

        /// <summary>
        /// <para>SLB listening port. This port must not be occupied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public string ListenerPort { get; set; }

        /// <summary>
        /// <para>Forwarding Protocol. Details are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP</b>: Applies to applications that need to identify data content.</para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b>: Applies to applications that need encrypted transmission.</para>
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
        /// <para>Deprecated parameter. Updates are no longer supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("LoadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        /// <summary>
        /// <para>Request timeout, in seconds (s).</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>Forwarding rules. Forward traffic to the specified application by domain name and URI of the request through the specified port. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>appId</b>: Application ID.</para>
        /// </description></item>
        /// <item><description><para><b>containerPort</b>: Application instance port.</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: Domain name.</para>
        /// </description></item>
        /// <item><description><para><b>path</b>: URI of the request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;<a href="http://www.sae.site%22,%22path%22:%22/path1%22%7D,%7B%22appId%22:%22666403ce-d25b-47cf-87fe-497565d2****%22,%22containerPort%22:8080,%22domain%22:%22sae.site%22,%22path%22:%22/path2%22%7D%5D">www.sae.site&quot;,&quot;path&quot;:&quot;/path1&quot;},{&quot;appId&quot;:&quot;666403ce-d25b-47cf-87fe-497565d2****&quot;,&quot;containerPort&quot;:8080,&quot;domain&quot;:&quot;sae.site&quot;,&quot;path&quot;:&quot;/path2&quot;}]</a></para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        /// <summary>
        /// <para>Security policy instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tls_cipher_policy_1_2_strict_with_1_3</para>
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

    }

}
