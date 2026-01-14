// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateForwardingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The GA instance ID.</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
            /// <para>The forwarding rule ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>frule-bp1dii16gu9qdvb34****</para>
            /// </summary>
            [NameInMap("ForwardingRuleId")]
            [Validation(Required=false)]
            public string ForwardingRuleId { get; set; }

            /// <summary>
            /// <para>The forwarding rule name.</para>
            /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ForwardingRuleName")]
            [Validation(Required=false)]
            public string ForwardingRuleName { get; set; }

            /// <summary>
            /// <para>The priority of the forwarding rule. Valid values: <b>1</b> to <b>10000</b>. A smaller value specifies a higher priority.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The configurations of the forwarding actions.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<UpdateForwardingRulesRequestForwardingRulesRuleActions> RuleActions { get; set; }
            public class UpdateForwardingRulesRequestForwardingRulesRuleActions : TeaModel {
                /// <summary>
                /// <para>The forwarding configuration.</para>
                /// <remarks>
                /// <para> We recommend that you use <b>RuleActionType</b> and <b>RuleActionValue</b> rather than this parameter to configure forwarding actions.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration of an endpoint group.</para>
                    /// <remarks>
                    /// <para> We recommend that you use <b>RuleActionType</b> and <b>RuleActionValue</b> rather than this parameter to configure forwarding actions.</para>
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
                        /// <para> We recommend that you use <b>RuleActionType</b> and <b>RuleActionValue</b> rather than this parameter to configure forwarding actions.</para>
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
                /// <para>The forwarding priority.</para>
                /// <remarks>
                /// <para> This parameter does not take effect. Ignore this parameter.</para>
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
                /// <para>The type of the forwarding action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroup</b>: forwards a request.</description></item>
                /// <item><description><b>Redirect</b>: redirects a request.</description></item>
                /// <item><description><b>FixResponse</b>: returns a fixed response.</description></item>
                /// <item><description><b>Rewrite</b>: rewrites a request.</description></item>
                /// <item><description><b>AddHeader</b>: adds a header to a request.</description></item>
                /// <item><description><b>RemoveHeaderConfig</b>: deletes the header of a request.</description></item>
                /// <item><description><b>Drop</b>: drops a request.</description></item>
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
                /// <para>The value of the forwarding action.</para>
                /// <para>You must specify different JSON strings based on <b>RuleActionType</b>.</para>
                /// <para>A forwarding rule can contain only one forwarding action whose type is <b>ForwardGroup</b>, <b>Redirect</b>, or <b>FixResponse</b>. You must specify a forwarding action whose type is <b>Rewrite</b>, <b>AddHeader</b>, or <b>RemoveHeader</b> before a forwarding action whose type is <b>ForwardGroup</b>.</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>ForwardGroup</b>, this parameter specifies the information of a virtual endpoint group. You can forward requests to only one virtual endpoint group. Example: <c>{&quot;type&quot;:&quot;endpointgroup&quot;, &quot;value&quot;:&quot;epg-bp1enpdcrqhl78g6r****&quot;}</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>type</c>: Set this parameter to <c>endpointgroup</c>.</description></item>
                /// <item><description><c>value</c>: Set this parameter to the ID of a virtual endpoint group.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>Redirect</b>, this parameter specifies redirecting configurations. You cannot leave the following parameters empty or use the default values for the following parameters for a forwarding action whose type is <b>Redirect</b>: <c>protocol</c>, <c>domain</c>, <c>port</c>, <c>path</c>, and <c>query</c>. Example: <c>{&quot;protocol&quot;:&quot;HTTP&quot;, &quot;domain&quot;:&quot;www.example.com&quot;, &quot;port&quot;:&quot;80&quot;, &quot;path&quot;:&quot;/a&quot;,&quot;query&quot;:&quot;value1&quot;, &quot;code&quot;:&quot;301&quot; }</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>protocol</c>: the protocol of requests after the requests are redirected. Valid values: <c>${protocol}</c> (default), <c>HTTP</c>, and <c>HTTPS</c>.</description></item>
                /// <item><description><c>domain</c>: the domain name to which requests are redirected. Default value: <c>${host}</c>. You can also enter a domain name. The domain name must be 3 to 128 characters in length, and can contain only letters, digits, and the following special characters: <c>. - ? = ~ _ - + / ^ * ! $ &amp; | ( ) [ ]</c>.</description></item>
                /// <item><description><c>port</c>: the port to which requests are redirected. Default value: <c>${port}</c>. You can enter a port number from 1 to 63335.</description></item>
                /// <item><description><c>path</c>: the path to which requests are redirected. Default value: <c>${path}</c>. The path must be 1 to 128 characters in length. To use a regular expression, the path can contain letters, digits, and the following special characters: <c>. - _ / = ? ~ ^ * $ : ( ) [ ] + |</c>. The path must start with a tilde (~). If you do not want to use a regular expression, the path can contain letters, digits, and the following special characters: <c>. - _ / = ? :</c>. The path must start with a forward slash (/).</description></item>
                /// <item><description><c>query</c>: the query string of the requests that are redirected. Default value: <c>${query}</c>. You can also specify a query string. The query string must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are <c>greater than or equal to 32 and smaller than 127</c>. The query string cannot contain uppercase letters, space characters, or the following special characters: <c>[ ] { } &lt; &gt; # | &amp;</c>.</description></item>
                /// <item><description><c>code</c>: the redirect code. Valid values: <c>301</c>, <c>302</c>, <c>303</c>, <c>307</c>, and <c>308</c>.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>FixResponse</b>, this parameter specifies a fixed response. Example: <c>{&quot;code&quot;:&quot;200&quot;, &quot;type&quot;:&quot;text/plain&quot;, &quot;content&quot;:&quot;dssacav&quot; }</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>code</c>: the HTTP response status code. The response status code must be one of the following numeric strings: <c>2xx</c>, <c>4xx</c>, and <c>5xx</c>. The letter <c>x</c> indicates a number from 0 to 9.</description></item>
                /// <item><description><c>type</c>: the type of the response content. Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</description></item>
                /// <item><description><c>content</c>: the response content. The response content cannot exceed 1,000 characters in length, and does not support Chinese characters.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>AddHeader</b>, this parameter specifies an HTTP header to be added. If a forwarding rule contains a forwarding action whose type is <b>AddHeader</b>, you must specify another forwarding action whose type is <b>ForwardGroup</b>. Example: <c>[{&quot;name&quot;:&quot;header1&quot;,&quot;type&quot;:&quot;userdefined&quot;, &quot;value&quot;:&quot;value&quot;}]</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>name</c>: the name of the HTTP header. The name must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). The name of the HTTP header specified by <b>AddHeader</b> must be unique and cannot be the same as the name of the HTTP header specified by <b>RemoveHeader</b>.</description></item>
                /// <item><description><c>type</c>: the content type of the HTTP header. Valid values: <c>user-defined</c>, <c>ref</c>, and <c>system-defined</c>.</description></item>
                /// <item><description><c>value</c>: the content of the HTTP header. You cannot leave this parameter empty. If you set <c>type</c> to <c>user-defined</c>, the content must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are <c>greater than or equal to 32 and smaller than 127</c>. The content can contain letters, digits, hyphens (-), and underscores (<em>*). The content cannot start or end with a space character. If you set <c>type</c> to <c>ref</c>, the content must be 1 to 128 characters in length, and can contain letters, digits, hyphens (-), and underscores (</em>*). The content cannot start or end with a space character. If you set <c>type</c> to <c>system-defined</c>, only <c>ClientSrcIp</c> is supported.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>RemoveHeader</b>, this parameter specifies an HTTP header to be removed. If a forwarding rule contains a forwarding action whose type is <b>RemoveHeader</b>, you must specify another forwarding action whose type is <b>ForwardGroup</b>. The header must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). Example: <c>[&quot;header1&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleActionType</b> is set to <b>Rewrite</b>, this parameter specifies the rewriting configuration. If a forwarding rule contains a forwarding action whose type is <b>Rewrite</b>, you must specify another forwarding action whose type is <b>ForwardGroup</b>. Example: <c>{&quot;domain&quot;:&quot;value1&quot;, &quot;path&quot;:&quot;value2&quot;, &quot;query&quot;:&quot;value3&quot;}</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>domain</c>: the domain name to which requests are redirected. Default value: <c>${host}</c>. You can also enter a domain name. The domain name must be 3 to 128 characters in length, and can contain only lowercase letters, digits, and the following special characters: <c>. - ? = ~ _ - + / ^ * ! $ &amp; | ( ) [ ]</c>.</description></item>
                /// <item><description><c>path</c>: the path to which requests are redirected. Default value: <c>${path}</c>. The path must be 1 to 128 characters in length. To use a regular expression, the path can contain letters, digits, and the following special characters: <c>. - _ / = ? ~ ^ * $ : ( ) [ ] + |</c>. The path must start with a tilde (~). If you do not want to use a regular expression, the path can contain letters, digits, and the following special characters: <c>. - _ / = ? :</c>. The path must start with a forward slash (/).</description></item>
                /// <item><description><c>query</c>: the query string of the requests that are redirected. Default value: <c>${query}</c>. You can also specify a query string. The query string must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are <c>greater than or equal to 32 and smaller than 127</c>. The query string cannot contain uppercase letters, space characters, or the following special characters: <c>[ ] { } &lt; &gt; # | &amp;</c>.</description></item>
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
            /// <para>The conditions that trigger the forwarding rule.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<UpdateForwardingRulesRequestForwardingRulesRuleConditions> RuleConditions { get; set; }
            public class UpdateForwardingRulesRequestForwardingRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The domain name configuration.</para>
                /// <remarks>
                /// <para> We recommend that you use <b>RuleConditionType</b> and <b>RuleConditionValue</b> rather than this parameter to configure forwarding conditions.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// <para>The domain name configuration.</para>
                    /// <remarks>
                    /// <para> We recommend that you use <b>RuleConditionType</b> and <b>RuleConditionValue</b> rather than this parameter to configure forwarding conditions.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The path configuration.</para>
                /// <remarks>
                /// <para> We recommend that you use <b>RuleConditionType</b> and <b>RuleConditionValue</b> rather than this parameter to configure forwarding conditions.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public UpdateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class UpdateForwardingRulesRequestForwardingRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The path configuration.</para>
                    /// <remarks>
                    /// <para> We recommend that you use <b>RuleConditionType</b> and <b>RuleConditionValue</b> rather than this parameter to configure forwarding conditions.</para>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The type of the forwarding condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Host</b>: Requests are forwarded based on domain names.</description></item>
                /// <item><description><b>Path</b>: Requests are forwarded based on paths.</description></item>
                /// <item><description><b>RequestHeader</b>: Requests are forwarded based on HTTP headers.</description></item>
                /// <item><description><b>Query</b>: Requests are forwarded based on query strings.</description></item>
                /// <item><description><b>Method</b>: Requests are forwarded based on HTTP request methods.</description></item>
                /// <item><description><b>Cookie</b>: Requests are forwarded based on cookies.</description></item>
                /// <item><description><b>SourceIp</b>: Requests are forwarded based on source IP addresses.</description></item>
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
                /// <para>The value of the forwarding condition. You must specify different JSON strings based on <b>RuleConditionType</b>.</para>
                /// <list type="bullet">
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Host</b>, RuleConditionValue specifies a domain name condition. A forwarding rule can contain only one forwarding condition of the host type. You can specify multiple domain names in a forwarding condition. The relationship between multiple domain names is OR. The domain name must be 3 to 128 characters in length, and can contain letters, digits, hyphens (-), and periods (.). You can use asterisks (\*) and question marks (?) as wildcard characters. Example: <c>[&quot;www.example.com&quot;, &quot;www.aliyun.com&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Path</b>, RuleConditionValue specifies a path condition. A forwarding rule can contain multiple forwarding conditions of the path type. The relationship between multiple path conditions is OR. You can specify multiple paths in a forwarding condition. The relationship between multiple paths is OR. The path must be 1 to 128 characters in length, and must start with a forward slash (/). The path can contain letters, digits, and the following special characters: $ - _ . + / &amp; ~ @ : \&quot;. Supported wildcard characters are asterisks (\*) and question marks (?). Example: <c>[&quot;/a&quot;, &quot;/b/&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>RequestHeader</b>, RuleConditionValue specifies an HTTP header condition. An HTTP header consists of a key and a value. The header values in a forwarding condition must be unique. Example: <c>[{&quot;header1&quot;:[&quot;value1&quot;,&quot;value2&quot;]}]</c>.</para>
                /// <list type="bullet">
                /// <item><description>Key: The key of an HTTP header must be 1 to 40 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</description></item>
                /// <item><description>Value: The value of an HTTP header must be 1 to 128 characters in length and can contain printable characters whose ASCII values <c>are larger than or equal to 32 and smaller than 127</c>. The value cannot start or end with a space.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Query</b>, RuleConditionValue specifies a query string condition. A query string consists of a key and a value. Example: <c>[{&quot;query1&quot;:[&quot;value1&quot;]}, {&quot;query2&quot;:[&quot;value2&quot;]}]</c>.</para>
                /// <list type="bullet">
                /// <item><description>Key: The key must be 1 to 100 characters in length and can contain printable characters whose ASCII values <c>are larger than or equal to 32 and smaller than 127</c>, excluding uppercase letters, spaces, and the following special characters: <c>[ ] { } &lt; &gt; \\ ; / ? : @ &amp; = + , $ % &quot; ^ ~</c>.</description></item>
                /// <item><description>Value: The value must be 1 to 128 characters in length and can contain printable characters whose ASCII values <c>are larger than or equal to 32 and smaller than 127</c>, excluding uppercase letters, spaces, and the following special characters: <c>[ ] { } &lt; &gt; \\ ; / ? : @ &amp; = + , $ % &quot; ^ ~</c>.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Method</b>, RuleConditionValue specifies an HTTP method condition. Valid values: <b>HEAD</b>, <b>GET</b>, <b>POST</b>, <b>OPTIONS</b>, <b>PUT</b>, <b>PATCH</b>, and <b>DELETE</b>. Example: <c>[&quot;GET&quot;, &quot;OPTIONS&quot;, &quot;POST&quot;]</c>.</para>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>Cookie</b>, RuleConditionValue specifies a cookie condition. A cookie consists of a key and a value. Example: <c>[{&quot;cookie1&quot;:[&quot;value1&quot;]}, {&quot;cookie2&quot;:[&quot;value2&quot;]}]</c>.</para>
                /// <list type="bullet">
                /// <item><description>Key: The key of a cookie must be 1 to 100 characters in length and can contain printable characters whose ASCII values <c>are larger than or equal to 32 and smaller than 127</c>, excluding uppercase letters, spaces, and the following special characters: <c># [ ] { } \\ &lt; &gt; &amp;</c>.</description></item>
                /// <item><description>Value: The value of a cookie must be 1 to 128 characters in length and can contain printable characters whose ASCII values <c>are larger than or equal to 32 and smaller than 127</c>, excluding uppercase letters, spaces, and the following special characters: <c># [ ] { } \\ &lt; &gt; &amp;</c>.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>RuleConditionType</b> is set to <b>SourceIP</b>, RuleConditionValue specifies a source IP address condition. IP addresses, such as 1.1.XX.XX/32, and CIDR blocks, such as 2.2.XX.XX/24, are supported. A forwarding rule can contain only one forwarding condition of the SourceIP type. You can specify multiple source IP addresses or CIDR blocks in a forwarding condition. The relationship between multiple IP addresses or CIDR blocks is OR. Example: <c>[&quot;1.1.XX.XX/32&quot;, &quot;2.2.XX.XX/24&quot;]</c>.</para>
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
            /// <para>The direction in which the rule takes effect. You do not need to specify this parameter.</para>
            /// <para>By default, this parameter is set to <b>request</b>, which specifies that the rule takes effect on requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>request</para>
            /// </summary>
            [NameInMap("RuleDirection")]
            [Validation(Required=false)]
            public string RuleDirection { get; set; }

        }

        /// <summary>
        /// <para>The listener ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1s0vzbi5bxlx5****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
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
