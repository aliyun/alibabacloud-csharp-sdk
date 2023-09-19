// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class MigrationJob : TeaModel {
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        [NameInMap("JobStatus")]
        [Validation(Required=false)]
        public string JobStatus { get; set; }

        [NameInMap("Plan")]
        [Validation(Required=false)]
        public MigrationJobPlan Plan { get; set; }
        public class MigrationJobPlan : TeaModel {
            [NameInMap("Contacts")]
            [Validation(Required=false)]
            public List<MigrationJobPlanContacts> Contacts { get; set; }
            public class MigrationJobPlanContacts : TeaModel {
                [NameInMap("Channels")]
                [Validation(Required=false)]
                public List<MigrationJobPlanContactsChannels> Channels { get; set; }
                public class MigrationJobPlanContactsChannels : TeaModel {
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public long? Level { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Escalations")]
            [Validation(Required=false)]
            public List<MigrationJobPlanEscalations> Escalations { get; set; }
            public class MigrationJobPlanEscalations : TeaModel {
                [NameInMap("Escalations")]
                [Validation(Required=false)]
                public List<MigrationJobPlanEscalationsEscalations> Escalations { get; set; }
                public class MigrationJobPlanEscalationsEscalations : TeaModel {
                    [NameInMap("Groups")]
                    [Validation(Required=false)]
                    public List<string> Groups { get; set; }

                    [NameInMap("LevelGroups")]
                    [Validation(Required=false)]
                    public MigrationJobPlanEscalationsEscalationsLevelGroups LevelGroups { get; set; }
                    public class MigrationJobPlanEscalationsEscalationsLevelGroups : TeaModel {
                        [NameInMap("Critical")]
                        [Validation(Required=false)]
                        public List<string> Critical { get; set; }

                        [NameInMap("Info")]
                        [Validation(Required=false)]
                        public List<string> Info { get; set; }

                        [NameInMap("Resolved")]
                        [Validation(Required=false)]
                        public List<string> Resolved { get; set; }

                        [NameInMap("Warning")]
                        [Validation(Required=false)]
                        public List<string> Warning { get; set; }

                    }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<MigrationJobPlanGroups> Groups { get; set; }
            public class MigrationJobPlanGroups : TeaModel {
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<string> Contacts { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("RuleNames")]
            [Validation(Required=false)]
            public List<string> RuleNames { get; set; }

            [NameInMap("Strategies")]
            [Validation(Required=false)]
            public List<MigrationJobPlanStrategies> Strategies { get; set; }
            public class MigrationJobPlanStrategies : TeaModel {
                [NameInMap("EscalationSetting")]
                [Validation(Required=false)]
                public MigrationJobPlanStrategiesEscalationSetting EscalationSetting { get; set; }
                public class MigrationJobPlanStrategiesEscalationSetting : TeaModel {
                    [NameInMap("escalationUuid")]
                    [Validation(Required=false)]
                    public string EscalationUuid { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PushingSetting")]
                [Validation(Required=false)]
                public MigrationJobPlanStrategiesPushingSetting PushingSetting { get; set; }
                public class MigrationJobPlanStrategiesPushingSetting : TeaModel {
                    [NameInMap("TargetUuids")]
                    [Validation(Required=false)]
                    public List<string> TargetUuids { get; set; }

                }

            }

            [NameInMap("Subscriptions")]
            [Validation(Required=false)]
            public List<MigrationJobPlanSubscriptions> Subscriptions { get; set; }
            public class MigrationJobPlanSubscriptions : TeaModel {
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<MigrationJobPlanSubscriptionsConditions> Conditions { get; set; }
                public class MigrationJobPlanSubscriptionsConditions : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("Op")]
                    [Validation(Required=false)]
                    public string Op { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("StrategyUuid")]
                [Validation(Required=false)]
                public string StrategyUuid { get; set; }

            }

            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<MigrationJobPlanTargets> Targets { get; set; }
            public class MigrationJobPlanTargets : TeaModel {
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                [NameInMap("HttpRequestTarget")]
                [Validation(Required=false)]
                public MigrationJobPlanTargetsHttpRequestTarget HttpRequestTarget { get; set; }
                public class MigrationJobPlanTargetsHttpRequestTarget : TeaModel {
                    [NameInMap("ContentType")]
                    [Validation(Required=false)]
                    public string ContentType { get; set; }

                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

        }

        [NameInMap("RuleNames")]
        [Validation(Required=false)]
        public List<string> RuleNames { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public List<MigrationJobSource> Source { get; set; }
        public class MigrationJobSource : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public MigrationJobSourceRule Rule { get; set; }
            public class MigrationJobSourceRule : TeaModel {
                [NameInMap("KeywordFilter")]
                [Validation(Required=false)]
                public MigrationJobSourceRuleKeywordFilter KeywordFilter { get; set; }
                public class MigrationJobSourceRuleKeywordFilter : TeaModel {
                    [NameInMap("Keywords")]
                    [Validation(Required=false)]
                    public List<string> Keywords { get; set; }

                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PrimaryFilters")]
                [Validation(Required=false)]
                public List<MigrationJobSourceRulePrimaryFilters> PrimaryFilters { get; set; }
                public class MigrationJobSourceRulePrimaryFilters : TeaModel {
                    [NameInMap("Field")]
                    [Validation(Required=false)]
                    public string Field { get; set; }

                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<MigrationJobSourceTargets> Targets { get; set; }
            public class MigrationJobSourceTargets : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public MigrationJobSourceTargetsContent Content { get; set; }
                public class MigrationJobSourceTargetsContent : TeaModel {
                    [NameInMap("Group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("Method")]
                    [Validation(Required=false)]
                    public string Method { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("ResourcePath")]
                    [Validation(Required=false)]
                    public string ResourcePath { get; set; }

                    [NameInMap("Url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
