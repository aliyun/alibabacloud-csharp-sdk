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

        /// <summary>
        /// <para>The description of the synchronization task.</para>
        /// </summary>
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

        /// <summary>
        /// <para>The settings for the dimension of the synchronization task. The settings include processing policies for DDL messages, policies for data type mappings between source fields and destination fields, and runtime parameters of the synchronization task.</para>
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public UpdateDIJobRequestJobSettings JobSettings { get; set; }
        public class UpdateDIJobRequestJobSettings : TeaModel {
            /// <summary>
            /// <para>The channel control settings for the synchronization task. The value of this parameter must be a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;structInfo&quot;:&quot;MANAGED&quot;,&quot;storageType&quot;:&quot;TEXTFILE&quot;,&quot;writeMode&quot;:&quot;APPEND&quot;,&quot;partitionColumns&quot;:[{&quot;columnName&quot;:&quot;pt&quot;,&quot;columnType&quot;:&quot;STRING&quot;,&quot;comment&quot;:&quot;&quot;}],&quot;fieldDelimiter&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            /// <summary>
            /// <para>The data type mappings between source fields and destination fields.</para>
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                /// <summary>
                /// <para>The data type of the destination field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                /// <summary>
                /// <para>The data type of the source field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public string SourceDataType { get; set; }

            }

            /// <summary>
            /// <para>The settings for periodic scheduling.</para>
            /// </summary>
            [NameInMap("CycleScheduleSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsCycleScheduleSettings : TeaModel {
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
            /// <para>The processing settings for DDL messages.</para>
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                /// <summary>
                /// <para>The processing policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Ignore: ignores a DDL message.</description></item>
                /// <item><description>Critical: reports an error for a DDL message.</description></item>
                /// <item><description>Normal: normally processes a DDL message.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Critical</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The type of the DDL operation. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RenameColumn</description></item>
                /// <item><description>ModifyColumn</description></item>
                /// <item><description>CreateTable</description></item>
                /// <item><description>TruncateTable</description></item>
                /// <item><description>DropTable</description></item>
                /// <item><description>DropColumn</description></item>
                /// <item><description>AddColumn</description></item>
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
            /// <para>The runtime settings.</para>
            /// </summary>
            [NameInMap("RuntimeSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsRuntimeSettings : TeaModel {
                /// <summary>
                /// <para>The name of the configuration item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>runtime.offline.speed.limit.mb: indicates the maximum transmission rate that is allowed for a batch synchronization task. This configuration item takes effect only when runtime.offline.speed.limit.enable is set to true.</description></item>
                /// <item><description>runtime.offline.speed.limit.enable: indicates whether throttling is enabled for a batch synchronization task.</description></item>
                /// <item><description>dst.offline.connection.max: indicates the maximum number of connections that are allowed for writing data to the destination of a batch synchronization task.</description></item>
                /// <item><description>runtime.offline.concurrent: indicates the maximum number of parallel threads that are allowed for a batch synchronization task.</description></item>
                /// <item><description>dst.realtime.connection.max: indicates the maximum number of connections that are allowed for writing data to the destination of a real-time synchronization task.</description></item>
                /// <item><description>runtime.enable.auto.create.schema: indicates whether schemas are automatically created in the destination of a synchronization task.</description></item>
                /// <item><description>src.offline.datasource.max.connection: indicates the maximum number of connections that are allowed for reading data from the source of a batch synchronization task.</description></item>
                /// <item><description>runtime.realtime.concurrent: indicates the maximum number of parallel threads that are allowed for a real-time synchronization task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>runtime.offline.concurrent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the configuration item.</para>
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
        public UpdateDIJobRequestResourceSettings ResourceSettings { get; set; }
        public class UpdateDIJobRequestResourceSettings : TeaModel {
            /// <summary>
            /// <para>The resource used for batch synchronization.</para>
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of compute units (CUs) in the resource group for Data Integration that are used for batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The identifier of the resource group for Data Integration used for batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The resource used for real-time synchronization.</para>
            /// </summary>
            [NameInMap("RealtimeResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs in the resource group for Data Integration that are used for real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The identifier of the resource group for Data Integration used for real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The resource used for scheduling.</para>
            /// </summary>
            [NameInMap("ScheduleResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsScheduleResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs in the resource group for scheduling that are used for batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The identifier of the resource group for scheduling used for batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_235454102432001_1721021993437</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of mappings between rules used to select synchronization objects in the source and transformation rules applied to the selected synchronization objects. Each entry in the list displays a mapping between a rule used to select synchronization objects and a transformation rule applied to the selected synchronization objects.</para>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTableMappings> TableMappings { get; set; }
        public class UpdateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// <para>The list of rules used to select synchronization objects in the source. The objects can be databases or tables.</para>
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class UpdateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
                /// <summary>
                /// <para>The operation that is performed to select objects. Valid values: Include and Exclude.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Include</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

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
                /// <para>The expression type. Valid values: Exact and Regex.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Exact</para>
                /// </summary>
                [NameInMap("ExpressionType")]
                [Validation(Required=false)]
                public string ExpressionType { get; set; }

                /// <summary>
                /// <para>The object type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Table</description></item>
                /// <item><description>Database</description></item>
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
            /// <para>The list of transformation rules that you want to apply to the synchronization objects selected from the source. Each entry in the list defines a transformation rule.</para>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class UpdateDIJobRequestTableMappingsTransformationRules : TeaModel {
                /// <summary>
                /// <para>The action type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DefinePrimaryKey</description></item>
                /// <item><description>Rename</description></item>
                /// <item><description>AddColumn</description></item>
                /// <item><description>HandleDml</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Rename</para>
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// <para>The name of the rule. If the values of the RuleActionType parameter and the RuleTargetType parameter are the same for multiple transformation rules, you must make sure that the transformation rule names are unique.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rename_rule_1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The type of the object on which you want to perform the action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Table</description></item>
                /// <item><description>Schema</description></item>
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
        /// <para>The list of transformation rules for objects involved in the synchronization task. Each entry in the list defines a transformation rule.</para>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class UpdateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// <para>The action type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DefinePrimaryKey</description></item>
            /// <item><description>Rename</description></item>
            /// <item><description>AddColumn</description></item>
            /// <item><description>HandleDml</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Rename</para>
            /// </summary>
            [NameInMap("RuleActionType")]
            [Validation(Required=false)]
            public string RuleActionType { get; set; }

            /// <summary>
            /// <para>The expression of the rule. The expression must be a JSON string.</para>
            /// <para>Example of a renaming rule: {&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot;,&quot;variables&quot;:[{&quot;variableName&quot;:&quot;srcDatabaseName&quot;,&quot;variableRules&quot;:[{&quot;from&quot;:&quot;fromdb&quot;,&quot;to&quot;:&quot;todb&quot;}]}]}.</para>
            /// <para>expression: the expression of the renaming rule. The expression may contain the following variables: ${srcDatasourceName}, ${srcDatabaseName}, and ${srcTableName}. ${srcDatasourceName} indicates the name of the source. ${srcDatabaseName} indicates the name of a source database. ${srcTableName} indicates the name of a source table. variables: the generation rule for a variable used in the expression of the renaming rule. The default value of the specified variable is the original value of the object indicated by the variable. You can define a group of string replacement rules to change the original values based on your business requirements. variableName: the name of the variable. The variable name cannot be enclosed in ${}. variableRules: the string replacement rules for variables. The system runs the string replacement rules in sequence. from specifies the original string. to specifies the new string. Example of a rule used to add a specific field to the destination and assign a value to the field: {&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}.</para>
            /// <para>If you do not configure such a rule, no fields are added to the destination and no values are assigned by default. columnName: the name of the field that you want to add. columnValueType: the value type of the field. Valid values: Constant and Variable. columnValue: the value of the field. If you set the valueType parameter to Constant, set the columnValue parameter to a custom constant of the STRING type. If you set the valueType parameter to Variable, set the columnValue to a built-in variable. The following built-in variables are supported: EXECUTE_TIME (LONG data type), DB_NAME_SRC (STRING data type), DATASOURCE_NAME_SRC (STRING data type), TABLE_NAME_SRC (STRING data type), DB_NAME_DEST (STRING data type), DATASOURCE_NAME_DEST (STRING data type), TABLE_NAME_DEST (STRING data type), and DB_NAME_SRC_TRANSED (STRING data type). EXECUTE_TIME specifies the execution time. DB_NAME_SRC indicates the name of a source database. DATASOURCE_NAME_SRC specifies the name of the source. TABLE_NAME_SRC specifies the name of a source table. DB_NAME_DEST specifies the name of a destination database. DATASOURCE_NAME_DEST specifies the name of the destination. TABLE_NAME_DEST specifies the name of a destination table. DB_NAME_SRC_TRANSED specifies the database name obtained after a transformation. Example of a rule used to specify primary key fields for a destination table: {&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}.</para>
            /// <para>If you do not configure such a rule, the primary key fields in the mapped source table are used for the destination table by default. If the destination table is an existing table, Data Integration does not modify the schema of the destination table. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run. If the destination table is automatically created by the system, Data Integration automatically creates the schema of the destination table. The schema contains the primary key fields that you specify. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run. Example of a rule used to process DML messages: {&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}.</para>
            /// <para>If you do not configure such a rule, the default processing policy for messages generated for insert, update, and delete operations is Normal. dmlType: the DML operation. Valid values: Insert, Update, and Delete. dmlAction: the processing policy for DML messages. Valid values: Normal, Ignore, Filter, and LogicalDelete. Filter indicates conditional processing. You can set the dmlAction parameter to Filter only when the dmlType parameter is set to Update or Delete. filterCondition: the condition used to filter DML messages. This parameter is required only when the dmlAction parameter is set to Filter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;expression&quot;:&quot;${srcDatasoureName}_${srcDatabaseName}&quot;}</para>
            /// </summary>
            [NameInMap("RuleExpression")]
            [Validation(Required=false)]
            public string RuleExpression { get; set; }

            /// <summary>
            /// <para>The name of the rule. If the values of the RuleActionType parameter and the RuleTargetType parameter are the same for multiple transformation rules, you must make sure that the transformation rule names are unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rename_rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The type of the object on which you want to perform the action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Table</description></item>
            /// <item><description>Schema</description></item>
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
