// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PolicyInfo : TeaModel {
        /// <summary>
        /// <para>The mount information.</para>
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// <para>The policy class alias.</para>
        /// </summary>
        [NameInMap("classAlias")]
        [Validation(Required=false)]
        public string ClassAlias { get; set; }

        /// <summary>
        /// <para>The class name supported by the policy. Different policies support different mount points. This parameter is used in combination with AttachResourceType.</para>
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
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The policy configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:false}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The direction of traffic on which the policy takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OutBound</description></item>
        /// <item><description>InBound</description></item>
        /// <item><description>Both</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>InBound</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The execution priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>310</para>
        /// </summary>
        [NameInMap("executePriority")]
        [Validation(Required=false)]
        public string ExecutePriority { get; set; }

        /// <summary>
        /// <para>The execution phase.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PluginStatistic</description></item>
        /// <item><description>PluginAuthorization</description></item>
        /// <item><description>PluginPre</description></item>
        /// <item><description>PluginAuthentication</description></item>
        /// <item><description>PluginDefault</description></item>
        /// <item><description>PluginPost</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PluginPost</para>
        /// </summary>
        [NameInMap("executeStage")]
        [Validation(Required=false)]
        public string ExecuteStage { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-policy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The policy ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>p-cq7l5s5lhtgi6qasrdc0</para>
        /// </summary>
        [NameInMap("policyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The policy type.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
