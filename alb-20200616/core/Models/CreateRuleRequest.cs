// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The direction of the forwarding rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Request</b> (default): The rule matches requests sent from clients to ALB and performs the corresponding actions.</para>
        /// </description></item>
        /// <item><description><para><b>Response</b>: The rule matches responses returned from backend server groups to ALB and performs the corresponding actions.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>ALB instances of Basic Edition do not support the <b>Response</b> type.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Request</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, an <c>HTTP 2xx</c> status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the Application Load Balancing (ALB) instance listener.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-l16uo9y******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The priority of the forwarding rule. Valid values: <b>1 to 10000</b>. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>The priority of each rule within a listener must be unique.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The list of forwarding rule actions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleActions")]
        [Validation(Required=false)]
        public List<CreateRuleRequestRuleActions> RuleActions { get; set; }
        public class CreateRuleRequestRuleActions : TeaModel {
            /// <summary>
            /// <para>The CORS configuration.</para>
            /// </summary>
            [NameInMap("CorsConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsCorsConfig CorsConfig { get; set; }
            public class CreateRuleRequestRuleActionsCorsConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether credentials are allowed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: allowed.</description></item>
                /// <item><description><b>off</b>: not allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public string AllowCredentials { get; set; }

                /// <summary>
                /// <para>The list of headers allowed for CORS requests.</para>
                /// </summary>
                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public List<string> AllowHeaders { get; set; }

                /// <summary>
                /// <para>The HTTP methods allowed for CORS requests.</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public List<string> AllowMethods { get; set; }

                /// <summary>
                /// <para>The list of allowed origins. You can configure a single element <c>*</c>, or configure one or more values.</para>
                /// <list type="bullet">
                /// <item><description>Each value must start with <c>http://</c> or <c>https://</c>, followed by a valid domain name or a first-level wildcard domain name (for example, <c>http://*.test.abc.example.com</c>).</description></item>
                /// <item><description>Each value can optionally include a port. The port range is <b>1</b> to <b>65535</b>.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("AllowOrigin")]
                [Validation(Required=false)]
                public List<string> AllowOrigin { get; set; }

                /// <summary>
                /// <para>The list of headers that can be exposed.</para>
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
            /// <para>The configuration of the fixed response.</para>
            /// </summary>
            [NameInMap("FixedResponseConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class CreateRuleRequestRuleActionsFixedResponseConfig : TeaModel {
                /// <summary>
                /// <para>The fixed content to return. The content can be up to 1 KB in size and can contain only ASCII characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dssacav</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The format of the fixed content.</para>
                /// <para>Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text/plain</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The HTTP response code to return. Only <b>2xx</b>, <b>4xx</b>, and <b>5xx</b> numeric strings are supported, where <b>x</b> is any digit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

            }

            /// <summary>
            /// <para>The list of destination server groups to which requests are forwarded. A maximum of 5 destination server groups can be added to a forwarding rule.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateRuleRequestRuleActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The session persistence configuration between server groups.</para>
                /// </summary>
                [NameInMap("ServerGroupStickySession")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable session persistence. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: enabled.</description></item>
                    /// <item><description><b>false</b> (default): disabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The timeout period. Unit: seconds. Valid values: <b>1</b> to <b>86400</b>. Default value: <b>1000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                /// <summary>
                /// <para>The list of destination server groups to which requests are forwarded. A maximum of 5 destination server groups can be added to a forwarding rule.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The destination server group to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sgp-k86c1ov501id6p****</para>
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                    /// <summary>
                    /// <para>The weight. A larger value indicates a higher weight, which means more requests are forwarded to the server group. Valid values: <b>0</b> to <b>100</b>.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If only one destination server group is specified and no weight is specified, the default value is <b>100</b>.</para>
                    /// </description></item>
                    /// <item><description><para>If more than one destination server group is specified, you must specify the weight value.</para>
                    /// </description></item>
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
            /// <para>The configuration for inserting a header field.</para>
            /// </summary>
            [NameInMap("InsertHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsInsertHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The name of the header field to insert. The name must be 1 to 40 characters in length and can contain lowercase and uppercase letters a to z, digits, underscores (_), and hyphens (-). The header field name specified in <b>InsertHeaderConfig</b> must be unique.</para>
                /// <remarks>
                /// <para>You cannot set the header name to the following fields (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>, <c>x-forwarded-host</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the header field to insert.</para>
                /// <list type="bullet">
                /// <item><description>If <b>ValueType</b> is set to <b>SystemDefined</b>, valid values are:<list type="bullet">
                /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                /// <item><description><b>ClientSrcIp</b>: the client IP address.</description></item>
                /// <item><description><b>Protocol</b>: the protocol used by the client request (HTTP or HTTPS).</description></item>
                /// <item><description><b>SLBId</b>: the Application Load Balancing instance ID.</description></item>
                /// <item><description><b>SLBPort</b>: the Application Load Balancing instance listener port.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>If <b>ValueType</b> is set to <b>UserDefined</b>: you can specify a custom header value. The value must be 1 to 128 characters in length and can contain wildcards asterisks (\*), question marks (?), and printable characters in the ASCII range <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The value cannot contain <c>&quot;</c>. The value cannot start or end with a space. The value cannot end with <c>\\</c>.</description></item>
                /// <item><description>If <b>ValueType</b> is set to <b>ReferenceHeader</b>: you can reference a field in the request header. The value must be 1 to 128 characters in length and can contain lowercase letters a to z, digits, hyphens (-), and underscores (_).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UserDefined</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The content type of the header field value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>UserDefined</b>: a custom value.</para>
                /// </description></item>
                /// <item><description><para><b>ReferenceHeader</b>: references a field in the request header.</para>
                /// </description></item>
                /// <item><description><para><b>SystemDefined</b>: a system-defined value.</para>
                /// </description></item>
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
            /// <para>The order in which the forwarding rule action is executed. Valid values: <b>1 to 50000</b>. Actions are executed in ascending order of values. This parameter cannot be left empty and the value cannot be duplicated.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The redirect configuration.</para>
            /// <remarks>
            /// <para>For the parameters in <b>RedirectConfig</b>, parameters other than <b>httpCode</b> cannot all use default values.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RedirectConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class CreateRuleRequestRuleActionsRedirectConfig : TeaModel {
                /// <summary>
                /// <para>The host to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${host}</b> (default): This value cannot be concatenated with other characters.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The hostname must be 3 to 256 characters in length and can contain lowercase letters a to z, digits, hyphens (-), periods (.), and wildcards asterisks (\*), equals signs (=), tildes (~), underscores (_), plus signs (+), backslashes (\), carets (^), exclamation marks (!), dollar signs ($), ampersands (&amp;), vertical bars (|), parentheses (()), brackets ([\]), and question marks (?).</description></item>
                /// <item><description>The hostname must contain at least one period (.) and cannot start or end with a period (.).</description></item>
                /// <item><description>The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-). The leftmost <c>domainlable</c> can be an asterisk (\*).</description></item>
                /// <item><description>Hyphens (-) cannot appear at the beginning or end of other domain labels.</description></item>
                /// <item><description>Wildcards asterisks (\*) and question marks (?) can appear at any position in a domain label.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>${host}</para>
                /// </summary>
                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                /// <summary>
                /// <para>The redirect type. Valid values: <b>301</b>, <b>302</b>, <b>303</b>, <b>307</b>, and <b>308</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>301</para>
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

                /// <summary>
                /// <para>The path to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${path}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with characters within the allowed character set described below.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The value must be 1 to 256 characters in length, is case-sensitive, and supports wildcards asterisks (\*) and question marks (?) as wildcards.</description></item>
                /// <item><description>The value must start with a forward slash (/), and can contain uppercase and lowercase letters, digits, and special characters <c>$-_.+/&amp;~@:\\&quot;*?</c>. The value cannot contain <c>&quot;%#;!()[]^,&quot;\\&quot;</c>. Wildcards asterisks (\*) and question marks (?) are supported.</description></item>
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
                /// <para>The port to which requests are redirected.</para>
                /// <list type="bullet">
                /// <item><description><b>${port}</b> (default): This value cannot be used together with other characters.</description></item>
                /// <item><description>Other values: <b>1 to 63335</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The protocol to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${protocol}</b> (default): This value can only be used alone and cannot be modified or concatenated with other characters.</description></item>
                /// <item><description><b>HTTP</b></description></item>
                /// <item><description><b>HTTPS</b><remarks>
                /// <list type="bullet">
                /// <item><description>HTTPS listeners support redirection to HTTPS only.</description></item>
                /// <item><description>HTTP listeners support redirection to both HTTP and HTTPS.</description></item>
                /// </list>
                /// </remarks>
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
                /// <item><description><b>${query}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with characters within the allowed character set described below.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The value must be 1 to 128 characters in length.</description></item>
                /// <item><description>The value can contain printable characters but cannot contain spaces or <c>#[]{}\\|&lt;&gt;&quot;</c>. Letters must be lowercase.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>${query}</para>
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <para>The configuration for removing an HTTP header field.</para>
            /// </summary>
            [NameInMap("RemoveHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsRemoveHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The name of the header field to remove. The name must be 1 to 40 characters in length and can contain uppercase and lowercase letters a to z, digits, underscores (_), and hyphens (-). The header field name cannot be duplicated in RemoveHeader.</para>
                /// <list type="bullet">
                /// <item><description>Request direction (Direction is set to Request): You cannot set the header name to the following fields (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>, <c>x-forwarded-host</c>.</description></item>
                /// <item><description>Response direction (Direction is set to Response): You cannot set the header name to the following fields (case-insensitive): <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>.</description></item>
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
            /// <para>The rewrite configuration.</para>
            /// <remarks>
            /// <para>When you configure multiple actions for a forwarding rule, the <b>RewriteConfig</b> action must be used together with the <b>ForwardGroup</b> action type.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RewriteConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class CreateRuleRequestRuleActionsRewriteConfig : TeaModel {
                /// <summary>
                /// <para>The destination hostname for internal redirection. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>${host}</b> (default): This value cannot be concatenated with other characters.</para>
                /// </description></item>
                /// <item><description><para>Other values. Character set and format restrictions are as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>The hostname must be 3 to 256 characters in length and can contain lowercase letters a to z, digits, hyphens (-), periods (.), and wildcards asterisks (\*), equals signs (=), tildes (~), underscores (_), plus signs (+), backslashes (\), carets (^), exclamation marks (!), dollar signs ($), ampersands (&amp;), vertical bars (|), parentheses (()), brackets ([\]), and question marks (?).</para>
                /// </description></item>
                /// <item><description><para>The hostname must contain at least one period (.) and cannot start or end with a period (.).</para>
                /// </description></item>
                /// <item><description><para>The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-). The leftmost <c>domainlable</c> can be an asterisk (\*).</para>
                /// </description></item>
                /// <item><description><para>Hyphens (-) cannot appear at the beginning or end of other domain labels. Wildcards asterisks (\*) and question marks (?) can appear at any position in a domain label.</para>
                /// </description></item>
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
                /// <para>The path to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${path}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with characters within the allowed character set described below.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The value must be 1 to 256 characters in length, is case-sensitive, and supports wildcards asterisks (\*) and question marks (?) as wildcards.</description></item>
                /// <item><description>The value must start with a forward slash (/), and can contain uppercase and lowercase letters, digits, and special characters <c>$-_.+/&amp;~@:\\&quot;*?</c>. The value cannot contain <c>&quot;%#;!()[]^,&quot;\\&quot;</c>. Wildcards asterisks (\*) and question marks (?) are supported.</description></item>
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
                /// <para>The query string for internal redirection.</para>
                /// <list type="bullet">
                /// <item><description><b>${query}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with characters within the allowed character set described below.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The value must be 1 to 128 characters in length.</description></item>
                /// <item><description>The value can contain printable characters but cannot contain spaces or <c>#[]{}\\|&lt;&gt;&quot;</c>. Letters must be lowercase.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>${query}</para>
                /// </summary>
                [NameInMap("Query")]
                [Validation(Required=false)]
                public string Query { get; set; }

            }

            /// <summary>
            /// <para>The traffic throttling configuration.</para>
            /// </summary>
            [NameInMap("TrafficLimitConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
            public class CreateRuleRequestRuleActionsTrafficLimitConfig : TeaModel {
                /// <summary>
                /// <para>The number of requests per second per IP address. Valid values: <b>1 to 1000000</b>.</para>
                /// <remarks>
                /// <para>If you configure both the <b>QPS</b> and <b>PerIpQps</b> parameters, the value of <b>PerIpQps</b> must be smaller than the value of <b>QPS</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("PerIpQps")]
                [Validation(Required=false)]
                public int? PerIpQps { get; set; }

                /// <summary>
                /// <para>The number of requests per second. Valid values: <b>1 to 1000000</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("QPS")]
                [Validation(Required=false)]
                public int? QPS { get; set; }

            }

            /// <summary>
            /// <para>The traffic mirroring configuration.</para>
            /// </summary>
            [NameInMap("TrafficMirrorConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
            public class CreateRuleRequestRuleActionsTrafficMirrorConfig : TeaModel {
                /// <summary>
                /// <para>The configuration for mirroring traffic to a server group.</para>
                /// </summary>
                [NameInMap("MirrorGroupConfig")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                public class CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration for mirroring traffic to a server group.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The server group ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sgp-00mkgijak0w4qgz9****</para>
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the mirror target. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroupMirror</b>: mirrors traffic to a server group.</description></item>
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
            /// <para>The action type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ForwardGroup</b>: forwards requests to multiple virtual services.</para>
            /// </description></item>
            /// <item><description><para><b>Redirect</b>: redirects requests.</para>
            /// </description></item>
            /// <item><description><para><b>FixedResponse</b>: returns a fixed response.</para>
            /// </description></item>
            /// <item><description><para><b>Rewrite</b>: rewrites requests.</para>
            /// </description></item>
            /// <item><description><para><b>InsertHeader</b>: inserts a header field.</para>
            /// </description></item>
            /// <item><description><para><b>RemoveHeader</b>: deletes a header field.</para>
            /// </description></item>
            /// <item><description><para><b>TrafficLimit</b>: throttles traffic.</para>
            /// </description></item>
            /// <item><description><para><b>TrafficMirror</b>: mirrors traffic.</para>
            /// </description></item>
            /// <item><description><para><b>Cors</b>: enables cross-origin resource sharing (CORS).</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>A forwarding rule must contain one <b>ForwardGroup</b> (forward to), <b>Redirect</b> (redirect), or <b>FixedResponse</b> (return a fixed response) action. When this action coexists with other action types, it must be executed last.</para>
            /// </remarks>
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
        /// <para>The list of forwarding rule conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<CreateRuleRequestRuleConditions> RuleConditions { get; set; }
        public class CreateRuleRequestRuleConditions : TeaModel {
            /// <summary>
            /// <para>The cookie configuration.</para>
            /// </summary>
            [NameInMap("CookieConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsCookieConfig CookieConfig { get; set; }
            public class CreateRuleRequestRuleConditionsCookieConfig : TeaModel {
                /// <summary>
                /// <para>The list of cookie values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleConditionsCookieConfigValues> Values { get; set; }
                public class CreateRuleRequestRuleConditionsCookieConfigValues : TeaModel {
                    /// <summary>
                    /// <para>The cookie key.</para>
                    /// <list type="bullet">
                    /// <item><description>The value must be 1 to 100 characters in length.</description></item>
                    /// <item><description>The value can contain printable characters, wildcards asterisks (\*), and question marks (?). Letters must be lowercase.</description></item>
                    /// <item><description>The value cannot contain spaces or <c>;#[]{}\\|&lt;&gt;&amp;&quot;</c>.</description></item>
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
                    /// <item><description>The value must be 1 to 100 characters in length.</description></item>
                    /// <item><description>The value can contain printable characters, wildcards asterisks (\*), and question marks (?). Letters must be lowercase.</description></item>
                    /// <item><description>The value cannot contain spaces or <c>;#[]{}\\|&lt;&gt;&amp;&quot;</c>.</description></item>
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
            /// <para>The header field configuration.</para>
            /// </summary>
            [NameInMap("HeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsHeaderConfig HeaderConfig { get; set; }
            public class CreateRuleRequestRuleConditionsHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The header field key.</para>
                /// <list type="bullet">
                /// <item><description>The value must be 1 to 40 characters in length.</description></item>
                /// <item><description>The value can contain letters a to z, digits, hyphens (-), and underscores (_).</description></item>
                /// <item><description>Cookie and Host are not supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Port</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The list of header field values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The hostname configuration.</para>
            /// </summary>
            [NameInMap("HostConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsHostConfig HostConfig { get; set; }
            public class CreateRuleRequestRuleConditionsHostConfig : TeaModel {
                /// <summary>
                /// <para>The list of hostnames.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The request method configuration.</para>
            /// </summary>
            [NameInMap("MethodConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsMethodConfig MethodConfig { get; set; }
            public class CreateRuleRequestRuleConditionsMethodConfig : TeaModel {
                /// <summary>
                /// <para>The list of request methods.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The forwarding path configuration.</para>
            /// </summary>
            [NameInMap("PathConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsPathConfig PathConfig { get; set; }
            public class CreateRuleRequestRuleConditionsPathConfig : TeaModel {
                /// <summary>
                /// <para>The list of forwarding paths.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The query string configuration.</para>
            /// </summary>
            [NameInMap("QueryStringConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
            public class CreateRuleRequestRuleConditionsQueryStringConfig : TeaModel {
                /// <summary>
                /// <para>The list of query strings.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleConditionsQueryStringConfigValues> Values { get; set; }
                public class CreateRuleRequestRuleConditionsQueryStringConfigValues : TeaModel {
                    /// <summary>
                    /// <para>The query string key.</para>
                    /// <list type="bullet">
                    /// <item><description>The value must be 1 to 100 characters in length.</description></item>
                    /// <item><description>The value can contain printable characters, wildcards asterisks (\*), and question marks (?). Letters must be lowercase. The value cannot contain spaces or <c>#[]{}\\|&lt;&gt;&amp;&quot;</c>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The query string value.</para>
                    /// <list type="bullet">
                    /// <item><description>The value must be 1 to 128 characters in length.</description></item>
                    /// <item><description>The value can contain lowercase letters, printable characters, wildcards asterisks (\*), and question marks (?). The value cannot contain spaces or <c>#[]{}\\|&lt;&gt;&amp;&quot;</c>.</description></item>
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
            /// <para>The response header configuration.</para>
            /// </summary>
            [NameInMap("ResponseHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
            public class CreateRuleRequestRuleConditionsResponseHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The header field key.</para>
                /// <list type="bullet">
                /// <item><description>The key must be 1 to 40 characters in length.</description></item>
                /// <item><description>The key can contain lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
                /// <item><description>Cookie and Host are not supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The list of header field values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The response status code configuration.
            /// [_single.params.RuleConditions.items.ResponseStatusCodeConfig.Values.</para>
            /// </summary>
            [NameInMap("ResponseStatusCodeConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
            public class CreateRuleRequestRuleConditionsResponseStatusCodeConfig : TeaModel {
                /// <summary>
                /// <para>The list of response status codes.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The configuration for source IP-based service traffic matching. This parameter is required and takes effect only when <b>Type</b> is set to <b>SourceIP</b>.</para>
            /// </summary>
            [NameInMap("SourceIpConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
            public class CreateRuleRequestRuleConditionsSourceIpConfig : TeaModel {
                /// <summary>
                /// <para>The list of source IP addresses for service traffic matching.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The type of the forwarding rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Host</b>: host.</para>
            /// </description></item>
            /// <item><description><para><b>Path</b>: path.</para>
            /// </description></item>
            /// <item><description><para><b>Header</b>: HTTP header field.</para>
            /// </description></item>
            /// <item><description><para><b>QueryString</b>: query string.</para>
            /// </description></item>
            /// <item><description><para><b>Method</b>: request method.</para>
            /// </description></item>
            /// <item><description><para><b>Cookie</b>: cookie.</para>
            /// </description></item>
            /// <item><description><para><b>SourceIp</b>: source IP address.</para>
            /// </description></item>
            /// <item><description><para><b>ResponseHeader</b>: response HTTP header field.</para>
            /// </description></item>
            /// <item><description><para><b>ResponseStatusCode</b>: response status code.</para>
            /// </description></item>
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
        /// <para>The name of the forwarding rule. </para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter, Chinese character, or digit. It can contain digits, periods (.), underscores (_), hyphens (-), and spaces.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-doc</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRuleRequestTag> Tag { get; set; }
        public class CreateRuleRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
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
