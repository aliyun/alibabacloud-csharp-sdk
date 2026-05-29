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
        /// <para>The forwarding rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateRulesAttributeRequestRules> Rules { get; set; }
        public class UpdateRulesAttributeRequestRules : TeaModel {
            /// <summary>
            /// <para>The priority of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The forwarding rules.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<UpdateRulesAttributeRequestRulesRuleActions> RuleActions { get; set; }
            public class UpdateRulesAttributeRequestRulesRuleActions : TeaModel {
                /// <summary>
                /// <para>The cross-origin resource sharing (CORS) configuration.</para>
                /// </summary>
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsCorsConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to allow credentials to be carried in CORS requests.</para>
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
                    /// <para>The trusted origins.</para>
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
                    /// <para>The maximum cache time for dry runs in the browser.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the action to return a custom response.</para>
                /// </summary>
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    /// <summary>
                    /// <para>The content of the response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dssacav</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The content type of the response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text/plain</para>
                    /// </summary>
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code in the response.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the action to forward requests to server groups.</para>
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
                        /// <para>Specifies whether to enable session persistence.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        /// <summary>
                        /// <para>The timeout period for sessions.</para>
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
                        /// <para>The ID of the server group.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sg-atstuj3rtoptyui****</para>
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        /// <summary>
                        /// <para>The weight of the server group.</para>
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
                /// <para>The configuration of the action to insert a header.</para>
                /// </summary>
                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to overwrite the header in the request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("CoverEnabled")]
                    [Validation(Required=false)]
                    public bool? CoverEnabled { get; set; }

                    /// <summary>
                    /// <para>The key of the HTTP header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the HTTP header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserDefined</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    /// <summary>
                    /// <para>The type of the header value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserDefined</para>
                    /// </summary>
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                }

                /// <summary>
                /// <para>The priority of the action.</para>
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
                /// </summary>
                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostname to which requests are redirected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The HTTP status code that indicates the redirect type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>301</para>
                    /// </summary>
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    /// <summary>
                    /// <para>The path of the destination to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/test</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The port to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The protocol of the destination to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>The query string to which requests are redirected.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>quert</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                /// <summary>
                /// <para>The configuration of the HTTP header to be removed.</para>
                /// </summary>
                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Port</para>
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
                public UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig : TeaModel {
                    /// <summary>
                    /// <para>The hostname of the destination to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://www.example.com">www.example.com</a></para>
                    /// </summary>
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    /// <summary>
                    /// <para>The path to which requests are forwarded.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/tsdf</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The query string of the URL to which requests are forwarded.</para>
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
                public UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    /// <summary>
                    /// <para>The number of requests per IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    /// <summary>
                    /// <para>The number of queries per second (QPS).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
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
                    /// <para>The type of the target to which network traffic is mirrored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ForwardGroupMirror</para>
                    /// </summary>
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// <para>The type of action.</para>
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
                /// <para>The configuration of the cookie.</para>
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
                        /// <para>The cookie key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The cookie value.</para>
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
                /// <para>The configuration of the HTTP header.</para>
                /// </summary>
                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Port</para>
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
                /// <para>The match conditions for hostnames.</para>
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
                /// <para>The configuration of the HTTP request method.</para>
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
                /// <para>The match conditions for query strings.</para>
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
                /// <para>The match conditions for query strings.</para>
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
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the query string.</para>
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
                /// <para>The HTTP response headers.</para>
                /// </summary>
                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    /// <summary>
                    /// <para>The key of the response header.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The values of the response header.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The match conditions for response status codes.</para>
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
                /// <para>Traffic matching based on source IP addresses.</para>
                /// </summary>
                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    /// <summary>
                    /// <para>You can add one or more IP addresses, including CIDR blocks.</para>
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>The condition type of the forwarding rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForwardGroup</para>
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
            /// <para>rule-cxjh7vazn2jpnl****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The name of the forwarding rule.</para>
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
