// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateDIJobRequest : TeaModel {
        /// <summary>
        /// <para>The description of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DI Job Demo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Settings for the destination data sources.</para>
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
                /// <para>Custom connection settings for the data source, such as instance ID, access credentials, and instance region. You must specify this parameter or <c>DataSourceName</c>.</para>
                /// <para>This parameter applies only when the data source is configured in instance mode (<c>ConnectionPropertiesMode</c>). The property format varies by data source. For more information, see <a href="https://help.aliyun.com/document_detail/2852465.html">ConnectionProperties for data sources</a>.</para>
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
        /// <para>The type of the destination data source. Valid values: <c>Hologres</c>, <c>OSS-HDFS</c>, <c>OSS</c>, <c>MaxCompute</c>, <c>LogHub</c>, <c>StarRocks</c>, <c>DataHub</c>, <c>AnalyticDB for MySQL</c>, <c>Kafka</c>, and <c>Hive</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hologres</para>
        /// </summary>
        [NameInMap("DestinationDataSourceType")]
        [Validation(Required=false)]
        public string DestinationDataSourceType { get; set; }

        /// <summary>
        /// <para>The code for a job created in script mode.</para>
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
        /// <para>This parameter is deprecated. Use the <c>Name</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_to_holo_sync_8772</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        [Obsolete]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The settings for the synchronization job, including DDL processing policies, data type mappings between source and destination columns, and runtime parameters.</para>
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public CreateDIJobRequestJobSettings JobSettings { get; set; }
        public class CreateDIJobRequestJobSettings : TeaModel {
            /// <summary>
            /// <para>Settings for data synchronization channels. You can configure special settings for specific channels. The following channels are supported: synchronization from Hologres to Hologres (Holo2Holo) and from Hologres to Kafka (Holo2Kafka).</para>
            /// <ol>
            /// <item><description>Holo2Kafka</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;destinationChannelSettings&quot;:{&quot;kafkaClientProperties&quot;:[{&quot;key&quot;:&quot;linger.ms&quot;,&quot;value&quot;:&quot;100&quot;}],&quot;keyColumns&quot;:[&quot;col3&quot;],&quot;writeMode&quot;:&quot;canal&quot;}}</c>
            /// <c>kafkaClientProperties</c>: Parameters for the Kafka producer.</para>
            /// </description></item>
            /// <item><description><para><c>keyColumns</c>: The columns whose values are used as keys for data written to Kafka.</para>
            /// </description></item>
            /// <item><description><para><c>writeMode</c>: The data format for writing to Kafka. Valid values: <c>json</c> and <c>canal</c>.</para>
            /// </description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Holo2Holo</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;destinationChannelSettings&quot;:{&quot;conflictMode&quot;:&quot;replace&quot;,&quot;dynamicColumnAction&quot;:&quot;replay&quot;,&quot;writeMode&quot;:&quot;replay&quot;}}</c></para>
            /// </description></item>
            /// <item><description><para><c>conflictMode</c>: The conflict handling policy for writing data to Hologres. Valid values: <c>replace</c> (overwrite) and <c>ignore</c>.</para>
            /// </description></item>
            /// <item><description><para><c>writeMode</c>: The method for writing data to Hologres. Valid values: <c>replay</c> and <c>insert</c>.</para>
            /// </description></item>
            /// <item><description><para><c>dynamicColumnAction</c>: The method for handling dynamic columns when writing data to Hologres. Valid values: <c>replay</c>, <c>insert</c>, and <c>ignore</c>.</para>
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
            /// <para>Column data type mappings.</para>
            /// <remarks>
            /// <para>&quot;ColumnDataTypeSettings&quot;:[ { &quot;SourceDataType&quot;:&quot;Bigint&quot;, &quot;DestinationDataType&quot;:&quot;Text&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class CreateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                /// <summary>
                /// <para>The destination data type. For example: <c>bigint</c>, <c>boolean</c>, <c>string</c>, <c>text</c>, <c>datetime</c>, <c>timestamp</c>, <c>decimal</c>, or <c>binary</c>. Available data types vary by data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                /// <summary>
                /// <para>The source data type. For example: <c>bigint</c>, <c>boolean</c>, <c>string</c>, <c>text</c>, <c>datetime</c>, <c>timestamp</c>, <c>decimal</c>, or <c>binary</c>. Available data types vary by data source.</para>
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
                /// <para>The synchronization type for periodic scheduling. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Full</c>: Full synchronization.</para>
                /// </description></item>
                /// <item><description><para><c>OfflineIncremental</c>: Incremental synchronization in batch mode.</para>
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
            /// <para>DDL handling settings.</para>
            /// <remarks>
            /// <para>&quot;DDLHandlingSettings&quot;:[ { &quot;Type&quot;:&quot;Insert&quot;, &quot;Action&quot;:&quot;Normal&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class CreateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                /// <summary>
                /// <para>The handling action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Ignore</c>: Ignores the DDL message.</para>
                /// </description></item>
                /// <item><description><para><c>Critical</c>: Reports an error.</para>
                /// </description></item>
                /// <item><description><para><c>Normal</c>: Processes the DDL message normally.</para>
                /// </description></item>
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
                /// <item><description><para><c>RenameColumn</c>: Renames a column.</para>
                /// </description></item>
                /// <item><description><para><c>ModifyColumn</c>: Modifies a column.</para>
                /// </description></item>
                /// <item><description><para><c>CreateTable</c>: Creates a table.</para>
                /// </description></item>
                /// <item><description><para><c>TruncateTable</c>: Truncates a table.</para>
                /// </description></item>
                /// <item><description><para><c>DropTable</c>: Drops a table.</para>
                /// </description></item>
                /// <item><description><para><c>DropColumn</c>: Drops a column.</para>
                /// </description></item>
                /// <item><description><para><c>AddColumn</c>: Adds a column.</para>
                /// </description></item>
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
                /// <para>The name of the setting. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>src.offline.datasource.max.connection</c>: The maximum number of connections to the source of a batch synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>dst.offline.truncate</c>: Specifies whether to truncate the destination table before a batch job starts.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.offline.speed.limit.enable</c>: Specifies whether to enable throttling for a batch synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.offline.concurrent</c>: The concurrency level of a batch synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.enable.auto.create.schema</c>: Specifies whether to automatically create a destination schema.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.realtime.concurrent</c>: The concurrency level of a real-time synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.realtime.failover.minute.dataxcdc</c>: The wait time in minutes for a failover restart.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.realtime.failover.times.dataxcdc</c>: The number of failover restart attempts.</para>
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
        /// <para>The job type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>DatabaseRealtimeMigration</c>: Synchronizes multiple tables from multiple source databases in real time (stream synchronization). This type supports full, incremental, or both full and incremental synchronization.</para>
        /// </description></item>
        /// <item><description><para><c>DatabaseOfflineMigration</c>: Synchronizes multiple tables from multiple source databases in batches. This type supports full, incremental, or both full and incremental synchronization.</para>
        /// </description></item>
        /// <item><description><para><c>SingleTableRealtimeMigration</c>: Synchronizes a single source table in real time (stream synchronization).</para>
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
        /// <item><description><para><c>FullAndRealtimeIncremental</c>: Full and real-time incremental synchronization for an entire database.</para>
        /// </description></item>
        /// <item><description><para><c>RealtimeIncremental</c>: Real-time incremental synchronization for a single table.</para>
        /// </description></item>
        /// <item><description><para><c>Full</c>: Full batch synchronization for an entire database.</para>
        /// </description></item>
        /// <item><description><para><c>OfflineIncremental</c>: Incremental synchronization in batch mode.</para>
        /// </description></item>
        /// <item><description><para><c>FullAndOfflineIncremental</c>: Full and incremental batch synchronization for an entire database.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullAndRealtimeIncremental</para>
        /// </summary>
        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        /// <summary>
        /// <para>The name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql_to_holo_sync_8772</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The job owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3726346</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace for this API call. To obtain the workspace ID, log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace Management page.</para>
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
            /// <para>Resource settings for batch synchronization.</para>
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs for the resource group for data integration that is used for batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The identifier of the resource group for data integration used for batch synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The resources for real-time synchronization.</para>
            /// </summary>
            [NameInMap("RealtimeResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs for the resource group for data integration that is used for real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The identifier of the resource group for data integration used for real-time synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
                /// </summary>
                [NameInMap("ResourceGroupIdentifier")]
                [Validation(Required=false)]
                public string ResourceGroupIdentifier { get; set; }

            }

            /// <summary>
            /// <para>The scheduling resources.</para>
            /// </summary>
            [NameInMap("ScheduleResourceSettings")]
            [Validation(Required=false)]
            public CreateDIJobRequestResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
            public class CreateDIJobRequestResourceSettingsScheduleResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs for the scheduling resource group that is used for batch synchronization jobs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The identifier of the scheduling resource group used for batch synchronization jobs.</para>
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
        /// <para>Settings for the source data sources.</para>
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
                /// <para>Custom connection settings for the data source, such as instance ID, access credentials, and instance region. You must specify this parameter or <c>DataSourceName</c>.</para>
                /// <para>This parameter applies only when the data source is configured in instance mode (<c>ConnectionPropertiesMode</c>). The property format varies by data source. For more information, see <a href="https://help.aliyun.com/document_detail/2852465.html">ConnectionProperties for data sources</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{ &quot;instanceId&quot;: &quot;rm-2ze09gn3x6xxx&quot;, &quot;password&quot;: &quot;xxxx&quot;, &quot;database&quot;: &quot;agent&quot;, &quot;username&quot;: &quot;zmtest&quot; &quot;regionId&quot;: &quot;cn-beijing&quot; }</para>
                /// </summary>
                [NameInMap("ConnectionProperties")]
                [Validation(Required=false)]
                public string ConnectionProperties { get; set; }

                /// <summary>
                /// <para>The database encoding format.</para>
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
        /// <para>The type of the source data source. Valid values: <c>PolarDB</c>, <c>MySQL</c>, <c>Kafka</c>, <c>LogHub</c>, <c>Hologres</c>, <c>Oracle</c>, <c>OceanBase</c>, <c>MongoDB</c>, <c>Redshift</c>, <c>Hive</c>, <c>SQL Server</c>, <c>Doris</c>, and <c>ClickHouse</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("SourceDataSourceType")]
        [Validation(Required=false)]
        public string SourceDataSourceType { get; set; }

        /// <summary>
        /// <para>Transformation mappings for the objects to be synchronized. Each mapping defines selection rules for a group of source objects and the transformation rules to apply to them.</para>
        /// <remarks>
        /// <para>[ { &quot;SourceObjectSelectionRules&quot;:[ { &quot;ObjectType&quot;:&quot;Database&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;biz_db&quot; }, { &quot;ObjectType&quot;:&quot;Schema&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;s1&quot; }, { &quot;ObjectType&quot;:&quot;Table&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;table1&quot; } ], &quot;TransformationRuleNames&quot;:[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot; } ] } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTableMappings> TableMappings { get; set; }
        public class CreateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// <para>Each rule can select a set of source objects to synchronize. Multiple rules combine to select one table.</para>
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class CreateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
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
            /// <para>The names of the transformation rules to apply to the selected objects.</para>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<CreateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class CreateDIJobRequestTableMappingsTransformationRules : TeaModel {
                /// <summary>
                /// <para>The action type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>DefinePrimaryKey</c>: Defines a primary key.</para>
                /// </description></item>
                /// <item><description><para><c>Rename</c>: Renames an object.</para>
                /// </description></item>
                /// <item><description><para><c>AddColumn</c>: Adds a column.</para>
                /// </description></item>
                /// <item><description><para><c>HandleDml</c>: Handles DML operations.</para>
                /// </description></item>
                /// <item><description><para><c>DefineIncrementalCondition</c>: Defines an incremental condition.</para>
                /// </description></item>
                /// <item><description><para><c>DefineCycleScheduleSettings</c>: Defines periodic scheduling settings.</para>
                /// </description></item>
                /// <item><description><para><c>DefinePartitionKey</c>: Defines a partition key.</para>
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
                /// <para>The name of the transformation rule. The rule name must be unique for a specific action type and target object type. Maximum length: 50 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rename_rule_1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The type of the object to which the action applies. Valid values:</para>
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
        /// <para>A list of transformation rules for the objects to be synchronized.</para>
        /// <remarks>
        /// <para>[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot;, &quot;RuleExpression&quot;:&quot;{\\&quot;expression\\&quot;:\\&quot;${srcDatasoureName}_${srcDatabaseName}\\&quot;}&quot; } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<CreateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class CreateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// <para>The action type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>DefinePrimaryKey</c>: Defines a primary key.</para>
            /// </description></item>
            /// <item><description><para><c>Rename</c>: Renames an object.</para>
            /// </description></item>
            /// <item><description><para><c>AddColumn</c>: Adds a column.</para>
            /// </description></item>
            /// <item><description><para><c>HandleDml</c>: Handles DML operations.</para>
            /// </description></item>
            /// <item><description><para><c>DefineIncrementalCondition</c>: Defines an incremental condition.</para>
            /// </description></item>
            /// <item><description><para><c>DefineCycleScheduleSettings</c>: Defines periodic scheduling settings.</para>
            /// </description></item>
            /// <item><description><para><c>DefinePartitionKey</c>: Defines a partition key.</para>
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
            /// <para>The rule expression, specified as a JSON string.</para>
            /// <ol>
            /// <item><description>Renaming rule (<c>Rename</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot; }</c></para>
            /// </description></item>
            /// <item><description><para><c>expression</c>: The renaming expression. You can use the following variables: <c>${srcDatasourceName}</c> (name of the source data source), <c>${srcDatabaseName}</c> (name of the source database), and <c>${srcTableName}</c> (name of the source table).</para>
            /// </description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Rule for adding a column (<c>AddColumn</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}</c></para>
            /// </description></item>
            /// <item><description><para>If you do not specify this rule, no columns are added.</para>
            /// </description></item>
            /// <item><description><para><c>columnName</c>: The name of the column to add.</para>
            /// </description></item>
            /// <item><description><para><c>columnValueType</c>: The value type of the added column. Valid values: <c>Constant</c> and <c>Variable</c>.</para>
            /// </description></item>
            /// <item><description><para><c>columnValue</c>: The value of the added column. If <c>columnValueType</c> is <c>Constant</c>, the value is a custom string constant. If <c>columnValueType</c> is <c>Variable</c>, the value is a built-in variable. Valid built-in variables include: <c>EXECUTE_TIME</c> (execution time, Long), <c>DB_NAME_SRC</c> (source database name, String), <c>DATASOURCE_NAME_SRC</c> (source data source name, String), <c>TABLE_NAME_SRC</c> (source table name, String), <c>DB_NAME_DEST</c> (destination database name, String), <c>DATASOURCE_NAME_DEST</c> (destination data source name, String), <c>TABLE_NAME_DEST</c> (destination table name, String), and <c>DB_NAME_SRC_TRANSED</c> (transformed database name, String).</para>
            /// </description></item>
            /// </list>
            /// <ol start="3">
            /// <item><description>Rule for defining the primary key columns of a destination table (<c>DefinePrimaryKey</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}</c></para>
            /// </description></item>
            /// <item><description><para>If you do not specify this rule, the primary key columns of the source table are used by default.</para>
            /// </description></item>
            /// <item><description><para>If the destination is an existing table, Data Integration does not modify its schema. If a specified primary key column does not exist in the destination table, the job fails to start and an error is reported.</para>
            /// </description></item>
            /// <item><description><para>If the destination table is automatically created, Data Integration automatically creates its schema with the defined primary key columns. If a specified primary key column does not exist in the source table, the job fails to start and an error is reported.</para>
            /// </description></item>
            /// </list>
            /// <ol start="4">
            /// <item><description>DML handling rule (<c>HandleDml</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}</c></para>
            /// </description></item>
            /// <item><description><para>If you do not specify this rule, the default <c>dmlAction</c> is <c>Normal</c> for <c>Insert</c>, <c>Update</c>, and <c>Delete</c> operations.</para>
            /// </description></item>
            /// <item><description><para><c>dmlType</c>: The DML operation type. Valid values: <c>Insert</c>, <c>Update</c>, and <c>Delete</c>.</para>
            /// </description></item>
            /// <item><description><para><c>dmlAction</c>: The DML handling policy. Valid values: <c>Normal</c> (normal processing), <c>Ignore</c>, <c>Filter</c> (conditional processing, used when <c>dmlType</c> is <c>Update</c> or <c>Delete</c>), and <c>LogicalDelete</c> (logical deletion).</para>
            /// </description></item>
            /// <item><description><para><c>filterCondition</c>: The DML filter condition, used when <c>dmlAction</c> is <c>Filter</c>.</para>
            /// </description></item>
            /// </list>
            /// <ol start="5">
            /// <item><description>Incremental condition (<c>DefineIncrementalCondition</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;where&quot;:&quot;id &gt; 0&quot;}</c></para>
            /// </description></item>
            /// <item><description><para>Specifies the filter condition for incremental synchronization.</para>
            /// </description></item>
            /// </list>
            /// <ol start="6">
            /// <item><description>Parameters for periodic scheduling (<c>DefineCycleScheduleSettings</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;cronExpress&quot;:&quot; * * * * * *&quot;, &quot;cycleType&quot;:&quot;1&quot;}</c></para>
            /// </description></item>
            /// <item><description><para>Specifies the parameters for periodically scheduling a job.</para>
            /// </description></item>
            /// </list>
            /// <ol start="7">
            /// <item><description>Rule to define a partition key (<c>DefinePartitionKey</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;columns&quot;:[&quot;id&quot;]}</c></para>
            /// </description></item>
            /// <item><description><para>Specifies a partition key.</para>
            /// </description></item>
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
            /// <para>The name of the rule. The rule name must be unique for a specific action type and target object type. Maximum length: 50 characters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rename_rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The type of the object to which the action applies. Valid values:</para>
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

}
