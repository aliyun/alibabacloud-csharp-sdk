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
        /// <para>You can use the client to generate the value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not set this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run and does not create the forwarding rules. The system checks whether the required parameters are set, the request format is valid, and the service limits are met. If the request fails the dry run, the corresponding error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, the system returns an HTTP 2xx status code and creates the forwarding rules.</para>
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
        /// <para>The ID of the listener for the Application Load Balancing instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsn-l16uo9y******</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The list of forwarding rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateRulesRequestRules> Rules { get; set; }
        public class CreateRulesRequestRules : TeaModel {
            /// <summary>
            /// <para>The direction of the forwarding rule.</para>
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
            /// <para>1</para>
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
                    /// <para>Specifies whether to allow credentials. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>on</b>: Yes.</description></item>
                    /// <item><description><b>off</b>: No.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>on</para>
                    /// </summary>
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    /// <summary>
                    /// <para>The list of allowed headers for cross-origin requests.</para>
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
                    /// <para>The allowed origins.</para>
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
                    /// <para>The maximum cache duration of preflight requests in the browser. Unit: seconds.</para>
                    /// <para>Valid values: <b>-1</b> to <b>172800</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the fixed response action.</para>
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// <para>The fixed content to be returned. The maximum size is 1 KB. Only ASCII characters are supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The format of the fixed content to be returned. Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text/plain</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code to be returned. Only numeric strings in the format of <b>2xx</b>, <b>4xx</b>, or <b>5xx</b> are supported, where <b>x</b> represents any digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the forward group action.</para>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The session persistence across server groups.</para>
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable session persistence. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: enables session persistence.</description></item>
                        /// <item><description><b>false</b>: disables session persistence. This is the default value.</description></item>
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
                        /// <para>30</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of destination server groups to which requests are forwarded.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The ID of the server group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sgp-ffm94ovy7lqw******</para>
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        /// <summary>
                        /// <para>The weight. A larger value indicates a higher weight, which means that more requests are forwarded to the server group. Valid values: <b>0</b> to <b>100</b>.</para>
                        /// <list type="bullet">
                        /// <item><description><para>If only one destination server group is specified and the weight is not specified, the default value is <b>100</b>.</para>
                        /// </description></item>
                        /// <item><description><para>If more than one destination server group is specified, you must specify the weight for each server group.</para>
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
                /// <para>The configuration of the insert header action.</para>
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The name of the header to be inserted. The name must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). Header names in <b>InsertHeaderConfig</b> must be unique.</para>
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
                    /// <para>The value of the header to be inserted.</para>
                    /// <list type="bullet">
                    /// <item><description>If <b>ValueType</b> is set to <b>SystemDefined</b>, valid values are:<list type="bullet">
                    /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                    /// <item><description><b>ClientSrcIp</b>: the client IP address.</description></item>
                    /// <item><description><b>Protocol</b>: the protocol of the client request (HTTP or HTTPS).</description></item>
                    /// <item><description><b>SLBId</b>: the Application Load Balancing (ALB) instance ID.</description></item>
                    /// <item><description><b>SLBPort</b>: the listening port of the ALB instance.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description>If <b>ValueType</b> is set to <b>UserDefined</b>, you can customize the header value. The value must be 1 to 128 characters in length, and can contain asterisks (*), question marks (?), and printable characters with ASCII values from 32 to 127 (<c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>). Double quotation marks (&quot;) are not supported. The value cannot start or end with a space, and cannot end with a backslash ().</description></item>
                    /// <item><description>If <b>ValueType</b> is set to <b>ReferenceHeader</b>, you can reference a field in the request header. The value must be 1 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The content type of the header field. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>UserDefined</b>: a custom header value.</para>
                    /// </description></item>
                    /// <item><description><para><b>ReferenceHeader</b>: a referenced field from the request header.</para>
                    /// </description></item>
                    /// <item><description><para><b>SystemDefined</b>: a system-defined header value.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SystemDefined</para>
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
                /// <para>For the parameters in <b>RedirectConfig</b>, you cannot use the default values for all parameters except <b>HttpCode</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// <para>The host to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${host}</b>: the default value. If you use this value, you cannot concatenate it with other characters.</description></item>
                    /// <item><description>Other values: The character set and format requirements are as follows:<list type="bullet">
                    /// <item><description>The hostname must be 3 to 256 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (*), equal signs (=), tildes (~), underscores (_), plus signs (+), backslashes (), carets (^), exclamation marks (!), dollar signs ($), ampersands (&amp;), vertical bars (|), parentheses (()), square brackets ([]), and question marks (?).</description></item>
                    /// <item><description>The hostname must contain at least one period (.), and the period cannot be at the beginning or end of the hostname.</description></item>
                    /// <item><description>The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-). The leftmost <c>domainlabel</c> can be an asterisk (*).</description></item>
                    /// <item><description>A hyphen (-) cannot be at the beginning or end of any other domain label.</description></item>
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
                    /// <item><description><b>${path}</b>: The default value. You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. You can use these variables together or concatenate them with strings within the allowed character set.</description></item>
                    /// <item><description>Other values: The character set and format requirements are as follows:<list type="bullet">
                    /// <item><description>The path must be 1 to 256 characters in length and is case-sensitive. Asterisks (*) and question marks (?) are supported as wildcards.</description></item>
                    /// <item><description>The path must start with a forward slash (/). It can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:\&quot;*?</c>. The following characters are not supported: <c>&quot;%#;!()[]^,&quot;\&quot;</c>. Asterisks (*) and question marks (?) are also supported.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The port to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${port}</b>: the default value. You cannot concatenate this value with other characters.</description></item>
                    /// <item><description>Other values: <b>1</b> to <b>63335</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>443</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The protocol to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${protocol}</b>: the default value. If you use this value, it must be used independently and cannot be modified or concatenated with other characters.</description></item>
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
                    /// <para>HTTPS</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The query string to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${query}</b>: the default value. You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. You can use these variables together or concatenate them with strings within the allowed character set.</description></item>
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
                public CreateRulesRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The name of the header to remove. The name must be 1 to 40 characters in length and can contain letters, digits, underscores (_), and hyphens (-). Header names cannot be duplicated in RemoveHeader.</para>
                    /// <list type="bullet">
                    /// <item><description>Request direction (when Direction is set to Request): The header name cannot be set to any of the following fields (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>, or <c>x-forwarded-host</c>.</description></item>
                    /// <item><description>Response direction (when Direction is set to Response): The header name cannot be set to any of the following fields (case-insensitive): <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, or <c>transfer-encoding</c>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// <para>The rewrite configuration.</para>
                /// <remarks>
                /// <para>If multiple actions are configured for the same forwarding rule, the <b>RewriteConfig</b> action must be used together with the <b>ForwardGroup</b> action type.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// <para>The destination host for the internal rewrite. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${host}</b>: the default value. You cannot concatenate this value with other characters.</para>
                    /// </description></item>
                    /// <item><description><para>Other values: The character set and format requirements are as follows:</para>
                    /// <list type="bullet">
                    /// <item><description><para>The hostname must be 3 to 256 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (*), equal signs (=), tildes (~), underscores (_), plus signs (+), backslashes (), carets (^), exclamation marks (!), dollar signs ($), ampersands (&amp;), vertical bars (|), parentheses (()), square brackets ([]), and question marks (?).</para>
                    /// </description></item>
                    /// <item><description><para>The hostname must contain at least one period (.), and the period cannot be at the beginning or end of the hostname.</para>
                    /// </description></item>
                    /// <item><description><para>The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-). The leftmost <c>domainlabel</c> can be an asterisk (*).</para>
                    /// </description></item>
                    /// <item><description><para>A hyphen (-) cannot be at the beginning or end of any other domain label. Asterisks (*) and question marks (?) can appear anywhere in a domain label.</para>
                    /// </description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.rewrite.alb">www.rewrite.alb</a></para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The path to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${path}</b>: The default value. You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. You can use these variables together or concatenate them with strings within the allowed character set.</description></item>
                    /// <item><description>Other values: The character set and format requirements are as follows:<list type="bullet">
                    /// <item><description>The path must be 1 to 256 characters in length and is case-sensitive. Asterisks (*) and question marks (?) are supported as wildcards.</description></item>
                    /// <item><description>The path must start with a forward slash (/). It can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:\&quot;*?</c>. The following characters are not supported: <c>&quot;%#;!()[]^,&quot;\&quot;</c>. Asterisks (*) and question marks (?) are also supported.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tea</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The query string for the internal rewrite. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${query}</b>: the default value. You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. You can use these variables together or concatenate them with strings within the allowed character set.</description></item>
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
                public CreateRulesRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// <para>The number of queries per second from a single IP address. Valid values: <b>1</b> to <b>1000000</b>.</para>
                    /// <remarks>
                    /// <para>If the <b>QPS</b> parameter is also configured, the value of <b>PerIpQps</b> must be less than the value of <b>QPS</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    /// <summary>
                    /// <para>The number of queries per second (QPS). Valid values: <b>1</b> to <b>1000000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5000</para>
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
                public CreateRulesRequestRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration for mirroring traffic to a server group.</para>
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
                            /// <para>sgp-u9cmf16iu69******</para>
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
                /// <item><description><para><b>ForwardGroup</b>: forwards requests to multiple virtual services.</para>
                /// </description></item>
                /// <item><description><para><b>Redirect</b>: redirects requests.</para>
                /// </description></item>
                /// <item><description><para><b>FixedResponse</b>: returns a fixed response.</para>
                /// </description></item>
                /// <item><description><para><b>Rewrite</b>: rewrites requests.</para>
                /// </description></item>
                /// <item><description><para><b>InsertHeader</b>: inserts a header.</para>
                /// </description></item>
                /// <item><description><para><b>RemoveHeader</b>: deletes a header.</para>
                /// </description></item>
                /// <item><description><para><b>TrafficLimit</b>: limits traffic.</para>
                /// </description></item>
                /// <item><description><para><b>TrafficMirror</b>: mirrors traffic.</para>
                /// </description></item>
                /// <item><description><para><b>Cors</b>: configures cross-origin resource sharing (CORS).</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>A forwarding rule must contain at least one <b>ForwardGroup</b>, <b>Redirect</b>, or <b>FixedResponse</b> action. If other action types are configured, the <b>ForwardGroup</b>, <b>Redirect</b>, or <b>FixedResponse</b> action must be executed last.</para>
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
            public List<CreateRulesRequestRulesRuleConditions> RuleConditions { get; set; }
            public class CreateRulesRequestRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The cookie condition configuration.</para>
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of cookie key-value pairs.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The cookie condition key.</para>
                        /// <list type="bullet">
                        /// <item><description><para>The key must be 1 to 100 characters in length.</para>
                        /// </description></item>
                        /// <item><description><para>The key can contain printable characters, asterisks (*), and question marks (?). Letters must be lowercase.</para>
                        /// </description></item>
                        /// <item><description><para>The key cannot contain spaces or the following characters: <c>;#[]{}\|&lt;&gt;&amp;&quot;</c>.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The cookie condition value.</para>
                        /// <list type="bullet">
                        /// <item><description><para>The value must be 1 to 100 characters in length.</para>
                        /// </description></item>
                        /// <item><description><para>The value can contain printable characters, asterisks (*), and question marks (?). Letters must be lowercase.</para>
                        /// </description></item>
                        /// <item><description><para>The value cannot contain spaces or the following characters: <c>;#[]{}\|&lt;&gt;&amp;&quot;</c>.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The HTTP header condition configuration.</para>
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The HTTP header key.</para>
                    /// <list type="bullet">
                    /// <item><description><para>The key must be 1 to 40 characters in length.</para>
                    /// </description></item>
                    /// <item><description><para>The key can contain letters, digits, hyphens (-), and underscores (_).</para>
                    /// </description></item>
                    /// <item><description><para>The key cannot be Cookie or Host.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>port</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The list of HTTP header values.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The hostname condition configuration.</para>
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of hostnames.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The HTTP request method condition configuration.</para>
                /// </summary>
                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsMethodConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of HTTP request methods.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The path condition configuration.</para>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of path conditions.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The query string condition configuration.</para>
                /// </summary>
                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of query string condition key-value pairs.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The query string condition key.</para>
                        /// <list type="bullet">
                        /// <item><description>The key must be 1 to 100 characters in length.</description></item>
                        /// <item><description>The key can contain printable characters, asterisks (*), and question marks (?). Letters must be lowercase. Spaces and the following characters are not supported: <c>#[]{}\|&lt;&gt;&amp;&quot;</c>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The query string condition value.</para>
                        /// <list type="bullet">
                        /// <item><description>The value must be 1 to 128 characters in length.</description></item>
                        /// <item><description>The value can contain lowercase letters, printable characters, asterisks (*), and question marks (?). Spaces and the following characters are not supported: <c>#[]{}\|&lt;&gt;&amp;&quot;</c>.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The response HTTP header configuration.</para>
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The response HTTP header key.</para>
                    /// <list type="bullet">
                    /// <item><description>The key must be 1 to 40 characters in length.</description></item>
                    /// <item><description>The key can contain letters, digits, hyphens (-), and underscores (_).</description></item>
                    /// <item><description>The key cannot be Cookie or Host.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The list of response HTTP header values.</para>
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
                public CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of response status codes.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration for matching service traffic based on source IP addresses.</para>
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// <para>The source IP addresses used to match service traffic.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The forwarding condition type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Host: Hostname.</para>
                /// </description></item>
                /// <item><description><para>Path: Path.</para>
                /// </description></item>
                /// <item><description><para>Header: HTTP header fields.</para>
                /// </description></item>
                /// <item><description><para>QueryString: Query character string.</para>
                /// </description></item>
                /// <item><description><para>Method: Request method.</para>
                /// </description></item>
                /// <item><description><para>Cookie: Cookie.</para>
                /// </description></item>
                /// <item><description><para>SourceIp: Source IP address.</para>
                /// </description></item>
                /// <item><description><para>ResponseHeader: Response HTTP header fields.</para>
                /// </description></item>
                /// <item><description><para>ResponseStatusCode: Response status code.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SourceIp</para>
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
            /// <para>rule-443-64</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesTag> Tag { get; set; }
            public class CreateRulesRequestRulesTag : TeaModel {
                /// <summary>
                /// <para>The tag key. It can be up to 128 characters in length, cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tag_key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. It can be up to 128 characters in length, cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_tag_value</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
