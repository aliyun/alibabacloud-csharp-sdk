// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateRulesAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a <c>2xx HTTP</c> status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The forwarding rules. You can specify at most 10 forwarding rules in each call.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateRulesAttributeRequestRules> Rules { get; set; }
        public class UpdateRulesAttributeRequestRules : TeaModel {
            /// <summary>
            /// <para>The priority of the forwarding rule. Valid values: <b>1 to 10000</b>. A smaller value specifies a higher priority. You can specify at most 20 rule priorities.</para>
            /// <remarks>
            /// <para>The priority of each forwarding rule within a listener must be unique.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The action of the forwarding rule.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<UpdateRulesAttributeRequestRulesRuleActions> RuleActions { get; set; }
            public class UpdateRulesAttributeRequestRulesRuleActions : TeaModel {
                /// <summary>
                /// <para>The CORS configuration.</para>
                /// </summary>
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsCorsConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow credentials to be carried in CORS requests. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>on</b>: allows credentials to be carried in CORS requests.</description></item>
                    /// <item><description><b>off</b>: does not allow credentials to be carried in CORS requests.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>on</para>
                    /// </summary>
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    /// <summary>
                    /// <para>The trusted headers of CORS requests.</para>
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
                    /// <para>The trusted origins. You can specify one or more values, or only an asterisk (<c>*</c>).</para>
                    /// <list type="bullet">
                    /// <item><description>The value must start with <c>http://</c> or <c>https://</c>, and be followed by a valid domain name, including top-level wildcard domain names. Example: <c>http://*.test.abc.example.com</c>.</description></item>
                    /// <item><description>You can specify ports for a single value. Valid values: <b>1</b> to <b>65535</b>.</description></item>
                    /// </list>
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
                /// <para>The configuration of the action to return a custom response. You can specify at most 20 custom responses.</para>
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// <para>The content of the response. The content can be up to 1 KB in size, and can contain only ASCII characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dssacav</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The content format of the response.</para>
                    /// <para>Valid values: <b>text/plain</b>, <b>text/css</b>, <b>text/html</b>, <b>application/javascript</b>, and <b>application/json</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text/plain</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code in responses. Valid values: <b>2xx</b>, <b>4xx</b>, <b>5xx</b>. The value must be a numeric string. <b>x</b> must be a digit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the action to forward requests to server groups. You can specify at most 20 actions.</para>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration of session persistence for server groups.</para>
                    /// </summary>
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
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
                        /// <para>The timeout period of sessions. Unit: seconds Valid values: <b>1</b> to <b>86400</b>.</para>
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
                    public List<UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
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
                        /// <para>The weight of the server group. A larger value specifies a higher weight. A server group with a higher weight receives more requests. Valid values: <b>0</b> to <b>100</b>.</para>
                        /// <list type="bullet">
                        /// <item><description>If the number of destination server groups is 1, the default weight of the server group is <b>100</b>, unless you specify a weight.</description></item>
                        /// <item><description>If the number of destination server groups is larger than 1, you must specify a weight.</description></item>
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
                /// <para>The configuration of the action to insert a header. You can specify at most 20 actions.</para>
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to overwrite the header in the request. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: overwrites the request header.</description></item>
                    /// <item><description><b>false</b> (default): does not overwrite the request header.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CoverEnabled")]
                    [Validation(Required=false)]
                    public bool? CoverEnabled { get; set; }

                    /// <summary>
                    /// <para>The key of the header. The header key must be 1 to 40 characters in length, and can contain lowercase letters, digits, underscores (_), and hyphens (-). The key specified in <c>InsertHeader</c> must be unique.</para>
                    /// <remarks>
                    /// <para>The following header keys are not supported: <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te, host</c>, <c>cookie</c>, <c>remoteip</c>, and <c>authority</c>. Header keys are not case-sensitive.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the header.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <b>ValueType</b> is set to <b>SystemDefined</b>, you can set the Value parameter to one of the following values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                    /// <item><description><b>ClientSrcIp</b>: the IP address of the client.</description></item>
                    /// <item><description><b>Protocol</b>: the request protocol (HTTP or HTTPS).</description></item>
                    /// <item><description><b>SLBId</b>: the ID of the ALB instance.</description></item>
                    /// <item><description><b>SLBPort</b>: the listener port of the ALB instance.</description></item>
                    /// </list>
                    /// </description></item>
                    /// <item><description><para>If <b>ValueType</b> is set to <b>UserDefined</b>, you can specify a custom header value. The header value must be 1 to 128 characters in length, and can contain wildcard characters, such as asterisks (\*) and question marks (?), and printable characters whose ASCII values are <c>larger than or equal to 32 and smaller than 127</c>. The header value cannot start or end with a space character.</para>
                    /// </description></item>
                    /// <item><description><para>If <b>ValueType</b> is set to <b>ReferenceHeader</b>, you can reference a value from request headers. The value must be 1 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
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
                    /// <para>The type of header. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>UserDefined</b>: a user-defined header.</description></item>
                    /// <item><description><b>ReferenceHeader</b>: a header that is referenced from a request header.</description></item>
                    /// <item><description><b>SystemDefined</b>: a system-defined header.</description></item>
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
                /// <para>The priority of the action. Valid values: <b>1</b> to <b>50000</b>. A lower value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter cannot be left empty. The priority of each action within a forwarding rule must be unique. You can specify at most 20 forwarding rule priorities.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The configuration of the redirect action. You can specify at most 20 redirect actions.</para>
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostname to which requests are redirected.</para>
                    /// <para>The hostname must meet the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following special characters: - . \* = ~ _ + \ ^ ! $ &amp; | ( ) [ ] ?.</description></item>
                    /// <item><description>The hostname must contain at least one period (.) but cannot start or end with a period (.).</description></item>
                    /// <item><description>The rightmost domain label can contain only letters, asterisks (<em>), and question marks (?), and cannot contain digits or hyphens (-). The leftmost <c>domain label</c> can contain asterisks (</em>).</description></item>
                    /// <item><description>The domain labels cannot start or end with hyphens (-). You can specify asterisks (∗) and question marks (?) anywhere in a domain label.</description></item>
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
                    /// <para>The path of the destination to which requests are forwarded. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${path}</b> (default): You can reference \<em>\</em>${host}**, <b>${protocol}</b> and **${port}\<em>\</em>. Each variable can be used only once. The preceding variables can be used at the same time or combined with a custom value.</para>
                    /// </description></item>
                    /// <item><description><para>A custom value. You must ensure that the custom value meets the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>The path must be 1 to 128 characters in length. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                    /// <item><description>The path can contain letters, digits, and the following special characters: <c>$ - _ . + / &amp; ~ @ : \\&quot; * ?</c>. It must start with a forward slash (/) and cannot contain the following characters: <c>&quot; % # ; ! ( ) [ ] ^ , &quot;</c>.</description></item>
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
                    /// <para>The port to which requests are forwarded.</para>
                    /// <para>Valid values: <b>1</b> to <b>63335</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The protocol of the destination to which requests are forwarded. Valid values:</para>
                    /// <para>Valid values for HTTP listeners: <b>HTTP</b> and <b>HTTPS</b>.</para>
                    /// <para>Valid values for HTTPS listeners: <b>HTTPS</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The query string to which requests are redirected.</para>
                    /// <para>The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quert</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the HTTP header to be removed. You can remove at most 20 HTTP headers.</para>
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the response header.</para>
                    /// <list type="bullet">
                    /// <item><description>The header key must be 1 to 40 characters in length.</description></item>
                    /// <item><description>The header key can contain lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
                    /// <item><description>Cookie and Host are not supported.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Port</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the rewrite action. You can specify at most 20 actions.</para>
                /// </summary>
                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostname of the destination to which requests are forwarded.</para>
                    /// <para>The hostname must meet the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following special characters: - . \* = ~ _ + \ ^ ! $ &amp; | ( ) [ ] ?.</description></item>
                    /// <item><description>The hostname must contain at least one period (.) but cannot start or end with a period (.).</description></item>
                    /// <item><description>The rightmost domain label can contain only letters, asterisks (<em>), and question marks (?), and cannot contain digits or hyphens (-). The leftmost <c>domain label</c> can contain asterisks (</em>).</description></item>
                    /// <item><description>The domain labels cannot start or end with hyphens (-). You can specify asterisks (∗) and question marks (?) anywhere in a domain label.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The path to which requests are forwarded.</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>${path}</b> (default): You can reference \<em>\</em>${host}**, <b>${protocol}</b> and **${port}\<em>\</em>. Each variable can be used only once. The preceding variables can be used at the same time or combined with a custom value.</para>
                    /// </description></item>
                    /// <item><description><para>A custom value. You must ensure that the custom value meets the following requirements:</para>
                    /// <list type="bullet">
                    /// <item><description>The path must be 1 to 128 characters in length. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                    /// <item><description>The custom value can contain letters, digits, and the following special characters: <c>$ - _ . + / &amp; ~ @ : \\&quot; * ?</c>. The custom value must start with a forward slash (/) and cannot contain the following characters: <c>&quot; % # ; ! ( ) [ ] ^ , &quot;</c>.</description></item>
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
                    /// <para>The query string of the URL to which requests are forwarded.</para>
                    /// <para>The query string must be 1 to 128 characters in length, and can contain printable characters, excluding uppercase letters and the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quedsa</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The configuration of traffic throttling. You can specify at most 20 throttling actions.</para>
                /// </summary>
                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// <para>The number of requests per IP address. Valid values: <b>1</b> to <b>1000000</b>.</para>
                    /// <remarks>
                    /// <para>If both the QPS and PerIpQps properties are specified, make sure that the value of the QPS property is smaller than the value of the PerIpQps property.</para>
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
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }

                }

                /// <summary>
                /// <para>The configuration of traffic mirroring. You can specify at most 20 traffic mirroring configurations.</para>
                /// </summary>
                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration of the server group to which traffic is mirrored.</para>
                    /// </summary>
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        /// <summary>
                        /// <para>The server group to which traffic is mirrored.</para>
                        /// </summary>
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
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
                    /// <para>The type of target to which network traffic is mirrored. Valid values:</para>
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
                /// <para>The type of action. You can specify at most 11 types of action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroup</b>: forwards a request to multiple vServer groups.</description></item>
                /// <item><description><b>Redirect</b>: redirects requests.</description></item>
                /// <item><description><b>FixedResponse</b>: returns a fixed response.</description></item>
                /// <item><description><b>Rewrite</b>: rewrites requests.</description></item>
                /// <item><description><b>InsertHeader</b>: inserts a header.</description></item>
                /// <item><description><b>RemoveHeaderConfig</b>: deletes a header.</description></item>
                /// <item><description><b>TrafficLimit</b>: throttles traffic.</description></item>
                /// <item><description><b>TrafficMirror</b>: mirrors network traffic.</description></item>
                /// <item><description><b>Cors</b>: enables cross-origin resource sharing (CORS).</description></item>
                /// </list>
                /// <para>The preceding actions can be classified into two types:</para>
                /// <list type="bullet">
                /// <item><description><b>FinalType</b>: Each forwarding rule can contain only one FinalType action, which is performed at the end. You can specify only one of <b>ForwardGroup</b>, <b>Redirect</b>, and <b>FixedResponse</b>.</description></item>
                /// <item><description><b>ExtType</b>: Each forwarding rule can contain one or more <b>ExtType</b> actions, which are performed before the <b>FinalType</b> action. If you want to specify an ExtType action, you must also specify a <b>FinalType</b> action. You can specify multiple <b>InsertHeader</b> actions or one <b>Rewrite</b> action.</description></item>
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
            /// <para>The match conditions of the forwarding rule.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<UpdateRulesAttributeRequestRulesRuleConditions> RuleConditions { get; set; }
            public class UpdateRulesAttributeRequestRulesRuleConditions : TeaModel {
                /// <summary>
                /// <para>The configuration of the cookie. You can specify at most 20 conditions.</para>
                /// </summary>
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsCookieConfig : TeaModel {
                    /// <summary>
                    /// <para>The key-value pairs of cookies.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The cookie key, which must be 1 to 100 characters in length, and can contain lowercase letters, asterisks (\*), question marks (?), and printable characters. It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The cookie value, which must be 1 to 128 characters in length, and can contain lowercase letters, asterisks (\*), question marks (?), and printable characters. It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
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
                /// <para>The configuration of the HTTP header. You can specify at most 20 HTTP headers.</para>
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header. The key must be 1 to 40 characters in length. The header key can contain lowercase letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Port</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The HTTP header values.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The match conditions for hostnames. You can specify at most 20 conditions.</para>
                /// </summary>
                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsHostConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostnames.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the HTTP request method. You can configure at most 20 HTTP request methods.</para>
                /// </summary>
                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsMethodConfig : TeaModel {
                    /// <summary>
                    /// <para>The HTTP request methods.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The match conditions for query strings. You can specify at most 20 conditions.</para>
                /// </summary>
                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsPathConfig : TeaModel {
                    /// <summary>
                    /// <para>The paths to which requests are forwarded.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The match conditions for query strings. You can specify at most 20 conditions.</para>
                /// </summary>
                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    /// <summary>
                    /// <para>The key-value pairs of query strings.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        /// <summary>
                        /// <para>The key of the query string.</para>
                        /// <para>The key must be 1 to 100 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\*), and question marks (?). It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the query string.</para>
                        /// <para>The value must be 1 to 128 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\*), and question marks (?). It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
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
                /// <para>The HTTP response headers. You can specify at most 20 HTTP response headers.</para>
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the response header.</para>
                    /// <list type="bullet">
                    /// <item><description>The header key must be 1 to 40 characters in length.</description></item>
                    /// <item><description>The header key can contain lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
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
                    /// <para>The value of the response header.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The match conditions for response status codes. This parameter is required and valid when <b>Type</b> is set to <b>ResponseStatusCode</b>. You can specify at most 20 conditions.</para>
                /// </summary>
                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    /// <summary>
                    /// <para>The match conditions.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>Traffic matching based on source IP addresses. You can specify at most 20 match conditions based on IP addresses.</para>
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// <para>Traffic matching based on source IP addresses.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The condition type of the forwarding rule is invalid.</para>
                /// <para>You can specify at most seven condition types for inbound forwarding rules. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Host</b>: Requests are forwarded based on hosts.</description></item>
                /// <item><description><b>Path</b>: Requests are forwarded based on paths.</description></item>
                /// <item><description><b>Header</b>: Requests are forwarded based on HTTP headers.</description></item>
                /// <item><description><b>QueryString</b>: Requests are forwarded based on query strings.</description></item>
                /// <item><description><b>Method</b>: Requests are forwarded based on request methods.</description></item>
                /// <item><description><b>Cookie</b>: Requests are forwarded based on cookies.</description></item>
                /// <item><description><b>SourceIp</b>: Requests are forwarded based on source IP addresses.</description></item>
                /// </list>
                /// <para>You can specify at most two condition types for outbound forwarding rules. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ResponseHeader</b>: Responses are forwarded based on HTTP response headers.</description></item>
                /// <item><description><b>ResponseStatusCode</b>: Response are forwarded based on response status codes.</description></item>
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
            /// <para>The IDs of the forwarding rules. You can specify at most 20 rule IDs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-cxjh7vazn2jpnl****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the forwarding rule. The name must be 2 to 128 letters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter. You can specify at most 20 rule names.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-instance-test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

    }

}
