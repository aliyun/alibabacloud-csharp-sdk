// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateForwardingRulesRequest : TeaModel {
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
        /// <para>You can generate a client token from your client and make sure that the client token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> of each request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The forwarding rule configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ForwardingRules")]
        [Validation(Required=false)]
        public List<CreateForwardingRulesRequestForwardingRules> ForwardingRules { get; set; }
        public class CreateForwardingRulesRequestForwardingRules : TeaModel {
            /// <summary>
            /// <para>The name of the forwarding rule. The name must be 2 to 128 characters long. It must start with a letter or a Chinese character, and can contain letters, Chinese characters, digits, periods (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            /// <summary>
            /// <para>The priority of the forwarding rule.
            /// Valid values: <b>1</b> to <b>10000</b>. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The rule actions.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<CreateForwardingRulesRequestForwardingRulesRuleActions> RuleActions { get; set; }
            public class CreateForwardingRulesRequestForwardingRulesRuleActions : TeaModel {
                /// <summary>
                /// <para>The forwarding configuration.</para>
                /// <remarks>
                /// <para>This parameter is deprecated. We recommend that you use <b>RuleActionType</b> and <b>RuleActionValue</b> to configure rule actions.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The endpoint group configuration.</para>
                    /// <remarks>
                    /// <para>This parameter is deprecated. We recommend that you use <b>RuleActionType</b> and <b>RuleActionValue</b> to configure rule actions.</para>
                    /// </remarks>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The ID of the endpoint group.</para>
                        /// <remarks>
                        /// <para>This parameter is deprecated. We recommend that you use <b>RuleActionType</b> and <b>RuleActionValue</b> to configure rule actions.</para>
                        /// </remarks>
                        /// <para>This parameter is required.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>epg-bp1nktp3qgbcq9ih6****</para>
                        /// </summary>
                        [NameInMap("EndpointGroupId")]
                        [Validation(Required=false)]
                        public string EndpointGroupId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The priority of the action.</para>
                /// <remarks>
                /// <para>This parameter is not in use and can be ignored.</para>
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
                /// <para>The type of the rule action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ForwardGroup</b>: Forwards requests.</para>
                /// </description></item>
                /// <item><description><para><b>Redirect</b>: Redirects requests.</para>
                /// </description></item>
                /// <item><description><para><b>FixResponse</b>: Returns a fixed response.</para>
                /// </description></item>
                /// <item><description><para><b>Rewrite</b>: Rewrites requests.</para>
                /// </description></item>
                /// <item><description><para><b>AddHeader</b>: Adds a header.</para>
                /// </description></item>
                /// <item><description><para><b>RemoveHeader</b>: Removes a header.</para>
                /// </description></item>
                /// <item><description><para><b>Drop</b>: Drops requests.</para>
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
                /// <para>The value for the rule action.</para>
                /// <para>This is a JSON-formatted string whose structure depends on the specified <b>RuleActionType</b>.</para>
                /// <para>A forwarding rule can have at most one action of type <b>ForwardGroup</b>, <b>Redirect</b>, or <b>FixResponse</b>. Actions of type <b>Rewrite</b>, <b>AddHeader</b>, and <b>RemoveHeader</b> must be specified before a <b>ForwardGroup</b> action.</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>ForwardGroup</b>, this parameter specifies the endpoint group. You can forward requests to only one endpoint group. Example: <c>{&quot;type&quot;:&quot;endpointgroup&quot;, &quot;value&quot;:&quot;epg-bp1enpdcrqhl78g6r****&quot;}</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>type</c>: Set the value to<c> endpointgroup</c>.</para>
                /// </description></item>
                /// <item><description><para><c>value</c>: The ID of the target endpoint group.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>Redirect</b>, this parameter specifies the redirect configuration. At least one of the <c>protocol</c>, <c>domain</c>, <c>port</c>, <c>path</c>, or <c>query</c> fields must be set to a value other than its default. Example: <c>{&quot;protocol&quot;:&quot;HTTP&quot;, &quot;domain&quot;:&quot;www.example.com&quot;, &quot;port&quot;:&quot;80&quot;, &quot;path&quot;:&quot;/a&quot;,&quot;query&quot;:&quot;value1&quot;, &quot;code&quot;:&quot;301&quot; }</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>protocol</c>: The protocol for the redirect. Valid values: <c>${protocol}</c> (default), <c>HTTP</c>, and <c>HTTPS</c>.</para>
                /// </description></item>
                /// <item><description><para><c>domain</c>: The domain name for the redirect. The default value is <c>${host}</c>. You can also specify another domain name. A domain name must be 3 to 128 characters long and can contain only lowercase letters, digits, and the following special characters:<c> .-=~_-+/^*!$&amp;()[]?</c>.</para>
                /// </description></item>
                /// <item><description><para><c>port</c>: The port for the redirect. The default value is <c>${port}</c>. You can also specify a port number. Valid values: 1 to 63335.</para>
                /// </description></item>
                /// <item><description><para><c>path</c>: The path for the redirect. The default value is <c>${path}</c>. The path must be 1 to 128 characters long. For a regular expression path, it must start with a tilde (\<del>) and can contain uppercase and lowercase letters, digits, and the following special characters:` .-_/=?</del>^*$:()[]+<c>. For a non-regular expression path, it must start with a forward slash (/) and can contain uppercase and lowercase letters, digits, and the following special characters:</c> .-_/=:?`.</para>
                /// </description></item>
                /// <item><description><para><c>query</c>: The query string for the redirect. The default value is <c>${query}</c>. You can also specify another query string. The query string must be 1 to 128 characters long and contain only printable characters within the ASCII range of<c> ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. Letters must be lowercase. Spaces and the following special characters are not supported:<c> []{}&lt;&gt;\\#&amp;</c>.</para>
                /// </description></item>
                /// <item><description><para><c>code</c>: The redirect code. Valid values: <c>301</c>, <c>302</c>, <c>303</c>, <c>307</c>, and <c>308</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>FixResponse</b>, this parameter specifies the fixed response configuration. Example: <c>{&quot;code&quot;:&quot;200&quot;, &quot;type&quot;:&quot;text/plain&quot;, &quot;content&quot;:&quot;dssacav&quot; }</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>code</c>: The response status code. The value must be a numeric string in the <c>2xx</c>, <c>4xx</c>, or <c>5xx</c> format, where <c>x</c> is any digit.</para>
                /// </description></item>
                /// <item><description><para><c>type</c>: The content type of the response body. Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                /// </description></item>
                /// <item><description><para><c>content</c>: The content of the response body. The content cannot exceed 1,000 characters and does not support Chinese characters.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>AddHeader</b>, this parameter specifies the configuration for adding an HTTP header. If a forwarding rule contains an <b>AddHeader</b> action, it must also contain a <b>ForwardGroup</b> action. Example: <c>[{&quot;name&quot;:&quot;header1&quot;,&quot;type&quot;:&quot;user-defined&quot;, &quot;value&quot;:&quot;value&quot;}]</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>name</c>: The name of the HTTP header. The name must be 1 to 40 characters long and can contain uppercase and lowercase letters, digits, hyphens (-), and underscores (_). The header names in <b>AddHeader</b> actions must be unique and cannot be the same as any header name in a <b>RemoveHeader</b> action.</para>
                /// </description></item>
                /// <item><description><para><c>type</c>: The type of the header value. Valid values: <c>user-defined</c>, <c>ref</c> (reference), and <c>system-defined</c>.</para>
                /// </description></item>
                /// <item><description><para><c>value</c>: The content of the HTTP header. This field cannot be empty. If <c>type</c> is <c>user-defined</c>, the value must be 1 to 128 characters long and contain only printable characters within the ASCII range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The value can contain uppercase and lowercase letters, digits, hyphens (-), and underscores (<em>), and cannot start or end with a space. If <c>type</c> is <c>ref</c>, the value must be 1 to 128 characters long and can contain uppercase and lowercase letters, digits, hyphens (-), and underscores (</em>). The value cannot start or end with a space. If <c>type</c> is <c>system-defined</c>, the only valid value is <c>ClientSrcIp</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>RemoveHeader</b>, this parameter specifies the HTTP headers to remove. If a forwarding rule contains a <b>RemoveHeader</b> action, it must also contain a <b>ForwardGroup</b> action. The value must be 1 to 40 characters long and can contain uppercase and lowercase letters, digits, hyphens (-), and underscores (_). Example: <c>[&quot;header1&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>Rewrite</b>, this parameter specifies the rewrite configuration. If a forwarding rule contains a <b>Rewrite</b> action, it must also contain a <b>ForwardGroup</b> action. Example: <c>{&quot;domain&quot;:&quot;value1&quot;, &quot;path&quot;:&quot;value2&quot;, &quot;query&quot;:&quot;value3&quot;}</c>, where:</para>
                /// <list type="bullet">
                /// <item><description><para><c>domain</c>: The domain name to rewrite. The default value is <c>${host}</c>. You can also specify another domain name. A domain name must be 3 to 128 characters long and can contain only lowercase letters, digits, and the following special characters:<c> .-=~_-+/^*!$&amp;()[]?</c>.</para>
                /// </description></item>
                /// <item><description><para><c>path</c>: The path to rewrite. The default value is <c>${path}</c>. The path must be 1 to 128 characters long. For a regular expression path, it must start with a tilde (\<del>) and can contain uppercase and lowercase letters, digits, and the following special characters:` .-_/=?</del>^*$:()[]+<c>. For a non-regular expression path, it must start with a forward slash (/) and can contain uppercase and lowercase letters, digits, and the following special characters:</c> .-_/=:?`.</para>
                /// </description></item>
                /// <item><description><para><c>query</c>: The query string to rewrite. The default value is <c>${query}</c>. You can also specify another query string. The query string must be 1 to 128 characters long and contain only printable characters within the ASCII range of<c> ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. Letters must be lowercase. Spaces and the following special characters are not supported:<c> []{}&lt;&gt;\\#&amp;</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>Drop</b>, you do not need to specify a value for this parameter.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;type&quot;:&quot;endpointgroup&quot;,&quot;value&quot;:&quot;epg-bp1l49ltx6iengvf2ks5z****&quot;}]</para>
                /// </summary>
                [NameInMap("RuleActionValue")]
                [Validation(Required=false)]
                public string RuleActionValue { get; set; }

            }

            /// <summary>
            /// <para>The rule conditions.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<CreateForwardingRulesRequestForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class CreateForwardingRulesRequestForwardingRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The domain name configuration.</para>
                /// <remarks>
                /// <para>This parameter is deprecated. We recommend that you use <b>RuleConditionType</b> and <b>RuleConditionValue</b> to configure rule conditions.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public CreateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class CreateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// <para>The domain name configuration.</para>
                    /// <remarks>
                    /// <para>This parameter is deprecated. We recommend that you use <b>RuleConditionType</b> and <b>RuleConditionValue</b> to configure rule conditions.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The path configuration.</para>
                /// <remarks>
                /// <para>This parameter is deprecated. We recommend that you use <b>RuleConditionType</b> and <b>RuleConditionValue</b> to configure rule conditions.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public CreateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class CreateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The path configuration.</para>
                    /// <para>A path must be 1 to 128 characters long and must start with a forward slash (/). It can contain letters, digits, dollar signs ($), hyphens (-), underscores (_), periods (.), plus signs (+), forward slashes (/), ampersands (&amp;), tildes (\~), at signs (@), colons (:), and apostrophes (\&quot;). You can use asterisks (\*) and question marks (?) as wildcards.</para>
                    /// <remarks>
                    /// <para>This parameter is deprecated. We recommend that you use <b>RuleConditionType</b> and <b>RuleConditionValue</b> to configure rule conditions.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The type of the rule condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Host</b>: Matches requests by domain name.</para>
                /// </description></item>
                /// <item><description><para><b>Path</b>: Matches requests by path.</para>
                /// </description></item>
                /// <item><description><para><b>RequestHeader</b>: Matches requests by HTTP header.</para>
                /// </description></item>
                /// <item><description><para><b>Query</b>: Matches requests by query string.</para>
                /// </description></item>
                /// <item><description><para><b>Method</b>: Matches requests by HTTP method.</para>
                /// </description></item>
                /// <item><description><para><b>Cookie</b>: Matches requests by cookie.</para>
                /// </description></item>
                /// <item><description><para><b>SourceIP</b>: Matches requests by source IP address.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Host</para>
                /// </summary>
                [NameInMap("RuleConditionType")]
                [Validation(Required=false)]
                public string RuleConditionType { get; set; }

                /// <summary>
                /// <para>The value of the rule condition.
                /// This is a JSON-formatted string whose structure depends on the specified <b>RuleConditionType</b>.</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Host</b>, this parameter specifies the domain name conditions. A forwarding rule can have only one <b>Host</b> rule condition. This rule condition can contain multiple domain names, which are evaluated with a logical OR. A domain name must be 3 to 128 characters long and can contain letters, digits, hyphens (-), and periods (.). You can use asterisks (\*) and question marks (?) as wildcards. Example: <c>[&quot;www.example.com&quot;, &quot;www.aliyun.com&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Path</b>, this parameter specifies the path conditions. A forwarding rule can have multiple <b>Path</b> rule conditions, which are evaluated with a logical OR. Each path rule condition can contain multiple paths, which are also evaluated with a logical OR. A path must be 1 to 128 characters long and must start with a forward slash (/). It can contain letters, digits, dollar signs ($), hyphens (-), underscores (_), periods (.), plus signs (+), forward slashes (/), ampersands (&amp;), tildes (\~), at signs (@), colons (:), and apostrophes (\&quot;). You can use asterisks (\*) and question marks (?) as wildcards. Example: <c>[&quot;/a&quot;, &quot;/b/&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>RequestHeader</b>, this parameter specifies the HTTP header conditions. The value is a key-value pair. The header values within the same rule condition must be unique. Example: <c>[{&quot;header1&quot;:[&quot;value1&quot;,&quot;value2&quot;]}]</c>.</para>
                /// <list type="bullet">
                /// <item><description><para>Key: The HTTP header key must be 1 to 40 characters long and can contain letters, digits, hyphens (-), and underscores (_).</para>
                /// </description></item>
                /// <item><description><para>Value: The HTTP header value must be 1 to 128 characters long and contain only printable characters within the ASCII range of<c> ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The value cannot start or end with a space.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Query</b>, this parameter specifies the query string conditions. The value is a key-value pair. Example: <c>[{&quot;query1&quot;:[&quot;value1&quot;]}, {&quot;query2&quot;:[&quot;value2&quot;]}]</c>.</para>
                /// <list type="bullet">
                /// <item><description><para>Key: The key must be 1 to 100 characters long and contain only printable characters within the ASCII range of<c> ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. Letters must be lowercase. Spaces and the following characters are not supported:<c> []{}&lt;&gt;\\;/?:@&amp;=+,$%&quot;^~</c>.</para>
                /// </description></item>
                /// <item><description><para>Value: The value must be 1 to 128 characters long and contain only printable characters within the ASCII range of<c> ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. Letters must be lowercase. Spaces and the following characters are not supported:<c> []{}&lt;&gt;\\;/?:@&amp;=+,$%&quot;^~</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Method</b>, this parameter specifies the HTTP method conditions. Valid values: <b>HEAD</b>, <b>GET</b>, <b>POST</b>, <b>OPTIONS</b>, <b>PUT</b>, <b>PATCH</b>, and <b>DELETE</b>. Example: <c>[&quot;GET&quot;, &quot;OPTIONS&quot;, &quot;POST&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Cookie</b>, this parameter specifies the cookie conditions. The value is a key-value pair. Example: <c>[{&quot;cookie1&quot;:[&quot;value1&quot;]}, {&quot;cookie2&quot;:[&quot;value2&quot;]}]</c></para>
                /// <list type="bullet">
                /// <item><description><para>Key: The cookie key must be 1 to 100 characters long and contain only printable characters within the ASCII range of<c> ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. Letters must be lowercase. Spaces and the following characters are not supported:<c> #[]{}\\&lt;&gt;&amp;</c>.</para>
                /// </description></item>
                /// <item><description><para>Value: The cookie value must be 1 to 128 characters long and contain only printable characters within the ASCII range of<c> ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. Letters must be lowercase. Spaces and the following characters are not supported:<c> #[]{}\\&lt;&gt;&amp;</c>.</para>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>SourceIP</b>, this parameter specifies the source IP conditions. You can specify IP addresses, for example, <c>1.1.XX.XX/32</c>, or CIDR blocks, for example, <c>2.2.XX.XX/24</c>. A forwarding rule can have only one <b>SourceIP</b> rule condition. This rule condition can contain multiple source IP addresses, which are evaluated with a logical OR. Example: <c>[&quot;1.1.XX.XX/32&quot;, &quot;2.2.XX.XX/24&quot;]</c>.</para>
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
            /// <para>The direction in which the rule takes effect. This parameter does not need to be configured.</para>
            /// <para>By default, this parameter is set to <b>request</b>, which indicates that the rule applies to requests.</para>
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
        /// <para>The ID of the region where the Global Accelerator instance is deployed. The only valid value is <b>cn-hangzhou</b>.</para>
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
