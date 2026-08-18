// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDIJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DI Job Demo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of destination data source settings.</para>
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
            public CreateDIJobRequestDestinationDataSourceSettingsDataSourceProperties DataSourceProperties { get; set; }
            public class CreateDIJobRequestDestinationDataSourceSettingsDataSourceProperties : TeaModel {
                /// <summary>
                /// <para>Specify either this parameter or DataSourceName. This parameter specifies custom data source connection configuration information, including the instance ID, access identity, and instance region.</para>
                /// <para>This parameter supports only datasource config in instance pattern (ConnectionPropertiesMode). Different data sources have different property specifications. For more information, see <a href="https://help.aliyun.com/document_detail/2852465.html">Data source connection information ConnectionProperties</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;instanceId&quot;: &quot;rm-2ze09gn3x6xxx&quot;, &quot;password&quot;: &quot;xxxx&quot;, &quot;database&quot;: &quot;agent&quot;, &quot;username&quot;: &quot;zmtest&quot; &quot;regionId&quot;: &quot;cn-beijing&quot; }</para>
                /// </summary>
                [NameInMap("ConnectionProperties")]
                [Validation(Required=false)]
                public string ConnectionProperties { get; set; }

            }

        }

        /// <summary>
        /// <para>The type of the destination data source. Valid values: Hologres, OSS-HDFS, OSS, MaxCompute, LogHub, StarRocks, DataHub, AnalyticDB_For_MySQL, Kafka, Hive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hologres</para>
        /// </summary>
        [NameInMap("DestinationDataSourceType")]
        [Validation(Required=false)]
        public string DestinationDataSourceType { get; set; }

        /// <summary>
        /// <para>The code content in script mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;resourceSettings&quot;: {
        ///         &quot;realtimeResourceSettings&quot;: {
        ///             &quot;requestedCu&quot;: 2,
        ///             &quot;resourceGroupIdentifier&quot;: &quot;Serverless_res_group_123_456&quot;
        ///         },
        ///         &quot;offlineResourceSettings&quot;: {
        ///             &quot;requestedCu&quot;: 2,
        ///             &quot;resourceGroupIdentifier&quot;: &quot;Serverless_res_group_123_456&quot;
        ///         }
        ///     },
        ///     &quot;tableMappings&quot;: [
        ///         {
        ///             &quot;sourceObjectSelectionRules&quot;: [
        ///                 {
        ///                     &quot;expression&quot;: &quot;autotest_hologres&quot;,
        ///                     &quot;action&quot;: &quot;Include&quot;,
        ///                     &quot;expressionType&quot;: &quot;Exact&quot;,
        ///                     &quot;objectType&quot;: &quot;Datasource&quot;
        ///                 },
        ///                 {
        ///                     &quot;expression&quot;: &quot;auto_holo_2661647&quot;,
        ///                     &quot;action&quot;: &quot;Include&quot;,
        ///                     &quot;expressionType&quot;: &quot;Exact&quot;,
        ///                     &quot;objectType&quot;: &quot;Table&quot;
        ///                 },
        ///                 {
        ///                     &quot;expression&quot;: &quot;public&quot;,
        ///                     &quot;action&quot;: &quot;Include&quot;,
        ///                     &quot;expressionType&quot;: &quot;Exact&quot;,
        ///                     &quot;objectType&quot;: &quot;Schema&quot;
        ///                 }
        ///             ],
        ///             &quot;transformationRules&quot;: [
        ///                 {
        ///                     &quot;ruleTargetType&quot;: &quot;Table&quot;,
        ///                     &quot;ruleActionType&quot;: &quot;SourceSchema&quot;,
        ///                     &quot;ruleName&quot;: &quot;SourceSchema_Table_BStf8aXPSCJjOWGe&quot;
        ///                 },
        ///                 {
        ///                     &quot;ruleTargetType&quot;: &quot;Schema&quot;,
        ///                     &quot;ruleActionType&quot;: &quot;Rename&quot;,
        ///                     &quot;ruleName&quot;: &quot;Rename_Schema_3qWNOIsljtInvKJy&quot;
        ///                 },
        ///                 {
        ///                     &quot;ruleTargetType&quot;: &quot;Table&quot;,
        ///                     &quot;ruleActionType&quot;: &quot;Rename&quot;,
        ///                     &quot;ruleName&quot;: &quot;Rename_Table_o3PVQq1aIKDGoVVW&quot;
        ///                 },
        ///                 {
        ///                     &quot;ruleTargetType&quot;: &quot;Table&quot;,
        ///                     &quot;ruleActionType&quot;: &quot;DefineDstTableSettings&quot;,
        ///                     &quot;ruleName&quot;: &quot;DefineDstTableSettings_Table_BhJltOmOCIc81fzi&quot;
        ///                 },
        ///                 {
        ///                     &quot;ruleTargetType&quot;: &quot;Table&quot;,
        ///                     &quot;ruleActionType&quot;: &quot;ColumnMapping&quot;,
        ///                     &quot;ruleName&quot;: &quot;ColumnMapping_Table_nP4hJPX1wh2W3fpo&quot;
        ///                 }
        ///             ]
        ///         }
        ///     ],
        ///     &quot;sourceDataSourceSettings&quot;: [
        ///         {
        ///             &quot;dataSourceProperties&quot;: {
        ///                 &quot;timeZone&quot;: &quot;Asia/Shanghai&quot;
        ///             },
        ///             &quot;dataSourceName&quot;: &quot;autotest_hologres&quot;
        ///         }
        ///     ],
        ///     &quot;jobSettings&quot;: {
        ///         &quot;runtimeSettings&quot;: [</para>
        /// <pre><c>    ],
        ///     &quot;ddlHandlingSettings&quot;: [
        /// 
        ///     ],
        ///     &quot;columnDataTypeSettings&quot;: [
        /// 
        ///     ],
        ///     &quot;cycleScheduleSettings&quot;: {
        /// 
        ///     },
        ///     &quot;channelSettings&quot;: {
        ///         &quot;destinationChannelSettings&quot;: {
        ///             &quot;conflictMode&quot;: &quot;replace&quot;,
        ///             &quot;dynamicColumnAction&quot;: &quot;replay&quot;,
        ///             &quot;writeMode&quot;: &quot;replay&quot;
        ///         },
        ///         &quot;sourceChannelSettings&quot;: {
        /// 
        ///         }
        ///     }
        /// },
        /// &quot;destinationDataSourceType&quot;: &quot;Hologres&quot;,
        /// &quot;transformationRules&quot;: [
        ///     {
        ///         &quot;ruleTargetType&quot;: &quot;Table&quot;,
        ///         &quot;ruleName&quot;: &quot;SourceSchema_Table_BStf8aXPSCJjOWGe&quot;,
        ///         &quot;ruleActionType&quot;: &quot;SourceSchema&quot;,
        ///         &quot;ruleExpression&quot;: {
        ///             &quot;columns&quot;: [
        ///                 {
        ///                     &quot;name&quot;: &quot;id&quot;,
        ///                     &quot;category&quot;: &quot;normal&quot;,
        ///                     &quot;type&quot;: &quot;BIGINT&quot;
        ///                 },
        ///                 {
        ///                     &quot;name&quot;: &quot;decimal&quot;,
        ///                     &quot;category&quot;: &quot;normal&quot;,
        ///                     &quot;type&quot;: &quot;DECIMAL&quot;
        ///                 }
        ///             ]
        ///         }
        ///     },
        ///     {
        ///         &quot;ruleTargetType&quot;: &quot;Schema&quot;,
        ///         &quot;ruleName&quot;: &quot;Rename_Schema_3qWNOIsljtInvKJy&quot;,
        ///         &quot;ruleActionType&quot;: &quot;Rename&quot;,
        ///         &quot;ruleExpression&quot;: {
        ///             &quot;expression&quot;: &quot;public&quot;
        ///         }
        ///     },
        ///     {
        ///         &quot;ruleTargetType&quot;: &quot;Table&quot;,
        ///         &quot;ruleName&quot;: &quot;Rename_Table_o3PVQq1aIKDGoVVW&quot;,
        ///         &quot;ruleActionType&quot;: &quot;Rename&quot;,
        ///         &quot;ruleExpression&quot;: {
        ///             &quot;expression&quot;: &quot;auto_holo_2661647_dst&quot;
        ///         }
        ///     },
        ///     {
        ///         &quot;ruleTargetType&quot;: &quot;Table&quot;,
        ///         &quot;ruleName&quot;: &quot;DefineDstTableSettings_Table_BhJltOmOCIc81fzi&quot;,
        ///         &quot;ruleActionType&quot;: &quot;DefineDstTableSettings&quot;,
        ///         &quot;ruleExpression&quot;: {
        ///             &quot;ddlString&quot;: &quot;BEGIN;
        /// </c></pre>
        /// <para>CREATE TABLE IF NOT EXISTS public.auto_holo_2661647_dst (
        ///    id          BIGINT PRIMARY KEY,
        ///    &quot;decimal&quot;   DECIMAL(38,18)
        /// );
        /// CALL SET_TABLE_PROPERTY(\&quot;public.auto_holo_2661647_dst\&quot;, \&quot;time_to_live_in_seconds\&quot;, \&quot;3153600000\&quot;);
        /// CALL SET_TABLE_PROPERTY(\&quot;public.auto_holo_2661647_dst\&quot;, \&quot;orientation\&quot;, \&quot;column\&quot;);
        /// CALL SET_TABLE_PROPERTY(\&quot;public.auto_holo_2661647_dst\&quot;, \&quot;binlog.level\&quot;, \&quot;replica\&quot;);
        /// CALL SET_TABLE_PROPERTY(\&quot;public.auto_holo_2661647_dst\&quot;, \&quot;binlog.ttl\&quot;, \&quot;2592000\&quot;);
        /// CALL SET_TABLE_PROPERTY(\&quot;public.auto_holo_2661647_dst\&quot;, \&quot;bitmap_columns\&quot;, \&quot;&quot;text&quot;,&quot;char&quot;,&quot;varchar&quot;\&quot;);
        /// CALL SET_TABLE_PROPERTY(\&quot;public.auto_holo_2661647_dst\&quot;, \&quot;dictionary_encoding_columns\&quot;, \&quot;&quot;text&quot;:auto,&quot;bytea&quot;:auto,&quot;char&quot;:auto,&quot;varchar&quot;:auto\&quot;);
        /// CALL SET_TABLE_PROPERTY(\&quot;public.auto_holo_2661647_dst\&quot;, \&quot;distribution_key\&quot;, \&quot;&quot;id&quot;\&quot;);
        /// COMMIT;
        /// &quot;,
        ///                 &quot;ddlType&quot;: &quot;STRUCT&quot;
        ///             }
        ///         },
        ///         {
        ///             &quot;ruleTargetType&quot;: &quot;Table&quot;,
        ///             &quot;ruleName&quot;: &quot;ColumnMapping_Table_nP4hJPX1wh2W3fpo&quot;,
        ///             &quot;ruleActionType&quot;: &quot;ColumnMapping&quot;,
        ///             &quot;ruleExpression&quot;: {
        ///                 &quot;columnMapping&quot;: [
        ///                     {
        ///                         &quot;sourceColName&quot;: &quot;id&quot;,
        ///                         &quot;dstColName&quot;: &quot;id&quot;
        ///                     },
        ///                     {
        ///                         &quot;sourceColName&quot;: &quot;decimal&quot;,
        ///                         &quot;dstColName&quot;: &quot;decimal&quot;
        ///                     }
        ///                 ]
        ///             }
        ///         }
        ///     ],
        ///     &quot;migrationType&quot;: &quot;FullAndRealtimeIncremental&quot;,
        ///     &quot;destinationDataSourceSettings&quot;: [
        ///         {
        ///             &quot;dataSourceProperties&quot;: {</para>
        /// <pre><c>        },
        ///         &quot;dataSourceName&quot;: &quot;autotest_hologres&quot;
        ///     }
        /// ],
        /// &quot;sourceDataSourceType&quot;: &quot;Hologres&quot;
        /// </c></pre>
        /// <para>}</para>
        /// </summary>
        [NameInMap("FileSpec")]
        [Validation(Required=false)]
        public string FileSpec { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Use the Name parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_to_holo_sync_8772</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        [Obsolete]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The task-level settings, including DDL handling policies, source-to-destination column data type mapping policies, and task runtime parameters.</para>
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestJobSettings JobSettings { get; set; }
        public class CreateDIJobRequestJobSettings : TeaModel {
            /// <summary>
            /// <para>The channel-related task settings. You can configure special settings for specific channels. Currently supported channels include Holo2Holo (synchronization from Hologres to Hologres) and Holo2Kafka (synchronization from Hologres to Kafka).</para>
            /// <ol>
            /// <item><description>Holo2Kafka</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;destinationChannelSettings&quot;:{&quot;kafkaClientProperties&quot;:[{&quot;key&quot;:&quot;linger.ms&quot;,&quot;value&quot;:&quot;100&quot;}],&quot;keyColumns&quot;:[&quot;col3&quot;],&quot;writeMode&quot;:&quot;canal&quot;}}</description></item>
            /// <item><description>kafkaClientProperties: Kafka producer parameters used when writing to Kafka.</description></item>
            /// <item><description>keyColumns: the columns whose values are written to Kafka.</description></item>
            /// <item><description>writeMode: the Kafka write format. Currently supports json and canal.</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Holo2Holo</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: {&quot;destinationChannelSettings&quot;:{&quot;conflictMode&quot;:&quot;replace&quot;,&quot;dynamicColumnAction&quot;:&quot;replay&quot;,&quot;writeMode&quot;:&quot;replay&quot;}}</para>
            /// </description></item>
            /// <item><description><para>conflictMode: the conflict handling policy when writing to Hologres. Valid values: replace (overwrite) and ignore.</para>
            /// </description></item>
            /// <item><description><para>writeMode: the write mode for Hologres. Valid values: replay and insert.</para>
            /// </description></item>
            /// <item><description><para>dynamicColumnAction: the dynamic column handling mode when writing to Hologres. Valid values: replay, insert, and ignore.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;structInfo&quot;: &quot;MANAGED&quot;,
            ///       &quot;storageType&quot;: &quot;TEXTFILE&quot;,
            ///       &quot;writeMode&quot;: &quot;APPEND&quot;,
            ///       &quot;partitionColumns&quot;: [
            ///             {
            ///                   &quot;columnName&quot;: &quot;pt&quot;,
            ///                   &quot;columnType&quot;: &quot;STRING&quot;,
            ///                   &quot;comment&quot;: &quot;&quot;
            ///             }
            ///       ],
            ///       &quot;fieldDelimiter&quot;: &quot;&quot;
            /// }</para>
            /// </summary>
            [NameInMap("ChannelSettings")]
            [Validation(Required=false)]
            public string ChannelSettings { get; set; }

            /// <summary>
            /// <para>The column data type mapping array.</para>
            /// <remarks>
            /// <para>[&quot;ColumnDataTypeSettings&quot;:[ { &quot;SourceDataType&quot;:&quot;Bigint&quot;, &quot;DestinationDataType&quot;:&quot;Text&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                /// <summary>
                /// <para>The destination data type, such as bigint, boolean, string, text, datetime, timestamp, decimal, or binary. The available types vary by data source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                /// <summary>
                /// <para>The source data type, such as bigint, boolean, string, text, datetime, timestamp, decimal, or binary. The available types vary by data source type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bigint</para>
                /// </summary>
                [NameInMap("SourceDataType")]
                [Validation(Required=false)]
                public string SourceDataType { get; set; }

            }

            /// <summary>
            /// <para>The cycle scheduling settings.</para>
            /// </summary>
            [NameInMap("CycleScheduleSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestJobSettingsCycleScheduleSettings CycleScheduleSettings { get; set; }
            public class CreateDIJobRequestJobSettingsCycleScheduleSettings : TeaModel {
                /// <summary>
                /// <para>The synchronization type that requires cycle scheduling. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Full: full synchronization.</description></item>
                /// <item><description>OfflineIncremental: offline incremental synchronization.</description></item>
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
            /// <para>The DDL handling settings array.</para>
            /// <remarks>
            /// <para>[&quot;DDLHandlingSettings&quot;:[ { &quot;Type&quot;:&quot;Insert&quot;, &quot;Action&quot;:&quot;Normal&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class CreateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                /// <summary>
                /// <para>The handling action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Ignore: ignores the DDL operation.</description></item>
                /// <item><description>Critical: reports an error.</description></item>
                /// <item><description>Normal: processes the DDL operation normally.</description></item>
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
                /// <item><description>RenameColumn: renames a column.</description></item>
                /// <item><description>ModifyColumn: modifies a column.</description></item>
                /// <item><description>CreateTable: creates a table.</description></item>
                /// <item><description>TruncateTable: truncates a table.</description></item>
                /// <item><description>DropTable: drops a table.</description></item>
                /// <item><description>DropColumn: drops a column.</description></item>
                /// <item><description>AddColumn: adds a column.</description></item>
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
                /// <para>The setting name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>src.offline.datasource.max.connection: the maximum number of connections to the source for offline batch tasks.</description></item>
                /// <item><description>dst.offline.truncate: specifies whether to truncate the destination table.</description></item>
                /// <item><description>runtime.offline.speed.limit.enable: specifies whether to enable throttling for offline batch tasks.</description></item>
                /// <item><description>runtime.offline.concurrent: the concurrency of offline batch synchronization tasks.</description></item>
                /// <item><description>runtime.enable.auto.create.schema: specifies whether to automatically create a schema on the destination.</description></item>
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
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>DatabaseRealtimeMigration: real-time migration of entire databases. Performs streaming synchronization of multiple tables from multiple source databases. Supports full-only, incremental-only, or full and incremental synchronization.</para>
        /// </description></item>
        /// <item><description><para>DatabaseOfflineMigration: offline migration of entire databases. Performs batch synchronization of multiple tables from multiple source databases. Supports full-only, incremental-only, or full and incremental synchronization.</para>
        /// </description></item>
        /// <item><description><para>SingleTableRealtimeMigration: real-time migration of a single table. Performs streaming synchronization of a single source table.</para>
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
        /// <item><description>FullAndRealtimeIncremental: full and real-time incremental synchronization for entire databases in real time.</description></item>
        /// <item><description>RealtimeIncremental: real-time incremental synchronization for single tables in real time.</description></item>
        /// <item><description>Full: full synchronization for entire databases offline.</description></item>
        /// <item><description>OfflineIncremental: offline incremental synchronization for entire databases offline.</description></item>
        /// <item><description>FullAndOfflineIncremental: full and offline incremental synchronization for entire databases offline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullAndRealtimeIncremental</para>
        /// </summary>
        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_to_holo_sync_8772</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The owner of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3726346</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for this API call.</para>
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
            /// <para>The offline synchronization resource settings.</para>
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of compute units (CUs) of the data integration resource group used for offline synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the data integration resource group used for offline synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The real-time synchronization resource settings.</para>
            /// </summary>
            [NameInMap("RealtimeResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs of the data integration resource group used for real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the data integration resource group used for real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The schedule resource settings.</para>
            /// </summary>
            [NameInMap("ScheduleResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsScheduleResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs of the scheduling resource group used for offline synchronization nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the scheduling resource group used for offline synchronization nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_222_333</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of source data source settings.</para>
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
                /// <para>Specify either this parameter or DataSourceName. This parameter specifies custom data source connection configuration information, including the instance ID, access identity, and instance region.</para>
                /// <para>This parameter supports only datasource config in instance pattern (ConnectionPropertiesMode). Different data sources have different property specifications. For more information, see <a href="https://help.aliyun.com/document_detail/2852465.html">Data source connection information ConnectionProperties</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;instanceId&quot;: &quot;rm-2ze09gn3x6xxx&quot;, &quot;password&quot;: &quot;xxxx&quot;, &quot;database&quot;: &quot;agent&quot;, &quot;username&quot;: &quot;zmtest&quot; &quot;regionId&quot;: &quot;cn-beijing&quot; }</para>
                /// </summary>
                [NameInMap("ConnectionProperties")]
                [Validation(Required=false)]
                public string ConnectionProperties { get; set; }

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
                /// <para>Asia/Shanghai</para>
                /// </summary>
                [NameInMap("Timezone")]
                [Validation(Required=false)]
                public string Timezone { get; set; }

            }

        }

        /// <summary>
        /// <para>The type of the source data source. Valid values: PolarDB, MySQL, Kafka, LogHub, Hologres, Oracle, OceanBase, MongoDB, RedShift, Hive, SQLServer, Doris, ClickHouse.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SourceDataSourceType")]
        [Validation(Required=false)]
        public string SourceDataSourceType { get; set; }

        /// <summary>
        /// <para>The list of synchronization object transformation mappings. Each element describes a group of source object selection rules and the transformation rules applied to that group.</para>
        /// <remarks>
        /// <para>[ { &quot;SourceObjectSelectionRules&quot;:[ { &quot;ObjectType&quot;:&quot;Database&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;biz_db&quot; }, { &quot;ObjectType&quot;:&quot;Schema&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;s1&quot; }, { &quot;ObjectType&quot;:&quot;Table&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;table1&quot; } ], &quot;TransformationRuleNames&quot;:[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot; } ] } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTableMappings> TableMappings { get; set; }
        public class CreateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// <para>Each rule selects a set of source objects to synchronize. Multiple rules together select a single table.</para>
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class CreateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
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
            /// <para>The list of synchronization object transformation rule definitions. Each element represents one transformation rule.</para>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class CreateDIJobRequestTableMappingsTransformationRules : TeaModel {
                /// <summary>
                /// <para>The action type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DefinePrimaryKey: defines a primary key.</description></item>
                /// <item><description>Rename: renames an object.</description></item>
                /// <item><description>AddColumn: adds a column.</description></item>
                /// <item><description>HandleDml: handles DML operations.</description></item>
                /// <item><description>DefineIncrementalCondition: defines an incremental condition.</description></item>
                /// <item><description>DefineCycleScheduleSettings: defines cycle scheduling settings.</description></item>
                /// <item><description>DefinePartitionKey: defines a partition key.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Rename</para>
                /// </summary>
                [NameInMap("RuleActionType")]
                [Validation(Required=false)]
                public string RuleActionType { get; set; }

                /// <summary>
                /// <para>The rule name. The name must be unique within the same action type and target type combination. The name cannot exceed 50 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rename_rule_1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The target type on which the action is applied. Valid values:</para>
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
        /// <para>[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot;, &quot;RuleExpression&quot;:&quot;{&quot;expression&quot;:&quot;${srcDatasoureName}_${srcDatabaseName}&quot;}&quot; } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class CreateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// <para>The action type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DefinePrimaryKey: defines a primary key.</description></item>
            /// <item><description>Rename: renames an object.</description></item>
            /// <item><description>AddColumn: adds a column.</description></item>
            /// <item><description>HandleDml: handles DML operations.</description></item>
            /// <item><description>DefineIncrementalCondition: defines an incremental condition.</description></item>
            /// <item><description>DefineCycleScheduleSettings: defines cycle scheduling settings.</description></item>
            /// <item><description>DefinePartitionKey: defines a partition key.</description></item>
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
            /// <item><description>Example: {&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot; }</description></item>
            /// <item><description>expression: the rename transformation rule expression. The expression supports the following variables: ${srcDatasourceName} (source data source name), ${srcDatabaseName} (source database name), and ${srcTableName} (source table name).</description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Add column rule (AddColumn)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}</description></item>
            /// <item><description>If not specified, the default rule is to neither add columns nor perform replication.</description></item>
            /// <item><description>columnName: the name of the additional column.</description></item>
            /// <item><description>columnValueType: the value type of the additional column. Valid values: Constant and Variable.</description></item>
            /// <item><description>columnValue: the value of the additional column. When columnValueType is set to Constant, the value is a custom constant of the String type. When columnValueType is set to Variable, the value is a built-in variable. Valid built-in variables: EXECUTE_TIME (execution time, Long type), DB_NAME_SRC (source database name, String type), DATASOURCE_NAME_SRC (source data source name, String type), TABLE_NAME_SRC (source table name, String type), DB_NAME_DEST (destination database name, String type), DATASOURCE_NAME_DEST (destination data source name, String type), TABLE_NAME_DEST (destination table name, String type), and DB_NAME_SRC_TRANSED (transformed database name, String type).</description></item>
            /// </list>
            /// <ol start="3">
            /// <item><description>Define primary key columns for the destination table (DefinePrimaryKey)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}</description></item>
            /// <item><description>If not specified, the source primary key columns are used by default.</description></item>
            /// <item><description>When the destination table already exists: the data integration system does not modify the destination table schema. If the specified primary key columns are not in the destination column set, the node reports an error upon startup.</description></item>
            /// <item><description>When the destination table uses automatic creation: the data integration system automatically creates the destination table schema, which includes the defined primary key columns. If the specified primary key columns are not in the destination column set, the node reports an error upon startup.</description></item>
            /// </list>
            /// <ol start="4">
            /// <item><description>DML operations handling rule (HandleDml)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}</description></item>
            /// <item><description>If not specified, the default rule is Normal for Insert, Update, and Delete.</description></item>
            /// <item><description>dmlType: the DML operations type. Valid values: Insert, Update, and Delete.</description></item>
            /// <item><description>dmlAction: the DML operations handling policy. Valid values: Normal (process normally), Ignore (ignore), Filter (conditionally process normally, used when dmlType is Update or Delete), and LogicalDelete (logical delete).</description></item>
            /// <item><description>filterCondition: the DML filter condition, used when dmlAction is set to Filter.</description></item>
            /// </list>
            /// <ol start="5">
            /// <item><description>Incremental condition (DefineIncrementalCondition)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;where&quot;:&quot;id &gt; 0&quot;}</description></item>
            /// <item><description>Specifies the incremental filter condition.</description></item>
            /// </list>
            /// <ol start="6">
            /// <item><description>Cycle scheduling parameters (DefineCycleScheduleSettings)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;cronExpress&quot;:&quot; * * * * * *&quot;, &quot;cycleType&quot;:&quot;1&quot;}</description></item>
            /// <item><description>Specifies the cycle node scheduling parameters.</description></item>
            /// </list>
            /// <ol start="7">
            /// <item><description>Define partition key (DefinePartitionKey)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description>Example: {&quot;columns&quot;:[&quot;id&quot;]}</description></item>
            /// <item><description>Specifies the partition key.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;expression&quot;: &quot;${srcDatasoureName}_${srcDatabaseName}&quot;
            /// }</para>
            /// </summary>
            [NameInMap("RuleExpression")]
            [Validation(Required=false)]
            public string RuleExpression { get; set; }

            /// <summary>
            /// <para>The rule name. When the action type and target type are the same, the rule name must be unique. The name cannot exceed 50 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rename_rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The target type on which the action is applied. Valid values:</para>
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
