// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateIngressRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate that is associated with the Classic Load Balancer (<b>CLB</b>) instance.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>LoadBalanceType</b> to <b>clb</b>, you can use CertId to configure a certificate for the HTTPS listener.</description></item>
        /// </list>
        /// <para>For more information about how to manage the SSL certificate IDs that are used by CLB instances, see <a href="https://help.aliyun.com/document_detail/90792.html">Overview</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>188077086902****_176993d****_181437****_108724****</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The IDs of the certificates that are associated with the Application Load Balancer (<b>ALB</b>) instance.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>LoadBalanceType</b> to <b>alb</b>, you can use CertIds to configure multiple certificates for the HTTPS listener. Separate multiple certificate IDs with commas (,).</description></item>
        /// <item><description>The ID of the SSL certificate that is used by an ALB instance can be obtained from Certificate Management Service. For example, if you specify <c>756***-cn-hangzhou</c>, <c>756***</c> is the certificate ID that is obtained from the service page, and <c>-cn-hangzhou</c> is the fixed suffix. For more information, see <a href="https://help.aliyun.com/document_detail/209076.html">Manage certificates</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>87<em><b>35-cn-hangzhou,812</b></em>3-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        /// <summary>
        /// <para>The default forwarding rule. You can specify a port and an application in the default forwarding rule to forward traffic based on the IP address. The following list describes the involved parameters:</para>
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
        /// <para>The port specified for the Server Load Balancer (SLB) listener. You must specify a vacant port.</para>
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
        /// <item><description><b>HTTP</b>: HTTP is suitable for applications that need to identify the transmitted data.</description></item>
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
        /// <para>This parameter is discontinued.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("LoadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// <para>The forwarding rules. You can specify a port and an application in a forwarding rule to forward traffic based on the specified domain name and request path. The following list describes the involved parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>appId</b>: the ID of the application.</description></item>
        /// <item><description><b>containerPort</b>: the container port of the application.</description></item>
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

        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

    }

}
