// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDIJobRequest : TeaModel {
        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated. Use the Id parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11588</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DIJobId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11588</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public UpdateDIJobRequestJobSettings JobSettings { get; set; }
        public class UpdateDIJobRequestJobSettings : TeaModel {
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public string SourceDataType { get; set; }

            }

            [NameInMap("CycleScheduleSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsCycleScheduleSettings : TeaModel {
                [NameInMap("ScheduleParameters")]
                [Validation(Required=false)]
                public string ScheduleParameters { get; set; }

            }

            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("RuntimeSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsRuntimeSettings : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to obtain the workspace ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("ResourceSettings")]
        [Validation(Required=false)]
        public UpdateDIJobRequestResourceSettings ResourceSettings { get; set; }
        public class UpdateDIJobRequestResourceSettings : TeaModel {
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            [NameInMap("RealtimeResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            [NameInMap("ScheduleResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsScheduleResourceSettings : TeaModel {
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

        }

        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTableMappings> TableMappings { get; set; }
        public class UpdateDIJobRequestTableMappings : TeaModel {
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class UpdateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("ExpressionType")]
                [Validation(Required=false)]
                public string ExpressionType { get; set; }

                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class UpdateDIJobRequestTableMappingsTransformationRules : TeaModel {
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
        public List<UpdateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class UpdateDIJobRequestTransformationRules : TeaModel {
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
