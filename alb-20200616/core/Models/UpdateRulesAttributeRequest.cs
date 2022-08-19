// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateRulesAttributeRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<UpdateRulesAttributeRequestRules> Rules { get; set; }
        public class UpdateRulesAttributeRequestRules : TeaModel {
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("RuleActions")]
            [Validation(Required=false)]
            public List<UpdateRulesAttributeRequestRulesRuleActions> RuleActions { get; set; }
            public class UpdateRulesAttributeRequestRulesRuleActions : TeaModel {
                [NameInMap("FixedResponseConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsFixedResponseConfig : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }
                    [NameInMap("HttpCode")]
                    [Validation(Required=false)]
                    public string HttpCode { get; set; }
                };

                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfig : TeaModel {
                    [NameInMap("ServerGroupStickySession")]
                    [Validation(Required=false)]
                    public UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public bool? Enabled { get; set; }

                        [NameInMap("Timeout")]
                        [Validation(Required=false)]
                        public int? Timeout { get; set; }

                    }
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        public string ServerGroupId { get; set; }
                        public int? Weight { get; set; }
                    }
                };

                [NameInMap("InsertHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsInsertHeaderConfig : TeaModel {
                    [NameInMap("CoverEnabled")]
                    [Validation(Required=false)]
                    public bool? CoverEnabled { get; set; }
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }
                    [NameInMap("ValueType")]
                    [Validation(Required=false)]
                    public string ValueType { get; set; }
                };

                [NameInMap("Order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("RedirectConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig RedirectConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRedirectConfig : TeaModel {
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
                };

                [NameInMap("RemoveHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig RemoveHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRemoveHeaderConfig : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }
                };

                [NameInMap("RewriteConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig RewriteConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsRewriteConfig : TeaModel {
                    [NameInMap("Host")]
                    [Validation(Required=false)]
                    public string Host { get; set; }
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }
                };

                [NameInMap("TrafficLimitConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsTrafficLimitConfig : TeaModel {
                    [NameInMap("PerIpQps")]
                    [Validation(Required=false)]
                    public int? PerIpQps { get; set; }
                    [NameInMap("QPS")]
                    [Validation(Required=false)]
                    public int? QPS { get; set; }
                };

                [NameInMap("TrafficMirrorConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfig : TeaModel {
                    [NameInMap("MirrorGroupConfig")]
                    [Validation(Required=false)]
                    public UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                        [NameInMap("ServerGroupTuples")]
                        [Validation(Required=false)]
                        public List<UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                        public class UpdateRulesAttributeRequestRulesRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
                            [NameInMap("ServerGroupId")]
                            [Validation(Required=false)]
                            public string ServerGroupId { get; set; }

                        }

                    }
                    [NameInMap("TargetType")]
                    [Validation(Required=false)]
                    public string TargetType { get; set; }
                };

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("RuleConditions")]
            [Validation(Required=false)]
            public List<UpdateRulesAttributeRequestRulesRuleConditions> RuleConditions { get; set; }
            public class UpdateRulesAttributeRequestRulesRuleConditions : TeaModel {
                [NameInMap("CookieConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsCookieConfig CookieConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsCookieConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleConditionsCookieConfigValues> Values { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleConditionsCookieConfigValues : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                };

                [NameInMap("HeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig HeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsHeaderConfig : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

                [NameInMap("HostConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsHostConfig HostConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsHostConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

                [NameInMap("MethodConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsMethodConfig MethodConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsMethodConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

                [NameInMap("PathConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsPathConfig PathConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsPathConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

                [NameInMap("QueryStringConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfigValues> Values { get; set; }
                    public class UpdateRulesAttributeRequestRulesRuleConditionsQueryStringConfigValues : TeaModel {
                        public string Key { get; set; }
                        public string Value { get; set; }
                    }
                };

                [NameInMap("ResponseHeaderConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig ResponseHeaderConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsResponseHeaderConfig : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

                [NameInMap("ResponseStatusCodeConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsResponseStatusCodeConfig ResponseStatusCodeConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsResponseStatusCodeConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

                [NameInMap("SourceIpConfig")]
                [Validation(Required=false)]
                public UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
                public class UpdateRulesAttributeRequestRulesRuleConditionsSourceIpConfig : TeaModel {
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public List<string> Values { get; set; }
                };

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

}
