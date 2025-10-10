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
        /// <para>The direction to which the forwarding rule is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Request</b> (default): The forwarding rule is applied to the requests received by ALB.</description></item>
        /// <item><description><b>Response</b>: The forwarding rule is applied to the responses returned by backend servers.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Basic ALB instances do not support the <b>Response</b> value.</para>
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
        /// <para>The listener ID of the ALB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>The priority of the forwarding rule. Valid values: <b>1 to 10000</b>. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>The priorities of the forwarding rules created for the same listener must be unique.</para>
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
        /// <para>The actions of the forwarding rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleActions")]
        [Validation(Required=false)]
        public List<CreateRuleRequestRuleActions> RuleActions { get; set; }
        public class CreateRuleRequestRuleActions : TeaModel {
            /// <summary>
            /// <para>Request forwarding based on CORS.</para>
            /// </summary>
            [NameInMap("CorsConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsCorsConfig CorsConfig { get; set; }
            public class CreateRuleRequestRuleActionsCorsConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether credentials can be carried in CORS requests. Valid values:</para>
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
                /// <para>The allowed HTTP methods of CORS requests.</para>
                /// </summary>
                [NameInMap("AllowMethods")]
                [Validation(Required=false)]
                public List<string> AllowMethods { get; set; }

                /// <summary>
                /// <para>The trusted origins of CORS requests. You can specify one or more values, or only the wildcard character (<c>*</c>).</para>
                /// <list type="bullet">
                /// <item><description>Each value must start with <c>http://</c> or <c>https://</c>, which must be followed by a valid domain name, including top-level domain names. Example: <c>http://*.test.abc.example.com</c>.</description></item>
                /// <item><description>You can specify a port in each value or leave the port empty. Valid values: <b>1</b> to <b>65535</b>.</description></item>
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
                /// <para>The maximum cache time of dry run requests in the browser. Unit: seconds.</para>
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
            public CreateRuleRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class CreateRuleRequestRuleActionsFixedResponseConfig : TeaModel {
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
            /// <para>The server groups to which requests are forwarded. You can specify at most five server groups for each forwarding rule.</para>
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateRuleRequestRuleActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// <para>The configuration of session persistence for the server groups.</para>
                /// </summary>
                [NameInMap("ServerGroupStickySession")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to enable session persistence. Valid values:</para>
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
                    /// <para>The timeout period of sessions. Unit: seconds. Valid values: <b>1</b> to <b>86400</b>. Default value: <b>1000</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                /// <summary>
                /// <para>The server groups to which requests are forwarded. You can specify at most five server groups for each forwarding rule.</para>
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// <para>The server group to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sgp-k86c1ov501id6p****</para>
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
                    /// <para>100</para>
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
            public CreateRuleRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsInsertHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The key of the header. The header key must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header keys specified by <b>InsertHeaderConfig</b> must be unique.</para>
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
                /// <item><description><para>If <b>ValueType</b> is set to <b>UserDefined</b>, a custom header value is supported. The header value must be 1 to 128 characters in length, and can contain printable characters whose ASCII values are <c>greater than or equal to 32 and lower than 127</c>. You can use asterisks (\*) and question marks (?) as wildcard characters. <c>Quotation marks (&quot;)</c> are not supported. The header value cannot start or end with a space character, or end with a backslash (<c>\\</c>).</para>
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
                /// <item><description><b>UserDefined</b>: a custom header value.</description></item>
                /// <item><description><b>ReferenceHeader</b>: a header value that is referenced from one of the request headers.</description></item>
                /// <item><description><b>SystemDefined</b>: a header predefined by the system.</description></item>
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
            /// <para>The priority of the action. Valid values: <b>1 to 50000</b>. A smaller value indicates a higher priority. The actions of a forwarding rule are applied in descending order of priority. This parameter cannot empty. The priority of each action within a forwarding rule must be unique.</para>
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
            /// <para> Do not set all fields in <b>RedirectConfig</b> to default values, except for <b>httpCode</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RedirectConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class CreateRuleRequestRuleActionsRedirectConfig : TeaModel {
                /// <summary>
                /// <para>The hostname to which requests are forwarded. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>${host}</b> (default): If you set the value to ${host}, you cannot append other characters.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following characters: - . \* = ~ _ + \ ^ ! $ &amp; | ( ) [ ] ?.</description></item>
                /// <item><description>The hostname must contain at least one period (.) but cannot start or end with a period (.).</description></item>
                /// <item><description>The rightmost domain label can contain only letters and wildcard characters, and cannot contain digits or hyphens (-). The leftmost <c>domain label</c> can be an asterisk (\*).</description></item>
                /// <item><description>The domain labels cannot start or end with hyphens (-).</description></item>
                /// <item><description>You can use asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.</description></item>
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
                /// <para>The HTTP status code that indicates the redirect type. Valid values: <b>301</b>, <b>302</b>, <b>303</b>, <b>307</b>, and <b>308</b>.</para>
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
                /// <item><description><para>Default value: <b>${path}</b>. <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b> are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The URL must be 1 to 128 characters in length, and is case-sensitive. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                /// <item><description>The URL must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$ - _ . + / &amp; ~ @ : \\&quot; * ?</c>. It cannot contain the following special characters: <c>% # ; ! ( ) [ ] ^ , \\ &quot;</c>. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
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
                /// <para>The port to which requests are distributed.</para>
                /// <list type="bullet">
                /// <item><description><b>${port}</b> (default): If you set the value to ${port}, you cannot append other characters to the value.</description></item>
                /// <item><description>You can also enter a port number. Valid values: <b>1 to 63335</b>.</description></item>
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
                /// <item><description><b>${protocol}</b> (default): If you set the value to ${protocol}, you cannot modify the value or append other characters.</description></item>
                /// <item><description><b>HTTP</b></description></item>
                /// <item><description><b>HTTPS</b></description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>HTTPS listeners support only HTTPS redirection.</description></item>
                /// <item><description>HTTP listeners support HTTP and HTTPS redirection.</description></item>
                /// </list>
                /// </remarks>
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
                /// <item><description><para>Default value: <b>${query}</b>. <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b> are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The query string must be 1 to 128 characters in length.</description></item>
                /// <item><description>It can contain printable characters, excluding space characters, the special characters <c># [ ] { } \\ | &lt; &gt; &quot;</c>, and lowercase letters.</description></item>
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
            /// <para>The HTTP headers to be removed.</para>
            /// </summary>
            [NameInMap("RemoveHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsRemoveHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The keys of the headers to be removed. The header keys must be 1 to 40 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The header keys specified in RemoveHeader must be unique.</para>
                /// <list type="bullet">
                /// <item><description>If Direction is set to Request, the following request headers cannot be removed: <c>slb-id</c>, <c>slb-ip</c>, <c>x-forwarded-for</c>, <c>x-forwarded-proto</c>, <c>x-forwarded-eip</c>, <c>x-forwarded-port</c>, <c>x-forwarded-client-srcport</c>, <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, <c>transfer-encoding</c>, <c>keep-alive</c>, <c>te</c>, <c>host</c>, <c>cookie</c>, <c>remoteip</c>, <c>authority</c>, and <c>x-forwarded-host</c>. Request headers are not case-sensitive.</description></item>
                /// <item><description>If Direction is set to Response, the following response header keys are not supported: <c>connection</c>, <c>upgrade</c>, <c>content-length</c>, and <c>transfer-encoding</c>. The header keys are not case-sensitive.</description></item>
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
            /// <para> If you specify multiple actions for a forwarding rule, you must configure the <b>ForwardGroup</b> parameter for the <b>RewriteConfig</b> action.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("RewriteConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class CreateRuleRequestRuleActionsRewriteConfig : TeaModel {
                /// <summary>
                /// <para>The hostname to which requests are redirected. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>${host}</b> (default): If you set the value to ${host}, you cannot append other characters.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The hostname must be 3 to 128 characters in length, and can contain lowercase letters, digits, and the following characters: - . \* = ~ _ + \ ^ ! $ &amp; | ( ) [ ] ?.</description></item>
                /// <item><description>The hostname must contain at least one period (.) but cannot start or end with a period (.).</description></item>
                /// <item><description>The rightmost domain label can contain only letters and wildcard characters, and cannot contain digits or hyphens (-). The leftmost <c>domain label</c> can be an asterisk (\*).</description></item>
                /// <item><description>The domain labels cannot start or end with hyphens (-). You can use asterisks (\*) and question marks (?) anywhere in a domain label as wildcard characters.</description></item>
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
                /// <item><description><para>Default value: <b>${path}</b>. <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b> are also supported. Each variable can be specified only once. You can specify one or more of the preceding variables in each request. You can also combine them with a custom value.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The URL must be 1 to 128 characters in length, and is case-sensitive. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                /// <item><description>The URL must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>$ - _ . + / &amp; ~ @ : \\&quot; * ?</c>. It cannot contain the following special characters: <c>% # ; ! ( ) [ ] ^ , \\ &quot;</c>. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
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
                /// <para>The query string of the URL to which requests are distributed.</para>
                /// <list type="bullet">
                /// <item><description><para>Default value: <b>${query}</b>. <b>${host}</b>, <b>${protocol}</b>, and <b>${port}</b> are also supported. Each variable can be specified only once. The preceding variables can be used at the same time or combined with a custom value.</para>
                /// </description></item>
                /// <item><description><para>If you want to specify a custom value, make sure that the following requirements are met:</para>
                /// <list type="bullet">
                /// <item><description>The path must be 1 to 128 characters in length.</description></item>
                /// <item><description>It can contain printable characters, excluding space characters, the special characters <c># [ ] { } \\ | &lt; &gt; &quot;</c> and lowercase letters.</description></item>
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
            /// <para>The configuration of the traffic throttling action.</para>
            /// </summary>
            [NameInMap("TrafficLimitConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
            public class CreateRuleRequestRuleActionsTrafficLimitConfig : TeaModel {
                /// <summary>
                /// <para>The number of requests per IP address. Value values: <b>1 to 1000000</b>.</para>
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
                /// <para>The queries per second (QPS). Valid values: <b>1 to 1000000</b>.</para>
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
            public CreateRuleRequestRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
            public class CreateRuleRequestRuleActionsTrafficMirrorConfig : TeaModel {
                /// <summary>
                /// <para>The configuration of the server group to which traffic is mirrored.</para>
                /// </summary>
                [NameInMap("MirrorGroupConfig")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                public class CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration of the server group to which traffic is mirrored.</para>
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
                /// <para>The type of destination to which network traffic is mirrored. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroupMirror</b>: a server group.</description></item>
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
            /// <para>The action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ForwardGroup</b>: distributes requests to multiple vServer groups.</description></item>
            /// <item><description><b>Redirect</b>: redirects requests.</description></item>
            /// <item><description><b>FixedResponse</b>: returns a custom response.</description></item>
            /// <item><description><b>Rewrite</b>: rewrites requests.</description></item>
            /// <item><description><b>InsertHeader</b>: inserts headers.</description></item>
            /// <item><description><b>RemoveHeaderConfig:</b> deletes the header of a request.</description></item>
            /// <item><description><b>TrafficLimit</b>: throttles traffic.</description></item>
            /// <item><description><b>TrafficMirror</b>: mirrors network traffic.</description></item>
            /// <item><description><b>Cors</b>: enables cross-origin resource sharing (CORS).</description></item>
            /// </list>
            /// <para>The following action types are supported:</para>
            /// <list type="bullet">
            /// <item><description><b>FinalType</b>: Each forwarding rule can contain only one FinalType action, which is performed at the end. You can specify only one of <b>ForwardGroup</b>, <b>Redirect</b>, and <b>FixedResponse</b>.</description></item>
            /// <item><description><b>ExtType</b>: Each forwarding rule can contain one or more <b>ExtType</b> actions, which are performed before the <b>FinalType</b> action. If you want to specify an ExtType action, you must also specify a <b>FinalType</b> action. You can specify multiple <b>InsertHeader</b> actions or one <b>Rewrite</b> action.</description></item>
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
        /// <para>The match conditions of the forwarding rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<CreateRuleRequestRuleConditions> RuleConditions { get; set; }
        public class CreateRuleRequestRuleConditions : TeaModel {
            /// <summary>
            /// <para>The key-value pairs of the cookie.</para>
            /// </summary>
            [NameInMap("CookieConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsCookieConfig CookieConfig { get; set; }
            public class CreateRuleRequestRuleConditionsCookieConfig : TeaModel {
                /// <summary>
                /// <para>The cookie values.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleConditionsCookieConfigValues> Values { get; set; }
                public class CreateRuleRequestRuleConditionsCookieConfigValues : TeaModel {
                    /// <summary>
                    /// <para>The cookie key.</para>
                    /// <list type="bullet">
                    /// <item><description>The cookie key must be 1 to 100 characters in length.</description></item>
                    /// <item><description>You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                    /// <item><description>The value can contain printable characters, excluding uppercase letters, space characters, and the following special characters: <c>; # [ ] { } \\ | &lt; &gt; &amp; &quot;</c>.</description></item>
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
                    /// <item><description>The cookie value must be 1 to 100 characters in length.</description></item>
                    /// <item><description>You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
                    /// <item><description>The value can contain printable characters, excluding uppercase letters, space characters, and the following special characters: <c>; # [ ] { } \\ | &lt; &gt; &amp; &quot;</c>.</description></item>
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
            /// <para>The configuration of the header.</para>
            /// </summary>
            [NameInMap("HeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsHeaderConfig HeaderConfig { get; set; }
            public class CreateRuleRequestRuleConditionsHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The header key.</para>
                /// <list type="bullet">
                /// <item><description>The header key must be 1 to 40 characters in length.</description></item>
                /// <item><description>The key can contain letters, digits, hyphens (-), and underscores (_).</description></item>
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
            public CreateRuleRequestRuleConditionsHostConfig HostConfig { get; set; }
            public class CreateRuleRequestRuleConditionsHostConfig : TeaModel {
                /// <summary>
                /// <para>The hostnames.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the request method.</para>
            /// </summary>
            [NameInMap("MethodConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsMethodConfig MethodConfig { get; set; }
            public class CreateRuleRequestRuleConditionsMethodConfig : TeaModel {
                /// <summary>
                /// <para>The request methods.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The configurations of the URL to which requests are forwarded.</para>
            /// </summary>
            [NameInMap("PathConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsPathConfig PathConfig { get; set; }
            public class CreateRuleRequestRuleConditionsPathConfig : TeaModel {
                /// <summary>
                /// <para>The forwarding URLs.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The configuration of the query strings.</para>
            /// </summary>
            [NameInMap("QueryStringConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
            public class CreateRuleRequestRuleConditionsQueryStringConfig : TeaModel {
                /// <summary>
                /// <para>The query strings.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleConditionsQueryStringConfigValues> Values { get; set; }
                public class CreateRuleRequestRuleConditionsQueryStringConfigValues : TeaModel {
                    /// <summary>
                    /// <para>They key of the query string.</para>
                    /// <list type="bullet">
                    /// <item><description>The key must be 1 to 100 characters in length.</description></item>
                    /// <item><description>You can use asterisks (\*) and question marks (?) as wildcard characters. It can contain printable characters, excluding uppercase letters, space characters, and the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp; &quot;</c>.</description></item>
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
                    /// <item><description>The value must be 1 to 128 characters in length.</description></item>
                    /// <item><description>It can contain printable characters, but cannot contain uppercase letters, space characters, or the following special characters: <c># [ ] { } \\ | &lt; &gt; &amp;</c>. You can use asterisks (\*) and question marks (?) as wildcard characters.</description></item>
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
            /// <para>The configuration of headers.</para>
            /// </summary>
            [NameInMap("ResponseHeaderConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
            public class CreateRuleRequestRuleConditionsResponseHeaderConfig : TeaModel {
                /// <summary>
                /// <para>The header key.</para>
                /// <list type="bullet">
                /// <item><description>The key must be 1 to 40 characters in length.</description></item>
                /// <item><description>It can contain letters, digits, hyphens (-), and underscores (_).</description></item>
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
            /// <para>The configuration of the response status codes.</para>
            /// </summary>
            [NameInMap("ResponseStatusCodeConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
            public class CreateRuleRequestRuleConditionsResponseStatusCodeConfig : TeaModel {
                /// <summary>
                /// <para>The response status codes.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>Configuration of traffic matching based on source IP addresses. This parameter is required and valid when <b>Type</b> is set to <b>SourceIP</b>.</para>
            /// </summary>
            [NameInMap("SourceIpConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
            public class CreateRuleRequestRuleConditionsSourceIpConfig : TeaModel {
                /// <summary>
                /// <para>The source IP addresses used for traffic matching.</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            /// <summary>
            /// <para>The type of forwarding rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Host</b>: Requests are distributed based on hosts.</description></item>
            /// <item><description><b>Path</b>: Requests are distributed based on paths.</description></item>
            /// <item><description><b>Header</b>: Requests are distributed based on HTTP headers.</description></item>
            /// <item><description><b>QueryString</b>: Requests are distributed based on query strings.</description></item>
            /// <item><description><b>Method</b>: Requests are distributed based on request methods.</description></item>
            /// <item><description><b>Cookie</b>: Requests are distributed based on cookies.</description></item>
            /// <item><description><b>SourceIp</b>: Requests are forwarded based on source IP addresses.</description></item>
            /// <item><description><b>ResponseHeader</b>: Requests are forwarded based on HTTP response headers.</description></item>
            /// <item><description><b>ResponseStatusCode</b>: Requests are forwarded based on response status codes.</description></item>
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
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>It can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</description></item>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRuleRequestTag> Tag { get; set; }
        public class CreateRuleRequestTag : TeaModel {
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
            /// <para>The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
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
