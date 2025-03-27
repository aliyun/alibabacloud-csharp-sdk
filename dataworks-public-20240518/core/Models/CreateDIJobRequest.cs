// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDIJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The description of the synchronization task.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The settings of the destination. Only a single destination is supported.</para>
        /// <para>This parameter is required.</para>
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

        }

        /// <summary>
        /// <para>The destination type. Valid values: Hologres, OSS-HDFS, OSS, MaxCompute, LogHub, StarRocks, DataHub, AnalyticDB for MySQL, Kafka, and Hive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hologres</para>
        /// </summary>
        [NameInMap("DestinationDataSourceType")]
        [Validation(Required=false)]
        public string DestinationDataSourceType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated and is replaced by the Name parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_to_holo_sync_8772</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        [Obsolete]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The settings for the dimension of the synchronization task. The settings include processing policies for DDL messages, policies for data type mappings between source fields and destination fields, and runtime parameters of the synchronization task.</para>
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestJobSettings JobSettings { get; set; }
        public class CreateDIJobRequestJobSettings : TeaModel {
            /// <summary>
            /// <para>The channel control settings for the synchronization task. You can configure special channel control settings for the following synchronization links: data synchronization between Hologres data sources and data synchronization from Hologres to Kafka.</para>
            /// <ol>
            /// <item><description>Holo2Kafka</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;destinationChannelSettings&quot;:{&quot;kafkaClientProperties&quot;:[{&quot;key&quot;:&quot;linger.ms&quot;,&quot;value&quot;:&quot;100&quot;}],&quot;keyColumns&quot;:[&quot;col3&quot;],&quot;writeMode&quot;:&quot;canal&quot;}}</description></item>
            /// <item><description>kafkaClientProperties: the parameters related to a Kafka producer, which are used when you write data to a Kafka data source.</description></item>
            /// <item><description>keyColumns: the names of Kafka columns to which you want to write data.</description></item>
            /// <item><description>writeMode: the writing format of the Kafka data source. Valid values: json and canal.</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Holo2Holo</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;destinationChannelSettings&quot;:{&quot;conflictMode&quot;:&quot;replace&quot;,&quot;dynamicColumnAction&quot;:&quot;replay&quot;,&quot;writeMode&quot;:&quot;replay&quot;}}</description></item>
            /// <item><description>conflictMode: the policy used to handle a conflict that occurs during data writing to Hologres. Valid values: replace and ignore.</description></item>
            /// <item><description>writeMode: the mode in which you want to write data to Hologres. Valid values: replay and insert.</description></item>
            /// <item><description>dynamicColumnAction: the mode in which you want to write data to dynamic columns in a Hologres table. Valid values: replay, insert, and ignore.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;structInfo&quot;:&quot;MANAGED&quot;,&quot;storageType&quot;:&quot;TEXTFILE&quot;,&quot;writeMode&quot;:&quot;APPEND&quot;,&quot;partitionColumns&quot;:[{&quot;columnName&quot;:&quot;pt&quot;,&quot;columnType&quot;:&quot;STRING&quot;,&quot;comment&quot;:&quot;&quot;}],&quot;fieldDelimiter&quot;:&quot;&quot;}</para>
            /// </summary>
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            /// <summary>
            /// <para>The data type mappings between source fields and destination fields.</para>
            /// <remarks>
            /// <para> &quot;ColumnDataTypeSettings&quot;:[ { &quot;SourceDataType&quot;:&quot;Bigint&quot;, &quot;DestinationDataType&quot;:&quot;Text&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                /// <summary>
                /// <para>The data type of the destination field. Valid values: bigint, boolean, string, text, datetime, timestamp, decimal, and binary. Different types of data sources support different data types.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                /// <summary>
                /// <para>The data type of the source field. Valid values: Valid values: bigint, boolean, string, text, datetime, timestamp, decimal, and binary. Different types of data sources support different data types.</para>
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
            /// <para>The processing settings for DDL messages.</para>
            /// <remarks>
            /// <para> &quot;DDLHandlingSettings&quot;:[ { &quot;Type&quot;:&quot;Insert&quot;, &quot;Action&quot;:&quot;Normal&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class CreateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
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
            public List<CreateDIJobRequestJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsRuntimeSettings : TeaModel {
                /// <summary>
                /// <para>The name of the configuration item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>src.offline.datasource.max.connection: specifies the maximum number of connections that are allowed for reading data from the source of a batch synchronization task.</description></item>
                /// <item><description>dst.offline.truncate: specifies whether to clear the destination table before data writing.</description></item>
                /// <item><description>runtime.offline.speed.limit.enable: specifies whether throttling is enabled for a batch synchronization task.</description></item>
                /// <item><description>runtime.offline.concurrent: specifies the maximum number of parallel threads that are allowed for a batch synchronization task.</description></item>
                /// <item><description>runtime.enable.auto.create.schema: specifies whether schemas are automatically created in the destination of a synchronization task.</description></item>
                /// <item><description>runtime.realtime.concurrent: specifies the maximum number of parallel threads that are allowed for a real-time synchronization task.</description></item>
                /// <item><description>runtime.realtime.failover.minute.dataxcdc: specifies the maximum waiting duration before a synchronization task retries the next restart if the previous restart fails after failover occurs. Unit: minutes.</description></item>
                /// <item><description>runtime.realtime.failover.times.dataxcdc: specifies the maximum number of failures that are allowed for restarting a synchronization task after failovers occur.</description></item>
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

        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The synchronization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>FullAndRealtimeIncremental: one-time full synchronization and real-time incremental synchronization</description></item>
        /// <item><description>RealtimeIncremental: real-time incremental synchronization</description></item>
        /// <item><description>Full: full synchronization</description></item>
        /// <item><description>OfflineIncremental: batch incremental synchronization</description></item>
        /// <item><description>FullAndOfflineIncremental: one-time full synchronization and batch incremental synchronization</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FullAndRealtimeIncremental</para>
        /// </summary>
        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        /// <summary>
        /// <para>The name of the synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_to_holo_sync_8772</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>You must configure this parameter to specify the DataWorks workspace to which the API operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The resource settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestResourceSettings ResourceSettings { get; set; }
        public class CreateDIJobRequestResourceSettings : TeaModel {
            /// <summary>
            /// <para>The resource used for batch synchronization.</para>
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
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
            public CreateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
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
            public CreateDIJobRequestResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsScheduleResourceSettings : TeaModel {
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
                /// <para>S_res_group_235454102432001_1579085295030</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

        }

        /// <summary>
        /// <para>The settings of the source. Only a single source is supported.</para>
        /// <para>This parameter is required.</para>
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
            public CreateDIJobRequestSourceDataSourceSettingsDataSourceProperties DataSourceProperties { get; set; }
            public class CreateDIJobRequestSourceDataSourceSettingsDataSourceProperties : TeaModel {
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
        /// <para>The source type. Valid values: PolarDB, MySQL, Kafka, LogHub, Hologres, Oracle, OceanBase, MongoDB, Redshift, Hive, SQL Server, Doris, and ClickHouse.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SourceDataSourceType")]
        [Validation(Required=false)]
        public string SourceDataSourceType { get; set; }

        /// <summary>
        /// <para>The list of mappings between rules used to select synchronization objects in the source and transformation rules applied to the selected synchronization objects. Each entry in the list displays a mapping between a rule used to select synchronization objects and a transformation rule applied to the selected synchronization objects.</para>
        /// <remarks>
        /// <para> [ { &quot;SourceObjectSelectionRules&quot;:[ { &quot;ObjectType&quot;:&quot;Database&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;biz_db&quot; }, { &quot;ObjectType&quot;:&quot;Schema&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;s1&quot; }, { &quot;ObjectType&quot;:&quot;Table&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;table1&quot; } ], &quot;TransformationRuleNames&quot;:[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot; } ] } ]</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTableMappings> TableMappings { get; set; }
        public class CreateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// <para>The list of rules used to select synchronization objects in the source.</para>
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class CreateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
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
            /// <para>The list of transformation rules that you want to apply to the synchronization objects selected from the source. Each entry in the list defines a transformation rule.</para>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class CreateDIJobRequestTableMappingsTransformationRules : TeaModel {
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
                /// <para>The type of the object on which you want to perform the action. Valid values:</para>
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
        /// <para>The list of transformation rules for objects involved in the synchronization task.</para>
        /// <remarks>
        /// <para> [ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot;, &quot;RuleExpression&quot;:&quot;{&quot;expression&quot;:&quot;${srcDatasoureName}_${srcDatabaseName}&quot;}&quot; } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class CreateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// <para>The action type. Valid values:</para>
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
            /// <para>The expression of the rule. The expression must be a JSON string.</para>
            /// <ol>
            /// <item><description>Example of a renaming rule</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot; }</description></item>
            /// <item><description>expression: the expression of the renaming rule. You can use the following variables in an expression: ${srcDatasourceName}, ${srcDatabaseName}, and ${srcTableName}. ${srcDatasourceName} specifies the name of the source. ${srcDatabaseName} specifies the name of a source database. ${srcTableName} specifies the name of a source table.</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Example of a column addition rule</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}</description></item>
            /// <item><description>If you do not configure such a rule, no fields are added to the destination and no values are assigned by default.</description></item>
            /// <item><description>columnName: the name of the field that is added.</description></item>
            /// <item><description>columnValueType: the value type of the field. Valid values: Constant and Variable.</description></item>
            /// <item><description>columnValue: the value of the field. If the columnValueType parameter is set to Constant, set the columnValue parameter to a constant of the STRING data type. If the columnValueType parameter is set to Variable, set the columnValue parameter to a built-in variable. The following built-in variables are supported: EXECUTE_TIME (LONG data type), DB_NAME_SRC (STRING data type), DATASOURCE_NAME_SRC (STRING data type), TABLE_NAME_SRC (STRING data type), DB_NAME_DEST (STRING data type), DATASOURCE_NAME_DEST (STRING data type), TABLE_NAME_DEST (STRING data type), and DB_NAME_SRC_TRANSED (STRING data type). EXECUTE_TIME specifies the execution time. DB_NAME_SRC specifies the name of a source database. DATASOURCE_NAME_SRC specifies the name of the source. TABLE_NAME_SRC specifies the name of a source table. DB_NAME_DEST specifies the name of a destination database. DATASOURCE_NAME_DEST specifies the name of the destination. TABLE_NAME_DEST specifies the name of a destination table. DB_NAME_SRC_TRANSED specifies the database name obtained after a transformation.</description></item>
            /// </list>
            /// <ol start="3">
            /// <item><description>Example of a rule used to specify primary key fields for a destination table</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}</description></item>
            /// <item><description>If you do not configure such a rule, the primary key fields in the mapped source table are used for the destination table by default.</description></item>
            /// <item><description>If the destination table is an existing table, Data Integration does not modify the schema of the destination table. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run.</description></item>
            /// <item><description>If the destination table is automatically created by the system, Data Integration automatically creates the schema of the destination table. The schema contains the primary key fields that you specify. If the specified primary key fields do not exist in the destination table, an error is reported when the synchronization task starts to run.</description></item>
            /// </list>
            /// <ol start="4">
            /// <item><description>Example of a rule used to process DML messages</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}</description></item>
            /// <item><description>If you do not configure such a rule, the default processing policy for messages generated for insert, update, and delete operations is Normal.</description></item>
            /// <item><description>dmlType: the DML operation. Valid values: Insert, Update, and Delete.</description></item>
            /// <item><description>dmlAction: the processing policy for DML messages. Valid values: Normal, Ignore, Filter, and LogicalDelete. Filter indicates conditional processing. You can set the dmlAction parameter to Filter only when the dmlType parameter is set to Update or Delete.</description></item>
            /// <item><description>filterCondition: the condition used to filter DML messages. This parameter is required only when the dmlAction parameter is set to Filter.</description></item>
            /// </list>
            /// <ol start="5">
            /// <item><description>Example of a rule used to perform incremental synchronization</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;where&quot;:&quot;id &gt; 0&quot;}</description></item>
            /// <item><description>You can configure such a rule to perform incremental synchronization.</description></item>
            /// </list>
            /// <ol start="6">
            /// <item><description>Example of a rule used to configure scheduling parameters for an auto triggered task</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;cronExpress&quot;:&quot; \* \* \* \* \* \*&quot;, &quot;cycleType&quot;:&quot;1&quot;}</description></item>
            /// <item><description>You can configure such a rule to configure scheduling parameters for an auto triggered task.</description></item>
            /// </list>
            /// <ol start="7">
            /// <item><description>Example of a rule used to specify a partition key</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[&quot;id&quot;]}</description></item>
            /// <item><description>You can configure such a rule to specify a partition key.</description></item>
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
            /// <para>The type of the object on which you want to perform the action. Valid values:</para>
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
