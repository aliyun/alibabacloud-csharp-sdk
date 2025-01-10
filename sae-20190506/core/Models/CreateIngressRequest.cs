// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateIngressRequest : TeaModel {
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the certificate that is associated with the <b>CLB</b> instance.</para>
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
        /// <para>The IDs of the certificates that are associated with the <b>ALB</b> instance.</para>
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
        /// <para>Default forwarding rule. Traffic is forwarded to the specified application through a designated port based on the IP address. Parameter descriptions are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>appId</b>: Application ID. - <b>containerPort</b>: Application instance port.<remarks>
        /// <para>All requests that do not match or do not meet the <b>Rules</b> for forwarding will be directed to this specified application.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;appId&quot;:&quot;395b60e4-0550-458d-9c54-a265d036****&quot;,&quot;containerPort&quot;:8080}</para>
        /// </summary>
        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public string DefaultRule { get; set; }

        /// <summary>
        /// <para>Route rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingress-for-sae-test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The timeout period of an idle connection. Unit: seconds. Valid values: 1 to 60.</para>
        /// <para>If no request is received within the specified timeout period, ALB closes the current connection. When another request is received, ALB establishes a new connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// <para>SThe frontend port that is used by the ALB instance.
        /// Valid values: 1 to 65535.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>Request forwarding protocol. The value description is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP</b>: Suitable for applications that need to identify data content. - <b>HTTPS</b>: Suitable for applications that require encrypted transmission.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The type of the SLB instance. The instance type can be specified only when you create a routing rule. You cannot change the instance type when you update the routing rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>clb</b></description></item>
        /// <item><description><b>alb</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>clb</para>
        /// </summary>
        [NameInMap("LoadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        /// <summary>
        /// <para>The ID of the namespace where the application is located. Currently, cross-namespace applications are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:sae-test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The timeout period of a request. Unit: seconds. Valid values: 1 to 180.
        /// If no response is received from the backend server within the specified timeout period, ALB returns an HTTP 504 error code to the client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
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
        /// <item><description><b>backendProtocol</b>: the backend service protocol. Valid values: http, https, and grpc. Default value: http.</description></item>
        /// <item><description><b>rewritePath</b>: the rewrite path.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The path rewrite feature is supported only by ALB instances.</para>
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
        /// <para>The security policy ID.</para>
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
        /// <para> The SLB instance can be a Classic Load Balancer (CLB) instance or an Application Load Balancer (ALB) instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>lb-uf6hucc7inlqrtcq5****</para>
        /// </summary>
        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public string ZoneMappings { get; set; }

    }

}
