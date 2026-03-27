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
        /// <para>The task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the synchronization task.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FileSpec")]
        [Validation(Required=false)]
        public string FileSpec { get; set; }

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
        /// <para>The task-level settings, including DDL handling policies, column data type mapping between source and destination, and runtime parameters.</para>
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public UpdateDIJobRequestJobSettings JobSettings { get; set; }
        public class UpdateDIJobRequestJobSettings : TeaModel {
            /// <summary>
            /// <para>The channel-specific settings. You can configure special settings for specific channels. Currently supported: Holo2Holo (Hologres to Hologres) and Holo2Kafka (Hologres to Kafka).</para>
            /// <ol>
            /// <item><description>Holo2Kafka</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;destinationChannelSettings&quot;:{&quot;kafkaClientProperties&quot;:[{&quot;key&quot;:&quot;linger.ms&quot;,&quot;value&quot;:&quot;100&quot;}],&quot;keyColumns&quot;:[&quot;col3&quot;],&quot;writeMode&quot;:&quot;canal&quot;}} kafkaClientProperties: Kafka producer parameters used when writing to Kafka.</description></item>
            /// <item><description>keyColumns: The columns to write to Kafka.</description></item>
            /// <item><description>writeMode: The Kafka write format. Valid values: json and canal.</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Holo2Holo</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;destinationChannelSettings&quot;:{&quot;conflictMode&quot;:&quot;replace&quot;,&quot;dynamicColumnAction&quot;:&quot;replay&quot;,&quot;writeMode&quot;:&quot;replay&quot;}}</description></item>
            /// <item><description>conflictMode: The conflict handling policy when writing to Hologres. Valid values: replace (overwrite) and ignore.</description></item>
            /// <item><description>writeMode: The write mode for Hologres. Valid values: replay and insert.</description></item>
            /// <item><description>dynamicColumnAction: The dynamic column handling mode when writing to Hologres. Valid values: replay, insert, and ignore.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;structInfo&quot;:&quot;MANAGED&quot;,&quot;storageType&quot;:&quot;TEXTFILE&quot;,&quot;writeMode&quot;:&quot;APPEND&quot;,&quot;partitionColumns&quot;:[{&quot;columnName&quot;:&quot;pt&quot;,&quot;columnType&quot;:&quot;STRING&quot;,&quot;comment&quot;:&quot;&quot;}],&quot;fieldDelimiter&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            /// <summary>
            /// <para>The array of column type mappings.</para>
            /// <remarks>
            /// <para> [&quot;ColumnDataTypeSettings&quot;:[ { &quot;SourceDataType&quot;:&quot;Bigint&quot;, &quot;DestinationDataType&quot;:&quot;Text&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                /// <summary>
                /// <para>The destination type, such as bigint, boolean, string, text, datetime, timestamp, decimal, or binary. Different data sources may have different types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                /// <summary>
                /// <para>The source type, such as bigint, boolean, string, text, datetime, timestamp, decimal, or binary. Different data sources may have different types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public string SourceDataType { get; set; }

            }

            /// <summary>
            /// <para>The scheduled task settings.</para>
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
            /// <para>The array of DDL handling settings.</para>
            /// <remarks>
            /// <para> [&quot;DDLHandlingSettings&quot;:[ { &quot;Type&quot;:&quot;Insert&quot;, &quot;Action&quot;:&quot;Normal&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                /// <summary>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Ignore</description></item>
                /// <item><description>Critical: Fail the task</description></item>
                /// <item><description>Normal</description></item>
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
                /// <para>The setting name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>src.offline.datasource.max.connection: Specifies the maximum number of connections that are allowed for reading data from the source of a batch synchronization task.</description></item>
                /// <item><description>dst.offline.truncate: Specifies whether to clear the destination table before data writing.</description></item>
                /// <item><description>runtime.offline.speed.limit.enable: Specifies whether throttling is enabled for a batch synchronization task.</description></item>
                /// <item><description>runtime.offline.concurrent: Specifies the maximum number of parallel threads that are allowed for a batch synchronization task.</description></item>
                /// <item><description>runtime.enable.auto.create.schema: Specifies whether schemas are automatically created in the destination of a synchronization task.</description></item>
                /// <item><description>runtime.realtime.concurrent: Specifies the maximum number of parallel threads that are allowed for a real-time synchronization task.</description></item>
                /// <item><description>runtime.realtime.failover.minute.dataxcdc: Specifies the maximum waiting duration before a synchronization task retries the next restart if the previous restart fails after failover occurs. Unit: minutes.</description></item>
                /// <item><description>runtime.realtime.failover.times.dataxcdc: Specifies the maximum number of failures that are allowed for restarting a synchronization task after failovers occur.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>runtime.offline.concurrent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The setting value.</para>
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
        /// <para>The task owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can call the <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> operation to obtain the ID.</para>
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
        public UpdateDIJobRequestResourceSettings ResourceSettings { get; set; }
        public class UpdateDIJobRequestResourceSettings : TeaModel {
            /// <summary>
            /// <para>The batch synchronization resources.</para>
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                /// <summary>
                /// <para>The CUs of the resource group for Data Integration used for batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the resource group for Data Integration that are used for batch synchronization.</para>
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
            public UpdateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                /// <summary>
                /// <para>The CUs of the resource group for Data Integration that are used for real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the resource group for Data Integration that are used for real-time synchronization.</para>
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
                /// <para>The CUs of the scheduling resource group for batch synchronization tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the scheduling resource group used for batch synchronization tasks.</para>
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
        /// <para>The list of synchronization object transformation mappings. Each element describes a set of source object selection rules and the transformation rules applied to those objects.</para>
        /// <remarks>
        /// <para> [ { &quot;SourceObjectSelectionRules&quot;:[ { &quot;ObjectType&quot;:&quot;Database&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;biz_db&quot; }, { &quot;ObjectType&quot;:&quot;Schema&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;s1&quot; }, { &quot;ObjectType&quot;:&quot;Table&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;table1&quot; } ], &quot;TransformationRuleNames&quot;:[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot; } ] } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTableMappings> TableMappings { get; set; }
        public class UpdateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// <para>Each rule can select different object types from the source, such as source databases and source tables.</para>
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class UpdateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
                /// <summary>
                /// <para>Valid values: Include and Exclude.</para>
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
                /// <item><description>Schema</description></item>
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
            /// <para>The transformation rules applied to source objects.</para>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class UpdateDIJobRequestTableMappingsTransformationRules : TeaModel {
                /// <summary>
                /// <para>Valid values:</para>
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
                /// <para>The rule name. The rule name must be unique for a given combination of action type and target type. The name cannot exceed 50 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rename_rule_1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Table</description></item>
                /// <item><description>Schema</description></item>
                /// <item><description>Database</description></item>
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
        /// <para>The list of synchronization object transformation rule definitions.</para>
        /// <remarks>
        /// <para> [ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot;, &quot;RuleExpression&quot;:&quot;{&quot;expression&quot;:&quot;${srcDatasoureName}_${srcDatabaseName}&quot;}&quot; } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class UpdateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DefinePrimaryKey</description></item>
            /// <item><description>Rename</description></item>
            /// <item><description>AddColumn</description></item>
            /// <item><description>HandleDml</description></item>
            /// <item><description>DefineIncrementalCondition</description></item>
            /// <item><description>DefineCycleScheduleSettings</description></item>
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
            /// <para>The rule expression in JSON string format.</para>
            /// <ol>
            /// <item><description>Rename rule</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot; }</description></item>
            /// <item><description>expression: The rename transformation expression. Supported variables include: ${srcDatasourceName} (source data source name), ${srcDatabaseName} (source database name), and ${srcTableName} (source table name).</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>AddColumn rule</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}</description></item>
            /// <item><description>If not specified, the default behavior is to not add columns.</description></item>
            /// <item><description>columnName: The name of the column to add.</description></item>
            /// <item><description>columnValueType: The value type of the column to add. Valid values: Constant and Variable.</description></item>
            /// <item><description>columnValue: The value of the column to add. When columnValueType is set to Constant, the value is a custom constant of the string type. When columnValueType is set to Variable, the value is a built-in variable. Built-in variables include: EXECUTE_TIME (execution time, long type), DB_NAME_SRC (source database name, string type), DATASOURCE_NAME_SRC (source data source name, string type), TABLE_NAME_SRC (source table name, string type), DB_NAME_DEST (destination database name, string type), DATASOURCE_NAME_DEST (destination data source name, string type), TABLE_NAME_DEST (destination table name, string type), and DB_NAME_SRC_TRANSED (transformed source database name, string type).</description></item>
            /// </list>
            /// <ol start="3">
            /// <item><description>DefinePrimaryKey</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}</description></item>
            /// <item><description>If not specified, the source primary key columns are used by default.</description></item>
            /// <item><description>When the destination table already exists: Data Integration does not modify the destination table structure. If the specified primary key columns are not in the destination table, the task fails to start.</description></item>
            /// <item><description>When the destination table is auto-created: Data Integration automatically creates the destination table structure with the defined primary key columns. If the specified primary key columns are not in the destination table, the task fails to start.</description></item>
            /// </list>
            /// <ol start="4">
            /// <item><description>HandleDml rule</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example of a rule used to process DML messages: {&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}.</description></item>
            /// <item><description>If not specified, the default rule is Normal for Insert, Update, and Delete.</description></item>
            /// <item><description>dmlType: The DML operation type. Valid values: Insert, Update, Delete.</description></item>
            /// <item><description>dmlAction: The DML handling policy. Valid values: Normal, Ignore, Filter (conditional processing, used when dmlType is Update or Delete), and LogicalDelete.</description></item>
            /// <item><description>filterCondition: The DML filter condition. This parameter is used when dmlAction is set to Filter.</description></item>
            /// </list>
            /// <ol start="5">
            /// <item><description>DefineIncrementalCondition</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;where&quot;:&quot;id &gt; 0&quot;}</description></item>
            /// <item><description>Specifies the incremental filter condition.</description></item>
            /// </list>
            /// <ol start="6">
            /// <item><description>DefineCycleScheduleSettings</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;cronExpress&quot;:&quot; \* \* \* \* \* \*&quot;, &quot;cycleType&quot;:&quot;1&quot;}</description></item>
            /// <item><description>Specifies the scheduled task parameters.</description></item>
            /// </list>
            /// <ol start="7">
            /// <item><description>DefinePartitionKey</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[&quot;id&quot;]}</description></item>
            /// <item><description>Specifies the partition key.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;expression&quot;:&quot;${srcDatasoureName}_${srcDatabaseName}&quot;}</para>
            /// </summary>
            [NameInMap("RuleExpression")]
            [Validation(Required=false)]
            public string RuleExpression { get; set; }

            /// <summary>
            /// <para>The rule name. When the action type and target type are the same, the rule name must be unique. The name cannot exceed 50 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rename_rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The target type for the action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Table</description></item>
            /// <item><description>Schema</description></item>
            /// <item><description>Database</description></item>
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
