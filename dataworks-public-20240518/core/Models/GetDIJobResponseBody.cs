// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetDIJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data integration job.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public GetDIJobResponseBodyPagingInfo PagingInfo { get; set; }
        public class GetDIJobResponseBodyPagingInfo : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>This field is deprecated. Use the <c>Id</c> field instead.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32601</para>
            /// </summary>
            [NameInMap("DIJobId")]
            [Validation(Required=false)]
            [Obsolete]
            public string DIJobId { get; set; }

            /// <summary>
            /// <para>The description of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The settings for the destination data source.</para>
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
            /// <para>The type of the destination data source. Valid values: <c>Hologres</c>, <c>OSS-HDFS</c>, <c>OSS</c>, <c>MaxCompute</c>, <c>LogHub</c>, <c>StarRocks</c>, <c>DataHub</c>, <c>AnalyticDB for MySQL</c>, <c>Kafka</c>, and <c>Hive</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hologres</para>
            /// </summary>
            [NameInMap("DestinationDataSourceType")]
            [Validation(Required=false)]
            public string DestinationDataSourceType { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32601</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imp_ods_dms_det_dealer_info_df</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The job settings.</para>
            /// </summary>
            [NameInMap("JobSettings")]
            [Validation(Required=false)]
            public GetDIJobResponseBodyPagingInfoJobSettings JobSettings { get; set; }
            public class GetDIJobResponseBodyPagingInfoJobSettings : TeaModel {
                /// <summary>
                /// <para>The settings for channel-related jobs. You can configure special settings for specific channels. The following channels are supported: Holo2Holo (data synchronization from Hologres to Hologres) and Holo2Kafka (data synchronization from Hologres to Kafka).</para>
                /// <ol>
                /// <item><description>Holo2Kafka</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;destinationChannelSettings&quot;:{&quot;kafkaClientProperties&quot;:[{&quot;key&quot;:&quot;linger.ms&quot;,&quot;value&quot;:&quot;100&quot;}],&quot;keyColumns&quot;:[&quot;col3&quot;],&quot;writeMode&quot;:&quot;canal&quot;}}</c></para>
                /// </description></item>
                /// <item><description><para><c>kafkaClientProperties</c>: The parameters for the Kafka producer, used when writing data to Kafka.</para>
                /// </description></item>
                /// <item><description><para><c>keyColumns</c>: The columns whose values are used as the key for Kafka records.</para>
                /// </description></item>
                /// <item><description><para><c>writeMode</c>: The format for writing data to Kafka. Valid values: <c>json</c> and <c>canal</c>.</para>
                /// </description></item>
                /// </list>
                /// <ol start="2">
                /// <item><description>Holo2Holo</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;destinationChannelSettings&quot;:{&quot;conflictMode&quot;:&quot;replace&quot;,&quot;dynamicColumnAction&quot;:&quot;replay&quot;,&quot;writeMode&quot;:&quot;replay&quot;}}</c></para>
                /// </description></item>
                /// <item><description><para><c>conflictMode</c>: The conflict handling policy for writing data to Hologres. Valid values: <c>replace</c> (overwrite) and <c>ignore</c> (ignore).</para>
                /// </description></item>
                /// <item><description><para><c>writeMode</c>: The method for writing data to Hologres. Valid values: <c>replay</c> and <c>insert</c>.</para>
                /// </description></item>
                /// <item><description><para><c>dynamicColumnAction</c>: The method for handling dynamic columns when writing data to Hologres. Valid values: <c>replay</c>, <c>insert</c>, and <c>ignore</c>.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;structInfo&quot;:&quot;MANAGED&quot;,&quot;storageType&quot;:&quot;TEXTFILE&quot;,&quot;writeMode&quot;:&quot;APPEND&quot;,&quot;partitionColumns&quot;:[{&quot;columnName&quot;:&quot;pt&quot;,&quot;columnType&quot;:&quot;STRING&quot;,&quot;comment&quot;:&quot;&quot;}],&quot;fieldDelimiter&quot;:&quot;&quot;}</para>
                /// </summary>
                [NameInMap("ChannelSettings")]
                [Validation(Required=false)]
                public string ChannelSettings { get; set; }

                /// <summary>
                /// <para>The column data type mappings.</para>
                /// </summary>
                [NameInMap("ColumnDataTypeSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsColumnDataTypeSettings : TeaModel {
                    /// <summary>
                    /// <para>The data type in the destination, such as <c>bigint</c>, <c>boolean</c>, <c>string</c>, <c>text</c>, <c>datetime</c>, <c>timestamp</c>, <c>decimal</c>, and <c>binary</c>. Data types vary depending on the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>text</para>
                    /// </summary>
                    [NameInMap("DestinationDataType")]
                    [Validation(Required=false)]
                    public string DestinationDataType { get; set; }

                    /// <summary>
                    /// <para>The data type in the source, such as <c>bigint</c>, <c>boolean</c>, <c>string</c>, <c>text</c>, <c>datetime</c>, <c>timestamp</c>, <c>decimal</c>, and <c>binary</c>. Data types vary depending on the data source.</para>
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
                    /// <para>The synchronization type for periodic scheduling. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Full</c>: full</para>
                    /// </description></item>
                    /// <item><description><para><c>OfflineIncremental</c>: offline incremental</para>
                    /// </description></item>
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
                /// <para>An array of settings for handling DDL messages. Each element specifies a DDL message type and the corresponding handling rule.</para>
                /// </summary>
                [NameInMap("DdlHandlingSettings")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoJobSettingsDdlHandlingSettings : TeaModel {
                    /// <summary>
                    /// <para>The handling action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Ignore</c>: Ignores the DDL message.</para>
                    /// </description></item>
                    /// <item><description><para><c>Critical</c>: Reports an error.</para>
                    /// </description></item>
                    /// <item><description><para><c>Normal</c>: Processes the DDL message.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ignore</para>
                    /// </summary>
                    [NameInMap("Action")]
                    [Validation(Required=false)]
                    public string Action { get; set; }

                    /// <summary>
                    /// <para>The DDL message type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>RenameColumn</c></para>
                    /// </description></item>
                    /// <item><description><para><c>ModifyColumn</c></para>
                    /// </description></item>
                    /// <item><description><para><c>CreateTable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>TruncateTable</c></para>
                    /// </description></item>
                    /// <item><description><para><c>DropTable</c></para>
                    /// </description></item>
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
                    /// <para>The name of the setting. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>src.offline.datasource.max.connection</c>: the maximum number of connections to the source for an offline batch job.</para>
                    /// </description></item>
                    /// <item><description><para><c>dst.offline.truncate</c>: Whether to truncate the destination table before the offline batch job starts.</para>
                    /// </description></item>
                    /// <item><description><para><c>runtime.offline.speed.limit.enable</c>: Whether to enable throttling for an offline batch job.</para>
                    /// </description></item>
                    /// <item><description><para><c>runtime.offline.concurrent</c>: the concurrency level for an offline batch synchronization job.</para>
                    /// </description></item>
                    /// <item><description><para><c>runtime.enable.auto.create.schema</c>: Whether to automatically create a schema at the destination.</para>
                    /// </description></item>
                    /// <item><description><para><c>runtime.realtime.concurrent</c>: the concurrency level for a real-time job.</para>
                    /// </description></item>
                    /// <item><description><para><c>runtime.realtime.failover.minute.dataxcdc</c>: The wait duration (in minutes) before restarting a failed instance.</para>
                    /// </description></item>
                    /// <item><description><para><c>runtime.realtime.failover.times.dataxcdc</c>: The maximum number of retries for a failed instance.</para>
                    /// </description></item>
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
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Finished</c>: The job is complete.</para>
            /// </description></item>
            /// <item><description><para><c>Failed</c>: The job failed.</para>
            /// </description></item>
            /// <item><description><para><c>Running</c>: The job is running.</para>
            /// </description></item>
            /// <item><description><para><c>Initialized</c>: The job is initialized but has not started.</para>
            /// </description></item>
            /// <item><description><para><c>Stopping</c>: The job is being stopped.</para>
            /// </description></item>
            /// <item><description><para><c>Stop</c>: The job is stopped.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The job type.</para>
            /// <list type="bullet">
            /// <item><description><para><c>DatabaseRealtimeMigration</c>: real-time synchronization of multiple tables from multiple source databases. This type supports full, incremental, or both full and incremental synchronization.</para>
            /// </description></item>
            /// <item><description><para><c>DatabaseOfflineMigration</c>: batch synchronization of multiple tables from multiple source databases. This type supports full, incremental, or both full and incremental synchronization.</para>
            /// </description></item>
            /// <item><description><para><c>SingleTableRealtimeMigration</c>: real-time synchronization of a single source table.</para>
            /// </description></item>
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
            /// <item><description><para><c>FullAndRealtimeIncremental</c>: one-time full synchronization and real-time incremental synchronization (for an entire database).</para>
            /// </description></item>
            /// <item><description><para><c>RealtimeIncremental</c>: real-time incremental synchronization (for a single table).</para>
            /// </description></item>
            /// <item><description><para><c>Full</c>: one-time full synchronization (for an entire database).</para>
            /// </description></item>
            /// <item><description><para><c>OfflineIncremental</c>: offline incremental synchronization (for an entire database).</para>
            /// </description></item>
            /// <item><description><para><c>FullAndOfflineIncremental</c>: one-time full synchronization and offline incremental synchronization (for an entire database).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FullAndRealtimeIncremental</para>
            /// </summary>
            [NameInMap("MigrationType")]
            [Validation(Required=false)]
            public string MigrationType { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the DataWorks workspace for the API call. You can obtain the workspace ID from the Workspace Configuration page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
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
                /// <para>The resource settings for the offline synchronization job.</para>
                /// </summary>
                [NameInMap("OfflineResourceSettings")]
                [Validation(Required=false)]
                public GetDIJobResponseBodyPagingInfoResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsOfflineResourceSettings : TeaModel {
                    /// <summary>
                    /// <para>The number of CUs from the data integration resource group for the offline synchronization job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RequestedCu")]
                    [Validation(Required=false)]
                    public double? RequestedCu { get; set; }

                    /// <summary>
                    /// <para>The name of the data integration resource group used by the offline synchronization job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>di_resourcegroup_v1</para>
                    /// </summary>
                    [NameInMap("ResourceGroupIdentifier")]
                    [Validation(Required=false)]
                    public string ResourceGroupIdentifier { get; set; }

                }

                /// <summary>
                /// <para>The resource settings for the real-time synchronization job.</para>
                /// </summary>
                [NameInMap("RealtimeResourceSettings")]
                [Validation(Required=false)]
                public GetDIJobResponseBodyPagingInfoResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsRealtimeResourceSettings : TeaModel {
                    /// <summary>
                    /// <para>The number of CUs from the data integration resource group for the real-time synchronization job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RequestedCu")]
                    [Validation(Required=false)]
                    public double? RequestedCu { get; set; }

                    /// <summary>
                    /// <para>The name of the data integration resource group used by the real-time job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>di_resourcegroup_v1</para>
                    /// </summary>
                    [NameInMap("ResourceGroupIdentifier")]
                    [Validation(Required=false)]
                    public string ResourceGroupIdentifier { get; set; }

                }

                /// <summary>
                /// <para>The scheduling resource settings.</para>
                /// </summary>
                [NameInMap("ScheduleResourceSettings")]
                [Validation(Required=false)]
                public GetDIJobResponseBodyPagingInfoResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
                public class GetDIJobResponseBodyPagingInfoResourceSettingsScheduleResourceSettings : TeaModel {
                    /// <summary>
                    /// <para>The number of CUs from the scheduling resource group for the offline scheduling job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RequestedCu")]
                    [Validation(Required=false)]
                    public double? RequestedCu { get; set; }

                    /// <summary>
                    /// <para>The name of the scheduling resource group used by the offline scheduling job.</para>
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
            /// <para>The settings for the source data source.</para>
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
                    /// <para>The encoding of the database.</para>
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
            /// <para>The type of the source data source. Valid values: <c>PolarDB</c>, <c>MySQL</c>, <c>Kafka</c>, <c>LogHub</c>, <c>Hologres</c>, <c>Oracle</c>, <c>OceanBase</c>, <c>MongoDB</c>, <c>RedShift</c>, <c>Hive</c>, <c>SQLServer</c>, <c>Doris</c>, and <c>ClickHouse</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Mysql</para>
            /// </summary>
            [NameInMap("SourceDataSourceType")]
            [Validation(Required=false)]
            public string SourceDataSourceType { get; set; }

            /// <summary>
            /// <para>A list of mappings for object transformation. Each element in the list describes a set of selection rules for source objects and a set of transformation rules that apply to the selected objects.</para>
            /// <remarks>
            /// <para>[
            /// {
            /// &quot;SourceObjectSelectionRules&quot;:[
            /// {
            /// &quot;ObjectType&quot;:&quot;Database&quot;,
            /// &quot;Action&quot;:&quot;Include&quot;,
            /// &quot;ExpressionType&quot;:&quot;Exact&quot;,
            /// &quot;Expression&quot;:&quot;biz_db&quot;
            /// },
            /// {
            /// &quot;ObjectType&quot;:&quot;Schema&quot;,
            /// &quot;Action&quot;:&quot;Include&quot;,
            /// &quot;ExpressionType&quot;:&quot;Exact&quot;,
            /// &quot;Expression&quot;:&quot;s1&quot;
            /// },
            /// {
            /// &quot;ObjectType&quot;:&quot;Table&quot;,
            /// &quot;Action&quot;:&quot;Include&quot;,
            /// &quot;ExpressionType&quot;:&quot;Exact&quot;,
            /// &quot;Expression&quot;:&quot;table1&quot;
            /// }
            /// ],
            /// &quot;TransformationRuleNames&quot;:[
            /// {
            /// &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;,
            /// &quot;RuleActionType&quot;:&quot;Rename&quot;,
            /// &quot;RuleTargetType&quot;:&quot;Schema&quot;
            /// }
            /// ]
            /// }
            /// ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TableMappings")]
            [Validation(Required=false)]
            public List<GetDIJobResponseBodyPagingInfoTableMappings> TableMappings { get; set; }
            public class GetDIJobResponseBodyPagingInfoTableMappings : TeaModel {
                /// <summary>
                /// <para>Each rule selects a set of source objects to be synchronized. A combination of multiple rules selects one table.</para>
                /// </summary>
                [NameInMap("SourceObjectSelectionRules")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
                public class GetDIJobResponseBodyPagingInfoTableMappingsSourceObjectSelectionRules : TeaModel {
                    /// <summary>
                    /// <para>The selection action. Valid values: <c>Include</c> and <c>Exclude</c>.</para>
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
                    /// <para>The expression type. Valid values: <c>Exact</c> and <c>Regex</c>.</para>
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
                    /// <item><description><para><c>Table</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Schema</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Database</c></para>
                    /// </description></item>
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
                /// <para>An array of object transformation rule definitions.</para>
                /// </summary>
                [NameInMap("TransformationRules")]
                [Validation(Required=false)]
                public List<GetDIJobResponseBodyPagingInfoTableMappingsTransformationRules> TransformationRules { get; set; }
                public class GetDIJobResponseBodyPagingInfoTableMappingsTransformationRules : TeaModel {
                    /// <summary>
                    /// <para>The action type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>DefinePrimaryKey</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Rename</c></para>
                    /// </description></item>
                    /// <item><description><para><c>AddColumn</c></para>
                    /// </description></item>
                    /// <item><description><para><c>HandleDml</c></para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AddColumn</para>
                    /// </summary>
                    [NameInMap("RuleActionType")]
                    [Validation(Required=false)]
                    public string RuleActionType { get; set; }

                    /// <summary>
                    /// <para>The name of the rule. The rule name must be unique for a specific action type (<c>RuleActionType</c>) and target type (<c>RuleTargetType</c>).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rename_rule_1</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The target object type of the action. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>Table</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Schema</c></para>
                    /// </description></item>
                    /// <item><description><para><c>Database</c></para>
                    /// </description></item>
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
            /// <para>A list of definitions for object transformation rules.</para>
            /// <remarks>
            /// <para>[
            /// {
            /// &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;,
            /// &quot;RuleActionType&quot;:&quot;Rename&quot;,
            /// &quot;RuleTargetType&quot;:&quot;Schema&quot;,
            /// &quot;RuleExpression&quot;:&quot;{\\&quot;expression\\&quot;:\\&quot;${srcDatasoureName}_${srcDatabaseName}\\&quot;}&quot;
            /// }
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
                /// <item><description><para><c>DefinePrimaryKey</c></para>
                /// </description></item>
                /// <item><description><para><c>Rename</c></para>
                /// </description></item>
                /// <item><description><para><c>AddColumn</c></para>
                /// </description></item>
                /// <item><description><para><c>HandleDml</c></para>
                /// </description></item>
                /// <item><description><para><c>DefineIncrementalCondition</c></para>
                /// </description></item>
                /// <item><description><para><c>DefineCycleScheduleSettings</c></para>
                /// </description></item>
                /// <item><description><para><c>DefinePartitionKey</c></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Rename</para>
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// <para>The rule expression, in JSON string format.</para>
                /// <ol>
                /// <item><description>Rename rule (<c>Rename</c>)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot;}</c></para>
                /// </description></item>
                /// <item><description><para><c>expression</c>: The expression for the rename transformation rule. The expression supports the following variables: <c>${srcDatasourceName}</c> (source data source name), <c>${srcDatabaseName}</c> (source database name), and <c>${srcTableName}</c> (source table name).</para>
                /// </description></item>
                /// </list>
                /// <ol start="2">
                /// <item><description>Add column rule (<c>AddColumn</c>)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}</c></para>
                /// </description></item>
                /// <item><description><para>If you do not specify this parameter, no columns are added or copied by default.</para>
                /// </description></item>
                /// <item><description><para><c>columnName</c>: The name of the column to add.</para>
                /// </description></item>
                /// <item><description><para><c>columnValueType</c>: The value type of the added column. Valid values: <c>Constant</c> and <c>Variable</c>.</para>
                /// </description></item>
                /// <item><description><para><c>columnValue</c>: The value of the added column. If <c>columnValueType</c> is <c>Constant</c>, the value is a custom string constant. If <c>columnValueType</c> is <c>Variable</c>, the value is a built-in variable. Valid built-in variables: <c>EXECUTE_TIME</c> (execution time, Long), <c>DB_NAME_SRC</c> (source database name, String), <c>DATASOURCE_NAME_SRC</c> (source data source name, String), <c>TABLE_NAME_SRC</c> (source table name, String), <c>DB_NAME_DEST</c> (destination database name, String), <c>DATASOURCE_NAME_DEST</c> (destination data source name, String), <c>TABLE_NAME_DEST</c> (destination table name, String), and <c>DB_NAME_SRC_TRANSED</c> (converted database name, String).</para>
                /// </description></item>
                /// </list>
                /// <ol start="3">
                /// <item><description>Define primary key rule (<c>DefinePrimaryKey</c>)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}</c></para>
                /// </description></item>
                /// <item><description><para>By default, the primary key columns from the source table are used.</para>
                /// </description></item>
                /// <item><description><para>If the destination table already exists, the data integration system does not modify the table schema. If the specified primary key columns are not in the destination table, the job fails to start.</para>
                /// </description></item>
                /// <item><description><para>If the destination table is automatically created, the data integration system automatically creates the table schema that includes the defined primary key columns. If the specified primary key columns are not in the destination table, the job fails to start.</para>
                /// </description></item>
                /// </list>
                /// <ol start="4">
                /// <item><description>DML handling rule (<c>HandleDml</c>)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}</c></para>
                /// </description></item>
                /// <item><description><para>If you do not specify this parameter, the default value <c>Normal</c> is used for Insert, Update, and Delete operations.</para>
                /// </description></item>
                /// <item><description><para><c>dmlType</c>: The DML operation type. Valid values: <c>Insert</c>, <c>Update</c>, and <c>Delete</c>.</para>
                /// </description></item>
                /// <item><description><para><c>dmlAction</c>: The DML handling policy. Valid values: <c>Normal</c> (process normally), <c>Ignore</c> (ignore), <c>Filter</c> (process conditionally, used when <c>dmlType</c> is <c>Update</c> or <c>Delete</c>), and <c>LogicalDelete</c> (logically delete).</para>
                /// </description></item>
                /// <item><description><para><c>filterCondition</c>: The DML filter condition. This parameter is used when <c>dmlAction</c> is <c>Filter</c>.</para>
                /// </description></item>
                /// </list>
                /// <ol start="5">
                /// <item><description>Define incremental condition rule (<c>DefineIncrementalCondition</c>)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;where&quot;:&quot;id &gt; 0&quot;}</c></para>
                /// </description></item>
                /// <item><description><para>Specifies the filter condition for incremental synchronization.</para>
                /// </description></item>
                /// </list>
                /// <ol start="6">
                /// <item><description>Define cycle schedule settings rule (<c>DefineCycleScheduleSettings</c>)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;cronExpress&quot;:&quot; * * * * * *&quot;, &quot;cycleType&quot;:&quot;1&quot;}</c></para>
                /// </description></item>
                /// <item><description><para>Specifies the scheduling parameters for a periodic job.</para>
                /// </description></item>
                /// </list>
                /// <ol start="7">
                /// <item><description>Define partition key rule (<c>DefinePartitionKey</c>)</description></item>
                /// </ol>
                /// <list type="bullet">
                /// <item><description><para>Example: <c>{&quot;columns&quot;:[&quot;id&quot;]}</c></para>
                /// </description></item>
                /// <item><description><para>Specifies the partition key.</para>
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
                /// <para>The name of the rule. The rule name must be unique for a specific action type (<c>RuleActionType</c>) and target type (<c>RuleTargetType</c>).</para>
                /// 
                /// <b>Example:</b>
                /// <para>rename_rule_1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The target object type of the action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Table</c></para>
                /// </description></item>
                /// <item><description><para><c>Schema</c></para>
                /// </description></item>
                /// <item><description><para><c>Database</c></para>
                /// </description></item>
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
        /// <para>The request ID. You can use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C99E2BE6-9DEA-5C2E-8F51-1DDCFEADE490</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
