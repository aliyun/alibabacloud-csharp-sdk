// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDIJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Synchronize mysql to hologres</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The settings of the destination data source. Currently, only a single data source is supported.</para>
        /// </summary>
        [NameInMap("DestinationDataSourceSettings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestDestinationDataSourceSettings> DestinationDataSourceSettings { get; set; }
        public class CreateDIJobRequestDestinationDataSourceSettings : TeaModel {
            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>holo_datasource_1</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The properties of the data source.</para>
            /// </summary>
            [NameInMap("DataSourceProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> DataSourceProperties { get; set; }

        }

        /// <summary>
        /// <para>The type of the destination data source. Valid values: Hologres and Hive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hologres</para>
        /// </summary>
        [NameInMap("DestinationDataSourceType")]
        [Validation(Required=false)]
        public string DestinationDataSourceType { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_to_holo_sync_8772</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The settings at the synchronization task level, including DDL handling policies, column data type mapping policies between the source and destination, and task runtime parameters.</para>
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestJobSettings JobSettings { get; set; }
        public class CreateDIJobRequestJobSettings : TeaModel {
            /// <summary>
            /// <para>The channel-related task settings in JSON string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;structInfo&quot;:&quot;MANAGED&quot;,&quot;storageType&quot;:&quot;TEXTFILE&quot;,&quot;writeMode&quot;:&quot;APPEND&quot;,&quot;partitionColumns&quot;:[{&quot;columnName&quot;:&quot;pt&quot;,&quot;columnType&quot;:&quot;STRING&quot;,&quot;comment&quot;:&quot;&quot;}],&quot;fieldDelimiter&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            /// <summary>
            /// <para>The column type mappings. Multiple values are supported.</para>
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                /// <summary>
                /// <para>The destination data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                /// <summary>
                /// <para>The source data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public string SourceDataType { get; set; }

            }

            /// <summary>
            /// <para>The periodic scheduling settings.</para>
            /// </summary>
            [NameInMap("CycleScheduleSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
            public class CreateDIJobRequestJobSettingsCycleScheduleSettings : TeaModel {
                /// <summary>
                /// <para>The synchronization type that requires periodic scheduling. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Full: full synchronization</description></item>
                /// <item><description>OfflineIncremental: batch incremental synchronization</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Full</para>
                /// </summary>
                [NameInMap("CycleMigrationType")]
                [Validation(Required=false)]
                public string CycleMigrationType { get; set; }

                /// <summary>
                /// <para>The scheduling parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bizdate=$bizdate</para>
                /// </summary>
                [NameInMap("ScheduleParameters")]
                [Validation(Required=false)]
                public string ScheduleParameters { get; set; }

            }

            /// <summary>
            /// <para>The DDL handling settings.</para>
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class CreateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                /// <summary>
                /// <para>The handling action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Ignore: ignores the operation</description></item>
                /// <item><description>Critical: reports an error</description></item>
                /// <item><description>Normal: handles the operation normally</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Critical</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The DDL type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RenameColumn: renames a column</description></item>
                /// <item><description>ModifyColumn: modifies a column</description></item>
                /// <item><description>CreateTable: creates a table</description></item>
                /// <item><description>TruncateTable: truncates a table</description></item>
                /// <item><description>DropTable: drops a table</description></item>
                /// <item><description>DropColumn: drops a column</description></item>
                /// <item><description>AddColumn: adds a column</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AddColumn</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The import settings for the synchronization task.</para>
            /// </summary>
            [NameInMap("ImportRuleSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestJobSettingsImportRuleSettings ImportRuleSettings { get; set; }
            public class CreateDIJobRequestJobSettingsImportRuleSettings : TeaModel {
                /// <summary>
                /// <para>The ID of the task to be imported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>The source from which the task configuration is imported. Valid value: Datastudio (synchronization tasks in Data Studio).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Datastudio</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

            /// <summary>
            /// <para>The runtime settings. Multiple values are supported.</para>
            /// </summary>
            [NameInMap("RuntimeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsRuntimeSettings : TeaModel {
                /// <summary>
                /// <para>The name of the setting. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>runtime.offline.speed.limit.mb: the throttling limit for batch tasks, which takes effect when runtime.offline.speed.limit.enable is set to true</description></item>
                /// <item><description>runtime.offline.speed.limit.enable: specifies whether to enable throttling for batch tasks</description></item>
                /// <item><description>dst.offline.connection.max: the maximum number of connections to the destination for batch tasks</description></item>
                /// <item><description>runtime.offline.concurrent: the concurrency of batch synchronization tasks</description></item>
                /// <item><description>dst.realtime.connection.max: the maximum number of connections to the destination for real-time tasks</description></item>
                /// <item><description>runtime.enable.auto.create.schema: specifies whether to automatically create a schema at the destination</description></item>
                /// <item><description>src.offline.datasource.max.connection: the maximum number of connections to the source for batch tasks</description></item>
                /// <item><description>runtime.realtime.concurrent: the concurrency of real-time tasks</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>runtime.offline.concurrent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the setting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The synchronization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FullAndRealtimeIncremental: full and real-time incremental synchronization</description></item>
        /// <item><description>RealtimeIncremental: real-time incremental synchronization</description></item>
        /// <item><description>Full: full synchronization</description></item>
        /// <item><description>OfflineIncremental: batch incremental synchronization</description></item>
        /// <item><description>FullAndOfflineIncremental: full and batch incremental synchronization</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullAndRealtimeIncremental</para>
        /// </summary>
        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can call the <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> operation to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource settings.</para>
        /// </summary>
        [NameInMap("ResourceSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestResourceSettings ResourceSettings { get; set; }
        public class CreateDIJobRequestResourceSettings : TeaModel {
            /// <summary>
            /// <para>The batch synchronization resources.</para>
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                /// <summary>
                /// <para>The identifier of the Data Integration resource group used for batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The real-time synchronization resources.</para>
            /// </summary>
            [NameInMap("RealtimeResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                /// <summary>
                /// <para>The identifier of the Data Integration resource group used for real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The number of compute units (CUs) of the resource group used for the full and incremental synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("RequestedCu")]
            [Validation(Required=false)]
            public float? RequestedCu { get; set; }

        }

        /// <summary>
        /// <para>The settings of the source data source. Currently, only a single data source is supported.</para>
        /// </summary>
        [NameInMap("SourceDataSourceSettings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestSourceDataSourceSettings> SourceDataSourceSettings { get; set; }
        public class CreateDIJobRequestSourceDataSourceSettings : TeaModel {
            /// <summary>
            /// <para>The name of the data source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_datasource_1</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The properties of the data source.</para>
            /// </summary>
            [NameInMap("DataSourceProperties")]
            [Validation(Required=false)]
            public Dictionary<string, string> DataSourceProperties { get; set; }

        }

        /// <summary>
        /// <para>The type of the source data source. Valid value: MySQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SourceDataSourceType")]
        [Validation(Required=false)]
        public string SourceDataSourceType { get; set; }

        /// <summary>
        /// <para>Used for system debugging. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SystemDebug")]
        [Validation(Required=false)]
        public string SystemDebug { get; set; }

        /// <summary>
        /// <para>The list of transformation mappings for synchronization objects. Each element in the list describes a set of source synchronization object selection rules and a list of synchronization object transformation rules applied to this set of synchronization objects.</para>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTableMappings> TableMappings { get; set; }
        public class CreateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// <para>The source object selection rules. Multiple rules are supported.</para>
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class CreateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
                /// <summary>
                /// <para>The expression.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mysql_table_1</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Table: table</description></item>
                /// <item><description>Database: database</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Table</para>
                /// </summary>
                [NameInMap("ObjectType")]
                [Validation(Required=false)]
                public string ObjectType { get; set; }

            }

            /// <summary>
            /// <para>The list of transformation rules applied to the source objects.</para>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class CreateDIJobRequestTableMappingsTransformationRules : TeaModel {
                /// <summary>
                /// <para>The action type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DefinePrimaryKey: defines the primary key</description></item>
                /// <item><description>Rename: renames the object</description></item>
                /// <item><description>AddColumn: adds a column</description></item>
                /// <item><description>HandleDml: handles DML operations</description></item>
                /// <item><description>DefineIncrementalCondition: defines the incremental condition</description></item>
                /// <item><description>DefineCycleScheduleSettings: defines the periodic scheduling settings</description></item>
                /// <item><description>DefineRuntimeSettings: defines the advanced configuration parameters</description></item>
                /// <item><description>DefinePartitionKey: defines the partition key</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Rename</para>
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// <para>The name of the rule. The rule name must be unique under a specific combination of action type and target type of the action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rename_rule_1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The target type of the action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Table: table</description></item>
                /// <item><description>Schema: schema</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Table</para>
                /// </summary>
                [NameInMap("RuleTargetType")]
                [Validation(Required=false)]
                public string RuleTargetType { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of transformation rule definitions for synchronization objects. Each element in the list represents a transformation rule definition.</para>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class CreateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// <para>The action type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DefinePrimaryKey: defines the primary key</description></item>
            /// <item><description>Rename: renames the object</description></item>
            /// <item><description>AddColumn: adds a column</description></item>
            /// <item><description>HandleDml: handles DML operations</description></item>
            /// <item><description>DefineIncrementalCondition: defines the incremental condition</description></item>
            /// <item><description>DefineCycleScheduleSettings: defines the periodic scheduling settings</description></item>
            /// <item><description>DefineRuntimeSettings: defines the advanced configuration parameters</description></item>
            /// <item><description>DefinePartitionKey: defines the partition key</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Rename</para>
            /// </summary>
            [NameInMap("RuleActionType")]
            [Validation(Required=false)]
            public string RuleActionType { get; set; }

            /// <summary>
            /// <para>The rule expression in JSON string format.</para>
            /// <para>Example of a rename rule (Rename):
            /// {&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot;,&quot;variables&quot;:[{&quot;variableName&quot;:&quot;srcDatabaseName&quot;,&quot;variableRules&quot;:[{&quot;from&quot;:&quot;fromdb&quot;,&quot;to&quot;:&quot;todb&quot;}]}]}</para>
            /// <list type="bullet">
            /// <item><description>expression: the expression for the rename transformation rule. Supported variables in the expression include ${srcDatasourceName} (source data source name), ${srcDatabaseName} (source database name), and ${srcTableName} (source table name).</description></item>
            /// <item><description>variables: the generation rules for each variable in the rename transformation rule expression. The default value of a parameter is the original value of the corresponding meaning at the source. You can define a set of string replacement rules to rewrite the original value as needed. variableName: the variable name, excluding the ${} characters. variableRules: the variable generation rule group. Replacements are performed in sequential execution. from: the original string. to: the replaced string.</description></item>
            /// </list>
            /// <para>Example of a rule to add a specified column and assign a value at the destination (AddColumn):
            /// {&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}</para>
            /// <list type="bullet">
            /// <item><description>If not specified, the default rule is that no columns are added and no replication is performed.</description></item>
            /// <item><description>columnName: the name of the appended column.</description></item>
            /// <item><description>columnValueType: the value type of the appended column. Valid values: Constant (constant) and Variable (variable).</description></item>
            /// <item><description>columnValue: the value of the appended column. When valueType is Constant, value is a custom constant of the String type. When valueType is Variable, value is a built-in variable. Valid values for built-in variables include EXECUTE_TIME (execution time, Long type), DB_NAME_SRC (source database name, String type), DATASOURCE_NAME_SRC (source data source name, String type), TABLE_NAME_SRC (source table name, String type), DB_NAME_DEST (destination database name, String type), DATASOURCE_NAME_DEST (destination data source name, String type), TABLE_NAME_DEST (destination table name, String type), and DB_NAME_SRC_TRANSED (transformed database name, String type).</description></item>
            /// </list>
            /// <para>Example of specifying the primary key column names for the destination table (DefinePrimaryKey):
            /// {&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}</para>
            /// <list type="bullet">
            /// <item><description>If not specified, the source primary key columns are used by default.</description></item>
            /// <item><description>When the destination is an existing table: the data integration system does not modify the destination table schema. If the specified primary key columns are not in the column set of the destination, an error is reported when the task starts.</description></item>
            /// <item><description>When the destination is an automatically created table: the data integration system automatically creates the destination table schema, and the table schema includes the defined primary key columns. If the specified primary key columns are not in the column set of the destination, an error is reported when the task starts.</description></item>
            /// </list>
            /// <para>Example of a DML handling rule (HandleDml):
            /// {&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}</para>
            /// <list type="bullet">
            /// <item><description>If not specified, the default rule is Normal for Insert, Update, and Delete.</description></item>
            /// <item><description>dmlType: the DML operations type. Valid values: Insert (insert), Update (update), and Delete (delete).</description></item>
            /// <item><description>dmlAction: the DML handling policy. Valid values: Normal (normal handling), Ignore (ignore), Filter (conditional normal handling, used when dmlType is Update or Delete), and LogicalDelete (logical delete).</description></item>
            /// <item><description>filterCondition: the DML filter condition, used when dmlAction is Filter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;expression&quot;:&quot;${srcDatasoureName}_${srcDatabaseName}&quot;}</para>
            /// </summary>
            [NameInMap("RuleExpression")]
            [Validation(Required=false)]
            public string RuleExpression { get; set; }

            /// <summary>
            /// <para>The name of the rule. The rule name must be unique when the action type and the target type of the action are the same.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rename_rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The target type of the action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Table: table</description></item>
            /// <item><description>Schema: schema</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Table</para>
            /// </summary>
            [NameInMap("RuleTargetType")]
            [Validation(Required=false)]
            public string RuleTargetType { get; set; }

        }

    }

}
