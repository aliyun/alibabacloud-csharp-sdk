// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateRuleAttributeRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("RuleActions")]
        [Validation(Required=false)]
        public List<UpdateRuleAttributeRequestRuleActions> RuleActions { get; set; }
        public class UpdateRuleAttributeRequestRuleActions : TeaModel {
            [NameInMap("CorsConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsCorsConfig CorsConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsCorsConfig : TeaModel {
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
            public UpdateRuleAttributeRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsFixedResponseConfig : TeaModel {
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
            public UpdateRuleAttributeRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfig : TeaModel {
                [NameInMap("ServerGroupStickySession")]
                [Validation(Required=false)]
                public UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
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
            public UpdateRuleAttributeRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsInsertHeaderConfig : TeaModel {
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

            [NameInMap("Order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

            [NameInMap("RedirectConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRedirectConfig : TeaModel {
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

            [NameInMap("RewriteConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsRewriteConfig : TeaModel {
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
            public UpdateRuleAttributeRequestRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsTrafficLimitConfig : TeaModel {
                [NameInMap("PerIpQps")]
                [Validation(Required=false)]
                public int? PerIpQps { get; set; }

                [NameInMap("QPS")]
                [Validation(Required=false)]
                public int? QPS { get; set; }

            }

            [NameInMap("TrafficMirrorConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfig : TeaModel {
                [NameInMap("MirrorGroupConfig")]
                [Validation(Required=false)]
                public UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                public class UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class UpdateRuleAttributeRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                    }

                }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RuleConditions")]
        [Validation(Required=false)]
        public List<UpdateRuleAttributeRequestRuleConditions> RuleConditions { get; set; }
        public class UpdateRuleAttributeRequestRuleConditions : TeaModel {
            [NameInMap("CookieConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsCookieConfig CookieConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsCookieConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleConditionsCookieConfigValues> Values { get; set; }
                public class UpdateRuleAttributeRequestRuleConditionsCookieConfigValues : TeaModel {
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
            public UpdateRuleAttributeRequestRuleConditionsHeaderConfig HeaderConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsHeaderConfig : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("HostConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsHostConfig HostConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsHostConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("MethodConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsMethodConfig MethodConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsMethodConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("PathConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsPathConfig PathConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsPathConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("QueryStringConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsQueryStringConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<UpdateRuleAttributeRequestRuleConditionsQueryStringConfigValues> Values { get; set; }
                public class UpdateRuleAttributeRequestRuleConditionsQueryStringConfigValues : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("SourceIpConfig")]
            [Validation(Required=false)]
            public UpdateRuleAttributeRequestRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
            public class UpdateRuleAttributeRequestRuleConditionsSourceIpConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
