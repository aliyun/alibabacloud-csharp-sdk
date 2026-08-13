// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ModifyCustomAgentShrinkRequest : TeaModel {
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public string CallbackConfigShrink { get; set; }

        /// <summary>
        /// <para>The custom agent ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca-4y3ca4khkcu**********ysf</para>
        /// </summary>
        [NameInMap("CustomAgentId")]
        [Validation(Required=false)]
        public string CustomAgentId { get; set; }

        /// <summary>
        /// <para>The current DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The specified data scope in <b>JSON string format</b>.</para>
        /// <list type="bullet">
        /// <item><description>Common parameter description<list type="bullet">
        /// <item><description>tableFlag: true indicates a specified data scope</description></item>
        /// <item><description>scope: personal is a fixed value</description></item>
        /// <item><description>personal: pass parameters for file or database types</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>File type</b>. Pass parameters in the following format:</para>
        /// <list type="bullet">
        /// <item><description>DataSourceType: remote_data_center is a fixed value</description></item>
        /// <item><description>FileId: the file ID</description></item>
        /// <item><description>Database: the database name returned by the ListDataCenterTable operation, which is usually the file name</description></item>
        /// <item><description>Tables: the table name returned by the ListDataCenterTable operation</description></item>
        /// <item><description>TableIds: the TableId returned by the ListDataCenterTable operation</description></item>
        /// <item><description>RegionId: the current region</description></item>
        /// </list>
        /// <pre><c>{
        ///   &quot;tableFlag&quot;: true,
        ///   &quot;scope&quot;: &quot;personal&quot;,
        ///   &quot;personal&quot;: {
        ///     &quot;DataSourceType&quot;: &quot;remote_data_center&quot;,
        ///     &quot;FileId&quot;: &quot;f-f0jksn001ibmkoo********6v2zn6&quot;,
        ///     &quot;Database&quot;: &quot;diamonds.csv&quot;,
        ///     &quot;Tables&quot;: [
        ///       &quot;diamonds&quot;
        ///     ],
        ///     &quot;TableIds&quot;: [
        ///       &quot;35hfn94pxl********50pi&quot;
        ///     ],
        ///     &quot;RegionId&quot;: &quot;cn-hangzhou&quot;
        ///   }
        /// }
        /// </c></pre>
        /// <para><b>Database type</b>. Pass parameters in the following format:</para>
        /// <list type="bullet">
        /// <item><description>DataSourceType: database is a fixed value</description></item>
        /// <item><description>DmsInstanceId: the DMS instance ID returned by the data center operation</description></item>
        /// <item><description>DmsDatabaseId: the DMS database ID returned by the data center operation</description></item>
        /// <item><description>FileId: the instance name (deprecated)</description></item>
        /// <item><description>DbName: the database name returned by the data center operation</description></item>
        /// <item><description>Database: the database name returned by the data center operation</description></item>
        /// <item><description>Tables: the table name returned by the data center operation</description></item>
        /// <item><description>TableIds: the TableId returned by the data center operation</description></item>
        /// <item><description>Engine: the engine type (mysql or postgresql)</description></item>
        /// <item><description>RegionId: the current region</description></item>
        /// </list>
        /// <pre><c>{
        ///   &quot;tableFlag&quot;: true,
        ///   &quot;scope&quot;: &quot;personal&quot;,
        ///   &quot;personal&quot;: {
        ///     &quot;DataSourceType&quot;: &quot;database&quot;,
        ///     &quot;DmsInstanceId&quot;: &quot;284***8&quot;,
        ///     &quot;DmsDatabaseId&quot;: &quot;769***45&quot;,
        ///     &quot;FileId&quot;: &quot;pgm-bp15095e*******6t&quot;,
        ///     &quot;DbName&quot;: &quot;pg_catalog&quot;,
        ///     &quot;Database&quot;: &quot;pg_catalog&quot;,
        ///     &quot;Tables&quot;: [
        ///       &quot;pg_aggregate&quot;
        ///     ],
        ///     &quot;TableIds&quot;: [
        ///       &quot;5263****31&quot;
        ///     ],
        ///     &quot;Engine&quot;: &quot;postgresql&quot;,
        ///     &quot;RegionId&quot;: &quot;cn-hangzhou&quot;
        ///   }
        /// }
        /// </c></pre>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;tableFlag&quot; : true,
        ///   &quot;scope&quot; : &quot;personal&quot;,
        ///   &quot;personal&quot; : {
        ///     &quot;DataSourceType&quot; : &quot;remote_data_center&quot;,
        ///     &quot;FileId&quot; : &quot;f-5qlrwaw10<b><b><b><b>s3gpw1z&quot;,
        ///     &quot;Database&quot; : &quot;TestTable</b></b></b>.xlsx&quot;,
        ///     &quot;Tables&quot; : [ &quot;Sheet1&quot; ],
        ///     &quot;TableIds&quot; : [ &quot;</b>****&quot; ],
        ///     &quot;RegionId&quot; : &quot;cn-hangzhou&quot;
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("DataJson")]
        [Validation(Required=false)]
        public string DataJson { get; set; }

        /// <summary>
        /// <para>The description of the custom agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentTestDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The execution configuration.</para>
        /// </summary>
        [NameInMap("ExecutionConfig")]
        [Validation(Required=false)]
        public string ExecutionConfigShrink { get; set; }

        /// <summary>
        /// <para>The instruction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Analysis framework:</para>
        /// </summary>
        [NameInMap("Instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>The knowledge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Core metric definitions:</para>
        /// <ol>
        /// <item><description>GMV (Gross Merchandise Volume) refers to the total order amount, including both paid and unpaid orders.</description></item>
        /// <item><description>Order volume is the number of valid orders placed per day.</description></item>
        /// <item><description>UV (Unique Visitors) refers to the deduplicated number of users who visit the website or app.</description></item>
        /// <item><description>Conversion rate = number of paid orders / UV, reflecting traffic conversion efficiency.</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <para>The external knowledge bases.</para>
        /// </summary>
        [NameInMap("KnowledgeConfigList")]
        [Validation(Required=false)]
        public string KnowledgeConfigListShrink { get; set; }

        [NameInMap("KnowledgeSemanticConfigList")]
        [Validation(Required=false)]
        public string KnowledgeSemanticConfigListShrink { get; set; }

        /// <summary>
        /// <para>The name of the custom agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AgentTestName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the referenced historical session.</para>
        /// </summary>
        [NameInMap("RelatedSessionId")]
        [Validation(Required=false)]
        public string RelatedSessionId { get; set; }

        /// <summary>
        /// <para>The scheduled task configuration.</para>
        /// </summary>
        [NameInMap("ScheduleTaskConfig")]
        [Validation(Required=false)]
        public string ScheduleTaskConfigShrink { get; set; }

        /// <summary>
        /// <para>The text report format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The text report requires all numbers to be written in Chinese characters instead of Arabic numerals</para>
        /// </summary>
        [NameInMap("TextReportConfig")]
        [Validation(Required=false)]
        public string TextReportConfig { get; set; }

        /// <summary>
        /// <para>The web report format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The web report requires all numbers to be written in Chinese characters instead of Arabic numerals</para>
        /// </summary>
        [NameInMap("WebReportConfig")]
        [Validation(Required=false)]
        public string WebReportConfig { get; set; }

        [NameInMap("WebReportTheme")]
        [Validation(Required=false)]
        public string WebReportTheme { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56kv1pvl9uvt9**********bb</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
