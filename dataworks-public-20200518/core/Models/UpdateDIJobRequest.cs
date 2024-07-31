// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateDIJobRequest : TeaModel {
        /// <summary>
        /// The ID of the synchronization task.
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        public long? DIJobId { get; set; }

        /// <summary>
        /// The description of the synchronization task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The settings for the dimension of the synchronization task. The settings include processing policies for DDL messages, policies for data type mappings between source fields and destination fields, and runtime parameters of the synchronization task.
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public UpdateDIJobRequestJobSettings JobSettings { get; set; }
        public class UpdateDIJobRequestJobSettings : TeaModel {
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            /// <summary>
            /// The settings for data type mappings between source fields and destination fields. The value of this parameter must be an array.
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                /// <summary>
                /// The data type of a destination field.
                /// </summary>
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                /// <summary>
                /// The data type of a source field.
                /// </summary>
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

            /// <summary>
            /// The settings for processing DDL messages. The value of this parameter must be an array.
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                /// <summary>
                /// The processing policy for DDL messages. Valid values:
                /// 
                /// *   Ignore: ignores a DDL message.
                /// *   Critical: reports an error for a DDL message.
                /// *   Normal: normally processes a DDL message.
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// The type of the DDL operation. Valid values:
                /// 
                /// *   RenameColumn
                /// *   ModifyColumn
                /// *   CreateTable
                /// *   TruncateTable
                /// *   DropTable
                /// *   DropColumn
                /// *   AddColumn
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The runtime settings. The value of this parameter must be an array.
            /// </summary>
            [NameInMap("RuntimeSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsRuntimeSettings : TeaModel {
                /// <summary>
                /// The name of the configuration item. Valid values:
                /// 
                /// *   runtime.offline.speed.limit.mb: indicates the maximum transmission rate that is allowed for a batch synchronization task. This configuration item takes effect only when runtime.offline.speed.limit.enable is set to true.
                /// *   runtime.offline.speed.limit.enable: indicates whether throttling is enabled for a batch synchronization task.
                /// *   dst.offline.connection.max: indicates the maximum number of connections that are allowed for writing data to the destination of a batch synchronization task.
                /// *   runtime.offline.concurrent: indicates the maximum number of parallel threads that are allowed for a batch synchronization task.
                /// *   dst.realtime.connection.max: indicates the maximum number of connections that are allowed for writing data to the destination of a real-time synchronization task.
                /// *   runtime.enable.auto.create.schema: indicates whether schemas are automatically created in the destination of a synchronization task.
                /// *   src.offline.datasource.max.connection: indicates the maximum number of connections that are allowed for reading data from the source of a batch synchronization task.
                /// *   runtime.realtime.concurrent: indicates the maximum number of parallel threads that are allowed for a real-time synchronization task.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the configuration item.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The resource settings.
        /// </summary>
        [NameInMap("ResourceSettings")]
        [Validation(Required=false)]
        public UpdateDIJobRequestResourceSettings ResourceSettings { get; set; }
        public class UpdateDIJobRequestResourceSettings : TeaModel {
            /// <summary>
            /// The resource used for batch synchronization.
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                /// <summary>
                /// The identifier of the resource group for Data Integration used for batch synchronization.
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// The resource used for real-time synchronization.
            /// </summary>
            [NameInMap("RealtimeResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                /// <summary>
                /// The identifier of the resource group for Data Integration used for real-time synchronization.
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            [NameInMap("RequestedCu")]
            [Validation(Required=false)]
            public float? RequestedCu { get; set; }

        }

        /// <summary>
        /// The list of mappings between rules used to select synchronization objects in the source and transformation rules applied to the selected synchronization objects. Each entry in the list displays a mapping between a rule used to select synchronization objects and a transformation rule applied to the selected synchronization objects.
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTableMappings> TableMappings { get; set; }
        public class UpdateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// The rule used to select synchronization objects in the source. You can configure multiple rules.
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class UpdateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
                /// <summary>
                /// The expression.
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// The type of the object. Valid values:
                /// 
                /// *   Table
                /// *   Database
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            /// <summary>
            /// The transformation rules that are applied to the selected synchronization objects.
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class UpdateDIJobRequestTableMappingsTransformationRules : TeaModel {
                /// <summary>
                /// The type of the action. Valid values:
                /// 
                /// *   DefinePrimaryKey
                /// *   Rename
                /// *   AddColumn
                /// *   HandleDml
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// The name of the rule. If the values of the RuleActionType parameter and the RuleTargetType parameter are the same for multiple transformation rules, you must make sure that the transformation rule names are unique.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The type of the object on which you want to perform the action. Valid values:
                /// 
                /// *   Table
                /// *   Schema
                /// </summary>
                [NameInMap("RuleTargetType")]
                [Validation(Required=false)]
                public string RuleTargetType { get; set; }

            }

        }

        /// <summary>
        /// The list of transformation rules for objects involved in the synchronization task. Each entry in the list defines a transformation rule.
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class UpdateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// The type of the action. Valid values:
            /// 
            /// *   DefinePrimaryKey
            /// *   Rename
            /// *   AddColumn
            /// *   HandleDml
            /// </summary>
            [NameInMap("RuleActionType")]
            [Validation(Required=false)]
            public string RuleActionType { get; set; }

            /// <summary>
            /// The expression of the rule. The expression is a JSON string.
            /// 
            /// Example of a renaming rule: {"expression":"${srcDatasourceName}_${srcDatabaseName}_0922","variables":[{"variableName":"srcDatabaseName","variableRules":[{"from":"fromdb","to":"todb"}]}]}.
            /// 
            /// expression: the expression of the renaming rule. The expression may contain the following variables: ${srcDatasourceName}, ${srcDatabaseName}, and ${srcTableName}. ${srcDatasourceName} indicates the name of the source. ${srcDatabaseName} indicates the name of a source database. ${srcTableName} indicates the name of a source table. variables: the generation rule for a variable used in the expression of the renaming rule. The default value of the specified variable is the original value of the object indicated by the variable. You can define a group of string replacement rules to change the original values based on your business requirements. variableName: the name of the variable. The variable name is not enclosed in ${}. variableRules: the string replacement rules for variables. The system runs the string replacement rules in sequence for string replacement. from indicates the original string. to indicates the new string. Example of a rule used to add a specific field to the destination and assign a value to the field: {"columns":[{"columnName":"my_add_column","columnValueType":"Constant","columnValue":"123"}]}.
            /// 
            /// If no rule of this type is configured, no fields are added to the destination and no values are assigned by default. columnName: the name of the field that is added. columnValueType: the value type of the field. Valid values: Constant and Variable. columnValue: the value of the field that is added. If the valueType parameter is set to Constant, the value of the columnValue parameter must be a constant of the STRING type. If the valueType parameter is set to Variable, the value of the columnValue parameter must be a built-in variable. The following built-in variables are supported: EXECUTE_TIME (LONG data type), DB_NAME_SRC (STRING data type), DATASOURCE_NAME_SRC (STRING data type), TABLE_NAME_SRC (STRING data type), DB_NAME_DEST (STRING data type), DATASOURCE_NAME_DEST (STRING data type), TABLE_NAME_DEST (STRING data type), and DB_NAME_SRC_TRANSED (STRING data type). EXECUTE_TIME indicates the execution time. DB_NAME_SRC indicates the name of a source database. DATASOURCE_NAME_SRC indicates the name of the source. TABLE_NAME_SRC indicates the name of a source table. DB_NAME_DEST indicates the name of a destination database. DATASOURCE_NAME_DEST indicates the name of the destination. TABLE_NAME_DEST indicates the name of a destination table. DB_NAME_SRC_TRANSED indicates the database name obtained after a transformation. Example of a rule used to specify primary key fields for a destination table: {"columns":["ukcolumn1","ukcolumn2"]}.
            /// 
            /// If no rule of this type is configured, the primary key fields in the mapped source table are used for the destination table by default. If the destination table is an existing table, Data Integration does not modify the schema of the destination table. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run. If the destination table is automatically created by the system, Data Integration automatically creates the schema of the destination table. The schema contains the primary key fields that you specify. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run. Example of a rule used to process DML messages: {"dmlPolicies":[{"dmlType":"Delete","dmlAction":"Filter","filterCondition":"id > 1"}]}.
            /// 
            /// If no rule of this type is configured, the default processing policy for messages generated for insert, update, and delete operations is Normal. dmlType: the DML operation. Valid values: Insert, Update, and Delete. dmlAction: the processing policy for DML messages. Valid values: Normal, Ignore, Filter, and LogicalDelete. Filter indicates conditional processing. You can set the dmlAction parameter to Filter only when the dmlType parameter is set to Update or Delete. filterCondition: the condition used to filter DML messages. This parameter is required only when the dmlAction parameter is set to Filter.
            /// </summary>
            [NameInMap("RuleExpression")]
            [Validation(Required=false)]
            public string RuleExpression { get; set; }

            /// <summary>
            /// The name of the rule. If the values of the RuleActionType parameter and the RuleTargetType parameter are the same for multiple transformation rules, you must make sure that the transformation rule names are unique.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The type of the object on which you want to perform the action. Valid values:
            /// 
            /// *   Table
            /// *   Schema
            /// </summary>
            [NameInMap("RuleTargetType")]
            [Validation(Required=false)]
            public string RuleTargetType { get; set; }

        }

    }

}
