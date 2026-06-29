// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAndAttachPolicyRequest : TeaModel {
        /// <summary>
        /// <para>List of attachment point IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("attachResourceIds")]
        [Validation(Required=false)]
        public List<string> AttachResourceIds { get; set; }

        /// <summary>
        /// <para>Types of attachment points supported by the policy.</para>
        /// <list type="bullet">
        /// <item><description>HttpApi: HttpApi.</description></item>
        /// <item><description>Operation: Operation of HttpApi.</description></item>
        /// <item><description>GatewayRoute: Gateway route.</description></item>
        /// <item><description>GatewayService: Gateway service.</description></item>
        /// <item><description>GatewayServicePort: Gateway service port.</description></item>
        /// <item><description>Domain: Gateway domain.</description></item>
        /// <item><description>Gateway: Gateway.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HttpApi</para>
        /// </summary>
        [NameInMap("attachResourceType")]
        [Validation(Required=false)]
        public string AttachResourceType { get; set; }

        /// <summary>
        /// <para>The class name types supported by the policy. Different policies support different attachment points, to be used in conjunction with <c>attachResourceType</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>RateLimit: Traffic control, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>ConcurrencyLimit: Concurrency control, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>CircuitBreaker: Circuit breaking and degradation, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>HttpRewrite: HTTP rewrite, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>HeaderModify: Header modification, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>Cors: Cross-origin, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>FlowCopy: Traffic replication, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>Timeout: Timeout, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>Retry: Retry, supports HttpApi, Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>IpAccessControl: IP access control, supports HttpApi, Operation, GatewayRoute, Domain, Gateway.</para>
        /// </description></item>
        /// <item><description><para>DirectResponse: Mock, supports Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>Redirect: Redirection, supports GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>Fallback: Fallback, supports Operation, GatewayRoute.</para>
        /// </description></item>
        /// <item><description><para>ServiceTls: Service TLS authentication, supports GatewayService.</para>
        /// </description></item>
        /// <item><description><para>ServiceLb: Service load balancing, supports GatewayService.</para>
        /// </description></item>
        /// <item><description><para>ServicePortTls: Service port TLS authentication, supports GatewayServicePort.</para>
        /// </description></item>
        /// <item><description><para>Waf: WAF protection, supports GatewayRoute, Gateway.</para>
        /// </description></item>
        /// <item><description><para>JWTAuth: JWT global authentication, supports Gateway.</para>
        /// </description></item>
        /// <item><description><para>OIDCAuth: OIDC global authentication, supports Gateway.</para>
        /// </description></item>
        /// <item><description><para>ExternalZAuth: Custom authorization, supports Gateway.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IpAccessControl</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>Configuration information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;enable\&quot;:false}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Policy description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是策略描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Gateway ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>Policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
