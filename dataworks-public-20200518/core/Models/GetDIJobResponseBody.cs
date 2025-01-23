// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDIJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the synchronization task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDIJobResponseBodyData Data { get; set; }
        public class GetDIJobResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp when the synchronization task was created. The timestamp is accurate to the second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1671516776</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who creates the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000001</para>
            /// </summary>
            [NameInMap("CreatedUid")]
            [Validation(Required=false)]
            public string CreatedUid { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11588</para>
            /// </summary>
            [NameInMap("DIJobId")]
            [Validation(Required=false)]
            public long? DIJobId { get; set; }

            /// <summary>
            /// <para>The description of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Synchronize mysql to hologres</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The settings of the destination. Only a single destination is supported.</para>
            /// </summary>
            [NameInMap("DestinationDataSourceSettings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyDataDestinationDataSourceSettings> DestinationDataSourceSettings { get; set; }
            public class GetDIJobResponseBodyDataDestinationDataSourceSettings : TeaModel {
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
            /// <para>The destination type. Valid values: Hologres and Hive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hologres</para>
            /// </summary>
            [NameInMap("DestinationDataSourceType")]
            [Validation(Required=false)]
            public string DestinationDataSourceType { get; set; }

            /// <summary>
            /// <para>The error message returned if the value of the JobStatus parameter is Failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error details xxx</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The name of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mysql_to_holo_sync_445</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The settings for the dimension of the synchronization task. The settings include processing policies for DDL messages, policies for data type mappings between source fields and destination fields, and runtime parameters of the synchronization task.</para>
            /// </summary>
            [NameInMap("JobSettings")]
            [Validation(Required=false)]
            public GetDIJobResponseBodyDataJobSettings JobSettings { get; set; }
            public class GetDIJobResponseBodyDataJobSettings : TeaModel {
                /// <summary>
                /// <para>The channel control settings for the synchronization task. The value of this parameter is a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;structInfo&quot;:&quot;MANAGED&quot;,&quot;storageType&quot;:&quot;TEXTFILE&quot;,&quot;writeMode&quot;:&quot;APPEND&quot;,&quot;partitionColumns&quot;:[{&quot;columnName&quot;:&quot;pt&quot;,&quot;columnType&quot;:&quot;STRING&quot;,&quot;comment&quot;:&quot;&quot;}],&quot;fieldDelimiter&quot;:&quot;&quot;}</para>
                /// </summary>
                [NameInMap("ChannelSettings")]
                [Validation(Required=false)]
                public string ChannelSettings { get; set; }

                /// <summary>
                /// <para>The settings for data type mappings between source fields and destination fields. The value of this parameter is an array.</para>
                /// </summary>
                [NameInMap("ColumnDataTypeSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyDataJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
                public class GetDIJobResponseBodyDataJobSettingsColumnDataTypeSettings : TeaModel {
                    /// <summary>
                    /// <para>The data type of a destination field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text</para>
                    /// </summary>
                    [NameInMap("DestinationDataType")]
                    [Validation(Required=false)]
                    public string DestinationDataType { get; set; }

                    /// <summary>
                    /// <para>The data type of a source field.</para>
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
                public GetDIJobResponseBodyDataJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
                public class GetDIJobResponseBodyDataJobSettingsCycleScheduleSettings : TeaModel {
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
                /// <para>The settings for processing DDL messages. The value of this parameter is an array.</para>
                /// </summary>
                [NameInMap("DdlHandlingSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyDataJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
                public class GetDIJobResponseBodyDataJobSettingsDdlHandlingSettings : TeaModel {
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
                /// <para>The runtime settings. The value of this parameter is an array.</para>
                /// </summary>
                [NameInMap("RuntimeSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyDataJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
                public class GetDIJobResponseBodyDataJobSettingsRuntimeSettings : TeaModel {
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
            /// <para>The status of the synchronization task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Finished</description></item>
            /// <item><description>Initialized</description></item>
            /// <item><description>Stopped</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Stopping</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Finished</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The synchronization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FullAndRealtimeIncremental: one-time full synchronization and real-time incremental synchronization</description></item>
            /// <item><description>RealtimeIncremental: real-time incremental synchronization</description></item>
            /// <item><description>Full: full synchronization</description></item>
            /// <item><description>OfflineIncremental: batch incremental synchronization</description></item>
            /// <item><description>FullAndOfflineIncremental: one-time full synchronization and batch incremental synchronization</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FullAndRealtimeIncremental</para>
            /// </summary>
            [NameInMap("MigrationType")]
            [Validation(Required=false)]
            public string MigrationType { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The resource settings.</para>
            /// </summary>
            [NameInMap("ResourceSettings")]
            [Validation(Required=false)]
            public GetDIJobResponseBodyDataResourceSettings ResourceSettings { get; set; }
            public class GetDIJobResponseBodyDataResourceSettings : TeaModel {
                /// <summary>
                /// <para>The resource used for batch synchronization.</para>
                /// </summary>
                [NameInMap("OfflineResourceSettings")]
                [Validation(Required=false)]
                public GetDIJobResponseBodyDataResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
                public class GetDIJobResponseBodyDataResourceSettingsOfflineResourceSettings : TeaModel {
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
                public GetDIJobResponseBodyDataResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
                public class GetDIJobResponseBodyDataResourceSettingsRealtimeResourceSettings : TeaModel {
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
                /// <para>The number of compute units (CUs) in the resource group that are used for incremental and full synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public float? RequestedCu { get; set; }

            }

            /// <summary>
            /// <para>The information about the running of the synchronization task.</para>
            /// </summary>
            [NameInMap("RunStats")]
            [Validation(Required=false)]
            public Dictionary<string, string> RunStats { get; set; }

            /// <summary>
            /// <para>The settings of the source. Only a single source is supported.</para>
            /// </summary>
            [NameInMap("SourceDataSourceSettings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyDataSourceDataSourceSettings> SourceDataSourceSettings { get; set; }
            public class GetDIJobResponseBodyDataSourceDataSourceSettings : TeaModel {
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
            /// <para>The source type. The value MySQL is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("SourceDataSourceType")]
            [Validation(Required=false)]
            public string SourceDataSourceType { get; set; }

            /// <summary>
            /// <para>The timestamp when the synchronization task was last started. The timestamp is accurate to the second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673859999</para>
            /// </summary>
            [NameInMap("StartedTime")]
            [Validation(Required=false)]
            public long? StartedTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who last starts the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000001</para>
            /// </summary>
            [NameInMap("StartedUid")]
            [Validation(Required=false)]
            public string StartedUid { get; set; }

            /// <summary>
            /// <para>The list of mappings between rules used to select synchronization objects in the source and transformation rules applied to the selected synchronization objects. Each entry in the list displays a mapping between a rule used to select synchronization objects and a transformation rule applied to the selected synchronization objects.</para>
            /// </summary>
            [NameInMap("TableMappings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyDataTableMappings> TableMappings { get; set; }
            public class GetDIJobResponseBodyDataTableMappings : TeaModel {
                /// <summary>
                /// <para>The list of rules used to select synchronization objects in the source.</para>
                /// </summary>
                [NameInMap("SourceObjectSelectionRules")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyDataTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
                public class GetDIJobResponseBodyDataTableMappingsSourceObjectSelectionRules : TeaModel {
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
                /// <para>The list of transformation rules that are applied to the synchronization objects selected from the source.</para>
                /// </summary>
                [NameInMap("TransformationRules")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyDataTableMappingsTransformationRules> TransformationRules { get; set; }
                public class GetDIJobResponseBodyDataTableMappingsTransformationRules : TeaModel {
                    /// <summary>
                    /// <para>The action type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>DefinePrimaryKey</description></item>
                    /// <item><description>Rename</description></item>
                    /// <item><description>AddColumn</description></item>
                    /// <item><description>HandleDml</description></item>
                    /// <item><description>DefineIncrementalCondition</description></item>
                    /// <item><description>DefineCycleScheduleSettings</description></item>
                    /// <item><description>DefineRuntimeSettings</description></item>
                    /// <item><description>DefinePartitionKey</description></item>
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
                    /// <para>The type of the object on which the action is performed. Valid values:</para>
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
            /// <para>The list of transformation rules that are applied to the synchronization objects selected from the source. Each entry in the list defines a transformation rule.</para>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyDataTransformationRules> TransformationRules { get; set; }
            public class GetDIJobResponseBodyDataTransformationRules : TeaModel {
                /// <summary>
                /// <para>The action type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DefinePrimaryKey</description></item>
                /// <item><description>Rename</description></item>
                /// <item><description>AddColumn</description></item>
                /// <item><description>HandleDml</description></item>
                /// <item><description>DefineIncrementalCondition</description></item>
                /// <item><description>DefineCycleScheduleSettings</description></item>
                /// <item><description>DefineRuntimeSettings</description></item>
                /// <item><description>DefinePartitionKey</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Rename</para>
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// <para>The expression of the rule. The expression is a JSON string.</para>
                /// <list type="bullet">
                /// <item><description><para>Example of a renaming rule: <c>{&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot;,&quot;variables&quot;:[{&quot;variableName&quot;:&quot;srcDatabaseName&quot;,&quot;variableRules&quot;:[{&quot;from&quot;:&quot;fromdb&quot;,&quot;to&quot;:&quot;todb&quot;}\\]}\\]}</c>.</para>
                /// <list type="bullet">
                /// <item><description><para>expression: the expression of the renaming rule. The expression may contain the following variables:</para>
                /// <list type="bullet">
                /// <item><description>${srcDatasourceName}</description></item>
                /// <item><description>${srcDatabaseName}</description></item>
                /// <item><description>${srcTableName}</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>variables: the generation rule for a variable used in the expression of the renaming rule. The default value of the specified variable is the original value of the object indicated by the variable. A group of string replacement rules used to change the original values may be returned.</para>
                /// <list type="bullet">
                /// <item><description>variableName: the name of the variable. The variable name is not enclosed in ${}.</description></item>
                /// <item><description>variableRules: the string replacement rules for variables. The system runs the string replacement rules in sequence. from indicates the original string. to indicates the new string.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Example of a rule used to add a specific field to the destination and assign a value to the field: <c>{&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}\\]}</c>.</para>
                /// <para>If no rule of this type is configured, no fields are added to the destination and no values are assigned by default.</para>
                /// <list type="bullet">
                /// <item><description><para>columnName: the name of the field that is added.</para>
                /// </description></item>
                /// <item><description><para>columnValueType: the value type of the field. Valid values: Constant and Variable.</para>
                /// </description></item>
                /// <item><description><para>columnValue: the value of the field.</para>
                /// <list type="bullet">
                /// <item><description>If the value of the columnValueType parameter is Constant, the value of the columnValue parameter is a constant of the STRING data type.</description></item>
                /// <item><description>If the value of the columnValueType parameter is Variable, the value of the columnValue parameter is a built-in variable. The following built-in variables are supported: EXECUTE_TIME (LONG data type), DB_NAME_SRC (STRING data type), DATASOURCE_NAME_SRC (STRING data type), TABLE_NAME_SRC (STRING data type), DB_NAME_DEST (STRING data type), DATASOURCE_NAME_DEST (STRING data type), TABLE_NAME_DEST (STRING data type), and DB_NAME_SRC_TRANSED (STRING data type). EXECUTE_TIME indicates the execution time. DB_NAME_SRC indicates the name of a source database. DATASOURCE_NAME_SRC indicates the name of the source. TABLE_NAME_SRC indicates the name of a source table. DB_NAME_DEST indicates the name of a destination database. DATASOURCE_NAME_DEST indicates the name of the destination. TABLE_NAME_DEST indicates the name of a destination table. DB_NAME_SRC_TRANSED indicates the database name obtained after a transformation.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Example of a rule used to specify primary key fields for a destination table: <c>{&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;\\]}</c>.</para>
                /// <para>If no rule of this type is configured, the primary key fields in the mapped source table are used for the destination table by default.</para>
                /// <list type="bullet">
                /// <item><description>If the destination table is an existing table, Data Integration does not modify the schema of the destination table. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run.</description></item>
                /// <item><description>If the destination table is automatically created by the system, Data Integration automatically creates the schema of the destination table. The schema contains the primary key fields that you specify. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run.</description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>Example of a rule used to process DML messages: <c>{&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}\\]}</c>.</para>
                /// <para>If no rule of this type is configured, the default processing policy for messages generated for insert, update, and delete operations is Normal.</para>
                /// <list type="bullet">
                /// <item><description>dmlType: the DML operation. Valid values: Insert, Update, and Delete.</description></item>
                /// <item><description>dmlAction: the processing policy for DML messages. Valid values: Normal, Ignore, Filter, and LogicalDelete. Filter indicates conditional processing. The value Filter is returned for the dmlAction parameter only when the value of the dmlType parameter is Update or Delete.</description></item>
                /// <item><description>filterCondition: the condition used to filter DML messages. This parameter is returned only when the value of the dmlAction parameter is Filter.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
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
                /// <para>The type of the object on which the action is performed. Valid values:</para>
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

            /// <summary>
            /// <para>The timestamp when the synchronization task was last modified. The timestamp is accurate to the second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1673859985</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The ID of the user who last modifies the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000001</para>
            /// </summary>
            [NameInMap("UpdatedUid")]
            [Validation(Required=false)]
            public string UpdatedUid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
