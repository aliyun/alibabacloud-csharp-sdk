// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of records returned for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Indicates whether a next query exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of forwarding rules.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListRulesResponseBodyRules> Rules { get; set; }
        public class ListRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The direction of the forwarding rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Request (default): request-based. Condition matching and corresponding processing are performed on requests sent from clients to ALB.</para>
            /// </description></item>
            /// <item><description><para>Response: response-based. Condition matching and corresponding processing are performed on responses returned from backend server groups to ALB.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>ALB Basic Edition instances do not support the Response type.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Request</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The ID of the listener to which the forwarding rule belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-i35udpz3pxsmnf****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The instance ID of the load balancing instance to which the forwarding rule belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-x30o38azsuj0sx****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The rule priority. Valid values: <b>1</b> to <b>10000</b>. A smaller value indicates a higher priority.</para>
            /// <remarks>
            /// <para>Rule priorities must be unique within the same listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The list of forwarding rule actions.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyRulesRuleActions> RuleActions { get; set; }
            public class ListRulesResponseBodyRulesRuleActions : TeaModel {
                /// <summary>
                /// <para>The CORS configuration.</para>
                /// </summary>
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsCorsConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether credentials are allowed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>on</b>: Credentials are allowed.</description></item>
                    /// <item><description><b>off</b>: Credentials are not allowed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>on</para>
                    /// </summary>
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    /// <summary>
                    /// <para>The allowed cross-origin headers.</para>
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
                    /// <para>The allowed origins.</para>
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
                /// <para>The fixed response configuration.</para>
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsFixedResponseConfig : TeaModel {
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
                    /// <para>The HTTP response code to return. Only numeric strings in the format of <b>HTTP_2xx</b>, <b>HTTP_4xx</b>, and <b>HTTP_5xx</b> are supported, where <b>x</b> is any digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP_2xx</para>
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
                public ListRulesResponseBodyRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The session persistence configuration across server groups.</para>
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable session persistence across server groups when multiple server groups are specified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The timeout period for session persistence when Enabled is set to true. Unit: seconds. Valid values: 1 to 86400.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
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
                    public List<ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The ID of the destination server group to which requests are forwarded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sgp-atstuj3rtoptyui****</para>
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        /// <summary>
                        /// <para>The weight. Valid values: <b>0</b> to <b>100</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// <para>The insert header field configuration.</para>
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The name of the header field to insert. The name must be 1 to 40 characters in length and can contain lowercase and uppercase letters a to z, digits, underscores (_), and hyphens (-). The header field name cannot be used more than once in <c>InsertHeader</c>.</para>
                    /// <remarks>
                    /// <para>You cannot use <b>Cookie</b> or <b>Host</b> as the header field name.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The content of the header field to insert.</para>
                    /// <list type="bullet">
                    /// <item><description>If <b>ValueType</b> is set to <b>SystemDefined</b>, the following values are supported:<list type="bullet">
                    /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                    /// <item><description><b>ClientSrcIp</b>: the client IP address.</description></item>
                    /// <item><description><b>Protocol</b>: the protocol used by the client request (HTTP or HTTPS).</description></item>
                    /// <item><description><b>SLBId</b>: the load balancing instance ID.</description></item>
                    /// <item><description><b>SLBPort</b>: the load balancing instance listener port.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description>If <b>ValueType</b> is set to <b>UserDefined</b>: you can specify a custom header field content. The content must be 1 to 128 characters in length and can contain wildcards such as asterisks (*) and question marks (?), as well as printable characters with ASCII values in the range of <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. The content cannot start or end with a space.</description></item>
                    /// <item><description>If <b>ValueType</b> is set to <b>ReferenceHeader</b>: you can reference a field from the request header. The value must be 1 to 128 characters in length and can contain lowercase letters a to z, digits, hyphens (-), and underscores (_).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ClientSrcPort</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The content type of the header field. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>UserDefined</b>: user-defined.</para>
                    /// </description></item>
                    /// <item><description><para><b>ReferenceHeader</b>: references a field from the client request header.</para>
                    /// </description></item>
                    /// <item><description><para><b>SystemDefined</b>: system-defined.</para>
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
                /// <para>The order in which the forwarding rule action is executed. Valid values: <b>1</b> to <b>50000</b>. Actions are executed in ascending order of value. The value cannot be empty or duplicated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The redirect configuration.</para>
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// <para>The host address to redirect to. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${host}</b> (default): this value cannot be concatenated with other characters.</description></item>
                    /// <item><description>Other values. The character set and format restrictions are as follows:<list type="bullet">
                    /// <item><description>The hostname must be 3 to 128 characters in length and can contain lowercase letters a to z, digits, hyphens (-), periods (.), asterisks (*), and question marks (?).</description></item>
                    /// <item><description>The hostname must contain at least one period (.) and cannot start or end with a period (.).</description></item>
                    /// <item><description>The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-).</description></item>
                    /// <item><description>Hyphens (-) cannot appear at the beginning or end of other domain labels.</description></item>
                    /// <item><description>Asterisks (*) and question marks (?) can appear at any position within a domain label.</description></item>
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
                    /// <item><description><b>${path}</b> (default): you can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>, which consist of <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can appear at most once. These variables can be used together or concatenated with strings from the following valid character set.</description></item>
                    /// <item><description>Other values. The character set and format restrictions are as follows:<list type="bullet">
                    /// <item><description>The path must be 1 to 128 characters in length.</description></item>
                    /// <item><description>The path must start with a forward slash (/) and can contain letters, digits, and the special characters <c>$-_.+/&amp;~@:</c>. The characters <c>&quot;%#;!()[]^,&quot; </c> are not supported. Asterisks (*) and question marks (?) are supported as wildcards.</description></item>
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
                    /// <item><description><b>${port}</b> (default): this value cannot be used with other characters.</description></item>
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
                    /// <item><description><b>${protocol}</b> (default): this value cannot be concatenated with other characters.</description></item>
                    /// <item><description><b>HTTP</b> or <b>HTTPS</b>.</description></item>
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
                    /// <para>The query string to redirect to. The query string must be 1 to 128 characters in length and can contain lowercase letters and visible characters. The characters <c>#[]{}\|&lt;&gt;&amp;</c> are not supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quert</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The remove HTTP header configuration.</para>
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The name of the header field to remove. The name must be 1 to 40 characters in length and can contain lowercase and uppercase letters a to z, digits, underscores (_), and hyphens (-). The header field name cannot be used more than once in RemoveHeader.</para>
                    /// <list type="bullet">
                    /// <item><description>Request direction (Direction is set to Request): the header name cannot be set to the following fields (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>.</description></item>
                    /// <item><description>Response direction (Direction is set to Response): the header name cannot be set to the following fields (case-insensitive): <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>.</description></item>
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
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// <para>The host address to redirect to. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${host}</b> (default): this value cannot be concatenated with other characters.</description></item>
                    /// <item><description>Other values. The character set and format restrictions are as follows:<list type="bullet">
                    /// <item><description>The hostname must be 3 to 128 characters in length and can contain lowercase letters a to z, digits, hyphens (-), periods (.), asterisks (*), and question marks (?).</description></item>
                    /// <item><description>The hostname must contain at least one period (.) and cannot start or end with a period (.).</description></item>
                    /// <item><description>The rightmost domain label can contain only letters and wildcards, and cannot contain digits or hyphens (-).</description></item>
                    /// <item><description>Hyphens (-) cannot appear at the beginning or end of other domain labels.</description></item>
                    /// <item><description>Asterisks (*) and question marks (?) can appear at any position within a domain label.</description></item>
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
                    /// <para>The destination path for the internal redirect. The path must be 1 to 128 characters in length, start with a forward slash (/), and can contain letters, digits, asterisks (*), question marks (?), and <c>$-_.+/&amp;~@:</c>. The characters <c>&quot;%#;!()[]^,&quot; </c> are not supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tsdf</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The query string for the internal redirect. The query string must be 1 to 128 characters in length and can contain lowercase letters and visible characters. The characters <c>#[]{}\|&lt;&gt;&amp;</c> are not supported.</para>
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
                public ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// <para>The QPS for each IP address. Valid values: <b>1</b> to <b>100000</b>.</para>
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
                    /// <para>The queries per second (QPS). Valid values: <b>1</b> to <b>100000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }

                }

                /// <summary>
                /// <para>The traffic mirror configuration.</para>
                /// </summary>
                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration for mirroring traffic to a server group.</para>
                    /// </summary>
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        /// <summary>
                        /// <para>The configuration for mirroring traffic to a server group.</para>
                        /// </summary>
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            /// <summary>
                            /// <para>The server group ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>sgp-00mkgijak0w4qgz9****</para>
                            /// </summary>
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                            /// <summary>
                            /// <para>The weight. Valid values: <b>0</b> to <b>100</b>.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2</para>
                            /// </summary>
                            [NameInMap("Weight")]
                            [Validation(Required=false)]
                            public int? Weight { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The destination of traffic mirroring, which can be a server group.</para>
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
                /// <item><description><para><b>ForwardGroup</b>: forwards requests to multiple virtual server groups.</para>
                /// </description></item>
                /// <item><description><para><b>Redirect</b>: redirects requests.</para>
                /// </description></item>
                /// <item><description><para><b>FixedResponse</b>: returns a fixed response.</para>
                /// </description></item>
                /// <item><description><para><b>Rewrite</b>: rewrites requests.</para>
                /// </description></item>
                /// <item><description><para><b>InsertHeader</b>: inserts a header field.</para>
                /// </description></item>
                /// <item><description><para><b>RemoveHeaderConfig</b>: deletes a header field.</para>
                /// </description></item>
                /// <item><description><para><b>TrafficLimitConfig</b>: throttles traffic.</para>
                /// </description></item>
                /// <item><description><para><b>TrafficMirrorConfig</b>: mirrors traffic.</para>
                /// </description></item>
                /// <item><description><para><b>CorsConfig</b>: enables cross-origin resource sharing (CORS).</para>
                /// </description></item>
                /// </list>
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
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyRulesRuleConditions> RuleConditions { get; set; }
            public class ListRulesResponseBodyRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The cookie configuration.</para>
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// <para>The cookie values.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class ListRulesResponseBodyRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The cookie key. The key must be 1 to 100 characters in length and can contain lowercase letters, printable characters, asterisks (*), and question marks (?). The key cannot contain spaces or <c>#[]{}\|&lt;&gt;&amp;</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The cookie value. The value must be 1 to 128 characters in length and can contain lowercase letters, printable characters, asterisks (*), and question marks (?). The value cannot contain spaces or <c>#[]{}\|&lt;&gt;&amp;</c>.</para>
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
                public ListRulesResponseBodyRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The header field key. The key must be 1 to 40 characters in length and can contain letters a to z, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Port</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The header field values.</para>
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
                public ListRulesResponseBodyRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsHostConfig : TeaModel {
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
                public ListRulesResponseBodyRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsMethodConfig : TeaModel {
                    /// <summary>
                    /// <para>The request methods.</para>
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
                public ListRulesResponseBodyRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsPathConfig : TeaModel {
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
                public ListRulesResponseBodyRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// <para>The query strings.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class ListRulesResponseBodyRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The query string key. The key must be 1 to 100 characters in length and can contain lowercase letters, printable characters, asterisks (*), and question marks (?). The key cannot contain spaces or <c>#[]{}\|&lt;&gt;&amp;</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The query string value. The value must be 1 to 128 characters in length and can contain lowercase letters, printable characters, asterisks (*), and question marks (?). The value cannot contain spaces or <c>#[]{}\|&lt;&gt;&amp;</c>.</para>
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
                /// <para>The response HTTP header configuration.</para>
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the response HTTP header. The key must be 1 to 40 characters in length. It can contain lowercase letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.</para>
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
                public ListRulesResponseBodyRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    /// <summary>
                    /// <para>The list of response status codes.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The source IP-based service traffic matching configuration.</para>
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// <para>The source IP addresses to match.</para>
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
                /// <item><description><para><b>QueryString</b>: query character string.</para>
                /// </description></item>
                /// <item><description><para><b>Method</b>: request method.</para>
                /// </description></item>
                /// <item><description><para><b>Cookie</b>: cookie.</para>
                /// </description></item>
                /// <item><description><para><b>SourceIp</b>: source IP address.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>rule-bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the forwarding rule. The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-instance-test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The status of the forwarding rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Provisioning</b>: being created.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Available</b>: running.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("RuleStatus")]
            [Validation(Required=false)]
            public string RuleStatus { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyRulesTags> Tags { get; set; }
            public class ListRulesResponseBodyRulesTags : TeaModel {
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

        /// <summary>
        /// <para>The total number of data records returned for the current request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
