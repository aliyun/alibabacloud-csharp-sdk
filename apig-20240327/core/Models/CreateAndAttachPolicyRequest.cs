// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateAndAttachPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the resources to be associated with the policy.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("attachResourceIds")]
        [Validation(Required=false)]
        public List<string> AttachResourceIds { get; set; }

        /// <summary>
        /// <para>The supported resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HttpApi: an HTTP API</description></item>
        /// <item><description>Operation: an operation in an HTTP API</description></item>
        /// <item><description>GatewayRoute: a route</description></item>
        /// <item><description>GatewayService: a service</description></item>
        /// <item><description>GatewayServicePort: a service port</description></item>
        /// <item><description>Domain: a domain name</description></item>
        /// <item><description>Gateway: an instance</description></item>
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
        /// <para>The class name supported by the policy. Different policies support different resources. This parameter is used in combination with AttachResourceType.</para>
        /// <list type="bullet">
        /// <item><description>RateLimit: throttles traffic. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>ConcurrencyLimit: controls concurrency. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>CircuitBreaker: breaks circuits and downgrades traffic. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>HttpRewrite: rewrites HTTP traffic. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>HeaderModify: modifies headers. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>Cors: supports CORS. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>FlowCopy: replicates traffic. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>Timeout: times out requests. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>Retry: retries requests. Supported: HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>IpAccessControl: implements IP address-based access control. Supported: HttpApi, Operation, GatewayRoute, Domain, and Gateway.</description></item>
        /// <item><description>DirectResponse: mocks responses. Supported: Operation and GatewayRoute.</description></item>
        /// <item><description>Redirect: redirects traffic. Supported: GatewayRoute.</description></item>
        /// <item><description>Fallback: implements fallback. Supported: Operation and GatewayRoute.</description></item>
        /// <item><description>ServiceTls: implements TLS authentication. Supported: GatewayService.</description></item>
        /// <item><description>ServiceLb: balances loads. Supported: GatewayService.</description></item>
        /// <item><description>ServicePortTls: implements service port TLS authentication. Supported: GatewayServicePort.</description></item>
        /// <item><description>Waf: implements WAF protection. Supported: GatewayRoute and Gateway.</description></item>
        /// <item><description>JWTAuth: implements global JWT authentication. Supported: Gateway.</description></item>
        /// <item><description>OIDCAuth: implements global OIDC authentication. Supported: Gateway.</description></item>
        /// <item><description>ExternalZAuth: implements custom authentication. Supported: Gateway.</description></item>
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
        /// <para>The policy configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;enable\&quot;:false}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The policy description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is the policy description.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
