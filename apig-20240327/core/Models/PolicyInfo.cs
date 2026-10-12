// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PolicyInfo : TeaModel {
        /// <summary>
        /// <para>The list of mount information.</para>
        /// </summary>
        [NameInMap("attachments")]
        [Validation(Required=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// <para>The policy class alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Throttling</para>
        /// </summary>
        [NameInMap("classAlias")]
        [Validation(Required=false)]
        public string ClassAlias { get; set; }

        /// <summary>
        /// <para>The class name supported by the policy. Different policies support different mount points. This parameter is used together with AttachResourceType. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RateLimit: throttling. Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>ConcurrencyLimit: concurrency control. Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>CircuitBreaker: circuit breaking. Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>HttpRewrite: HTTP rewrite. Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>HeaderModify: header modification. Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>Cors: cross-origin resource sharing (CORS). Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>FlowCopy: traffic copy. Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>Timeout: timeout. Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>Retry: retry. Supported for HttpApi, Operation, and GatewayRoute.</description></item>
        /// <item><description>IpAccessControl: IP access control. Supported for HttpApi, Operation, GatewayRoute, Domain, and Gateway.</description></item>
        /// <item><description>DirectResponse: mock. Supported for Operation and GatewayRoute.</description></item>
        /// <item><description>Redirect: redirect. Supported for GatewayRoute.</description></item>
        /// <item><description>Fallback: fallback. Supported for Operation and GatewayRoute.</description></item>
        /// <item><description>ServiceTls: service TLS authentication. Supported for GatewayService.</description></item>
        /// <item><description>ServiceLb: service load balancing. Supported for GatewayService.</description></item>
        /// <item><description>ServicePortTls: service port TLS authentication. Supported for GatewayServicePort.</description></item>
        /// <item><description>Waf: WAF protection. Supported for GatewayRoute and Gateway.</description></item>
        /// <item><description>JWTAuth: JWT global authentication. Supported for Gateway.</description></item>
        /// <item><description>OIDCAuth: OIDC global authentication. Supported for Gateway.</description></item>
        /// <item><description>ExternalZAuth: custom authentication. Supported for Gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RateLimit</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The policy configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enable&quot;:false}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The inbound or outbound direction of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OutBound: outbound.</description></item>
        /// <item><description>InBound: inbound.</description></item>
        /// <item><description>Both: both directions.</description></item>
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
        /// <para>The execution stage.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>Policy type</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
