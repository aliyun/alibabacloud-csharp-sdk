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
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, a <c>2xx HTTP</c> status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the Application Load Balancer (ALB) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsr-bp1bpn0kn908w4nbw****</para>
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<CreateRulesRequestRules> Rules { get; set; }
        public class CreateRulesRequestRules : TeaModel {
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesRuleActions> RuleActions { get; set; }
            public class CreateRulesRequestRulesRuleActions : TeaModel {
                [NameInMap("CorsConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsCorsConfig CorsConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsCorsConfig : TeaModel {
                    [NameInMap("AllowCredentials")]
                    [Validation(Required=false)]
                    public string AllowCredentials { get; set; }

                    [NameInMap("AllowHeaders")]
                    [Validation(Required=false)]
                    public List<string> AllowHeaders { get; set; }

                    [NameInMap("AllowMethods")]
                    [Validation(Required=false)]
                    public List<string> AllowMethods { get; set; }

                    [NameInMap("AllowOrigin")]
                    [Validation(Required=false)]
                    public List<string> AllowOrigin { get; set; }

                    [NameInMap("ExposeHeaders")]
                    [Validation(Required=false)]
                    public List<string> ExposeHeaders { get; set; }

                    [NameInMap("MaxAge")]
                    [Validation(Required=false)]
                    public long? MaxAge { get; set; }

                }

                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                }

                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsForwardGroupConfig : TeaModel {
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }

                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateRulesRequestRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRedirectConfig : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    [NameInMap("Protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                }

                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsRewriteConfig : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }

                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                }

                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }

                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }

                }

                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class CreateRulesRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                        }

                    }

                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesRuleConditions> RuleConditions { get; set; }
            public class CreateRulesRequestRulesRuleConditions : TeaModel {
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsCookieConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsHostConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsMethodConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsPathConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<CreateRulesRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class CreateRulesRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public CreateRulesRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class CreateRulesRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<CreateRulesRequestRulesTag> Tag { get; set; }
            public class CreateRulesRequestRulesTag : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
