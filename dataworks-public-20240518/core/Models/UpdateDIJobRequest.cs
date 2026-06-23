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
        /// <para>This parameter is deprecated. Use the <c>Id</c> parameter instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11588</para>
        /// </summary>
        [NameInMap("DIJobId")]
        [Validation(Required=false)]
        [Obsolete]
        public long? DIJobId { get; set; }

        /// <summary>
        /// <para>The description of the synchronization job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DI Job Demo</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The job configuration in script mode.</para>
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

        /// <summary>
        /// <para>The ID of the synchronization job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11588</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The settings for the synchronization job. This includes DDL handling settings, data type mappings for columns between the source and destination, and runtime parameters.</para>
        /// </summary>
        [NameInMap("JobSettings")]
        [Validation(Required=false)]
        public UpdateDIJobRequestJobSettings JobSettings { get; set; }
        public class UpdateDIJobRequestJobSettings : TeaModel {
            /// <summary>
            /// <para>The job settings for specific data synchronization channels. You can apply special configurations to certain channels. Currently, <c>Holo2Holo</c> (synchronization from Hologres to Hologres) and <c>Holo2Kafka</c> (synchronization from Hologres to Kafka) are supported.</para>
            /// <ol>
            /// <item><description><c>Holo2Kafka</c></description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;destinationChannelSettings&quot;:{&quot;kafkaClientProperties&quot;:[{&quot;key&quot;:&quot;linger.ms&quot;,&quot;value&quot;:&quot;100&quot;}],&quot;keyColumns&quot;:[&quot;col3&quot;],&quot;writeMode&quot;:&quot;canal&quot;}}</c>
            /// <c>kafkaClientProperties</c>: The Kafka producer parameters used when writing to Kafka.</para>
            /// </description></item>
            /// <item><description><para><c>keyColumns</c>: The columns whose values are written to the key of a Kafka message.</para>
            /// </description></item>
            /// <item><description><para><c>writeMode</c>: The format for writing data to Kafka. Valid values: <c>json</c> and <c>canal</c>.</para>
            /// </description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description><c>Holo2Holo</c></description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;destinationChannelSettings&quot;:{&quot;conflictMode&quot;:&quot;replace&quot;,&quot;dynamicColumnAction&quot;:&quot;replay&quot;,&quot;writeMode&quot;:&quot;replay&quot;}}</c></para>
            /// </description></item>
            /// <item><description><para><c>conflictMode</c>: The conflict handling policy for writing data to Hologres. Valid values: <c>replace</c> (overwrite) and <c>ignore</c> (ignore).</para>
            /// </description></item>
            /// <item><description><para><c>writeMode</c>: The method for writing data to Hologres. Valid values: <c>replay</c> and <c>insert</c>.</para>
            /// </description></item>
            /// <item><description><para><c>dynamicColumnAction</c>: The action for handling dynamic columns when writing data to Hologres. Valid values: <c>replay</c>, <c>insert</c>, and <c>ignore</c>.</para>
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
            /// <para>An array of column data type mappings.</para>
            /// <remarks>
            /// <para>[&quot;ColumnDataTypeSettings&quot;:[ { &quot;SourceDataType&quot;:&quot;Bigint&quot;, &quot;DestinationDataType&quot;:&quot;Text&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ColumnDataTypeSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsColumnDataTypeSettings> ColumnDataTypeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsColumnDataTypeSettings : TeaModel {
                /// <summary>
                /// <para>The destination data type. Examples: <c>bigint</c>, <c>boolean</c>, <c>string</c>, <c>text</c>, <c>datetime</c>, <c>timestamp</c>, <c>decimal</c>, and <c>binary</c>. The supported data types depend on the destination data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("DestinationDataType")]
                [Validation(Required=false)]
                public string DestinationDataType { get; set; }

                /// <summary>
                /// <para>The source data type. Examples: <c>bigint</c>, <c>boolean</c>, <c>string</c>, <c>text</c>, <c>datetime</c>, <c>timestamp</c>, <c>decimal</c>, and <c>binary</c>. The supported data types depend on the source data source.</para>
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
            /// <para>An array of DDL handling settings.</para>
            /// <remarks>
            /// <para>[&quot;DDLHandlingSettings&quot;:[ { &quot;Type&quot;:&quot;Insert&quot;, &quot;Action&quot;:&quot;Normal&quot; } ]</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DdlHandlingSettings")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestJobSettingsDdlHandlingSettings> DdlHandlingSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsDdlHandlingSettings : TeaModel {
                /// <summary>
                /// <para>The handling action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Ignore</c>: Ignores the DDL message.</para>
                /// </description></item>
                /// <item><description><para><c>Critical</c>: Reports an error and terminates the synchronization job.</para>
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
                /// <item><description><para><c>DropColumn</c></para>
                /// </description></item>
                /// <item><description><para><c>AddColumn</c></para>
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
            public List<UpdateDIJobRequestJobSettingsRuntimeSettings> RuntimeSettings { get; set; }
            public class UpdateDIJobRequestJobSettingsRuntimeSettings : TeaModel {
                /// <summary>
                /// <para>The name of the setting. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>src.offline.datasource.max.connection</c>: The maximum number of concurrent connections to the source for an offline synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>dst.offline.truncate</c>: Specifies whether to truncate the destination table before an offline synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.offline.speed.limit.enable</c>: Specifies whether to enable speed limiting for an offline synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.offline.concurrent</c>: The concurrency level for an offline synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.enable.auto.create.schema</c>: Specifies whether to automatically create a schema at the destination.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.realtime.concurrent</c>: The concurrency level for a real-time synchronization job.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.realtime.failover.minute.dataxcdc</c>: The number of minutes to wait before a failover retry.</para>
                /// </description></item>
                /// <item><description><para><c>runtime.realtime.failover.times.dataxcdc</c>: The number of failover retries.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>src.offline.datasource.max.connection</para>
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
        /// <para>The owner of the synchronization job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95279527</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can call the <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> operation to get the workspace ID.</para>
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
            /// <para>The resource settings for the offline synchronization job.</para>
            /// </summary>
            [NameInMap("OfflineResourceSettings")]
            [Validation(Required=false)]
            public UpdateDIJobRequestResourceSettingsOfflineResourceSettings OfflineResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsOfflineResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs for the Data Integration resource group used by the offline synchronization job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the Data Integration resource group used by the offline synchronization job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
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
            public UpdateDIJobRequestResourceSettingsRealtimeResourceSettings RealtimeResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsRealtimeResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs for the Data Integration resource group used by the real-time synchronization job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the Data Integration resource group used by the real-time synchronization job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>S_res_group_111_222</para>
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
            public UpdateDIJobRequestResourceSettingsScheduleResourceSettings ScheduleResourceSettings { get; set; }
            public class UpdateDIJobRequestResourceSettingsScheduleResourceSettings : TeaModel {
                /// <summary>
                /// <para>The number of CUs for the scheduling resource group used by the offline synchronization job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RequestedCu")]
                [Validation(Required=false)]
                public double? RequestedCu { get; set; }

                /// <summary>
                /// <para>The name of the scheduling resource group used by the offline synchronization job.</para>
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
        /// <para>A list of object transformation mappings. Each mapping specifies a set of selection rules for source objects and a list of transformation rules that apply to the selected objects.</para>
        /// <remarks>
        /// <para>[ { &quot;SourceObjectSelectionRules&quot;:[ { &quot;ObjectType&quot;:&quot;Database&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;biz_db&quot; }, { &quot;ObjectType&quot;:&quot;Schema&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;s1&quot; }, { &quot;ObjectType&quot;:&quot;Table&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;table1&quot; } ], &quot;TransformationRuleNames&quot;:[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot; } ] } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTableMappings> TableMappings { get; set; }
        public class UpdateDIJobRequestTableMappings : TeaModel {
            /// <summary>
            /// <para>The rules for selecting source objects. Each rule can select a different type of source object to synchronize, such as a source database or table.</para>
            /// </summary>
            [NameInMap("SourceObjectSelectionRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsSourceObjectSelectionRules> SourceObjectSelectionRules { get; set; }
            public class UpdateDIJobRequestTableMappingsSourceObjectSelectionRules : TeaModel {
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
                /// <para>The type of the expression. Valid values: <c>Exact</c> and <c>Regex</c>.</para>
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
                /// <item><description><para><c>Table</c> (table)</para>
                /// </description></item>
                /// <item><description><para><c>Schema</c> (schema)</para>
                /// </description></item>
                /// <item><description><para><c>Database</c> (database)</para>
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
            /// <para>The transformation rules for the source objects.</para>
            /// </summary>
            [NameInMap("TransformationRules")]
            [Validation(Required=false)]
            public List<UpdateDIJobRequestTableMappingsTransformationRules> TransformationRules { get; set; }
            public class UpdateDIJobRequestTableMappingsTransformationRules : TeaModel {
                /// <summary>
                /// <para>The type of the action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>DefinePrimaryKey</c>: Defines a primary key.</para>
                /// </description></item>
                /// <item><description><para><c>Rename</c>: Renames an object.</para>
                /// </description></item>
                /// <item><description><para><c>AddColumn</c>: Adds a column.</para>
                /// </description></item>
                /// <item><description><para><c>HandleDml</c>: Handles DML operations.</para>
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
                /// <para>The name of the transformation rule. The name must be unique for a specific combination of <c>RuleActionType</c> and <c>RuleTargetType</c> and can be up to 50 characters long.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rename_rule_1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The type of the target object. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>Table</c> (table)</para>
                /// </description></item>
                /// <item><description><para><c>Schema</c> (schema)</para>
                /// </description></item>
                /// <item><description><para><c>Database</c> (database)</para>
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
        /// <para>A list of transformation rule definitions.</para>
        /// <remarks>
        /// <para>[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot;, &quot;RuleExpression&quot;:&quot;{&quot;expression&quot;:&quot;${srcDatasoureName}_${srcDatabaseName}&quot;}&quot; } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public List<UpdateDIJobRequestTransformationRules> TransformationRules { get; set; }
        public class UpdateDIJobRequestTransformationRules : TeaModel {
            /// <summary>
            /// <para>The type of the action. Valid values:</para>
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
            /// <item><description>Rename rule (<c>Rename</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;expression&quot;:&quot;${srcDatasourceName}_${srcDatabaseName}_0922&quot;}</c></para>
            /// </description></item>
            /// <item><description><para><c>expression</c>: The expression for the rename transformation rule. The expression supports variables, including <c>${srcDatasourceName}</c> (source data source name), <c>${srcDatabaseName}</c> (source database name), and <c>${srcTableName}</c> (source table name).</para>
            /// </description></item>
            /// </list>
            /// <ol start="2">
            /// <item><description>Add column rule (<c>AddColumn</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;columns&quot;:[{&quot;columnName&quot;:&quot;my_add_column&quot;,&quot;columnValueType&quot;:&quot;Constant&quot;,&quot;columnValue&quot;:&quot;123&quot;}]}</c></para>
            /// </description></item>
            /// <item><description><para>If this rule is not specified, no columns are added.</para>
            /// </description></item>
            /// <item><description><para><c>columnName</c>: The name of the column to add.</para>
            /// </description></item>
            /// <item><description><para><c>columnValueType</c>: The value type of the added column. Valid values: <c>Constant</c> and <c>Variable</c>.</para>
            /// </description></item>
            /// <item><description><para><c>columnValue</c>: The value of the added column. If <c>columnValueType</c> is <c>Constant</c>, the value is a custom constant of the string type. If <c>columnValueType</c> is <c>Variable</c>, the value is a built-in variable. Valid built-in variables: <c>EXECUTE_TIME</c> (execution time, Long type), <c>DB_NAME_SRC</c> (source database name, String type), <c>DATASOURCE_NAME_SRC</c> (source data source name, String type), <c>TABLE_NAME_SRC</c> (source table name, String type), <c>DB_NAME_DEST</c> (destination database name, String type), <c>DATASOURCE_NAME_DEST</c> (destination data source name, String type), <c>TABLE_NAME_DEST</c> (destination table name, String type), and <c>DB_NAME_SRC_TRANSED</c> (transformed database name, String type).</para>
            /// </description></item>
            /// </list>
            /// <ol start="3">
            /// <item><description>Define primary key rule (<c>DefinePrimaryKey</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;columns&quot;:[&quot;ukcolumn1&quot;,&quot;ukcolumn2&quot;]}</c></para>
            /// </description></item>
            /// <item><description><para>If this rule is not specified, the primary key of the source is used by default.</para>
            /// </description></item>
            /// <item><description><para>Data Integration does not modify the structure of an existing destination table. If a specified primary key column does not exist in the table, the synchronization job fails.</para>
            /// </description></item>
            /// <item><description><para>When a destination table is automatically created, Data Integration includes the defined primary key columns in the structure. If a specified primary key column is not in the destination column set, the synchronization job fails.</para>
            /// </description></item>
            /// </list>
            /// <ol start="4">
            /// <item><description>DML handling rule (<c>HandleDml</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;dmlPolicies&quot;:[{&quot;dmlType&quot;:&quot;Delete&quot;,&quot;dmlAction&quot;:&quot;Filter&quot;,&quot;filterCondition&quot;:&quot;id &gt; 1&quot;}]}</c></para>
            /// </description></item>
            /// <item><description><para>If this rule is not specified, the default action for <c>Insert</c>, <c>Update</c>, and <c>Delete</c> operations is <c>Normal</c>.</para>
            /// </description></item>
            /// <item><description><para><c>dmlType</c>: The DML operation type. Valid values: <c>Insert</c>, <c>Update</c>, and <c>Delete</c>.</para>
            /// </description></item>
            /// <item><description><para><c>dmlAction</c>: The DML handling policy. Valid values: <c>Normal</c> (process the operation), <c>Ignore</c> (ignore the operation), <c>Filter</c> (conditionally process the operation, used when <c>dmlType</c> is <c>Update</c> or <c>Delete</c>), and <c>LogicalDelete</c> (perform a logical delete).</para>
            /// </description></item>
            /// <item><description><para><c>filterCondition</c>: The DML filter condition, used when <c>dmlAction</c> is <c>Filter</c>.</para>
            /// </description></item>
            /// </list>
            /// <ol start="5">
            /// <item><description>Incremental condition rule (<c>DefineIncrementalCondition</c>)</description></item>
            /// </ol>
            /// <list type="bullet">
            /// <item><description><para>Example: <c>{&quot;where&quot;:&quot;id &gt; 0&quot;}</c></para>
            /// </description></item>
            /// <item><description><para>The <c>WHERE</c> clause for the incremental condition.</para>
            /// </description></item>
            /// </list>
            /// <ol start="6">
            /// <item><description>Periodic scheduling rule (<c>DefineCycleScheduleSettings</c>)</description></item>
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
            /// <para>The name of the transformation rule. The name must be unique for a specific combination of <c>RuleActionType</c> and <c>RuleTargetType</c> and can be up to 50 characters long.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rename_rule_1</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The type of the target object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Table</c> (table)</para>
            /// </description></item>
            /// <item><description><para><c>Schema</c> (schema)</para>
            /// </description></item>
            /// <item><description><para><c>Database</c> (database)</para>
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
