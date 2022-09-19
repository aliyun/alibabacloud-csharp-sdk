// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateRuleRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("RuleActions")]
        [Validation(Required=false)]
        public List<CreateRuleRequestRuleActions> RuleActions { get; set; }
        public class CreateRuleRequestRuleActions : TeaModel {
            [NameInMap("FixedResponseConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsFixedResponseConfig FixedResponseConfig { get; set; }
            public class CreateRuleRequestRuleActionsFixedResponseConfig : TeaModel {
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
            public CreateRuleRequestRuleActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateRuleRequestRuleActionsForwardGroupConfig : TeaModel {
                [NameInMap("ServerGroupStickySession")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession ServerGroupStickySession { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupStickySession : TeaModel {
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    [NameInMap("Timeout")]
                    [Validation(Required=false)]
                    public int? Timeout { get; set; }

                }

                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class CreateRuleRequestRuleActionsForwardGroupConfigServerGroupTuples : TeaModel {
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
            public CreateRuleRequestRuleActionsInsertHeaderConfig InsertHeaderConfig { get; set; }
            public class CreateRuleRequestRuleActionsInsertHeaderConfig : TeaModel {
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
            public CreateRuleRequestRuleActionsRedirectConfig RedirectConfig { get; set; }
            public class CreateRuleRequestRuleActionsRedirectConfig : TeaModel {
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
            public CreateRuleRequestRuleActionsRewriteConfig RewriteConfig { get; set; }
            public class CreateRuleRequestRuleActionsRewriteConfig : TeaModel {
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
            public CreateRuleRequestRuleActionsTrafficLimitConfig TrafficLimitConfig { get; set; }
            public class CreateRuleRequestRuleActionsTrafficLimitConfig : TeaModel {
                [NameInMap("PerIpQps")]
                [Validation(Required=false)]
                public int? PerIpQps { get; set; }

                [NameInMap("QPS")]
                [Validation(Required=false)]
                public int? QPS { get; set; }

            }

            [NameInMap("TrafficMirrorConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleActionsTrafficMirrorConfig TrafficMirrorConfig { get; set; }
            public class CreateRuleRequestRuleActionsTrafficMirrorConfig : TeaModel {
                [NameInMap("MirrorGroupConfig")]
                [Validation(Required=false)]
                public CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig MirrorGroupConfig { get; set; }
                public class CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfig : TeaModel {
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class CreateRuleRequestRuleActionsTrafficMirrorConfigMirrorGroupConfigServerGroupTuples : TeaModel {
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
        public List<CreateRuleRequestRuleConditions> RuleConditions { get; set; }
        public class CreateRuleRequestRuleConditions : TeaModel {
            [NameInMap("CookieConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsCookieConfig CookieConfig { get; set; }
            public class CreateRuleRequestRuleConditionsCookieConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleConditionsCookieConfigValues> Values { get; set; }
                public class CreateRuleRequestRuleConditionsCookieConfigValues : TeaModel {
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
            public CreateRuleRequestRuleConditionsHeaderConfig HeaderConfig { get; set; }
            public class CreateRuleRequestRuleConditionsHeaderConfig : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("HostConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsHostConfig HostConfig { get; set; }
            public class CreateRuleRequestRuleConditionsHostConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("MethodConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsMethodConfig MethodConfig { get; set; }
            public class CreateRuleRequestRuleConditionsMethodConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("PathConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsPathConfig PathConfig { get; set; }
            public class CreateRuleRequestRuleConditionsPathConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("QueryStringConfig")]
            [Validation(Required=false)]
            public CreateRuleRequestRuleConditionsQueryStringConfig QueryStringConfig { get; set; }
            public class CreateRuleRequestRuleConditionsQueryStringConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<CreateRuleRequestRuleConditionsQueryStringConfigValues> Values { get; set; }
                public class CreateRuleRequestRuleConditionsQueryStringConfigValues : TeaModel {
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
            public CreateRuleRequestRuleConditionsSourceIpConfig SourceIpConfig { get; set; }
            public class CreateRuleRequestRuleConditionsSourceIpConfig : TeaModel {
                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
