// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>NextToken</b> is empty, no more results are returned.</para>
        /// </description></item>
        /// <item><description><para>If <b>NextToken</b> has a value, it is the token for the next query.</para>
        /// </description></item>
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
            /// <item><description><para>Request (default): The forwarding rule is applied to requests. ALB matches conditions in the requests sent from clients and performs the specified actions.</para>
            /// </description></item>
            /// <item><description><para>Response: The forwarding rule is applied to responses. ALB matches conditions in the responses sent from backend servers and performs the specified actions.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Basic ALB instances do not support the Response type.</para>
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
            /// <para>The ID of the SLB instance to which the forwarding rule belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-x30o38azsuj0sx****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The priority of the rule. A smaller value indicates a higher priority. Valid values: 1 to <b>10000</b>.</para>
            /// <remarks>
            /// <para>The priority of each rule must be unique within a listener.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The actions of the forwarding rule.</para>
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
                    /// <para>Specifies whether the browser can send credentials. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>on</b></para>
                    /// </description></item>
                    /// <item><description><para><b>off</b></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>on</para>
                    /// </summary>
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    /// <summary>
                    /// <para>The allowed headers for cross-origin requests.</para>
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
                    /// <para>The headers that can be exposed to the browser.</para>
                    /// </summary>
                    [NameInMap("ExposeHeaders")]
                    [Validation(Required=false)]
                    public List<string> ExposeHeaders { get; set; }

                    /// <summary>
                    /// <para>The maximum cache time of preflight requests in the browser. Unit: seconds.</para>
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
                public ListRulesResponseBodyRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// <para>The fixed response. The response can be up to 1 KB in length and can contain only ASCII characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dssacav</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The format of the fixed response.</para>
                    /// <para>Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text/plain</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code of the response. Only <b>HTTP_2xx</b>, <b>HTTP_4xx</b>, and <b>HTTP_5xx</b> are supported. <b>x</b> is a digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP_2xx</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the forwarding group.</para>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The session persistence settings for the server groups.</para>
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        /// <summary>
                        /// <para>Specifies whether to enable session persistence among server groups. This parameter is available when multiple server groups are specified in \<c>ServerGroupTuples\\</c>.</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The timeout period for session persistence. This parameter is available when \<c>Enabled\\</c> is set to \<c>true\\</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                    /// <summary>
                    /// <para>The destination server groups.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The ID of the destination server group.</para>
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
                /// <para>The configuration of the header to be inserted.</para>
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header to be inserted. The key must be 1 to 40 characters in length. It can contain letters, digits, underscores (_), and hyphens (-). The header key in <c>InsertHeader</c> cannot be the same as the key of a header that has been inserted.</para>
                    /// <remarks>
                    /// <para>You cannot set the key to <b>Cookie</b> or <b>Host</b>.</para>
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
                    /// <item><description><para><b>ValueType</b> is set to <b>SystemDefined</b>, you can set the value to:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>ClientSrcPort</b>: the client port.</para>
                    /// </description></item>
                    /// <item><description><para><b>ClientSrcIp</b>: the client IP address.</para>
                    /// </description></item>
                    /// <item><description><para><b>Protocol</b>: the protocol of the client request (HTTP or HTTPS).</para>
                    /// </description></item>
                    /// <item><description><para><b>SLBId</b>: the ID of the Application Load Balancer instance.</para>
                    /// </description></item>
                    /// <item><description><para><b>SLBPort</b>: the listening port of the Application Load Balancer instance.</para>
                    /// </description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If <b>ValueType</b> is set to <b>UserDefined</b>: you can specify a custom header value. The value must be 1 to 128 characters in length. It can contain printable characters with ASCII values from <c>ch &gt;= 32 &amp;&amp; ch &lt; 127</c>. It can also contain wildcard characters, including asterisks (\*) and question marks (?). The value cannot start or end with a space.</para>
                    /// </description></item>
                    /// <item><description><para>If <b>ValueType</b> is set to <b>ReferenceHeader</b>: you can reference a field in the request header. The value must be 1 to 128 characters in length. It can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ClientSrcPort</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The type of the header value. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>UserDefined</b>: a user-defined value.</para>
                    /// </description></item>
                    /// <item><description><para><b>ReferenceHeader</b>: a value that is referenced from a field in the request header.</para>
                    /// </description></item>
                    /// <item><description><para><b>SystemDefined</b>: a system-defined value.</para>
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
                /// <para>The order of the action. Valid values: 1 to 50000. A smaller value indicates a higher priority. The value of this parameter cannot be the same as the value of <b>Order</b> for other actions of the same rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The configuration of the redirection.</para>
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// <para>The destination host to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${host}</b> (default): If you set the value to ${host}, you cannot add other characters to the value.</para>
                    /// </description></item>
                    /// <item><description><para>A value that meets the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description><para>The host must be 3 to 128 characters in length. It can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\*), and question marks (?).</para>
                    /// </description></item>
                    /// <item><description><para>The host must contain at least one period (.). A period (.) cannot be the first or last character.</para>
                    /// </description></item>
                    /// <item><description><para>The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).</para>
                    /// </description></item>
                    /// <item><description><para>The domain labels cannot start or end with a hyphen (-).</para>
                    /// </description></item>
                    /// <item><description><para>You can use asterisks (\*) and question marks (?) anywhere in a domain label.</para>
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
                    /// <para>The redirection method. Valid values: <b>301</b>, <b>302</b>, <b>303</b>, <b>307</b>, and <b>308</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>301</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    /// <summary>
                    /// <para>The destination path to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${path}</b> (default): You can reference <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b>. Each variable can be used at most once. You can use these variables together or combine them with a string.</para>
                    /// </description></item>
                    /// <item><description><para>A value that meets the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description><para>The value must be 1 to 128 characters in length.</para>
                    /// </description></item>
                    /// <item><description><para>It must start with a forward slash (/). It can contain letters, digits, and the following special characters: <c>$-_.+/&amp;~@:</c>. It cannot contain the following special characters: <c>“%#;!()[]^,” </c>. It can contain asterisks (\*) and question marks (?).</para>
                    /// </description></item>
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
                    /// <para>The destination port to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${port}</b> (default): If you set the value to ${port}, you cannot add other characters to the value.</para>
                    /// </description></item>
                    /// <item><description><para>1 to <b>63335</b>.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The destination protocol to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${protocol}</b> (default): If you set the value to ${protocol}, you cannot add other characters to the value.</para>
                    /// </description></item>
                    /// <item><description><para><b>HTTP</b> or <b>HTTPS</b>.</para>
                    /// </description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>HTTPS listeners support only HTTPS.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The query string of the destination to which requests are redirected. The query string must be 1 to 128 characters in length. It can contain lowercase letters and printable characters. It cannot contain <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quert</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The configuration for removing a header.</para>
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header to be removed. The key must be 1 to 40 characters in length. It can contain letters, digits, underscores (_), and hyphens (-). The header key in RemoveHeader cannot be the same as the key of a header that has been removed.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If Direction is set to Request, you cannot remove the following headers (case-insensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, and <c>authority</c>.</para>
                    /// </description></item>
                    /// <item><description><para>If Direction is set to Response, you cannot remove the following headers (case-insensitive): <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, and <c>transfer-encoding</c>.</para>
                    /// </description></item>
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
                /// <para>The configuration of the rewrite.</para>
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// <para>The destination host to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${host}</b> (default): If you set the value to ${host}, you cannot add other characters to the value.</para>
                    /// </description></item>
                    /// <item><description><para>A value that meets the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description><para>The host must be 3 to 128 characters in length. It can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\*), and question marks (?).</para>
                    /// </description></item>
                    /// <item><description><para>The host must contain at least one period (.). A period (.) cannot be the first or last character.</para>
                    /// </description></item>
                    /// <item><description><para>The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).</para>
                    /// </description></item>
                    /// <item><description><para>The domain labels cannot start or end with a hyphen (-).</para>
                    /// </description></item>
                    /// <item><description><para>You can use asterisks (\*) and question marks (?) anywhere in a domain label.</para>
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
                    /// <para>The destination path to which requests are redirected. The path must be 1 to 128 characters in length. It must start with a forward slash (/). It can contain letters, digits, asterisks (\*), question marks (?), and the following special characters: <c>$-_.+/&amp;~@:</c>. It cannot contain <c>“%#;!()[]^,” </c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tsdf</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The query string of the destination to which requests are redirected. The query string must be 1 to 128 characters in length. It can contain lowercase letters and printable characters. It cannot contain <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quedsa</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The configuration of throttling.</para>
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// <para>The QPS of a single IP address. Valid values: 1 to <b>100000</b>.</para>
                    /// <remarks>
                    /// <para>If you set both QPS and <b>PerIpQps</b>, the value of <b>PerIpQps</b> must be smaller than the value of <b>QPS</b>.</para>
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
                /// <para>The configuration of traffic mirroring.</para>
                /// </summary>
                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    /// <summary>
                    /// <para>The server group to which traffic is mirrored.</para>
                    /// </summary>
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        /// <summary>
                        /// <para>The server groups to which traffic is mirrored.</para>
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
                    /// <para>The destination of traffic mirroring. The value can be \<c>ForwardGroupMirror\\</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ForwardGroupMirror</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// <para>The type of the action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>ForwardGroup</b>: forwards requests to multiple vServer groups.</para>
                /// </description></item>
                /// <item><description><para><b>Redirect</b>: redirects requests.</para>
                /// </description></item>
                /// <item><description><para><b>FixedResponse</b>: returns a fixed response.</para>
                /// </description></item>
                /// <item><description><para><b>Rewrite</b>: rewrites a request.</para>
                /// </description></item>
                /// <item><description><para><b>InsertHeader</b>: inserts a header.</para>
                /// </description></item>
                /// <item><description><para><b>RemoveHeaderConfig</b>: removes a header.</para>
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
            /// <para>The conditions of the forwarding rule.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<ListRulesResponseBodyRulesRuleConditions> RuleConditions { get; set; }
            public class ListRulesResponseBodyRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The configuration of the cookie.</para>
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
                        /// <para>The key of the cookie. The key must be 1 to 100 characters in length. It can contain lowercase letters, printable characters, asterisks (\*), and question marks (?). It cannot contain spaces or the following special characters: <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the cookie. The value must be 1 to 128 characters in length. It can contain lowercase letters, printable characters, asterisks (\*), and question marks (?). It cannot contain spaces or the following special characters: <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
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
                /// <para>The configuration of the header.</para>
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header. The key must be 1 to 40 characters in length. It can contain letters, digits, hyphens (-), and underscores (_). You cannot set the key to Cookie or Host.</para>
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
                /// <para>The configuration of the host.</para>
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
                /// <para>The configuration of the request method.</para>
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
                /// <para>The configuration of the path.</para>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The paths.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the query string.</para>
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
                        /// <para>The key of the query string. The key must be 1 to 100 characters in length. It can contain lowercase letters, printable characters, asterisks (\*), and question marks (?). It cannot contain spaces or the following special characters: <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the query string. The value must be 1 to 128 characters in length. It can contain lowercase letters, printable characters, asterisks (\*), and question marks (?). It cannot contain spaces or the following special characters: <c>#[]{}\\|&lt;&gt;&amp;</c>.</para>
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
                /// <para>The configuration of the response HTTP header.</para>
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the response HTTP header. The key must be 1 to 40 characters in length. It can contain letters, digits, hyphens (-), and underscores (_). You cannot set the key to Cookie or Host.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The values of the response HTTP header.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the response status code.</para>
                /// </summary>
                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    /// <summary>
                    /// <para>The response status codes.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the source IP address.</para>
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
                /// <item><description><para><b>Host</b>: a host.</para>
                /// </description></item>
                /// <item><description><para><b>Path</b>: a path.</para>
                /// </description></item>
                /// <item><description><para><b>Header</b>: an HTTP header.</para>
                /// </description></item>
                /// <item><description><para><b>QueryString</b>: a query string.</para>
                /// </description></item>
                /// <item><description><para><b>Method</b>: a request method.</para>
                /// </description></item>
                /// <item><description><para><b>Cookie</b>: a cookie.</para>
                /// </description></item>
                /// <item><description><para><b>SourceIp</b>: a source IP address.</para>
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
            /// <para>The name of the forwarding rule. The name must be 2 to 128 characters in length, start with a letter or a Chinese character, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
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
            /// <item><description><para><b>Provisioning</b>: The rule is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: The rule is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>Available</b>: The rule is running.</para>
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
                /// <para>The tag key. The tag key can be up to 128 characters in length. It cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c>, and cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The tag value can be up to 128 characters in length. It cannot start with \<c>aliyun\\</c> or \<c>acs:\\</c>, and cannot contain \<c>http\\://\\</c> or \<c>https\\://\\</c>.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
