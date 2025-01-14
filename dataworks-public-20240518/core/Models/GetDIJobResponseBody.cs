// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDIJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public GetDIJobResponseBodyPagingInfo PagingInfo { get; set; }
        public class GetDIJobResponseBodyPagingInfo : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This parameter is deprecated. Use the Id parameter instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32601</para>
            /// </summary>
            [NameInMap("DIJobId")]
            [Validation(Required=false)]
            [Obsolete]
            public string DIJobId { get; set; }

            /// <summary>
            /// <para>The description of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The properties of the destination.</para>
            /// </summary>
            [NameInMap("DestinationDataSourceSettings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyPagingInfoDestinationDataSourceSettings> DestinationDataSourceSettings { get; set; }
            public class GetDIJobResponseBodyPagingInfoDestinationDataSourceSettings : TeaModel {
                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dw_mysql</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

            }

            /// <summary>
            /// <para>The destination type. The value Hologres is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hologres</para>
            /// </summary>
            [NameInMap("DestinationDataSourceType")]
            [Validation(Required=false)]
            public string DestinationDataSourceType { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32601</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imp_ods_dms_det_dealer_info_df</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The runtime settings.</para>
            /// </summary>
            [NameInMap("JobSettings")]
            [Validation(Required=false)]
            public GetDIJobResponseBodyPagingInfoJobSettings JobSettings { get; set; }
            public class GetDIJobResponseBodyPagingInfoJobSettings : TeaModel {
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
                /// <para>The data type mappings between source fields and destination fields.</para>
                /// </summary>
                [NameInMap("ColumnDataTypeSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsColumnDataTypeSettings : TeaModel {
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
                public GetDIJobResponseBodyPagingInfoJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsCycleScheduleSettings : TeaModel {
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
                /// <para>The DDL operation types. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RenameColumn</description></item>
                /// <item><description>ModifyColumn</description></item>
                /// <item><description>CreateTable</description></item>
                /// <item><description>TruncateTable</description></item>
                /// <item><description>DropTable</description></item>
                /// <item><description>DropColumn</description></item>
                /// <item><description>AddColumn</description></item>
                /// </list>
                /// </summary>
                [NameInMap("DdlHandlingSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsDdlHandlingSettings : TeaModel {
                    /// <summary>
                    /// <para>The processing policy for a specific type of DDL message. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Ignore: ignores a DDL message.</description></item>
                    /// <item><description>Critical: reports an error for a DDL message.</description></item>
                    /// <item><description>Normal: normally processes a DDL message.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ignore</para>
                    /// </summary>
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>The DDL operation type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>RenameColumn</description></item>
                    /// <item><description>ModifyColumn</description></item>
                    /// <item><description>CreateTable</description></item>
                    /// <item><description>TruncateTable</description></item>
                    /// <item><description>DropTable</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CreateTable</para>
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
                public List<GetDIJobResponseBodyPagingInfoJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsRuntimeSettings : TeaModel {
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
            /// <para>Running</para>
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
            /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
            /// <para>This parameter indicates the DataWorks workspace to which the API operation is applied.</para>
            /// 
            /// <b>Example:</b>
            /// <para>98330</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The resource settings.</para>
            /// </summary>
            [NameInMap("ResourceSettings")]
            [Validation(Required=false)]
            public GetDIJobResponseBodyPagingInfoResourceSettings ResourceSettings { get; set; }
            public class GetDIJobResponseBodyPagingInfoResourceSettings : TeaModel {
                /// <summary>
                /// <para>The resource used for batch synchronization.</para>
                /// </summary>
                [NameInMap("OfflineResourceSettings")]
                [Validation(Required=false)]
                public GetDIJobResponseBodyPagingInfoResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsOfflineResourceSettings : TeaModel {
                    /// <summary>
                    /// <para>The number of compute units (CUs) in the resource group for scheduling that are used for batch synchronization.</para>
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
                    /// <para>S_res_group_7708_1667792816832</para>
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
                public GetDIJobResponseBodyPagingInfoResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsRealtimeResourceSettings : TeaModel {
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
                    /// <para>S_res_group_235454102432001_1579085295030</para>
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
                public GetDIJobResponseBodyPagingInfoResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsScheduleResourceSettings : TeaModel {
                    /// <summary>
                    /// <para>The number of CUs in the resource group for Data Integration that are used for scheduling.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RequestedCu")]
                    [Validation(Required=false)]
                    public double? RequestedCu { get; set; }

                    /// <summary>
                    /// <para>The identifier of the resource group for scheduling used by the synchronization task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S_res_group_235454102432001_1718359176885</para>
                    /// </summary>
                    [NameInMap("ResourceGroupIdentifier")]
                    [Validation(Required=false)]
                    public string ResourceGroupIdentifier { get; set; }

                }

            }

            /// <summary>
            /// <para>The settings of the source. Only a single source is supported.</para>
            /// </summary>
            [NameInMap("SourceDataSourceSettings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyPagingInfoSourceDataSourceSettings> SourceDataSourceSettings { get; set; }
            public class GetDIJobResponseBodyPagingInfoSourceDataSourceSettings : TeaModel {
                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dw_mysql</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

                /// <summary>
                /// <para>The properties of the data source.</para>
                /// </summary>
                [NameInMap("DataSourceProperties")]
                [Validation(Required=false)]
                public GetDIJobResponseBodyPagingInfoSourceDataSourceSettingsDataSourceProperties DataSourceProperties { get; set; }
                public class GetDIJobResponseBodyPagingInfoSourceDataSourceSettingsDataSourceProperties : TeaModel {
                    /// <summary>
                    /// <para>The encoding format of the database.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UTF-8</para>
                    /// </summary>
                    [NameInMap("Encoding")]
                    [Validation(Required=false)]
                    public string Encoding { get; set; }

                    /// <summary>
                    /// <para>The time zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>GMT+8</para>
                    /// </summary>
                    [NameInMap("Timezone")]
                    [Validation(Required=false)]
                    public string Timezone { get; set; }

                }

            }

            /// <summary>
            /// <para>The source type. The value MySQL is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mysql</para>
            /// </summary>
            [NameInMap("SourceDataSourceType")]
            [Validation(Required=false)]
            public string SourceDataSourceType { get; set; }

            /// <summary>
            /// <para>The list of mappings between rules used to select synchronization objects in the source and transformation rules applied to the selected synchronization objects. Each entry in the list displays a mapping between a rule used to select synchronization objects and a transformation rule applied to the selected synchronization objects.</para>
            /// </summary>
            [NameInMap("TableMappings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyPagingInfoTableMappings> TableMappings { get; set; }
            public class GetDIJobResponseBodyPagingInfoTableMappings : TeaModel {
                /// <summary>
                /// <para>The list of rules used to select synchronization objects in the source. The objects can be databases or tables.</para>
                /// </summary>
                [NameInMap("SourceObjectSelectionRules")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
                public class GetDIJobResponseBodyPagingInfoTableMappingsSourceObjectSelectionRules : TeaModel {
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
                /// <para>The list of transformation rules that are applied to the synchronization objects selected from the source. Each entry in the list defines a transformation rule.</para>
                /// </summary>
                [NameInMap("TransformationRules")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoTableMappingsTransformationRules> TransformationRules { get; set; }
                public class GetDIJobResponseBodyPagingInfoTableMappingsTransformationRules : TeaModel {
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
                    /// <para>AddColumn</para>
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
            public List<GetDIJobResponseBodyPagingInfoTransformationRules> TransformationRules { get; set; }
            public class GetDIJobResponseBodyPagingInfoTransformationRules : TeaModel {
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
                /// <para>Example of a renaming rule: {&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot;,&quot;variables&quot;:[{&quot;variableName&quot;:&quot;srcDatabaseName&quot;,&quot;variableRules&quot;:[{&quot;from&quot;:&quot;fromdb&quot;,&quot;to&quot;:&quot;todb&quot;}]}]}.</para>
                /// <para>expression: the expression of the renaming rule. The expression may contain the following variables: ${srcDatasourceName}, ${srcDatabaseName}, and ${srcTableName}. ${srcDatasourceName} indicates the name of the source. ${srcDatabaseName} indicates the name of a source database. ${srcTableName} indicates the name of a source table. variables: the generation rule for a variable used in the expression of the renaming rule. The default value of the specified variable is the original value of the object indicated by the variable. You can define a group of string replacement rules to change the original values based on your business requirements. variableName: the name of the variable. The variable name is not enclosed in ${}. variableRules: the string replacement rules for variables. The system runs the string replacement rules in sequence. from indicates the original string. to indicates the new string. Example of a rule used to add a specific field to the destination and assign a value to the field: {&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}.</para>
                /// <para>If no rule of this type is configured, no fields are added to the destination and no values are assigned by default. columnName: the name of the field that is added. columnValueType: the value type of the field. Valid values: Constant and Variable. columnValue: the value of the field. If the value of the columnValueType parameter is Constant, the value of the columnValue parameter is a constant of the STRING data type. If the value of the columnValueType parameter is Variable, the value of the columnValue parameter is a built-in variable. The following built-in variables are supported: EXECUTE_TIME (LONG data type), DB_NAME_SRC (STRING data type), DATASOURCE_NAME_SRC (STRING data type), TABLE_NAME_SRC (STRING data type), DB_NAME_DEST (STRING data type), DATASOURCE_NAME_DEST (STRING data type), TABLE_NAME_DEST (STRING data type), and DB_NAME_SRC_TRANSED (STRING data type). EXECUTE_TIME indicates the execution time. DB_NAME_SRC indicates the name of a source database. DATASOURCE_NAME_SRC indicates the name of the source. TABLE_NAME_SRC indicates the name of a source table. DB_NAME_DEST indicates the name of a destination database. DATASOURCE_NAME_DEST indicates the name of the destination. TABLE_NAME_DEST indicates the name of a destination table. DB_NAME_SRC_TRANSED indicates the database name obtained after a transformation. Example of a rule used to specify primary key fields for a destination table: {&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}.</para>
                /// <para>If no rule of this type is configured, the primary key fields in the mapped source table are used for the destination table by default. If the destination table is an existing table, Data Integration does not modify the schema of the destination table. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run. If the destination table is automatically created by the system, Data Integration automatically creates the schema of the destination table. The schema contains the primary key fields that you specify. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run. Example of a rule used to process DML messages: {&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}.</para>
                /// <para>If no rule of this type is configured, the default processing policy for messages generated for insert, update, and delete operations is Normal. dmlType: the DML operation. Valid values: Insert, Update, and Delete. dmlAction: the processing policy for DML messages. Valid values: Normal, Ignore, Filter, and LogicalDelete. Filter indicates conditional processing. The value Filter is returned for the dmlAction parameter only when the value of the dmlType parameter is Update or Delete. filterCondition: the condition used to filter DML messages. This parameter is returned only when the value of the dmlAction parameter is Filter.</para>
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

        }

        /// <summary>
        /// <para>The request ID. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C99E2BE6-9DEA-5C2E-8F51-1DDCFEADE490</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
