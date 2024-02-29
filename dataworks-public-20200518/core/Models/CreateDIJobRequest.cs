// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDIJobRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DestinationDataSourceSettings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestDestinationDataSourceSettings> DestinationDataSourceSettings { get; set; }
        public class CreateDIJobRequestDestinationDataSourceSettings : TeaModel {
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("DataSourceProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> DataSourceProperties { get; set; }

        }

        [NameInMap("DestinationDataSourceType")]
        [Validation(Required=false)]
        public string DestinationDataSourceType { get; set; }

        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestJobSettings JobSettings { get; set; }
        public class CreateDIJobRequestJobSettings : TeaModel {
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public string SourceDataType { get; set; }

            }

            [NameInMap("CycleScheduleSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
            public class CreateDIJobRequestJobSettingsCycleScheduleSettings : TeaModel {
                [NameInMap("CycleMigrationType")]
                [Validation(Required=false)]
                public string CycleMigrationType { get; set; }

                [NameInMap("ScheduleParameters")]
                [Validation(Required=false)]
                public string ScheduleParameters { get; set; }

            }

            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class CreateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("ImportRuleSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestJobSettingsImportRuleSettings ImportRuleSettings { get; set; }
            public class CreateDIJobRequestJobSettingsImportRuleSettings : TeaModel {
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            [NameInMap("RuntimeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsRuntimeSettings : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ResourceSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestResourceSettings ResourceSettings { get; set; }
        public class CreateDIJobRequestResourceSettings : TeaModel {
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            [NameInMap("RealtimeResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

        }

        [NameInMap("SourceDataSourceSettings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestSourceDataSourceSettings> SourceDataSourceSettings { get; set; }
        public class CreateDIJobRequestSourceDataSourceSettings : TeaModel {
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            [NameInMap("DataSourceProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> DataSourceProperties { get; set; }

        }

        [NameInMap("SourceDataSourceType")]
        [Validation(Required=false)]
        public string SourceDataSourceType { get; set; }

        [NameInMap("SystemDebug")]
        [Validation(Required=false)]
        public string SystemDebug { get; set; }

        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTableMappings> TableMappings { get; set; }
        public class CreateDIJobRequestTableMappings : TeaModel {
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class CreateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class CreateDIJobRequestTableMappingsTransformationRules : TeaModel {
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("RuleTargetType")]
                [Validation(Required=false)]
                public string RuleTargetType { get; set; }

            }

        }

        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class CreateDIJobRequestTransformationRules : TeaModel {
            [NameInMap("RuleActionType")]
            [Validation(Required=false)]
            public string RuleActionType { get; set; }

            [NameInMap("RuleExpression")]
            [Validation(Required=false)]
            public string RuleExpression { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("RuleTargetType")]
            [Validation(Required=false)]
            public string RuleTargetType { get; set; }

        }

    }

}
