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
            /// <para><b>[Deprecated]</b> This field is deprecated. Use the Id field instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32601</para>
            /// </summary>
            [NameInMap("DIJobId")]
            [Validation(Required=false)]
            [Obsolete]
            public string DIJobId { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of destination data source properties.</para>
            /// </summary>
            [NameInMap("DestinationDataSourceSettings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyPagingInfoDestinationDataSourceSettings> DestinationDataSourceSettings { get; set; }
            public class GetDIJobResponseBodyPagingInfoDestinationDataSourceSettings : TeaModel {
                /// <summary>
                /// <para>The name of the destination data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dw_mysql</para>
                /// </summary>
                [NameInMap("DataSourceName")]
                [Validation(Required=false)]
                public string DataSourceName { get; set; }

            }

            /// <summary>
            /// <para>The type of the destination data source. Valid values: Hologres, OSS-HDFS, OSS, MaxCompute, LogHub, StarRocks, DataHub, AnalyticDB_For_MySQL, Kafka, and Hive.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hologres</para>
            /// </summary>
            [NameInMap("DestinationDataSourceType")]
            [Validation(Required=false)]
            public string DestinationDataSourceType { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32601</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The task name.</para>
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
                /// <para>The channel-related task settings. You can configure specific channels. Currently, Holo2Holo (synchronization from Hologres to Hologres) and Holo2Kafka (synchronization from Hologres to Kafka) are supported.</para>
                /// <ol>
                /// <item><description>Holo2Kafka</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example: {&quot;destinationChannelSettings&quot;:{&quot;kafkaClientProperties&quot;:[{&quot;key&quot;:&quot;linger.ms&quot;,&quot;value&quot;:&quot;100&quot;}],&quot;keyColumns&quot;:[&quot;col3&quot;],&quot;writeMode&quot;:&quot;canal&quot;}}</description></item>
                /// <item><description>kafkaClientProperties: the Kafka producer parameters used when writing data to Kafka.</description></item>
                /// <item><description>keyColumns: the Kafka columns to which data is written.</description></item>
                /// <item><description>writeMode: the format in which data is written to Kafka. Valid values: json and canal.</description></item>
                /// </list>
                /// <ol start="2">
                /// <item><description>Holo2Holo</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example: {&quot;destinationChannelSettings&quot;:{&quot;conflictMode&quot;:&quot;replace&quot;,&quot;dynamicColumnAction&quot;:&quot;replay&quot;,&quot;writeMode&quot;:&quot;replay&quot;}}</description></item>
                /// <item><description>conflictMode: the conflict handling policy when writing data to Hologres. Valid values: replace (overwrite) and ignore (ignore).</description></item>
                /// <item><description>writeMode: the method used to write data to Hologres. Valid values: replay and insert.</description></item>
                /// <item><description>dynamicColumnAction: the method used to write dynamic columns to Hologres. Valid values: replay, insert, and ignore.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;structInfo&quot;:&quot;MANAGED&quot;,&quot;storageType&quot;:&quot;TEXTFILE&quot;,&quot;writeMode&quot;:&quot;APPEND&quot;,&quot;partitionColumns&quot;:[{&quot;columnName&quot;:&quot;pt&quot;,&quot;columnType&quot;:&quot;STRING&quot;,&quot;comment&quot;:&quot;&quot;}],&quot;fieldDelimiter&quot;:&quot;&quot;}</para>
                /// </summary>
                [NameInMap("ChannelSettings")]
                [Validation(Required=false)]
                public string ChannelSettings { get; set; }

                /// <summary>
                /// <para>The column type mappings.</para>
                /// </summary>
                [NameInMap("ColumnDataTypeSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsColumnDataTypeSettings : TeaModel {
                    /// <summary>
                    /// <para>The destination data type, such as bigint, boolean, string, text, datetime, timestamp, decimal, and binary. Data types vary based on the data source type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text</para>
                    /// </summary>
                    [NameInMap("DestinationDataType")]
                    [Validation(Required=false)]
                    public string DestinationDataType { get; set; }

                    /// <summary>
                    /// <para>The source data type, such as bigint, boolean, string, text, datetime, timestamp, decimal, and binary. Data types vary based on the data source type.</para>
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
                public GetDIJobResponseBodyPagingInfoJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsCycleScheduleSettings : TeaModel {
                    /// <summary>
                    /// <para>The synchronization type that requires periodic scheduling. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Full: full data synchronization.</description></item>
                    /// <item><description>OfflineIncremental: batch incremental synchronization.</description></item>
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
                /// <para>The array of DDL handling settings, which includes a list of DDL types to be handled and their corresponding rules.</para>
                /// </summary>
                [NameInMap("DdlHandlingSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsDdlHandlingSettings : TeaModel {
                    /// <summary>
                    /// <para>The handling action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>Ignore: ignores the DDL statement.</description></item>
                    /// <item><description>Critical: reports an error.</description></item>
                    /// <item><description>Normal: processes the DDL statement normally.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ignore</para>
                    /// </summary>
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>The DDL type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>RenameColumn: renames a column.</description></item>
                    /// <item><description>ModifyColumn: modifies a column.</description></item>
                    /// <item><description>CreateTable: creates a table.</description></item>
                    /// <item><description>TruncateTable: truncates a table.</description></item>
                    /// <item><description>DropTable: drops a table.</description></item>
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
                    /// <para>The setting name. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>src.offline.datasource.max.connection: the maximum number of connections to the source for batch tasks.</description></item>
                    /// <item><description>dst.offline.truncate: specifies whether to truncate the destination table.</description></item>
                    /// <item><description>runtime.offline.speed.limit.enable: specifies whether to enable throttling for batch tasks.</description></item>
                    /// <item><description>runtime.offline.concurrent: the concurrency of batch synchronization tasks.</description></item>
                    /// <item><description>runtime.enable.auto.create.schema: specifies whether to automatically create a schema at the destination.</description></item>
                    /// <item><description>runtime.realtime.concurrent: the concurrency of real-time tasks.</description></item>
                    /// <item><description>runtime.realtime.failover.minute.dataxcdc: the wait time in minutes before restarting after a failover failure.</description></item>
                    /// <item><description>runtime.realtime.failover.times.dataxcdc: the number of restart attempts after a failover failure.</description></item>
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
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Finished: the task ran successfully and has finished.</description></item>
            /// <item><description>Failed: the task failed to run.</description></item>
            /// <item><description>Running: the task is running.</description></item>
            /// <item><description>Initialized: the task is initialized but not started.</description></item>
            /// <item><description>Stopping: the task is being stopped.</description></item>
            /// <item><description>Stop: the task is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DatabaseRealtimeMigration: performs stream synchronization for multiple tables across multiple source databases. Supports full data only, incremental data only, or both full and incremental data.</description></item>
            /// <item><description>DatabaseOfflineMigration: performs batch synchronization for multiple tables across multiple source databases. Supports full data only, incremental data only, or both full and incremental data.</description></item>
            /// <item><description>SingleTableRealtimeMigration: performs stream synchronization for a single source table.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DatabaseRealtimeMigration</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The synchronization type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FullAndRealtimeIncremental: full and real-time incremental synchronization (real-time synchronization for the entire database).</description></item>
            /// <item><description>RealtimeIncremental: real-time incremental synchronization (real-time synchronization for a single table).</description></item>
            /// <item><description>Full: full data synchronization (batch synchronization for the entire database).</description></item>
            /// <item><description>OfflineIncremental: batch incremental synchronization (batch synchronization for the entire database).</description></item>
            /// <item><description>FullAndOfflineIncremental: full and batch incremental synchronization (batch synchronization for the entire database).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FullAndRealtimeIncremental</para>
            /// </summary>
            [NameInMap("MigrationType")]
            [Validation(Required=false)]
            public string MigrationType { get; set; }

            /// <summary>
            /// <para>The task owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3726346</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace configuration page to obtain the workspace ID.</para>
            /// <para>This parameter specifies the DataWorks workspace used for this API call.</para>
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
                /// <para>The batch synchronization resources.</para>
                /// </summary>
                [NameInMap("OfflineResourceSettings")]
                [Validation(Required=false)]
                public GetDIJobResponseBodyPagingInfoResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsOfflineResourceSettings : TeaModel {
                    /// <summary>
                    /// <para>The number of compute units (CUs) of the scheduling resource group used by the batch synchronization task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RequestedCu")]
                    [Validation(Required=false)]
                    public double? RequestedCu { get; set; }

                    /// <summary>
                    /// <para>The name of the data integration resource group used for batch synchronization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>di_resourcegroup_v1</para>
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
                public GetDIJobResponseBodyPagingInfoResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsRealtimeResourceSettings : TeaModel {
                    /// <summary>
                    /// <para>The number of CUs of the data integration resource group used for real-time synchronization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RequestedCu")]
                    [Validation(Required=false)]
                    public double? RequestedCu { get; set; }

                    /// <summary>
                    /// <para>The name of the data integration resource group used for real-time tasks.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>di_resourcegroup_v1</para>
                    /// </summary>
                    [NameInMap("ResourceGroupIdentifier")]
                    [Validation(Required=false)]
                    public string ResourceGroupIdentifier { get; set; }

                }

                /// <summary>
                /// <para>The scheduling resource.</para>
                /// </summary>
                [NameInMap("ScheduleResourceSettings")]
                [Validation(Required=false)]
                public GetDIJobResponseBodyPagingInfoResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsScheduleResourceSettings : TeaModel {
                    /// <summary>
                    /// <para>The number of CUs of the data integration resource group used by the batch scheduling task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RequestedCu")]
                    [Validation(Required=false)]
                    public double? RequestedCu { get; set; }

                    /// <summary>
                    /// <para>The name of the scheduling resource group used by the batch scheduling task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>schedual_resourcegroup_v1</para>
                    /// </summary>
                    [NameInMap("ResourceGroupIdentifier")]
                    [Validation(Required=false)]
                    public string ResourceGroupIdentifier { get; set; }

                }

            }

            /// <summary>
            /// <para>The array of source data source settings.</para>
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
                    /// <para>The database encoding.</para>
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
            /// <para>The type of the source data source. Valid values: PolarDB, MySQL, Kafka, LogHub, Hologres, Oracle, OceanBase, MongoDB, RedShift, Hive, SQLServer, Doris, and ClickHouse.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mysql</para>
            /// </summary>
            [NameInMap("SourceDataSourceType")]
            [Validation(Required=false)]
            public string SourceDataSourceType { get; set; }

            /// <summary>
            /// <para>The list of synchronization object transformation mappings. Each element in the list describes a set of source object selection rules and a list of transformation rules applied to the selected synchronization objects.</para>
            /// <remarks>
            /// <para>[
            ///   {
            ///     &quot;SourceObjectSelectionRules&quot;:[
            ///       {
            ///         &quot;ObjectType&quot;:&quot;Database&quot;,
            ///         &quot;Action&quot;:&quot;Include&quot;,
            ///         &quot;ExpressionType&quot;:&quot;Exact&quot;,
            ///         &quot;Expression&quot;:&quot;biz_db&quot;
            ///       },
            ///     {
            ///         &quot;ObjectType&quot;:&quot;Schema&quot;,
            ///         &quot;Action&quot;:&quot;Include&quot;,
            ///         &quot;ExpressionType&quot;:&quot;Exact&quot;,
            ///         &quot;Expression&quot;:&quot;s1&quot;
            ///       }, 
            ///     {
            ///         &quot;ObjectType&quot;:&quot;Table&quot;,
            ///         &quot;Action&quot;:&quot;Include&quot;,
            ///         &quot;ExpressionType&quot;:&quot;Exact&quot;,
            ///         &quot;Expression&quot;:&quot;table1&quot;
            ///       }
            ///     ],
            ///     &quot;TransformationRuleNames&quot;:[
            ///       {
            ///         &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;,
            ///         &quot;RuleActionType&quot;:&quot;Rename&quot;,
            ///         &quot;RuleTargetType&quot;:&quot;Schema&quot;
            ///           }
            ///     ]
            ///   }
            /// ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TableMappings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyPagingInfoTableMappings> TableMappings { get; set; }
            public class GetDIJobResponseBodyPagingInfoTableMappings : TeaModel {
                /// <summary>
                /// <para>Each rule selects a set of source objects to be synchronized. Multiple rules combine to select a single table.</para>
                /// </summary>
                [NameInMap("SourceObjectSelectionRules")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
                public class GetDIJobResponseBodyPagingInfoTableMappingsSourceObjectSelectionRules : TeaModel {
                    /// <summary>
                    /// <para>The selection action. Valid values: Include and Exclude.</para>
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
                    /// <item><description>Table: table.</description></item>
                    /// <item><description>Schema: schema.</description></item>
                    /// <item><description>Database: database.</description></item>
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
                /// <para>The list of transformation rule definitions for synchronization objects. Each element in the list is a transformation rule definition.</para>
                /// </summary>
                [NameInMap("TransformationRules")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoTableMappingsTransformationRules> TransformationRules { get; set; }
                public class GetDIJobResponseBodyPagingInfoTableMappingsTransformationRules : TeaModel {
                    /// <summary>
                    /// <para>The action type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>DefinePrimaryKey: defines the primary key.</description></item>
                    /// <item><description>Rename: renames the object.</description></item>
                    /// <item><description>AddColumn: adds a column.</description></item>
                    /// <item><description>HandleDml: handles DML operations.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AddColumn</para>
                    /// </summary>
                    [NameInMap("RuleActionType")]
                    [Validation(Required=false)]
                    public string RuleActionType { get; set; }

                    /// <summary>
                    /// <para>The rule name. The rule name must be unique when the action type and the target type of the action are the same.</para>
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
                    /// <item><description>Table: table.</description></item>
                    /// <item><description>Schema: schema.</description></item>
                    /// <item><description>Database: database.</description></item>
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
            /// <para>The list of transformation rule definitions for synchronization objects.</para>
            /// <remarks>
            /// <para>[
            ///   {
            ///     &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;,
            ///     &quot;RuleActionType&quot;:&quot;Rename&quot;,
            ///     &quot;RuleTargetType&quot;:&quot;Schema&quot;,
            ///     &quot;RuleExpression&quot;:&quot;{\&quot;expression\&quot;:\&quot;${srcDatasoureName}_${srcDatabaseName}\&quot;}&quot;
            ///   }
            /// ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyPagingInfoTransformationRules> TransformationRules { get; set; }
            public class GetDIJobResponseBodyPagingInfoTransformationRules : TeaModel {
                /// <summary>
                /// <para>The action type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DefinePrimaryKey: defines the primary key.</description></item>
                /// <item><description>Rename: renames the object.</description></item>
                /// <item><description>AddColumn: adds a column.</description></item>
                /// <item><description>HandleDml: handles DML operations.</description></item>
                /// <item><description>DefineIncrementalCondition: defines the incremental condition.</description></item>
                /// <item><description>DefineCycleScheduleSettings: defines the periodic scheduling settings.</description></item>
                /// <item><description>DefinePartitionKey: defines the partition key.</description></item>
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
                /// <item><description>Rename rule (Rename)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example: {&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot;}</description></item>
                /// <item><description>expression: the expression for the rename transformation rule. Supported variables in the expression include: ${srcDatasourceName} (source data source name), ${srcDatabaseName} (source database name), and ${srcTableName} (source table name).</description></item>
                /// </list>
                /// <ol start="2">
                /// <item><description>Add column rule (AddColumn)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example: {&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}</description></item>
                /// <item><description>If not specified, the default rule is to add no columns and perform no replication.</description></item>
                /// <item><description>columnName: the name of the appended column.</description></item>
                /// <item><description>columnValueType: the value type of the appended column. Valid values: Constant and Variable.</description></item>
                /// <item><description>columnValue: the value of the appended column. When columnValueType is Constant, the value is a custom constant of the String type. When columnValueType is Variable, the value is a built-in variable. Valid built-in variables include: EXECUTE_TIME (execution time, Long type), DB_NAME_SRC (source database name, String type), DATASOURCE_NAME_SRC (source data source name, String type), TABLE_NAME_SRC (source table name, String type), DB_NAME_DEST (destination database name, String type), DATASOURCE_NAME_DEST (destination data source name, String type), TABLE_NAME_DEST (destination table name, String type), and DB_NAME_SRC_TRANSED (transformed database name, String type).</description></item>
                /// </list>
                /// <ol start="3">
                /// <item><description>Specify the primary key column names for the destination table (DefinePrimaryKey)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example: {&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}</description></item>
                /// <item><description>If not specified, the source primary key columns are used by default.</description></item>
                /// <item><description>When the destination is an existing table: the data integration system does not modify the destination table schema. If the specified primary key columns are not in the destination column set, an error is reported when the task starts.</description></item>
                /// <item><description>When the destination is a table to be created automatically: the data integration system automatically creates the destination table schema, which includes the defined primary key columns. If the specified primary key columns are not in the destination column set, an error is reported when the task starts.</description></item>
                /// </list>
                /// <ol start="4">
                /// <item><description>DML handling rule (HandleDml)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example:
                /// {&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}</description></item>
                /// <item><description>If not specified, the default rule is Normal for Insert, Update, and Delete.</description></item>
                /// <item><description>dmlType: the DML operations type. Valid values: Insert, Update, and Delete.</description></item>
                /// <item><description>dmlAction: the DML handling policy. Valid values: Normal (normal processing), Ignore (ignore), Filter (conditional normal processing, used when dmlType is Update or Delete), and LogicalDelete (logical deletion).</description></item>
                /// <item><description>filterCondition: the DML filter condition, used when dmlAction is Filter.</description></item>
                /// </list>
                /// <ol start="5">
                /// <item><description>Incremental condition (DefineIncrementalCondition)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example:
                /// {&quot;where&quot;:&quot;id &gt; 0&quot;}</description></item>
                /// <item><description>Specifies the incremental filter condition.</description></item>
                /// </list>
                /// <ol start="6">
                /// <item><description>Periodic scheduling parameters (DefineCycleScheduleSettings)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example:
                /// {&quot;cronExpress&quot;:&quot; * * * * * *&quot;, &quot;cycleType&quot;:&quot;1&quot;}</description></item>
                /// <item><description>Specifies the scheduling parameters for the scheduled task.</description></item>
                /// </list>
                /// <ol start="7">
                /// <item><description>Specify the partition key (DefinePartitionKey)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description>Example:
                /// {&quot;columns&quot;:[&quot;id&quot;]}</description></item>
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
                /// <para>The rule name. The rule name must be unique under a specific combination of action type and target type.</para>
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
                /// <item><description>Table: table.</description></item>
                /// <item><description>Schema: schema.</description></item>
                /// <item><description>Database: database.</description></item>
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
        /// <para>The request ID. You can use the ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C99E2BE6-9DEA-5C2E-8F51-1DDCFEADE490</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
