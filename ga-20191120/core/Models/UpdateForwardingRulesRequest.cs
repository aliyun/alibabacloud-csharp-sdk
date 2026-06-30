// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateForwardingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Global Accelerator instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4q****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>client token</b>. The <b>RequestId</b> of each request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configurations of the forwarding rules.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<UpdateForwardingRulesRequestForwardingRules> ForwardingRules { get; set; }
        public class UpdateForwardingRulesRequestForwardingRules : TeaModel {
            /// <summary>
            /// <para>The ID of the forwarding rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>frule-bp1dii16gu9qdvb34****</para>
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

            /// <summary>
            /// <para>The name of the forwarding rule.</para>
            /// <para>The name must be 2 to 128 characters in length, start with a letter or a Chinese character, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            /// <summary>
            /// <para>The priority of the forwarding rule. A smaller value indicates a higher priority. Valid values: <b>1</b> to <b>10000</b>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The actions that are performed when the forwarding conditions are met.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<UpdateForwardingRulesRequestForwardingRulesRuleActions> RuleActions { get; set; }
            public class UpdateForwardingRulesRequestForwardingRulesRuleActions : TeaModel {
                /// <summary>
                /// <para>The forwarding configuration.</para>
                /// <remarks>
                /// <para>This parameter is deprecated. We recommend that you use the <b>RuleActionType</b> and <b>RuleActionValue</b> parameters.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The endpoint group configuration.</para>
                    /// <remarks>
                    /// <para>This parameter is deprecated. We recommend that you use the <b>RuleActionType</b> and <b>RuleActionValue</b> parameters.</para>
                    /// </remarks>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The ID of the endpoint group.</para>
                        /// <remarks>
                        /// <para>This parameter is deprecated. We recommend that you use the <b>RuleActionType</b> and <b>RuleActionValue</b> parameters.</para>
                        /// </remarks>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>epg-bp1ieei9664r5nv****</para>
                        /// </summary>
                        [NameInMap("EndpointGroupId")]
                        [Validation(Required=false)]
                        public string EndpointGroupId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The priority of the action.</para>
                /// <remarks>
                /// <para>This parameter is not in use. You do not need to specify this parameter.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The type of the action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ForwardGroup</b>: forwards a request to an endpoint group.</para>
                /// </description></item>
                /// <item><description><para><b>Redirect</b>: redirects a request.</para>
                /// </description></item>
                /// <item><description><para><b>FixResponse</b>: returns a fixed response.</para>
                /// </description></item>
                /// <item><description><para><b>Rewrite</b>: rewrites a request.</para>
                /// </description></item>
                /// <item><description><para><b>AddHeader</b>: adds a header to a request.</para>
                /// </description></item>
                /// <item><description><para><b>RemoveHeader</b>: removes a header from a request.</para>
                /// </description></item>
                /// <item><description><para><b>Drop</b>: drops a request.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForwardGroup</para>
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// <para>The value of the action.</para>
                /// <para>The value is a JSON string that varies based on the value of <b>RuleActionType</b>.</para>
                /// <para>A forwarding rule can have at most one action of the <b>ForwardGroup</b>, <b>Redirect</b>, or <b>FixResponse</b> type. The <c>Rewrite</c>, <c>AddHeader</c>, and <c>RemoveHeader</c> actions must precede a <c>ForwardGroup</c> action.</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>ForwardGroup</b>, this parameter specifies the endpoint group configuration. You can forward requests to only one endpoint group. Example: <c>{&quot;type&quot;:&quot;endpointgroup&quot;, &quot;value&quot;:&quot;epg-bp1enpdcrqhl78g6r****&quot;}</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>type</c>: Set the value to <c>endpointgroup</c>.</para>
                /// </description></item>
                /// <item><description><para><c>value</c>: The ID of the destination endpoint group.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>Redirect</b>, this parameter specifies the redirect configuration. In a <b>Redirect</b> action, at least one of the following fields must be specified with a non-default value: <c>protocol</c>, <c>domain</c>, <c>port</c>, <c>path</c>, or <c>query</c>. Example: <c>{&quot;protocol&quot;:&quot;HTTP&quot;, &quot;domain&quot;:&quot;www.example.com&quot;, &quot;port&quot;:&quot;80&quot;, &quot;path&quot;:&quot;/a&quot;,&quot;query&quot;:&quot;value1&quot;, &quot;code&quot;:&quot;301&quot; }</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>protocol</c>: The protocol to which requests are redirected. Valid values: <c>${protocol}</c> (default), <c>HTTP</c>, and <c>HTTPS</c>.</para>
                /// </description></item>
                /// <item><description><para><c>domain</c>: The domain to which requests are redirected. The default value is <c>${host}</c>. You can also specify another domain. The domain must be 3 to 128 characters in length and can contain only lowercase letters, digits, and the following special characters: <c>.-?=~_-+/^*!$&amp;|()[]</c>.</para>
                /// </description></item>
                /// <item><description><para><c>port</c>: The port to which requests are redirected. The default value is <c>${port}</c>. You can also specify another port. Valid values: 1 to 63335.</para>
                /// </description></item>
                /// <item><description><para><c>path</c>: The path to which requests are redirected. The default value is <c>${path}</c>. The path must be 1 to 128 characters in length. A regular expression-based path must start with a tilde (\<del>) and can contain letters, digits, and the following special characters: `.-_/=?</del>^*$:()[]+|<c>. A path that is not a regular expression must start with a forward slash (/) and can contain letters, digits, and the following special characters: </c>.-_/=?:`.</para>
                /// </description></item>
                /// <item><description><para><c>query</c>: The query string to which requests are redirected. The default value is <c>${query}</c>. You can also specify another query string. The query string must be 1 to 128 characters in length and can contain printable ASCII characters whose character codes are in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The letters must be in lowercase. Spaces and the following characters are not allowed: <c>[]{}&lt;&gt;\\#|&amp;</c>.</para>
                /// </description></item>
                /// <item><description><para><c>code</c>: The redirect type. Valid values: <c>301</c>, <c>302</c>, <c>303</c>, <c>307</c>, and <c>308</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>FixResponse</b>, this parameter specifies the fixed response configuration. Example: <c>{&quot;code&quot;:&quot;200&quot;, &quot;type&quot;:&quot;text/plain&quot;, &quot;content&quot;:&quot;dssacav&quot; }</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>code</c>: The HTTP status code. You can specify a numeric string that represents a <c>2xx</c>, <c>4xx</c>, or <c>5xx</c> status code, where <c>x</c> indicates a digit.</para>
                /// </description></item>
                /// <item><description><para><c>type</c>: The content type of the response body. Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                /// </description></item>
                /// <item><description><para><c>content</c>: The content of the response body. The content can be up to 1,024 characters in length and cannot contain Chinese characters.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>AddHeader</b>, this parameter specifies the configuration for adding an HTTP header. An <b>AddHeader</b> action must be used together with a <b>ForwardGroup</b> action. Example: <c>[{&quot;name&quot;:&quot;header1&quot;,&quot;type&quot;:&quot;user-defined&quot;, &quot;value&quot;:&quot;value&quot;}]</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>name</c>: The name of the HTTP header. The name must be 1 to 40 characters in length and can contain letters, digits, hyphens (-), and underscores (_). The header names specified for <b>AddHeader</b> must be unique and cannot be the same as those specified for <b>RemoveHeader</b>.</para>
                /// </description></item>
                /// <item><description><para><c>type</c>: The content type of the HTTP header. Valid values: <c>user-defined</c>, <c>ref</c> (reference), and <c>system-defined</c>.</para>
                /// </description></item>
                /// <item><description><para><c>value</c>: The content of the HTTP header. This parameter cannot be left empty. If <c>type</c> is set to <c>user-defined</c>, the content must be 1 to 128 characters in length and can contain printable ASCII characters whose character codes are in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The content can include letters, digits, hyphens (-), and underscores (<em>). The content cannot start or end with a space. If <c>type</c> is set to <c>ref</c> (reference), the content must be 1 to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (</em>). The content cannot start or end with a space. If <c>type</c> is set to <c>system-defined</c>, the only valid value is <c>ClientSrcIp</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>RemoveHeader</b>, this parameter specifies the configuration for removing an HTTP header. A <b>RemoveHeader</b> action must be used together with a <b>ForwardGroup</b> action. The header name must be 1 to 40 characters in length and can contain letters, digits, hyphens (-), and underscores (_). Example: <c>[&quot;header1&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>Rewrite</b>, this parameter specifies the rewrite configuration. A <b>Rewrite</b> action must be used together with a <b>ForwardGroup</b> action. Example: <c>{&quot;domain&quot;:&quot;value1&quot;, &quot;path&quot;:&quot;value2&quot;, &quot;query&quot;:&quot;value3&quot;}</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>domain</c>: The domain to which requests are rewritten. The default value is <c>${host}</c>. You can also specify another domain. The domain must be 3 to 128 characters in length and can contain only lowercase letters, digits, and the following special characters: <c>.-?=~_-+/^*!$&amp;|()[]</c>.</para>
                /// </description></item>
                /// <item><description><para><c>path</c>: The path to which requests are rewritten. The default value is <c>${path}</c>. The path must be 1 to 128 characters in length. A regular expression-based path must start with a tilde (\<del>) and can contain letters, digits, and the following special characters: `.-_/=?</del>^*$:()[]+|<c>. A path that is not a regular expression must start with a forward slash (/) and can contain letters, digits, and the following special characters: </c>.-_/=?:`.</para>
                /// </description></item>
                /// <item><description><para><c>query</c>: The query string to which requests are rewritten. The default value is <c>${query}</c>. You can also specify another query string. The query string must be 1 to 128 characters in length and can contain printable ASCII characters whose character codes are in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The letters must be in lowercase. Spaces and the following characters are not allowed: <c>[]{}&lt;&gt;\\#|&amp;</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>Drop</b>, you do not need to specify this parameter.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;type&quot;:&quot;endpointgroup&quot;, &quot;value&quot;:&quot;epg-bp1enpdcrqhl78g6r****&quot;}]</para>
                /// </summary>
                [NameInMap("RuleActionValue")]
                [Validation(Required=false)]
                public string RuleActionValue { get; set; }

            }

            /// <summary>
            /// <para>The forwarding conditions.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<UpdateForwardingRulesRequestForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class UpdateForwardingRulesRequestForwardingRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The domain configuration.</para>
                /// <remarks>
                /// <para>This parameter is deprecated. We recommend that you use the <b>RuleConditionType</b> and <b>RuleConditionValue</b> parameters.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// <para>The domain configuration.</para>
                    /// <remarks>
                    /// <para>This parameter is deprecated. We recommend that you use the <b>RuleConditionType</b> and <b>RuleConditionValue</b> parameters.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The path configuration.</para>
                /// <remarks>
                /// <para>This parameter is deprecated. We recommend that you use the <b>RuleConditionType</b> and <b>RuleConditionValue</b> parameters.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The path configuration.</para>
                    /// <remarks>
                    /// <para>This parameter is deprecated. We recommend that you use the <b>RuleConditionType</b> and <b>RuleConditionValue</b> parameters.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The type of the forwarding condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Host</b>: matches a request based on its domain name.</para>
                /// </description></item>
                /// <item><description><para><b>Path</b>: matches a request based on its path.</para>
                /// </description></item>
                /// <item><description><para><b>RequestHeader</b>: matches a request based on its HTTP header.</para>
                /// </description></item>
                /// <item><description><para><b>Query</b>: matches a request based on its query string.</para>
                /// </description></item>
                /// <item><description><para><b>Method</b>: matches a request based on its HTTP request method.</para>
                /// </description></item>
                /// <item><description><para><b>Cookie</b>: matches a request based on its cookie.</para>
                /// </description></item>
                /// <item><description><para><b>SourceIP</b>: matches a request based on its source IP address.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Host</para>
                /// </summary>
                [NameInMap("RuleConditionType")]
                [Validation(Required=false)]
                public string RuleConditionType { get; set; }

                /// <summary>
                /// <para>The value of the forwarding condition.
                /// The value is a JSON string that varies based on the value of <b>RuleConditionType</b>.</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Host</b>, this parameter specifies the domain configuration. A forwarding rule can contain only one Host-based rule condition. The condition can contain multiple domains that are evaluated with a logical OR. A domain must be 3 to 128 characters in length and can contain letters, digits, hyphens (-), and periods (.). You can use asterisks (\*) and question marks (?) as wildcards. Example: <c>[&quot;www.example.com&quot;, &quot;www.aliyun.com&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Path</b>, this parameter specifies the path configuration. A forwarding rule can contain multiple path-based rule conditions, which are evaluated with a logical OR. Each condition can contain multiple paths, which are also evaluated with a logical OR. A path must be 1 to 128 characters in length, start with a forward slash (/), and contain only letters, digits, and the following special characters: <c>$</c>, <c>-</c>, <c>_</c>, <c>.</c>, <c>+</c>, <c>/</c>, <c>&amp;</c>, <c>~</c>, <c>@</c>, <c>:</c>, and <c>\\&quot;</c>. You can use asterisks (\*) and question marks (?) as wildcards. Example: <c>[&quot;/a&quot;, &quot;/b/&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>RequestHeader</b>, this parameter specifies the HTTP header configuration, which consists of key-value pairs. The values for a specific header must be unique. Example: <c>[{&quot;header1&quot;:[&quot;value1&quot;,&quot;value2&quot;]}]</c>.</para>
                /// <list type="bullet">
                /// <item><description><para>Key: The key of the HTTP header. The key must be 1 to 40 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
                /// </description></item>
                /// <item><description><para>Value: The value of the HTTP header. The value must be 1 to 128 characters in length and can contain printable ASCII characters whose character codes are in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The value cannot start or end with a space.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Query</b>, this parameter specifies the query string configuration, which consists of key-value pairs. Example: <c>[{&quot;query1&quot;:[&quot;value1&quot;]}, {&quot;query2&quot;:[&quot;value2&quot;]}]</c>.</para>
                /// <list type="bullet">
                /// <item><description><para>Key: The key of the query string. The key must be 1 to 100 characters in length and can contain printable ASCII characters whose character codes are in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The letters must be in lowercase. Spaces and the following characters are not allowed: <c>[]{}&lt;&gt;\\;/?:@&amp;=+,$%|&quot;^~</c>.</para>
                /// </description></item>
                /// <item><description><para>Value: The value of the query string. The value must be 1 to 128 characters in length and can contain printable ASCII characters whose character codes are in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The letters must be in lowercase. Spaces and the following characters are not allowed: <c>[]{}&lt;&gt;\\;/?:@&amp;=+,$%|&quot;^~</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Method</b>, this parameter specifies the HTTP request method configuration. Valid values: <b>HEAD</b>, <b>GET</b>, <b>POST</b>, <b>OPTIONS</b>, <b>PUT</b>, <b>PATCH</b>, and <b>DELETE</b>. Example: <c>[&quot;GET&quot;, &quot;OPTIONS&quot;, &quot;POST&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Cookie</b>, this parameter specifies the cookie configuration, which consists of key-value pairs. Example: <c>[{&quot;cookie1&quot;:[&quot;value1&quot;]}, {&quot;cookie2&quot;:[&quot;value2&quot;]}]</c></para>
                /// <list type="bullet">
                /// <item><description><para>Key: The key of the cookie. The key must be 1 to 100 characters in length and can contain printable ASCII characters whose character codes are in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The letters must be in lowercase. Spaces and the following characters are not allowed: <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
                /// </description></item>
                /// <item><description><para>Value: The value of the cookie. The value must be 1 to 128 characters in length and can contain printable ASCII characters whose character codes are in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The letters must be in lowercase. Spaces and the following characters are not allowed: <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>SourceIP</b>, this parameter specifies the source IP configuration. You can specify IP addresses such as 1.1.XX.XX/32 or CIDR blocks such as 2.2.XX.XX/24. A forwarding rule can contain only one source IP-based rule condition, which can contain multiple source IP addresses or CIDR blocks that are evaluated with a logical OR. Example: <c>[&quot;1.1.XX.XX/32&quot;, &quot;2.2.XX.XX/24&quot;]</c>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;<a href="http://www.example.com">www.example.com</a>&quot;, &quot;<a href="http://www.aliyun.com%22%5D">www.aliyun.com&quot;]</a></para>
                /// </summary>
                [NameInMap("RuleConditionValue")]
                [Validation(Required=false)]
                public string RuleConditionValue { get; set; }

            }

            /// <summary>
            /// <para>The direction of the rule. You do not need to specify this parameter.</para>
            /// <para>This parameter is set to <b>request</b> by default, which indicates that the rule applies to inbound requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>request</para>
            /// </summary>
            [NameInMap("RuleDirection")]
            [Validation(Required=false)]
            public string RuleDirection { get; set; }

        }

        /// <summary>
        /// <para>The ID of the listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1s0vzbi5bxlx5****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Global Accelerator instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
