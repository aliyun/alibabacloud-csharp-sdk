// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateRuleAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value of each API request is different.</para>
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
        /// <para>The priority of the rule. Valid values: <b>1</b> to <b>10000</b>. A smaller value specifies a higher priority.</para>
        /// <remarks>
        /// <para>Rule priorities within the same listener must be unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The forwarding rule actions.</para>
        /// </summary>
        [NameInMap("RuleActions")]
        [Validation(Required=false)]
        public List<UpdateRuleAttributeRequestRuleActions> RuleActions { get; set; }
        public class UpdateRuleAttributeRequestRuleActions : TeaModel {
            /// <summary>
            /// <para>The cross-origin resource sharing (CORS) configuration.</para>
            /// </summary>
            [NameInMap("CorsConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsCorsConfig CorsConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsCorsConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow credentials. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: allows credentials.</description></item>
                /// <item><description><b>off</b>: does not allow credentials.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("AllowCredentials")]
                [Validation(Required=false)]
                public string AllowCredentials { get; set; }

                /// <summary>
                /// <para>The list of headers allowed for cross-origin access.</para>
                /// </summary>
                [NameInMap("AllowHeaders")]
                [Validation(Required=false)]
                public List<string> AllowHeaders { get; set; }

                /// <summary>
                /// <para>The HTTP methods allowed for cross-origin access.</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public List<string> AllowMethods { get; set; }

                /// <summary>
                /// <para>The list of allowed origins. You can configure a single element <c>*</c> or one or more values.</para>
                /// <list type="bullet">
                /// <item><description>Each value must start with <c>http://</c> or <c>https://</c>, followed by a valid domain name or a first-level wildcard domain name (for example, <c>http://*.test.abc.example.com</c>).</description></item>
                /// <item><description>Each value can optionally include a port. Port range: <b>1</b> to <b>65535</b>.</description></item>
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
            /// <para>The fixed response configuration.</para>
            /// </summary>
            [NameInMap("FixedResponseConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsFixedResponseConfig : TeaModel {
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
                /// <para>The format of the fixed content to return.</para>
                /// <para>Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text/plain</para>
                /// </summary>
                [NameInMap("ContentType")]
                [Validation(Required=false)]
                public string ContentType { get; set; }

                /// <summary>
                /// <para>The HTTP response code to return. Only numeric strings in the <b>2xx</b>, <b>4xx</b>, and <b>5xx</b> format are supported, where <b>x</b> is any digit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

            }

            /// <summary>
            /// <para>The forward group configuration.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The session persistence configuration between server groups.</para>
                /// </summary>
                [NameInMap("ServerGroupStickySession")]
                [Validation(Required=false)]
                public UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
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
                    /// <para>The timeout period. Unit: seconds. Valid values: 1 to 86400.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                /// <summary>
                /// <para>The destination server groups to which requests are forwarded.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The ID of the destination server group to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg--atstuj3rtoptyui****</para>
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                    /// <summary>
                    /// <para>The weight. A larger value specifies a higher weight, which means more requests are forwarded to the server group. Valid values: <b>0</b> to <b>100</b>.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If only one destination server group is specified, the default weight is <b>100</b> when no weight is specified.</para>
                    /// </description></item>
                    /// <item><description><para>If more than one destination server group is specified, you must specify the weight value.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public int? Weight { get; set; }

                }

            }

            /// <summary>
            /// <para>The insert header configuration.</para>
            /// </summary>
            [NameInMap("InsertHeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsInsertHeaderConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to overwrite the value in the request. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: overwrites the value.</description></item>
                /// <item><description><b>false</b> (default): does not overwrite the value.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("CoverEnabled")]
                [Validation(Required=false)]
                public bool? CoverEnabled { get; set; }

                /// <summary>
                /// <para>The name of the header to insert. The name must be 1 to 40 characters in length and can contain uppercase and lowercase letters a to z, digits, underscores (_), and hyphens (-). The header name specified in <b>InsertHeaderConfig</b> must be unique.</para>
                /// <remarks>
                /// <para>The header name cannot be set to the following fields (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>x-forwarded-host</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>key</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The content of the header to insert.</para>
                /// <list type="bullet">
                /// <item><description>If <b>ValueType</b> is set to <b>SystemDefined</b>, valid values are:<list type="bullet">
                /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                /// <item><description><b>ClientSrcIp</b>: the client IP address.</description></item>
                /// <item><description><b>Protocol</b>: the protocol used by the client request (HTTP or HTTPS).</description></item>
                /// <item><description><b>SLBId</b>: the Application Load Balancer (ALB) instance ID.</description></item>
                /// <item><description><b>SLBPort</b>: the Application Load Balancer (ALB) instance listener port.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description>If <b>ValueType</b> is set to <b>UserDefined</b>: you can specify a custom header value. The value must be 1 to 128 characters in length and can contain wildcards asterisks (*), question marks (?), and printable characters whose ASCII values are <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The value cannot contain <c>&quot;</c>. The value cannot start or end with a space. The value cannot end with <c>\\</c>.</description></item>
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
                /// <para>The content type of the header value. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>UserDefined</b>: a custom header value.</para>
                /// </description></item>
                /// <item><description><para><b>ReferenceHeader</b>: references a field in the request header.</para>
                /// </description></item>
                /// <item><description><para><b>SystemDefined</b>: a system-defined header value.</para>
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
            /// <para>The priority of the action in the forwarding rule. Valid values: <b>1</b> to <b>50000</b>. Actions are performed in ascending order of priority. This value cannot be empty or duplicated. You can specify up to 20 action priorities.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            /// <summary>
            /// <para>The redirect configuration. You can add up to 20 redirects.</para>
            /// </summary>
            [NameInMap("RedirectConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRedirectConfig : TeaModel {
                /// <summary>
                /// <para>The host to redirect to. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${host}</b> (default): this value cannot be concatenated with other characters.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The hostname must be 3 to 256 characters in length and can contain lowercase letters a to z, digits, hyphens (-), periods (.), asterisks (*), and question marks (?).</description></item>
                /// <item><description>The hostname must contain at least one period (.). Periods (.) cannot appear at the beginning or end.</description></item>
                /// <item><description>The rightmost domain label can contain only letters and wildcards. It cannot contain digits or hyphens (-).</description></item>
                /// <item><description>Hyphens (-) cannot appear at the beginning or end of other domain labels.</description></item>
                /// <item><description>Asterisks (*) and question marks (?) can appear at any position of a domain label.</description></item>
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
                /// <para>The redirect type. Valid values: <b>301</b>, <b>302</b>, <b>303</b>, <b>307</b>, and <b>308</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>301</para>
                /// </summary>
                [NameInMap("HttpCode")]
                [Validation(Required=false)]
                public string HttpCode { get; set; }

                /// <summary>
                /// <para>The path to redirect to. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${path}</b> (default): you can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with characters within the allowed value range listed below.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The path must be 1 to 256 characters in length.</description></item>
                /// <item><description>The path must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:</c>. The path cannot contain <c>&quot;%#;!()[]^,&quot;\\&quot;</c>. Asterisks (*) and question marks (?) can be used as wildcards.</description></item>
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
                /// <para>The port to redirect to. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${port}</b> (default): this value can only be used alone and cannot be concatenated with other characters.</description></item>
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
                /// <para>The protocol to redirect to. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>${protocol}</b> (default): this value cannot be concatenated with other characters.</para>
                /// </description></item>
                /// <item><description><para><b>HTTP</b> or <b>HTTPS</b>.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>HTTPS listeners support only redirects to HTTPS.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>The query string to redirect to. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${query}</b> (default): you can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with characters within the allowed value range listed below.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The query string must be 1 to 128 characters in length.</description></item>
                /// <item><description>The query string can contain printable characters but cannot contain spaces or <c>#[]{}\\|&lt;&gt;&quot;</c>. Letters must be lowercase.</description></item>
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
            /// <para>The remove header configuration.</para>
            /// </summary>
            [NameInMap("RemoveHeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRemoveHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The name of the header to remove. The name must be 1 to 40 characters in length and can contain uppercase and lowercase letters a to z, digits, underscores (_), and hyphens (-). The header name cannot be duplicated in RemoveHeader.</para>
                /// <list type="bullet">
                /// <item><description>Request direction (Direction is set to Request): the header name cannot be set to the following fields (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>x-forwarded-host</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>.</description></item>
                /// <item><description>Response direction (Direction is set to Response): the header name cannot be set to the following fields (case-insensitive): <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>.</description></item>
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
            /// </summary>
            [NameInMap("RewriteConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRewriteConfig : TeaModel {
                /// <summary>
                /// <para>The destination host address for internal redirects. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>${host}</b> (default): this value cannot be concatenated with other characters.</para>
                /// </description></item>
                /// <item><description><para>Other values. Character set and format restrictions are as follows:</para>
                /// <list type="bullet">
                /// <item><description><para>The hostname must be 3 to 256 characters in length and can contain lowercase letters a to z, digits, hyphens (-), periods (.), asterisks (*), and question marks (?).</para>
                /// </description></item>
                /// <item><description><para>The hostname must contain at least one period (.). Periods (.) cannot appear at the beginning or end.</para>
                /// </description></item>
                /// <item><description><para>The rightmost domain label can contain only letters and wildcards. It cannot contain digits or hyphens (-).</para>
                /// </description></item>
                /// <item><description><para>Hyphens (-) cannot appear at the beginning or end of other domain labels. Asterisks (*) and question marks (?) can appear at any position of a domain label.</para>
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
                /// <para>The path to redirect to. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${path}</b> (default): you can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with characters within the allowed value range listed below.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The path must be 1 to 256 characters in length.</description></item>
                /// <item><description>The path must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:</c>. The path cannot contain <c>&quot;%#;!()[]^,&quot;\\&quot;</c>. Asterisks (*) and question marks (?) can be used as wildcards.</description></item>
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
                /// <para>The query string for internal redirects. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>${query}</b> (default): you can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with characters within the allowed value range listed below.</description></item>
                /// <item><description>Other values. Character set and format restrictions are as follows:<list type="bullet">
                /// <item><description>The query string must be 1 to 128 characters in length.</description></item>
                /// <item><description>The query string can contain printable characters but cannot contain spaces or <c>#[]{}\\|&lt;&gt;&quot;</c>. Letters must be lowercase.</description></item>
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
            /// <para>The traffic throttling configuration.</para>
            /// </summary>
            [NameInMap("TrafficLimitConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsTrafficLimitConfig : TeaModel {
                /// <summary>
                /// <para>The QPS per IP address. Valid values: <b>1</b> to <b>1000000</b>.</para>
                /// <remarks>
                /// <para>If both <b>QPS</b> and <b>PerIpQps</b> are configured, the value of <b>PerIpQps</b> must be less than the value of <b>QPS</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("PerIpQps")]
                [Validation(Required=false)]
                public int? PerIpQps { get; set; }

                /// <summary>
                /// <para>The queries per second (QPS). Valid values: <b>1</b> to <b>1000000</b>.</para>
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
            public UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfig : TeaModel {
                /// <summary>
                /// <para>The configuration for mirroring traffic to a server group.</para>
                /// </summary>
                [NameInMap("MirrorGroupConfig")]
                [Validation(Required=false)]
                public UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration for mirroring traffic to a server group.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The server group ID.</para>
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
            /// <para>The action type. You can add up to 11 action types. Valid values:</para>
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
            /// <item><description><para><b>TrafficLimit</b>: throttles traffic.</para>
            /// </description></item>
            /// <item><description><para><b>TrafficMirror</b>: mirrors traffic.</para>
            /// </description></item>
            /// <item><description><para><b>Cors</b>: enables cross-origin resource sharing (CORS).</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>A forwarding rule must contain one <b>ForwardGroup</b>, <b>Redirect</b>, or <b>FixedResponse</b> action. When this action coexists with other action types, it must be the last action to execute.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ForwardGroup</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The forwarding rule conditions.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<UpdateRuleAttributeRequestRuleConditions> RuleConditions { get; set; }
        public class UpdateRuleAttributeRequestRuleConditions : TeaModel {
            /// <summary>
            /// <para>The cookie configuration.</para>
            /// </summary>
            [NameInMap("CookieConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsCookieConfig CookieConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsCookieConfig : TeaModel {
                /// <summary>
                /// <para>The cookie configuration.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleConditionsCookieConfigValues> Values { get; set; }
                public class UpdateRuleAttributeRequestRuleConditionsCookieConfigValues : TeaModel {
                    /// <summary>
                    /// <para>The cookie key. The key must be 1 to 100 characters in length and can contain lowercase letters, printable characters, asterisks (*), and question marks (?). The key cannot contain spaces or <c>#[]{}\\|&lt;&gt;&amp;&quot;;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The cookie value. The value must be 1 to 128 characters in length and can contain lowercase letters, printable characters, asterisks (*), and question marks (?). The value cannot contain spaces or <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
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
            /// <para>The header configuration.</para>
            /// </summary>
            [NameInMap("HeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsHeaderConfig HeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The header key. The key must be 1 to 40 characters in length and can contain letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Port</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The header values.</para>
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
            public UpdateRuleAttributeRequestRuleConditionsHostConfig HostConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsHostConfig : TeaModel {
                /// <summary>
                /// <para>The hostnames.</para>
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
            public UpdateRuleAttributeRequestRuleConditionsMethodConfig MethodConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsMethodConfig : TeaModel {
                /// <summary>
                /// <para>The request methods.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The path configuration for forwarding.</para>
            /// </summary>
            [NameInMap("PathConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsPathConfig PathConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsPathConfig : TeaModel {
                /// <summary>
                /// <para>The forwarding paths.</para>
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
            public UpdateRuleAttributeRequestRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsQueryStringConfig : TeaModel {
                /// <summary>
                /// <para>The query strings. You can add up to 20 query strings.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleConditionsQueryStringConfigValues> Values { get; set; }
                public class UpdateRuleAttributeRequestRuleConditionsQueryStringConfigValues : TeaModel {
                    /// <summary>
                    /// <para>The query string key. The key must be 1 to 100 characters in length and can contain lowercase letters, printable characters, asterisks (*), and question marks (?). The key cannot contain spaces or <c>#[]{}\\|&lt;&gt;&amp;&quot;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The query string value. The value must be 1 to 128 characters in length and can contain lowercase letters, printable characters, asterisks (*), and question marks (?). The value cannot contain spaces or <c>#[]{}\\|&lt;&gt;&amp;&quot;</c>.</para>
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
            /// <para>The response header condition configuration.</para>
            /// </summary>
            [NameInMap("ResponseHeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsResponseHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The header key.</para>
                /// <list type="bullet">
                /// <item><description>The key must be 1 to 40 characters in length.</description></item>
                /// <item><description>The key can contain letters a to z, digits, hyphens (-), and underscores (_).</description></item>
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
                /// <para>The header values.</para>
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
            public UpdateRuleAttributeRequestRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsResponseStatusCodeConfig : TeaModel {
                /// <summary>
                /// <para>The response status code list.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The source IP-service traffic matching configuration. You can add up to 5 source IP-service traffic matching conditions.</para>
            /// </summary>
            [NameInMap("SourceIpConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsSourceIpConfig : TeaModel {
                /// <summary>
                /// <para>One or more IP addresses or CIDR blocks.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The type of forwarding rule. You can add up to 7 types of forwarding rules. Valid values:</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>Host</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The forwarding rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-4dp5i6ea****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the forwarding rule. The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. The name must start with a letter, Chinese character, or digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-instance-test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
