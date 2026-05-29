// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateRulesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, a <c>2xx HTTP</c> status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the Application Load Balancer (ALB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The details about the forwarding rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateRulesRequestRules> Rules { get; set; }
        public class CreateRulesRequestRules : TeaModel {
            /// <summary>
            /// <para>The traffic direction to which the forwarding rule is applied.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Response</description></item>
            /// <item><description>Request</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Request</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The priority of the forwarding rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The actions of the forwarding rule.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesRuleActions> RuleActions { get; set; }
            public class CreateRulesRequestRulesRuleActions : TeaModel {
                /// <summary>
                /// <para>The CORS configuration.</para>
                /// </summary>
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsCorsConfig : TeaModel {
                    /// <summary>
                    /// <para>Include credentials in CORS requests. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>on</b></description></item>
                    /// <item><description><b>off</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>on</para>
                    /// </summary>
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    /// <summary>
                    /// <para>The trusted header of CORS requests.</para>
                    /// </summary>
                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowHeaders { get; set; }

                    /// <summary>
                    /// <para>The trusted HTTP methods of CORS requests.</para>
                    /// </summary>
                    [NameInMap("AllowMethods")]
                    [Validation(Required=false)]
                    public List<string> AllowMethods { get; set; }

                    /// <summary>
                    /// <para>The trusted origins of CORS requests.</para>
                    /// </summary>
                    [NameInMap("AllowOrigin")]
                    [Validation(Required=false)]
                    public List<string> AllowOrigin { get; set; }

                    /// <summary>
                    /// <para>The headers that can be exposed.</para>
                    /// </summary>
                    [NameInMap("ExposeHeaders")]
                    [Validation(Required=false)]
                    public List<string> ExposeHeaders { get; set; }

                    /// <summary>
                    /// <para>The maximum cache time for preflight requests in the browser. Unit: seconds.</para>
                    /// <para>Valid values: <b>-1</b> to <b>172800</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the action to return a fixed response.</para>
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// <para>The content of the custom response. The content cannot exceed 1 KB in size, and can contain only ASCII characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dssacav</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The format of the custom response.</para>
                    /// <para>Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text/plain</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code in responses. Valid values: <b>2xx</b>, <b>4xx</b>, and <b>5xx</b>. The value must be a numeric string. <b>x</b> can be any digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP_200</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the action to forward requests to server groups.</para>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration of session persistence.</para>
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        /// <summary>
                        /// <para>Enables session persistence. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b></description></item>
                        /// <item><description><b>false</b> (default)</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The timeout period for sessions. Unit: seconds. Valid values: <b>1</b> to <b>86400</b>. Default value: <b>1000</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                    /// <summary>
                    /// <para>The server groups to which requests are forwarded.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The ID of the server group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sgp-k86c1ov501id6p****</para>
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        /// <summary>
                        /// <para>The weight of the server group. A larger value indicates a higher weight. A server group with a higher weight receives more requests. Valid values: <b>0</b> to <b>100</b></para>
                        /// <list type="bullet">
                        /// <item><description>If the number of destination server groups is 1, the default weight of the server group is <b>100</b>. You can specify another value.</description></item>
                        /// <item><description>If the number of destination server groups is larger than 1, you must specify weights for the server groups.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// <para>The configuration of the action to insert a header.</para>
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header, which can contain a maximum of 40 characters. Supported characters include letters, digits, underscores (_), and hyphens (-). The header keys specified by <b>InsertHeaderConfig</b> must be unique.</para>
                    /// <remarks>
                    /// <para> You cannot specify the following header keys: <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>, and <c>x-forwarded-host</c>. The header keys are case-insensitive.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the header.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <b>ValueType</b> is set to <b>SystemDefined</b>, you can set this parameter to one of the following values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                    /// <item><description><b>ClientSrcIp</b>: the client IP address.</description></item>
                    /// <item><description><b>Protocol</b>: the request protocol (HTTP or HTTPS).</description></item>
                    /// <item><description><b>SLBId</b>: the ID of the ALB instance.</description></item>
                    /// <item><description><b>SLBPort</b>: the listener port of the ALB instance.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If <b>ValueType</b> is set to <b>UserDefined</b>, specify a custom header value. The header value can contain a maximum of 128 characters, and supports printable characters whose ASCII values are <c>greater than or equal to 32 and lower than 127</c> and asterisks (\*) and question marks (?) as wildcard characters. Quotation marks (<c>&quot;</c>) are not supported. The header value cannot start or end with a space or end with a backslash (<c>\\</c>).</para>
                    /// </description></item>
                    /// <item><description><para>If <b>ValueType</b> is set to <b>ReferenceHeader</b>, you can reference a value from request headers. The value can contain a maximum of 128 characters. Supported characters include lowercase letters, digits, hyphens (-), and underscores (_).</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserDefined</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The type of the header value. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><b>UserDefined</b>: a custom header value</description></item>
                    /// <item><description><b>ReferenceHeader</b>: a header value that references one of the request headers</description></item>
                    /// <item><description><b>SystemDefined</b>: a system-defined header value</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserDefined</para>
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                }

                /// <summary>
                /// <para>The priority of the action. Valid values: <b>1 to 50000</b>. A lower value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter is required. The priority of each action within a forwarding rule must be unique.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The configuration of the redirect action.</para>
                /// <remarks>
                /// <para> Do not set all parameters in <b>RedirectConfig</b> to default values, excluding <b>httpCode</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostname to which requests are redirected. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${host}</b> (default): This value cannot be concatenated with any other characters.</para>
                    /// </description></item>
                    /// <item><description><para>A custom hostname, which must meet the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>Contain 3 to 128 characters. Supported characters include lowercase letters, digits, and the following characters: - . \* (as wildcard characters) = ~ _ + \ ^ ! $ &amp; | ( ) [ ] ?</description></item>
                    /// <item><description>Contain at least one period (.) but cannot start or end with a period (.).</description></item>
                    /// <item><description>The rightmost domain label can contain only letters and wildcard characters, and cannot contain digits or hyphens (-). The leftmost <c>domain label</c> can be an asterisk (\*).</description></item>
                    /// <item><description>The other domain labels do not start or end with hyphens (-).</description></item>
                    /// <item><description>Support asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code that indicates the redirect type. Valid values: <b>301</b>, <b>302</b>, <b>303</b>, <b>307</b>, and <b>308</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>301</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    /// <summary>
                    /// <para>The path to which requests are redirected. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${path}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>, with each appearing only once. You can also concatenate any preceding variable with strings that meet the following requirements.</para>
                    /// </description></item>
                    /// <item><description><para>A custom path, which must meet the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>Contain a maximum of 128 characters and is case-sensitive. Support asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                    /// <item><description>Start with a forward slash (/), and can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:\\&quot;*?</c>. It cannot contain the following special characters: <c>“%#;!()[]^,”\\&quot;</c>. Support asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/test</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The port to which requests are redirected. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${port}</b> (default): This value cannot be concatenated with any other characters.</description></item>
                    /// <item><description>A custom port number. Valid values: <b>1 to 63335</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The redirect protocol. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${protocol}</b> (default): This value cannot be modified or concatenated with any other characters.</description></item>
                    /// <item><description><b>HTTP</b></description></item>
                    /// <item><description><b>HTTPS</b></description></item>
                    /// </list>
                    /// <remarks>
                    /// </remarks>
                    /// <list type="bullet">
                    /// <item><description><para>For HTTPS listeners, you can only redirect HTTPS to HTTPS.</para>
                    /// </description></item>
                    /// <item><description><para>For HTTP listeners, you can redirect HTTP to either HTTP or HTTPS.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The query string to which requests are redirected.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${query}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>, with each appearing only once. You can also concatenate any preceding variable with strings that meet the following requirements.</para>
                    /// </description></item>
                    /// <item><description><para>A custom query string, which must meet the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>Contain a maximum of 128 characters.</description></item>
                    /// <item><description>Contain printable characters, excluding space characters, the special characters <c>#[]{}\\|&lt;&gt;&quot;</c>, and uppercase letters.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quert</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the action to remove a header.</para>
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header to be removed. It can contain a maximum of 40 characters and supports letters, digits, underscores (_), and hyphens (-). The header keys specified in RemoveHeader must be unique.</para>
                    /// <list type="bullet">
                    /// <item><description>If Direction is set to Request, the following request headers cannot be removed: <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>, and <c>x-forwarded-host</c>.</description></item>
                    /// <item><description>If Direction is set to Response, the following response headers (case-insensitive) cannot be removed: <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, and <c>transfer-encoding</c>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the rewrite action.</para>
                /// <remarks>
                /// <para> If you specify a <b>Rewrite</b> action along with other types of actions in a forwarding rule, you must also specify a <b>ForwardGroup</b> action.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostname to which requests are rewritten. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${host}</b> (default): This value cannot be concatenated with any other characters.</para>
                    /// </description></item>
                    /// <item><description><para>A custom hostname, which must meet the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>Contain 3 to 128 characters. Supported characters include lowercase letters, digits, and the following characters: - . \* (as wildcard characters) = ~ _ + \ ^ ! $ &amp; | ( ) [ ] ?</description></item>
                    /// <item><description>Contain at least one period (.) but cannot start or end with a period (.).</description></item>
                    /// <item><description>The rightmost domain label can contain only letters and wildcard characters, and cannot contain digits or hyphens (-). The leftmost <c>domain label</c> can be an asterisk (\*).</description></item>
                    /// <item><description>The other domain labels do not start or end with hyphens (-). You can use asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The path to which requests are rewritten. Valid values are:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${path}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>, with each appearing only once. You can also concatenate any preceding variable with strings that meet the following requirements.</para>
                    /// </description></item>
                    /// <item><description><para>A custom path, which must meet the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>Contain a maximum of 128 characters and is case-sensitive. Support asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                    /// <item><description>Start with a forward slash (/), and can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:\\&quot;*?</c>. It cannot contain the following special characters: <c>“%#;!()[]^,”\\&quot;</c>. Support asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tsdf</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The query string of the URL to which requests are rewritten.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${query}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>, with each appearing only once. You can also concatenate any preceding variable with strings that meet the following requirements.</para>
                    /// </description></item>
                    /// <item><description><para>A custom query string, which must meet the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>Contain a maximum of 128 characters.</description></item>
                    /// <item><description>Contain printable characters, excluding space characters, the special characters <c>#[]{}\\|&lt;&gt;&quot;</c>, and uppercase letters.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quedsa</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the action to throttle traffic.</para>
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// <para>QPS per IP address. Valid values: <b>1 to 1000000</b>.</para>
                    /// <remarks>
                    /// <para> If both the <b>QPS</b> and <b>PerIpQps</b> parameters are specified, the value of the <b>QPS</b> parameter must be smaller than that of the PerIpQps parameter.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    /// <summary>
                    /// <para>Queries per second (QPS). Valid values: <b>1</b> to <b>1000000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the action to mirror traffic.</para>
                /// </summary>
                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration of the server group to which traffic is mirrored.</para>
                    /// </summary>
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        /// <summary>
                        /// <para>The server group to which traffic is mirrored.</para>
                        /// </summary>
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            /// <summary>
                            /// <para>The ID of the server group.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>srg-00mkgijak0w4qgz9****</para>
                            /// </summary>
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The type of destination to which network traffic is mirrored. Valid value:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ForwardGroupMirror</b>: a server group</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ForwardGroupMirror</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// <para>The type of the action. Valid values are:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroup</b>: forwards requests to multiple vServer groups.</description></item>
                /// <item><description><b>Redirect</b>: redirects requests.</description></item>
                /// <item><description><b>FixedResponse</b>: returns a fixed response.</description></item>
                /// <item><description><b>Rewrite</b>: rewrites requests.</description></item>
                /// <item><description><b>InsertHeader</b>: inserts a header.</description></item>
                /// <item><description><b>RemoveHeader</b>: deletes a header.</description></item>
                /// <item><description><b>TrafficLimit</b>: throttles traffic.</description></item>
                /// <item><description><b>trafficMirror</b>: mirrors network traffic.</description></item>
                /// <item><description><b>Cors</b>: forwards requests based on CORS.</description></item>
                /// </list>
                /// <para>Actions in each forwarding rule must meet the following requirements:</para>
                /// <list type="bullet">
                /// <item><description><b>Each forwarding rule must include one and only one of the following actions: <b>ForwardGroup</b>, <b>Redirect</b>, or <b>FixedResponse</b>, and this action must be performed last.</b></description></item>
                /// <item><description><b>Each forwarding rule may contain none, one, or more actions of other types.</b>************ You can specify multiple <b>InsertHeader</b> actions or one <b>Rewrite</b> action.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForwardGroup</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The conditions of the forwarding rule.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesRuleConditions> RuleConditions { get; set; }
            public class CreateRulesRequestRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The configuration of the cookie condition.</para>
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// <para>The key-value pairs in cookies.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The cookie key.</para>
                        /// <list type="bullet">
                        /// <item><description>Contain a maximum of 100 characters.</description></item>
                        /// <item><description>Support asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                        /// <item><description>Support printable characters, excluding uppercase letters, space characters, and the following special characters: <c>; # [ ] { } \\ | &lt; &gt; &amp; &quot;</c>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The cookie value.</para>
                        /// <list type="bullet">
                        /// <item><description>Contain a maximum of 100 characters.</description></item>
                        /// <item><description>Support asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                        /// <item><description>Support printable characters, excluding uppercase letters, space characters, and the following special characters: <c>; # [ ] { } \\ | &lt; &gt; &amp; &quot;</c>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The configuration of the HTTP header condition.</para>
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the HTTP header.</para>
                    /// <list type="bullet">
                    /// <item><description>Contain a maximum of 40 characters.</description></item>
                    /// <item><description>Support letters, digits, hyphens (-), and underscores (_).</description></item>
                    /// <item><description>Do not support Cookie or Host.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Port</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The values of the HTTP header.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the hostname condition.</para>
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostnames.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the HTTP request method condition.</para>
                /// </summary>
                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsMethodConfig : TeaModel {
                    /// <summary>
                    /// <para>The HTTP request methods.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the path condition.</para>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The paths to which requests are forwarded.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configurations of the query string condition.</para>
                /// </summary>
                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// <para>The key-value pairs in query strings.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The key of the query string.</para>
                        /// <list type="bullet">
                        /// <item><description>Contain a maximum of 100 characters.</description></item>
                        /// <item><description>Support asterisks (\*) and question marks (?) as wildcard characters. Support printable characters, excluding uppercase letters, space characters, and the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp; &quot;</c>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the query string.</para>
                        /// <list type="bullet">
                        /// <item><description>Contain a maximum of 128 characters.</description></item>
                        /// <item><description>Support printable characters, excluding uppercase letters, space characters, and the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp; &quot;</c>. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The configuration of the HTTP response header condition.</para>
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the HTTP response header.</para>
                    /// <list type="bullet">
                    /// <item><description>Contain a maximum of 40 characters.</description></item>
                    /// <item><description>Support letters, digits, hyphens (-), and underscores (_).</description></item>
                    /// <item><description>Do not support Cookie or Host.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Port</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The values of the HTTP response header.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the response status code condition.</para>
                /// </summary>
                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    /// <summary>
                    /// <para>The response status codes.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the condition that matches requests based on source IP addresses.</para>
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// <para>The condition that matches requests based on source IP addresses.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The type of the condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Host: forwards requests based on hosts.</description></item>
                /// <item><description>Path: forwards requests based on paths.</description></item>
                /// <item><description>Header: forwards requests based on HTTP headers.</description></item>
                /// <item><description>QueryString: forwards requests based on query strings.</description></item>
                /// <item><description>Method: forwards requests based on HTTP request methods.</description></item>
                /// <item><description>Cookie: forwards requests based on cookies.</description></item>
                /// <item><description>SourceIp: forwards requests based on source IP addresses.</description></item>
                /// <item><description>ResponseHeader: forwards requests based on HTTP response headers.</description></item>
                /// <item><description>ResponseStatusCode: forwards requests based on response status codes.</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Host</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The name of the forwarding rule.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesTag> Tag { get; set; }
            public class CreateRulesRequestRulesTag : TeaModel {
                /// <summary>
                /// <para>The key of the tag. It can contain a maximum of 128 characters, cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the tag. It can contain a maximum of 128 characters, cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
