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
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
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
        /// <item><description><para><b>Request</b> (default): matches and processes packets sent from clients to ALB.</para>
        /// </description></item>
        /// <item><description><para><b>Response</b>: matches and processes packets returned from backend server groups to ALB.</para>
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
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs only a dry run and does not create the forwarding rule. The system checks whether the required parameters are set, and validates the request format and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, an <c>HTTP 2xx</c> status code is returned and the operation is performed.</para>
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
        /// <para>The ID of the listener on the Application Load Balancing (ALB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-l16uo9y******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The priority of the rule. Valid values: <b>1</b> to <b>10000</b>. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>The priority of each rule within the same listener must be unique.</para>
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
                /// <para>Specifies whether to allow credentials. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: yes.</description></item>
                /// <item><description><b>off</b>: no.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public string AllowCredentials { get; set; }

                /// <summary>
                /// <para>The list of allowed cross-origin headers.</para>
                /// </summary>
                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public List<string> AllowHeaders { get; set; }

                /// <summary>
                /// <para>The allowed HTTP methods for cross-origin requests.</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public List<string> AllowMethods { get; set; }

                /// <summary>
                /// <para>The list of allowed origins. You can specify a single asterisk (<c>*</c>) or one or more values.</para>
                /// <list type="bullet">
                /// <item><description>Each value must start with <c>http://</c> or <c>https://</c>, followed by a valid domain name or a first-level wildcard domain name (example: <c>http://*.test.abc.example.com</c>).</description></item>
                /// <item><description>You can omit the port or specify a port in the range of <b>1</b> to <b>65535</b>.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("AllowOrigin")]
                [Validation(Required=false)]
                public List<string> AllowOrigin { get; set; }

                /// <summary>
                /// <para>The list of exposed headers.</para>
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
            /// <para>The fixed response content configuration.</para>
            /// </summary>
            [NameInMap("FixedResponseConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class CreateRuleRequestRuleActionsFixedResponseConfig : TeaModel {
                /// <summary>
                /// <para>The fixed content to return. The maximum size is 1 KB. Only ASCII characters are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dssacav</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The format of the fixed content to return. Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text/plain</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The HTTP status code to return. Only numeric strings in the format of <b>2xx</b>, <b>4xx</b>, or <b>5xx</b> are supported, where <b>x</b> represents any digit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

            }

            /// <summary>
            /// <para>The list of destination server groups to which requests are forwarded. You can add up to five destination server groups in a forwarding rule.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateRuleRequestRuleActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The session persistence configuration across server groups.</para>
                /// </summary>
                [NameInMap("ServerGroupStickySession")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable session persistence. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: enables session persistence.</description></item>
                    /// <item><description><b>false</b> (default): disables session persistence.</description></item>
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
                /// <para>The list of destination server groups to which requests are forwarded. You can add up to five destination server groups in a forwarding rule.</para>
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
                    /// <para>The weight. A greater value indicates a higher weight, which means that more requests are forwarded to the server group. Valid values: <b>0</b> to <b>100</b>.</para>
                    /// <list type="bullet">
                    /// <item><description>If only one destination server group is specified and the weight is not specified, the default value is <b>100</b>.</description></item>
                    /// <item><description>If more than one destination server group is specified, you must specify the weight for each server group.</description></item>
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
            /// <para>The configuration for inserting an HTTP header.</para>
            /// </summary>
            [NameInMap("InsertHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsInsertHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The name of the header to insert. The name must be 1 to 40 characters in length and can contain letters, digits, underscores (_), and hyphens (-). Header names in <b>InsertHeaderConfig</b> must be unique.</para>
                /// <remarks>
                /// <para>You cannot set the header name to any of the following fields (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>, and <c>x-forwarded-host</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the header to insert.</para>
                /// <list type="bullet">
                /// <item><description>If <b>ValueType</b> is set to <b>SystemDefined</b>, valid values are:<list type="bullet">
                /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                /// <item><description><b>ClientSrcIp</b>: the client IP address.</description></item>
                /// <item><description><b>Protocol</b>: the protocol used by the client request (HTTP or HTTPS).</description></item>
                /// <item><description><b>SLBId</b>: the instance ID of the application load balancing instance.</description></item>
                /// <item><description><b>SLBPort</b>: the listener port of the application load balancing instance.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>If <b>ValueType</b> is set to <b>UserDefined</b>, you can customize the header value. The value must be 1 to 128 characters in length and can contain asterisks (*), question marks (?), and printable ASCII characters whose ASCII values are <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. Double quotation marks (&quot;) are not supported. The value cannot start or end with a space, and cannot end with a backslash ().</description></item>
                /// <item><description>If <b>ValueType</b> is set to <b>ReferenceHeader</b>, you can reference a field in the request header. The value must be 1 to 128 characters in length and can contain lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UserDefined</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>The content type of the header field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UserDefined</b>: a custom header value.</description></item>
                /// <item><description><b>ReferenceHeader</b>: a referenced value from a field in the request header.</description></item>
                /// <item><description><b>SystemDefined</b>: a system-defined header value.</description></item>
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
            /// <para>The execution order of the forwarding rule action. Valid values: <b>1</b> to <b>50000</b>. Actions are executed in ascending order of their values. The value cannot be empty and must be unique.</para>
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
            /// <para>For the parameters in <b>RedirectConfig</b>, you cannot use default values for all parameters except <b>HttpCode</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RedirectConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class CreateRuleRequestRuleActionsRedirectConfig : TeaModel {
                /// <summary>
                /// <para>The host to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${host}</b> (default): If this value is used, it cannot be concatenated with other characters.</description></item>
                /// <item><description>Other values: The character set and format requirements are as follows:<list type="bullet">
                /// <item><description>The hostname must be 3 to 256 characters in length and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (*), equal signs (=), tildes (~), underscores (_), plus signs (+), backslashes (), carets (^), exclamation marks (!), dollar signs ($), ampersands (&amp;), vertical bars (|), parentheses (()), square brackets ([]), and question marks (?).</description></item>
                /// <item><description>The hostname must contain at least one period (.), and the period (.) cannot be at the beginning or end.</description></item>
                /// <item><description>The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-). The leftmost <c>domainlabel</c> can be an asterisk (*).</description></item>
                /// <item><description>A hyphen (-) cannot be at the beginning or end of other domain labels.</description></item>
                /// <item><description>Asterisks (*) and question marks (?) can appear anywhere in a domain label.</description></item>
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
                /// <para>The HTTP status code for the redirect. Valid values: <b>301</b>, <b>302</b>, <b>303</b>, <b>307</b>, and <b>308</b>.</para>
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
                /// <item><description><b>${path}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with strings within the allowed character set listed below.</description></item>
                /// <item><description>Other values: The character set and format requirements are as follows:<list type="bullet">
                /// <item><description>The path must be 1 to 256 characters in length and is case-sensitive. Asterisks (*) and question marks (?) are supported as wildcards.</description></item>
                /// <item><description>The path must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:\&quot;*?</c>. The following characters are not supported: <c>&quot;</c>, <c>%</c>, <c>#</c>, <c>;</c>, <c>!</c>, <c>(</c>, <c>)</c>, <c>[</c>, <c>]</c>, <c>^</c>, <c>,</c>, and <c>\</c>. Asterisks (*) and question marks (?) are also supported.</description></item>
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
                /// <para>The port to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${port}</b> (default): This value cannot be used together with other characters.</description></item>
                /// <item><description>Other values: <b>1</b> to <b>63335</b>.</description></item>
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
                /// <item><description><b>${protocol}</b> (default): This value can only be used independently and cannot be modified or concatenated with other characters.</description></item>
                /// <item><description><b>HTTP</b></description></item>
                /// <item><description><b>HTTPS</b><remarks>
                /// <list type="bullet">
                /// <item><description>HTTPS listeners support redirection only to the HTTPS protocol.</description></item>
                /// <item><description>HTTP listeners support redirection to both HTTP and HTTPS protocols.</description></item>
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
                /// <para>The query string to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${query}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with strings within the allowed character set listed below.</description></item>
                /// <item><description>Other values: The character set and format requirements are as follows:<list type="bullet">
                /// <item><description>The query string must be 1 to 128 characters in length.</description></item>
                /// <item><description>Visible characters are supported. Spaces and <c>#[]{}\|&lt;&gt;&quot;</c> are not supported. Letters must be lowercase.</description></item>
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
            /// <para>The configuration for removing an HTTP header.</para>
            /// </summary>
            [NameInMap("RemoveHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsRemoveHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The name of the header to remove. The name must be 1 to 40 characters in length and can contain letters, digits, underscores (_), and hyphens (-). Header names in RemoveHeader must be unique.</para>
                /// <list type="bullet">
                /// <item><description>Request direction (when Direction is set to Request): You cannot set the header name to any of the following fields (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>, and <c>x-forwarded-host</c>.</description></item>
                /// <item><description>Response direction (when Direction is set to Response): You cannot set the header name to any of the following fields (case-insensitive): <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, and <c>transfer-encoding</c>.</description></item>
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
            /// <para>If multiple actions are configured in the same forwarding rule, the <b>RewriteConfig</b> action must be used together with the <b>ForwardGroup</b> action type.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RewriteConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class CreateRuleRequestRuleActionsRewriteConfig : TeaModel {
                /// <summary>
                /// <para>The destination host for the internal rewrite. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${host}</b> (default): This value cannot be concatenated with other characters.</description></item>
                /// <item><description>Other values: The character format requirements are as follows:<list type="bullet">
                /// <item><description>The hostname must be 3 to 256 characters in length and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (*), equal signs (=), tildes (~), underscores (_), plus signs (+), backslashes (), carets (^), exclamation marks (!), dollar signs ($), ampersands (&amp;), vertical bars (|), parentheses (()), square brackets ([]), and question marks (?).</description></item>
                /// <item><description>The hostname must contain at least one period (.), and the period (.) cannot be at the beginning or end.</description></item>
                /// <item><description>The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-). The leftmost <c>domainlabel</c> can be an asterisk (*).</description></item>
                /// <item><description>A hyphen (-) cannot be at the beginning or end of other domain labels. Asterisks (*) and question marks (?) can appear anywhere in a domain label.</description></item>
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
                /// <item><description><b>${path}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with strings within the allowed character set listed below.</description></item>
                /// <item><description>Other values: The character set and format requirements are as follows:<list type="bullet">
                /// <item><description>The path must be 1 to 256 characters in length and is case-sensitive. Asterisks (*) and question marks (?) are supported as wildcards.</description></item>
                /// <item><description>The path must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:\&quot;*?</c>. The following characters are not supported: <c>&quot;</c>, <c>%</c>, <c>#</c>, <c>;</c>, <c>!</c>, <c>(</c>, <c>)</c>, <c>[</c>, <c>]</c>, <c>^</c>, <c>,</c>, and <c>\</c>. Asterisks (*) and question marks (?) are also supported.</description></item>
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
                /// <para>The query string for the internal rewrite. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${query}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with strings within the allowed character set listed below.</description></item>
                /// <item><description>Other values: The character set and format requirements are as follows:<list type="bullet">
                /// <item><description>The query string must be 1 to 128 characters in length.</description></item>
                /// <item><description>Visible characters are supported. Spaces and <c>#[]{}\|&lt;&gt;&quot;</c> are not supported. Letters must be lowercase.</description></item>
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
                /// <para>The number of queries per second from a single IP address. Valid values: <b>1</b> to <b>1000000</b>.</para>
                /// <remarks>
                /// <para>If the <b>QPS</b> parameter is also configured, the value of <b>PerIpQps</b> must be less than the value of <b>QPS</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("PerIpQps")]
                [Validation(Required=false)]
                public int? PerIpQps { get; set; }

                /// <summary>
                /// <para>The number of queries per second (QPS). Valid values: <b>1</b> to <b>1000000</b>.</para>
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
                        /// <para>The ID of the server group.</para>
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
                /// <para>The target type for traffic mirroring. Valid values:</para>
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
            /// <item><description><para><b>ForwardGroup</b>: forward requests to multiple virtual services.</para>
            /// </description></item>
            /// <item><description><para><b>Redirect</b>: redirect requests.</para>
            /// </description></item>
            /// <item><description><para><b>FixedResponse</b>: return a fixed response.</para>
            /// </description></item>
            /// <item><description><para><b>Rewrite</b>: rewrite requests.</para>
            /// </description></item>
            /// <item><description><para><b>InsertHeader</b>: insert an HTTP header.</para>
            /// </description></item>
            /// <item><description><para><b>RemoveHeader</b>: delete an HTTP header.</para>
            /// </description></item>
            /// <item><description><para><b>TrafficLimit</b>: limit traffic.</para>
            /// </description></item>
            /// <item><description><para><b>TrafficMirror</b>: mirror traffic.</para>
            /// </description></item>
            /// <item><description><para><b>Cors</b>: configure cross-origin resource sharing (CORS).</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>A forwarding rule must contain at least one <b>ForwardGroup</b>, <b>Redirect</b>, or <b>FixedResponse</b> action. If it is used together with other action types, it must be executed last.</para>
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
                    /// <item><description>Must be 1 to 100 characters in length.</description></item>
                    /// <item><description>Supports visible characters, the asterisk (*) wildcard, and the half-width question mark (?). Letters must be lowercase.</description></item>
                    /// <item><description>Does not support spaces or the following characters: <c>;#[]{}\|&lt;&gt;&amp;&quot;</c>.</description></item>
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
                    /// <item><description>Must be 1 to 100 characters in length.</description></item>
                    /// <item><description>Supports visible characters, the asterisk (*) wildcard, and the half-width question mark (?). Letters must be lowercase.</description></item>
                    /// <item><description>Does not support spaces or the following characters: <c>;#[]{}\|&lt;&gt;&amp;&quot;</c>.</description></item>
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
                /// <item><description>Supports 1 to 40 characters.</description></item>
                /// <item><description>Supports lowercase letters a to z, digits, hyphens (-), and underscores (_).</description></item>
                /// <item><description>Does not support Cookie and Host.</description></item>
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
            /// <para>The host configuration.</para>
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
                    /// <item><description>Must be 1 to 100 characters in length.</description></item>
                    /// <item><description>Supports visible characters, wildcard asterisks (*), and half-width question marks (?). Letters must be lowercase. Does not support spaces or the following characters: <c>#[]{}\|&lt;&gt;&amp;&quot;</c>.</description></item>
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
                    /// <item><description>Must be 1 to 128 characters in length.</description></item>
                    /// <item><description>Supports lowercase letters, visible characters, wildcard asterisks (*), and half-width question marks (?). Does not support spaces or the following characters: <c>#[]{}\|&lt;&gt;&amp;&quot;</c>.</description></item>
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
            /// <para>The header condition configuration.</para>
            /// </summary>
            [NameInMap("ResponseHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
            public class CreateRuleRequestRuleConditionsResponseHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The header field key.</para>
                /// <list type="bullet">
                /// <item><description>Must be 1 to 40 characters in length.</description></item>
                /// <item><description>Supports lowercase letters a to z, digits, hyphens (-), and underscores (_).</description></item>
                /// <item><description>Does not support Cookie and Host.</description></item>
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
            /// <para>The response status code configuration.</para>
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
            /// <para>The source IP-based service traffic matching configuration. Required and valid only when <b>Type</b> is set to <b>SourceIP</b>.</para>
            /// </summary>
            [NameInMap("SourceIpConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
            public class CreateRuleRequestRuleConditionsSourceIpConfig : TeaModel {
                /// <summary>
                /// <para>The list of source IP-based service traffic matching conditions.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The forwarding rule type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Host</b>: Host.</para>
            /// </description></item>
            /// <item><description><para><b>Path</b>: Path.</para>
            /// </description></item>
            /// <item><description><para><b>Header</b>: HTTP header fields.</para>
            /// </description></item>
            /// <item><description><para><b>QueryString</b>: Query string.</para>
            /// </description></item>
            /// <item><description><para><b>Method</b>: Request method.</para>
            /// </description></item>
            /// <item><description><para><b>Cookie</b>: Cookie.</para>
            /// </description></item>
            /// <item><description><para><b>SourceIp</b>: Source IP address.</para>
            /// </description></item>
            /// <item><description><para><b>ResponseHeader</b>: Response HTTP header fields.</para>
            /// </description></item>
            /// <item><description><para><b>ResponseStatusCode</b>: Response status code.</para>
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
        /// <para>The forwarding rule name. </para>
        /// <list type="bullet">
        /// <item><description>Must be 2 to 128 characters in length.</description></item>
        /// <item><description>Must start with a letter, Chinese character, or digit. Can contain digits, periods (.), underscores (_), hyphens (-), and spaces.</description></item>
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
            /// <para>The tag key. Can be up to 128 characters in length. Cannot start with <c>aliyun</c> or <c>acs:</c>. Cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Can be up to 128 characters in length. Cannot start with <c>aliyun</c> or <c>acs:</c>. Cannot contain <c>http://</c> or <c>https://</c>.</para>
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
