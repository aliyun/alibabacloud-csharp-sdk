// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateDIJobShrinkRequest : TeaModel {
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
        public string JobSettingsShrink { get; set; }

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
        public string ResourceSettingsShrink { get; set; }

        /// <summary>
        /// <para>A list of object transformation mappings. Each mapping specifies a set of selection rules for source objects and a list of transformation rules that apply to the selected objects.</para>
        /// <remarks>
        /// <para>[ { &quot;SourceObjectSelectionRules&quot;:[ { &quot;ObjectType&quot;:&quot;Database&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;biz_db&quot; }, { &quot;ObjectType&quot;:&quot;Schema&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;s1&quot; }, { &quot;ObjectType&quot;:&quot;Table&quot;, &quot;Action&quot;:&quot;Include&quot;, &quot;ExpressionType&quot;:&quot;Exact&quot;, &quot;Expression&quot;:&quot;table1&quot; } ], &quot;TransformationRuleNames&quot;:[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot; } ] } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TableMappings")]
        [Validation(Required=false)]
        public string TableMappingsShrink { get; set; }

        /// <summary>
        /// <para>A list of transformation rule definitions.</para>
        /// <remarks>
        /// <para>[ { &quot;RuleName&quot;:&quot;my_database_rename_rule&quot;, &quot;RuleActionType&quot;:&quot;Rename&quot;, &quot;RuleTargetType&quot;:&quot;Schema&quot;, &quot;RuleExpression&quot;:&quot;{&quot;expression&quot;:&quot;${srcDatasoureName}_${srcDatabaseName}&quot;}&quot; } ]</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransformationRules")]
        [Validation(Required=false)]
        public string TransformationRulesShrink { get; set; }

    }

}
