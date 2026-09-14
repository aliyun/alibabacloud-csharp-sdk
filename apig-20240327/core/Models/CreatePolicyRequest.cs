// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreatePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RateLimit: Rate limiting. Limits the request rate.</description></item>
        /// <item><description>ConcurrencyLimit: Concurrency limiting. Limits the number of concurrent requests.</description></item>
        /// <item><description>CircuitBreaker: Circuit breaker. Automatically triggers circuit breaking when backend exceptions occur.</description></item>
        /// <item><description>HttpRewrite: HTTP rewrite. Rewrites the request URL or path.</description></item>
        /// <item><description>HeaderModify: Header modification. Adds, removes, or modifies HTTP request headers.</description></item>
        /// <item><description>Cors: Cross-Origin Resource Sharing (CORS). Controls cross-origin requests.</description></item>
        /// <item><description>Authentication: General authentication. A general request authentication policy.</description></item>
        /// <item><description>FlowCopy: Traffic mirroring. Copies requests to an additional backend.</description></item>
        /// <item><description>Timeout: Timeout. Sets the request timeout period.</description></item>
        /// <item><description>Retry: Retry. Automatically retries failed requests.</description></item>
        /// <item><description>IpAccessControl: IP access control. Filters requests based on IP address whitelists and blacklists.</description></item>
        /// <item><description>DirectResponse: Direct response. Returns a fixed response directly.</description></item>
        /// <item><description>Redirect: Redirect. Redirects requests to another address.</description></item>
        /// <item><description>Fallback: Fallback. Returns a fallback response when the backend is unavailable.</description></item>
        /// <item><description>ServiceTls: Service TLS. Configures TLS for backend services.</description></item>
        /// <item><description>ServiceLb: Service load balancing. Configures load balancing for backend services.</description></item>
        /// <item><description>ServicePortTls: Service port TLS. Configures TLS for backend service ports.</description></item>
        /// <item><description>Waf: Web Application Firewall (WAF). Provides request security protection.</description></item>
        /// <item><description>JWTAuth: JWT authentication. Authenticates requests based on JSON Web Tokens (JWT).</description></item>
        /// <item><description>OIDCAuth: OIDC authentication. Authenticates requests based on the OpenID Connect (OIDC) protocol.</description></item>
        /// <item><description>ExternalZAuth: External authentication. Integrates with an external authentication service.</description></item>
        /// <item><description>AiProxy: AI proxy.</description></item>
        /// <item><description>ModelRouter: Model router.</description></item>
        /// <item><description>AiStatistics: AI statistics.</description></item>
        /// <item><description>AiSecurityGuard: AI security guard. Detects the security of AI request and response content.</description></item>
        /// <item><description>AiFallback: AI fallback. Falls back to an alternative model when the AI service is unavailable.</description></item>
        /// <item><description>ModelMapper: Model mapper.</description></item>
        /// <item><description>AiTokenRateLimit: AI token rate limiting. Limits the rate based on token consumption.</description></item>
        /// <item><description>AiCache: AI cache. Caches AI response results.</description></item>
        /// <item><description>DynamicRoute: Dynamic route.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Timeout</para>
        /// </summary>
        [NameInMap("className")]
        [Validation(Required=false)]
        public string ClassName { get; set; }

        /// <summary>
        /// <para>The policy configuration.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;unitNum&quot;:1,&quot;timeUnit&quot;:&quot;s&quot;,&quot;enable&quot;:true}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The description of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Timeout policy</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The policy name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-policy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
