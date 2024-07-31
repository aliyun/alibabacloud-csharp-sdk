// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDIJobRequest : TeaModel {
        /// <summary>
        /// The description of the synchronization task.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The settings of the destination. Only a single destination is supported.
        /// </summary>
        [NameInMap("DestinationDataSourceSettings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestDestinationDataSourceSettings> DestinationDataSourceSettings { get; set; }
        public class CreateDIJobRequestDestinationDataSourceSettings : TeaModel {
            /// <summary>
            /// The name of the data source.
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// The properties of the data source.
            /// </summary>
            [NameInMap("DataSourceProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> DataSourceProperties { get; set; }

        }

        /// <summary>
        /// The type of the destination. Valid values: Hologres and Hive.
        /// </summary>
        [NameInMap("DestinationDataSourceType")]
        [Validation(Required=false)]
        public string DestinationDataSourceType { get; set; }

        /// <summary>
        /// The name of the synchronization task.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// The settings for the dimension of the synchronization task. The settings include processing policies for DDL messages, policies for data type mappings between source fields and destination fields, and runtime parameters of the synchronization task.
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestJobSettings JobSettings { get; set; }
        public class CreateDIJobRequestJobSettings : TeaModel {
            /// <summary>
            /// The channel control settings for the synchronization task. The value of this parameter must be a JSON string.
            /// </summary>
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            /// <summary>
            /// The settings for data type mappings between source fields and destination fields. The value of this parameter must be an array.
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
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

            /// <summary>
            /// The settings for periodic scheduling.
            /// </summary>
            [NameInMap("CycleScheduleSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
            public class CreateDIJobRequestJobSettingsCycleScheduleSettings : TeaModel {
                /// <summary>
                /// The synchronization type that requires periodic scheduling. Valid values:
                /// 
                /// *   Full: full synchronization
                /// *   OfflineIncremental: batch incremental synchronization
                /// </summary>
                [NameInMap("CycleMigrationType")]
                [Validation(Required=false)]
                public string CycleMigrationType { get; set; }

                /// <summary>
                /// The scheduling parameters.
                /// </summary>
                [NameInMap("ScheduleParameters")]
                [Validation(Required=false)]
                public string ScheduleParameters { get; set; }

            }

            /// <summary>
            /// The processing settings for DDL messages.
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class CreateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
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
            /// The import settings for the synchronization task.
            /// </summary>
            [NameInMap("ImportRuleSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestJobSettingsImportRuleSettings ImportRuleSettings { get; set; }
            public class CreateDIJobRequestJobSettingsImportRuleSettings : TeaModel {
                /// <summary>
                /// The ID of the task to be imported.
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// The import source of the task. Set the value to Datastudio, which indicates synchronization tasks created in DataStudio.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// The runtime settings. The value of this parameter must be an array.
            /// </summary>
            [NameInMap("RuntimeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsRuntimeSettings : TeaModel {
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
        /// The synchronization type. Valid values:
        /// 
        /// *   FullAndRealtimeIncremental (one-time full synchronization and real-time incremental synchronization)
        /// *   RealtimeIncremental (real-time incremental synchronization)
        /// *   Full (full synchronization)
        /// *   OfflineIncremental (batch incremental synchronization)
        /// *   FullAndOfflineIncremental (one-time full synchronization and batch incremental synchronization)
        /// </summary>
        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        /// <summary>
        /// The DataWorks workspace ID. You can call the [ListProjects](https://help.aliyun.com/document_detail/178393.html) operation to obtain the ID.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The resource settings.
        /// </summary>
        [NameInMap("ResourceSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestResourceSettings ResourceSettings { get; set; }
        public class CreateDIJobRequestResourceSettings : TeaModel {
            /// <summary>
            /// The resource used for batch synchronization.
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
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
            public CreateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
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
        /// The settings of the source. Only a single source is supported.
        /// </summary>
        [NameInMap("SourceDataSourceSettings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestSourceDataSourceSettings> SourceDataSourceSettings { get; set; }
        public class CreateDIJobRequestSourceDataSourceSettings : TeaModel {
            /// <summary>
            /// The name of the data source.
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// The properties of the data source.
            /// </summary>
            [NameInMap("DataSourceProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> DataSourceProperties { get; set; }

        }

        /// <summary>
        /// The type of the source. Set the value to MySQL.
        /// </summary>
        [NameInMap("SourceDataSourceType")]
        [Validation(Required=false)]
        public string SourceDataSourceType { get; set; }

        /// <summary>
        /// Specifies whether to perform system debugging. Valid values: true and false. Default value: false.
        /// </summary>
        [NameInMap("SystemDebug")]
        [Validation(Required=false)]
        public string SystemDebug { get; set; }

        /// <summary>
        /// The list of mappings between rules used to select synchronization objects in the source and transformation rules applied to the selected synchronization objects. Each entry in the list displays a mapping between a rule used to select synchronization objects and a transformation rule applied to the selected synchronization objects.
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTableMappings> TableMappings { get; set; }
        public class CreateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// The rule used to select synchronization objects in the source. You can configure multiple rules.
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class CreateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
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
            /// The transformation rules applied to the selected synchronization objects.
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class CreateDIJobRequestTableMappingsTransformationRules : TeaModel {
                /// <summary>
                /// The type of the action. Valid values:
                /// 
                /// *   DefinePrimaryKey
                /// *   Rename
                /// *   AddColumn
                /// *   HandleDml
                /// *   DefineIncrementalCondition
                /// *   DefineCycleScheduleSettings
                /// *   DefineRuntimeSettings
                /// *   DefinePartitionKey
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
        public List<CreateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class CreateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// The type of the action. Valid values:
            /// 
            /// *   DefinePrimaryKey
            /// *   Rename
            /// *   AddColumn
            /// *   HandleDml
            /// *   DefineIncrementalCondition
            /// *   DefineCycleScheduleSettings
            /// *   DefineRuntimeSettings
            /// *   DefinePartitionKey
            /// </summary>
            [NameInMap("RuleActionType")]
            [Validation(Required=false)]
            public string RuleActionType { get; set; }

            /// <summary>
            /// The expression of the rule. An expression must be a JSON string.
            /// 
            /// Example of a renaming rule: {"expression":"${srcDatasourceName}_${srcDatabaseName}_0922","variables":[{"variableName":"srcDatabaseName","variableRules":[{"from":"fromdb","to":"todb"}]}]}
            /// 
            /// *   expression: the expression of the renaming rule. You can use the following variables in an expression: ${srcDatasourceName}, ${srcDatabaseName}, and ${srcTableName}. ${srcDatasourceName} indicates the name of the source. ${srcDatabaseName} indicates the name of a source database. ${srcTableName} indicates the name of a source table.
            /// *   variables: the generation rule for a variable used in the expression of the renaming rule. The default value of the specified variable is the original value of the object indicated by the variable. You can define a group of string replacement rules to change the original values based on your business requirements. variableName: the name of the variable. Do not enclose the variable name in ${}. variableRules: the string replacement rules for variables. The system runs the string replacement rules in sequence for string replacement. from specifies the original string. to specifies the new string.
            /// 
            /// Example of a rule used to add a specific field to the destination and assign a value to the field: {"columns":[{"columnName":"my_add_column","columnValueType":"Constant","columnValue":"123"}]}
            /// 
            /// *   If you do not configure such a rule, no fields are added to the destination and no values are assigned by default.
            /// *   columnName: the name of the field that you want to add.
            /// *   columnValueType: the type of the value of the field. Valid values: Constant and Variable.
            /// *   columnValue: the value of the field that you want to add. If you set the valueType parameter to Constant, set the columnValue parameter to a custom constant of the STRING type. If you set the valueType parameter to Variable, set the columnValue to a built-in variable. The following built-in variables are supported: EXECUTE_TIME (LONG data type), DB_NAME_SRC (STRING data type), DATASOURCE_NAME_SRC (STRING data type), TABLE_NAME_SRC (STRING data type), DB_NAME_DEST (STRING data type), DATASOURCE_NAME_DEST (STRING data type), TABLE_NAME_DEST (STRING data type), and DB_NAME_SRC_TRANSED (STRING data type). EXECUTE_TIME specifies the execution time. DB_NAME_SRC specifies the name of a source database. DATASOURCE_NAME_SRC specifies the name of the source. TABLE_NAME_SRC specifies the name of a source table. DB_NAME_DEST specifies the name of a destination database. DATASOURCE_NAME_DEST specifies the name of the destination. TABLE_NAME_DEST specifies the name of a destination table. DB_NAME_SRC_TRANSED specifies the database name obtained after a transformation.
            /// 
            /// Example of a rule used to specify primary key fields for a destination table: {"columns":["ukcolumn1","ukcolumn2"]}
            /// 
            /// *   If you do not configure such a rule, the primary key fields in the mapped source table are used for the destination table by default.
            /// *   If the destination table is an existing table, Data Integration does not modify the schema of the destination table. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run.
            /// *   If the destination table is automatically created by the system, Data Integration automatically creates the schema of the destination table. The schema contains the primary key fields that you specify. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run.
            /// 
            /// Example of a rule used to process DML messages: {"dmlPolicies":[{"dmlType":"Delete","dmlAction":"Filter","filterCondition":"id > 1"}]}
            /// 
            /// *   If you do not configure such a rule, the default processing policy for messages generated for insert, update, and delete operations is Normal.
            /// *   dmlType: the DML operation. Valid values: Insert, Update, and Delete.
            /// *   dmlAction: the processing policy for DML messages. Valid values: Normal, Ignore, Filter, and LogicalDelete. Filter indicates conditional processing. You can set the dmlAction parameter to Filter only when the dmlType parameter is set to Update or Delete.
            /// *   filterCondition: the condition used to filter DML messages. This parameter is required only when the dmlAction parameter is set to Filter.
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
