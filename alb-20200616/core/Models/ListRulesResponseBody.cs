// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the forwarding rule.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<ListRulesResponseBodyRules> Rules { get; set; }
        public class ListRulesResponseBodyRules : TeaModel {
            /// <summary>
            /// <para>The direction to which the forwarding rule is applied. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Request (default): The forwarding rule is applied to requests. The forwarding action is performed on packets that are forwarded from clients to ALB.</description></item>
            /// <item><description>Responses: The forwarding rule is applied to responses. The forwarding action is performed on packets that are returned from backend servers to ALB.</description></item>
            /// </list>
            /// <remarks>
            /// <para> Basic ALB instances support only the Response direction.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Request</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The ID of the listener that is associated with the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-i35udpz3pxsmnf****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The ID of the Application Load Balancer (ALB) instance that is associated with the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-x30o38azsuj0sx****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The priority of the forwarding rule. Valid values: <b>1 to 10000</b>. A smaller value indicates a higher priority.</para>
            /// <remarks>
            /// <para> The priority of each forwarding rule added to a listener must be unique.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The action of the forwarding rule.</para>
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
                    /// <para>Indicates whether credentials can be carried in CORS requests. Valid values:</para>
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
                    /// <para>The allowed headers of CORS requests.</para>
                    /// </summary>
                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowHeaders { get; set; }

                    /// <summary>
                    /// <para>The allowed HTTP methods of CORS requests.</para>
                    /// </summary>
                    [NameInMap("AllowMethods")]
                    [Validation(Required=false)]
                    public List<string> AllowMethods { get; set; }

                    /// <summary>
                    /// <para>The allowed origins of CORS requests.</para>
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
                    /// <para>The maximum cache time of dry runs in the browser. Unit: seconds.</para>
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
                /// <para>The configuration of the custom response.</para>
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// <para>The content of the custom response. The content can be up to 1 KB in size, and can contain only ASCII characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dssacav</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The format of the response.</para>
                    /// <para>Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text/plain</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code in responses. Valid values: <b>HTTP_2xx</b>, <b>HTTP_4xx</b>, and <b>HTTP_5xx</b>. <b>x</b> is a digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP_2xx</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// <para>The configurations of the server groups.</para>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The session persistence configurations of the server group.</para>
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        /// <summary>
                        /// <para>If the value of N in ServerGroupTuple.N is larger than 1, you can enable or disable session persistence for server groups.</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>If Enabled is set to True, you can specify a session persistence timeout period.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
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
                    public List<ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The server group to which requests are forwarded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-atstuj3rtoptyui****</para>
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        /// <summary>
                        /// <para>The weight of the server group. Valid values: <b>0</b> to <b>100</b>.</para>
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
                /// <para>The key of the header to be inserted.</para>
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header. The header key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header key specified in <c>InsertHeader</c> must be unique.</para>
                    /// <remarks>
                    /// <para> <b>Cookie</b> and <b>Host</b> are not supported.</para>
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
                    /// <item><description><para>If <b>ValueType</b> is set to <b>SystemDefined</b>, you can set the Value parameter to one of the following values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                    /// <item><description><b>ClientSrcIp</b>: the IP address of the client.</description></item>
                    /// <item><description><b>Protocol</b>: the request protocol (HTTP or HTTPS).</description></item>
                    /// <item><description><b>SLBId</b>: the ID of the ALB instance.</description></item>
                    /// <item><description><b>SLBPort</b>: the listener port.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If <b>ValueType</b> is set to <b>UserDefined</b>, you can specify a custom header value. The header value must be 1 to 128 characters in length, and can contain wildcard characters, such as asterisks (\*) and question marks (?), and printable characters whose ASCII values are <c>larger than or equal to 32 and smaller than 127</c>. The header value cannot start or end with a space character.</para>
                    /// </description></item>
                    /// <item><description><para>If <b>ValueType</b> is set to <b>ReferenceHeader</b>, you can reference a value from a request header. The header value must be 1 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
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
                    /// <item><description><b>UserDefined</b>: a user-defined header value.</description></item>
                    /// <item><description><b>ReferenceHeader</b>: a header value that is referenced from a request header.</description></item>
                    /// <item><description><b>SystemDefined:</b> a system-defined header value.</description></item>
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
                /// <para>The priority of the action. Valid values: <b>1 to 50000</b>. A smaller value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter cannot empty. The priority of each action within a forwarding rule must be unique.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The configuration of the redirect action.</para>
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostname to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${host}</b> (default): If ${host} is returned, no other characters are appended.</para>
                    /// </description></item>
                    /// <item><description><para>A custom value. Make sure that the custom value meets the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\*), and question marks (?).</description></item>
                    /// <item><description>The hostname must contain at least one period (.) but cannot start or end with a period (.).</description></item>
                    /// <item><description>The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).</description></item>
                    /// <item><description>The domain labels cannot start or end with a hyphen (-).</description></item>
                    /// <item><description>You can use asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.</description></item>
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
                    /// <para>The forwarding method. Valid values: <b>301</b>, <b>302</b>, <b>303</b>, <b>307</b>, and <b>308</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>301</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    /// <summary>
                    /// <para>The URL to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${path}</b> (default): You can reference \<em>\</em>${host}<b>, <b>${protocol}</b>, and</b>${port}<b>. The URL can consist of <b>${host}</b>,</b>${protocol}**, and **${port}\<em>\</em>. Each variable can be used only once. The preceding variables can be used at the same time or combined with a custom value.</para>
                    /// </description></item>
                    /// <item><description><para>A custom value. Make sure that the custom value meets the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>The URL must be 1 to 128 characters in length.</description></item>
                    /// <item><description>It must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$ - _ .+ / &amp; ~ @ :</c>. It cannot contain the following special characters: <c>&quot; % # ; ! ( ) [ ] ^ , &quot;</c>. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
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
                    /// <item><description><b>${port}</b> (default): If ${port} is returned, no other characters are appended.</description></item>
                    /// <item><description>Other valid values: <b>1 to 63335</b>.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The redirect protocol. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>${protocol}</b> (default): If ${protocol} is returned, no other characters are appended.</description></item>
                    /// <item><description><b>HTTP</b> or <b>HTTPS</b></description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> HTTPS listeners supports only HTTPS redirects.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The query string of the URL to which requests are redirected. The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quert</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The HTTP header to be removed.</para>
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header to be removed. The header key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header keys specified in RemoveHeader must be unique.</para>
                    /// <list type="bullet">
                    /// <item><description>If Direction is set to Request, the specified headers are removed from requests. The following header keys are not supported (not case-sensitive): <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, and <c>authority</c>.</description></item>
                    /// <item><description>If Direction is set to Response, the specified headers are removed from responses. The following header keys are not supported (not case-sensitive): <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, and <c>transfer-encoding</c>.</description></item>
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
                /// <para>The configuration of the rewrite action.</para>
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostname to which requests are redirected. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${host}</b> (default): If ${host} is returned, no other characters are appended.</para>
                    /// </description></item>
                    /// <item><description><para>A custom value. Make sure that the custom value meets the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\*), and question marks (?).</description></item>
                    /// <item><description>The hostname must contain at least one period (.) but cannot start or end with a period (.).</description></item>
                    /// <item><description>The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).</description></item>
                    /// <item><description>The domain labels cannot start or end with a hyphen (-).</description></item>
                    /// <item><description>You can use asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.</description></item>
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
                    /// <para>The URL to which requests are redirected. The URL must be 1 to 128 characters in length, and can contain letters, digits, asterisks (\*), question marks (?), and the following special characters: <c>$ - _ . + / &amp; ~ @ :</c>. It must start with a forward slash (/) and does not contain the following special characters: <c>&quot; % # ; ! ( ) [ ] ^ , &quot;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tsdf</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The query string of the URL to which requests are redirected. The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quedsa</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The configuration of traffic throttling.</para>
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// <para>The number of requests per IP address. Valid values: <b>1 to 100000</b>.</para>
                    /// <remarks>
                    /// <para> If both the <b>QPS</b> and <b>PerIpQps</b> parameters are specified, the value of the <b>QPS</b> parameter is smaller than the value of the PerIpQps parameter.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    /// <summary>
                    /// <para>The number of queries per second (QPS). Valid values: <b>1</b> to <b>100000</b>.</para>
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
                    /// <para>The configuration of the server group to which traffic is mirrored.</para>
                    /// </summary>
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        /// <summary>
                        /// <para>The server group to which traffic is mirrored.</para>
                        /// </summary>
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class ListRulesResponseBodyRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            /// <summary>
                            /// <para>The ID of the server group.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>srg-00mkgijak0w4qgz9****</para>
                            /// </summary>
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                            /// <summary>
                            /// <para>The weight of the server group. Valid values: <b>0</b> to <b>100</b>.</para>
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
                    /// <para>The destination to which traffic is mirrored. The destination can be a server group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ForwardGroupMirror</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// <para>The action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroup</b>: distributes requests to multiple vServer groups.</description></item>
                /// <item><description><b>Redirect</b>: redirects requests.</description></item>
                /// <item><description><b>FixedResponse</b>: returns a custom response.</description></item>
                /// <item><description><b>Rewrite</b>: rewrites requests.</description></item>
                /// <item><description><b>InsertHeader</b>: inserts headers.</description></item>
                /// <item><description><b>RemoveHeaderConfig</b>: removes headers.</description></item>
                /// <item><description><b>TrafficLimitConfig</b>: throttles network traffic.</description></item>
                /// <item><description><b>TrafficMirrorConfig</b>: mirrors network traffic.</description></item>
                /// <item><description><b>CorsConfig</b>: forwards requests based on CORS.</description></item>
                /// </list>
                /// <para>The preceding actions can be classified into two broad types:</para>
                /// <list type="bullet">
                /// <item><description><b>FinalType</b>: Each forwarding rule can contain only one FinalType action, which is performed at the end. You can specify only one of <b>ForwardGroup</b>, <b>Redirect</b>, and <b>FixedResponse</b>.</description></item>
                /// <item><description><b>ExtType</b>: Each forwarding rule can contain one or more <b>ExtType</b> actions, which are performed before the <b>FinalType</b> action. If you want to specify an ExtType action, you must also specify a <b>FinalType</b> action. You can specify multiple <b>InsertHeader</b> actions or one <b>Rewrite</b> action.</description></item>
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
                /// <para>The key-value pairs of the cookie.</para>
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// <para>The cookie value.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class ListRulesResponseBodyRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The cookie key. The cookie key must be 1 to 100 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\*), and question marks (?). It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The cookie value. The cookie value must be 1 to 128 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\*), and question marks (?). It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
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
                    /// <para>The key of the header. The header key must be 1 to 40 characters in length. It can contain letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Port</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the header.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the hosts.</para>
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
                /// <para>The configurations of the request methods.</para>
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
                /// <para>The configurations of the forwarding URLs.</para>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The URLs to which requests are forwarded.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configurations of the query strings.</para>
                /// </summary>
                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// <para>The query string.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<ListRulesResponseBodyRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class ListRulesResponseBodyRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// <para>They key of the query string. The key must be 1 to 100 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\*), and question marks (?). It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the query string. The value must be 1 to 128 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\*), and question marks (?). It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
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
                /// <para>The HTTP header in responses.</para>
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the HTTP header. The header key must be 1 to 40 characters in length, It can contain letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
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
                /// <para>The configurations of the response status codes.</para>
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
                /// <para>Traffic matching based on source IP addresses.</para>
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public ListRulesResponseBodyRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class ListRulesResponseBodyRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// <para>The source IP addresses.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The type of forwarding rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Host</b>: Responses are forwarded based on hosts.</description></item>
                /// <item><description><b>Path</b>: Responses are forwarded based on URLs.</description></item>
                /// <item><description><b>Header</b>: Responses are forwarded based on HTTP headers.</description></item>
                /// <item><description><b>QueryString</b>: Responses are forwarded based on query strings.</description></item>
                /// <item><description><b>Method</b>: Responses are forwarded based on request methods.</description></item>
                /// <item><description><b>Cookie</b>: Responses are forwarded based on cookies.</description></item>
                /// <item><description><b>SourceIp</b>: Responses are forwarded based on source IP addresses.</description></item>
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
            /// <para>The ID of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the forwarding rule. The name must be 2 to 128 letters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
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
            /// <item><description><b>Provisioning</b>: The forwarding rule is being created.</description></item>
            /// <item><description><b>Configuring</b>: The forwarding rule is being modified.</description></item>
            /// <item><description><b>Available</b>: The forwarding rule is available.</description></item>
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
                /// <para>The tag key. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
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
