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
        /// <para>The priority of the forwarding rule. Valid values: <b>1 to 10000</b>. A lower value specifies a higher priority.</para>
        /// <remarks>
        /// <para>The priorities of the forwarding rules created for the same listener must be unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The actions of the forwarding rule.</para>
        /// </summary>
        [NameInMap("RuleActions")]
        [Validation(Required=false)]
        public List<UpdateRuleAttributeRequestRuleActions> RuleActions { get; set; }
        public class UpdateRuleAttributeRequestRuleActions : TeaModel {
            /// <summary>
            /// <para>The CORS configuration.</para>
            /// </summary>
            [NameInMap("CorsConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsCorsConfig CorsConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsCorsConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to allow credentials to be carried in CORS requests. Valid values:</para>
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
            /// <para>The configuration of the custom response.</para>
            /// </summary>
            [NameInMap("FixedResponseConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsFixedResponseConfig : TeaModel {
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
                /// <para>The content type.</para>
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
                /// <para>HTTP_200</para>
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
            public UpdateRuleAttributeRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The configuration of session persistence.</para>
                /// </summary>
                [NameInMap("ServerGroupStickySession")]
                [Validation(Required=false)]
                public UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable session persistence. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: enables session persistence.</description></item>
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
                    /// <para>The timeout period of sessions. Unit: seconds Valid values: 1 to 86400.</para>
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
                public List<UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The ID of the server group to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg--atstuj3rtoptyui****</para>
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
            /// <para>The configuration of the header to be inserted.</para>
            /// </summary>
            [NameInMap("InsertHeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsInsertHeaderConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to overwrite the request header values. Valid values:</para>
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
                /// <para>The key of the header. The key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header keys specified by <b>InsertHeaderConfig</b> must be unique.</para>
                /// <remarks>
                /// <para>The following header keys are not supported: <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, and <c>authority</c>. The header keys are not case-sensitive.</para>
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
                /// <item><description><para>If <b>ValueType</b> is set to <b>SystemDefined</b>, you can set the Value parameter to one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>ClientSrcPort</b>: the client port.</description></item>
                /// <item><description><b>ClientSrcIp</b>: the IP address of the client.</description></item>
                /// <item><description><b>Protocol</b>: the request protocol (HTTP or HTTPS).</description></item>
                /// <item><description><b>SLBId</b>: the ID of the ALB instance.</description></item>
                /// <item><description><b>SLBPort</b>: the listener port of the ALB instance.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>If <b>ValueType</b> is set to <b>UserDefined</b>, you can specify a custom value. The value must be 1 to 128 characters in length, and can contain asterisks (\*), question marks (?), and printable characters whose ASCII values are <c>larger than or equal to 32 and smaller than 127</c>. It cannot start or end with a space character.</para>
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
                /// <para>The type of the header. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>UserDefined</b>: a custom header.</description></item>
                /// <item><description><b>ReferenceHeader</b>: a header that references one of the request headers.</description></item>
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
            /// <para>The priority of the action. Valid values: <b>1 to 50000</b>. A smaller value specifies a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter is required. The priority of each action within a forwarding rule must be unique. You can specify at most 20 forwarding rule priorities.</para>
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
            public UpdateRuleAttributeRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRedirectConfig : TeaModel {
                /// <summary>
                /// <para>The hostname to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>${host}</b> (default): If ${host} is returned, no other character is appended.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\*), and question marks (?).</description></item>
                /// <item><description>The hostname must contain at least one period (.) but cannot start or end with a period (.).</description></item>
                /// <item><description>The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).</description></item>
                /// <item><description>Other domain labels cannot start or end with a hyphen (-).</description></item>
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
                /// <item><description><para>Default value: <b>${path}</b>. \<em>\</em>${host}**, <b>${protocol}</b>, and **${port}\<em>\</em> are also supported. Each variable can be specified only once. The preceding variables can be used at the same time or combined with a custom value.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The URL must be 1 to 128 characters in length,</description></item>
                /// <item><description>The URL must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$ - _ .+ / &amp; ~ @ :</c>. It cannot contain the following special characters: <c>&quot; % # ; ! ( ) [ ]^ , &quot;</c>. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
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
                /// <item><description><b>${port}</b> (default): If you set the value to ${port}, you cannot append other characters.</description></item>
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
                /// <item><description><b>${protocol}</b> (default): If you set the value to ${protocol}, you cannot append other characters.</description></item>
                /// <item><description><b>HTTP</b> or <b>HTTPS</b>.</description></item>
                /// </list>
                /// <remarks>
                /// <para>HTTPS listeners support only HTTPS redirects.</para>
                /// </remarks>
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
                /// <item><description><para>Default value: <b>${query}</b>. \<em>\</em>${host}**, <b>${protocol}</b>, and **${port}\<em>\</em> are also supported. Each variable can be specified only once. The preceding variables can be used at the same time or combined with a custom value.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The query string must be 1 to 128 characters in length.</description></item>
                /// <item><description>The query string can contain printable characters, but cannot contain space characters, the special characters <c># [ ] { } \\ | &lt; &gt; &amp;</c>, or uppercase letters.</description></item>
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
            /// <para>The HTTP header to be removed.</para>
            /// </summary>
            [NameInMap("RemoveHeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRemoveHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The key of the header to be removed. The header key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header keys specified in RemoveHeader must be unique.</para>
                /// <list type="bullet">
                /// <item><description>If Direction is set to Request, the following request header keys are not supported: <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, and <c>authority</c>. The header keys are not case-sensitive.</description></item>
                /// <item><description>If Direction is set to Response, the following header keys are not supported: <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, and <c>transfer-encoding</c>. The header keys are not case-sensitive.</description></item>
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
            /// </summary>
            [NameInMap("RewriteConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRewriteConfig : TeaModel {
                /// <summary>
                /// <para>The hostname to which requests are rewritten. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>${host}</b> (default): If you set the value to ${host}, you cannot append other characters.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, hyphens (-), periods (.), asterisks (\*), and question marks (?).</description></item>
                /// <item><description>The hostname contains at least one period (.) but does not start or end with a period (.).</description></item>
                /// <item><description>The rightmost domain label can contain only letters and wildcard characters. It cannot contain digits or hyphens (-).</description></item>
                /// <item><description>Other domain labels cannot start or end with a hyphen (-). You can use asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.</description></item>
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
                /// <para>The URL to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Default value: <b>${path}</b>. \<em>\</em>${host}**, <b>${protocol}</b>, and **${port}\<em>\</em> are also supported. Each variable can be specified only once. The preceding variables can be used at the same time or combined with a custom value.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The URL must be 1 to 128 characters in length,</description></item>
                /// <item><description>The URL must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$ - _ .+ / &amp; ~ @ :</c>. It cannot contain the following special characters: <c>&quot; % # ; ! ( ) [ ]^ , &quot;</c>. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
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
                /// <para>The query string to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Default value: <b>${query}</b>. \<em>\</em>${host}**, <b>${protocol}</b>, and **${port}\<em>\</em> are also supported. Each variable can be specified only once. The preceding variables can be used at the same time or combined with a custom value.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The query string must be 1 to 128 characters in length.</description></item>
                /// <item><description>The query string can contain printable characters, but cannot contain space characters, the special characters <c># [ ] { } \\ | &lt; &gt; &amp;</c>, or uppercase letters.</description></item>
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
            public UpdateRuleAttributeRequestRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsTrafficLimitConfig : TeaModel {
                /// <summary>
                /// <para>The number of requests per IP address. Value range: <b>1 to 1000000</b>.</para>
                /// <remarks>
                /// <para>If both the <b>QPS</b> and <b>PerIpQps</b> parameters are specified, make sure that the value of the <b>QPS</b> parameter is smaller than the value of the PerIpQps parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("PerIpQps")]
                [Validation(Required=false)]
                public int? PerIpQps { get; set; }

                /// <summary>
                /// <para>The queries per second (QPS). Value range: <b>1 to 1000000</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("QPS")]
                [Validation(Required=false)]
                public int? QPS { get; set; }

            }

            /// <summary>
            /// <para>The configuration of the traffic mirroring action.</para>
            /// </summary>
            [NameInMap("TrafficMirrorConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfig : TeaModel {
                /// <summary>
                /// <para>The server group to which network traffic is mirrored.</para>
                /// </summary>
                [NameInMap("MirrorGroupConfig")]
                [Validation(Required=false)]
                public UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The server group to which network traffic is mirrored.</para>
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
                /// <para>The type of destination to which network traffic is mirrored. Valid values:</para>
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
            /// <para>The type of the task. You can specify at most 11 types of action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ForwardGroup</b>: forwards requests to multiple vServer groups.</description></item>
            /// <item><description><b>Redirect</b>: redirects requests.</description></item>
            /// <item><description><b>FixedResponse</b>: returns a fixed response.</description></item>
            /// <item><description><b>Rewrite</b>: rewrites requests.</description></item>
            /// <item><description><b>InsertHeader</b>: inserts a header.</description></item>
            /// <item><description><b>RemoveHeader</b>: removes headers.</description></item>
            /// <item><description><b>TrafficLimit</b>: throttles traffic.</description></item>
            /// <item><description><b>trafficMirror</b>: mirrors network traffic.</description></item>
            /// <item><description><b>Cors</b>: forwards requests based on CORS.</description></item>
            /// </list>
            /// <para>The preceding actions can be classified into two types:</para>
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
        /// <para>The match condition of the forwarding rule.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<UpdateRuleAttributeRequestRuleConditions> RuleConditions { get; set; }
        public class UpdateRuleAttributeRequestRuleConditions : TeaModel {
            /// <summary>
            /// <para>The key-value pairs of the cookie.</para>
            /// </summary>
            [NameInMap("CookieConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsCookieConfig CookieConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsCookieConfig : TeaModel {
                /// <summary>
                /// <para>The key-value pairs of the cookie.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleConditionsCookieConfigValues> Values { get; set; }
                public class UpdateRuleAttributeRequestRuleConditionsCookieConfigValues : TeaModel {
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
            public UpdateRuleAttributeRequestRuleConditionsHeaderConfig HeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The key of the response header. The header key must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). Cookie and Host are not supported.</para>
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
            /// <para>The configurations of the hosts.</para>
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
            /// <para>The configuration of the request method.</para>
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
            /// <para>The configurations of the forwarding URL.</para>
            /// </summary>
            [NameInMap("PathConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsPathConfig PathConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsPathConfig : TeaModel {
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
            public UpdateRuleAttributeRequestRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsQueryStringConfig : TeaModel {
                /// <summary>
                /// <para>The query strings. You can specify at most 20 query strings.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleConditionsQueryStringConfigValues> Values { get; set; }
                public class UpdateRuleAttributeRequestRuleConditionsQueryStringConfigValues : TeaModel {
                    /// <summary>
                    /// <para>The key of the query string. The key must be 1 to 100 characters in length, and can contain lowercase letters, printable ASCII characters, asterisks (\*), and question marks (?). It cannot contain space characters or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>.</para>
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
            /// <para>The configuration of headers.</para>
            /// </summary>
            [NameInMap("ResponseHeaderConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsResponseHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The header key.</para>
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
                /// <para>The header values.</para>
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
            public UpdateRuleAttributeRequestRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsResponseStatusCodeConfig : TeaModel {
                /// <summary>
                /// <para>The response status codes.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>Traffic matching based on source IP addresses. You can specify at most five IP addresses, including CIDR blocks.</para>
            /// </summary>
            [NameInMap("SourceIpConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsSourceIpConfig : TeaModel {
                /// <summary>
                /// <para>You can add one or more IP addresses, including CIDR blocks.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The type of forwarding rule. You can specify at most seven types of forwarding rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Host</b>: Requests are forwarded based on hosts.</description></item>
            /// <item><description><b>Path</b>: Requests are forwarded based on paths.</description></item>
            /// <item><description><b>Header</b>: Requests are forwarded based on HTTP headers.</description></item>
            /// <item><description><b>QueryString</b>: Requests are forwarded based on query strings.</description></item>
            /// <item><description><b>Method</b>: Requests are forwarded based on request methods.</description></item>
            /// <item><description><b>Cookie</b>: Requests are forwarded based on cookies.</description></item>
            /// <item><description><b>SourceIp</b>: Responses are forwarded based on source IP addresses.</description></item>
            /// <item><description><b>ResponseHeader</b>: Requests are forwarded based on HTTP response headers.</description></item>
            /// <item><description><b>ResponseStatusCode</b>: Requests are forwarded based on response status codes.</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-4dp5i6ea****</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The name of the forwarding rule. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-instance-test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
