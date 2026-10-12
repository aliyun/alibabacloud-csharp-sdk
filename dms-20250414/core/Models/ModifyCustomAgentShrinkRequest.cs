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
        /// <para>The ID of the custom agent.</para>
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
        /// <para>The specified data scope in <b>JSON character string format</b>.</para>
        /// <list type="bullet">
        /// <item><description>General parameter description<list type="bullet">
        /// <item><description>tableFlag: true specifies the data scope.</description></item>
        /// <item><description>scope: personal is a fixed value.</description></item>
        /// <item><description>personal: parameters for file and database types.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>File type</b>: pass parameters in the following format:</para>
        /// <list type="bullet">
        /// <item><description>DataSourceType: remote_data_center is a fixed value.</description></item>
        /// <item><description>FileId: the file ID.</description></item>
        /// <item><description>Database: the database name returned by the ListDataCenterTable operation, which is usually the file name.</description></item>
        /// <item><description>Tables: the table names returned by the ListDataCenterTable operation.</description></item>
        /// <item><description>TableIds: the table IDs returned by the ListDataCenterTable operation.</description></item>
        /// <item><description>RegionId: the current region.</description></item>
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
        /// <para><b>Database type</b>: pass parameters as follows:</para>
        /// <list type="bullet">
        /// <item><description>DataSourceType: database is a fixed value.</description></item>
        /// <item><description>DmsInstanceId: the DMS instance ID returned by the Data Center operation.</description></item>
        /// <item><description>DmsDatabaseId: the DMS database ID returned by the Data Center operation.</description></item>
        /// <item><description>FileId: the instance name. <b>[Deprecated]</b></description></item>
        /// <item><description>DbName: the database name returned by the Data Center operation.</description></item>
        /// <item><description>Database: the database name returned by the Data Center operation.</description></item>
        /// <item><description>Tables: the table names returned by the Data Center operation.</description></item>
        /// <item><description>TableIds: the table IDs returned by the Data Center operation.</description></item>
        /// <item><description>Engine: the engine type, such as mysql or postgresql.</description></item>
        /// <item><description>RegionId: the current region.</description></item>
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
        ///     &quot;Database&quot; : &quot;Test_spreadsheet</b></b></b>.xlsx&quot;,
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
        /// <para>Agent test description</para>
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
        /// <para>The instructions.</para>
        /// <list type="bullet">
        /// <item><description>Input limit: up to 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Analysis framework:</para>
        /// <ol>
        /// <item><description>Monitor core metrics (GMV, order volume, UV, and conversion rate) on a daily, weekly, and monthly basis, and analyze trend changes as well as year-over-year and month-over-month fluctuations.</description></item>
        /// <item><description>Segment data by new and returning customers, channels, and regions to identify growth drivers and weaknesses.</description></item>
        /// <item><description>Conduct funnel analysis based on user behavior paths (browse -&gt; add to cart -&gt; pay) to locate churn points</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("Instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>The knowledge.</para>
        /// <list type="bullet">
        /// <item><description>Input limit: up to 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Core metric definitions:</para>
        /// <ol>
        /// <item><description>GMV (Gross Merchandise Volume) refers to the total order amount, including both successfully paid and unpaid orders.</description></item>
        /// <item><description>Order volume refers to the number of valid orders placed per day.</description></item>
        /// <item><description>UV (Unique Visitors) refers to the number of deduplicated users who visit the website or app.</description></item>
        /// <item><description>Conversion rate = Number of paid orders / UV, reflecting the traffic conversion efficiency</description></item>
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
        /// <para>Agent test name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the referenced historical session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ski-sldk8v******3owd</para>
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
        /// <list type="bullet">
        /// <item><description>Input limit: up to 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Require all numbers in the text report to be written in Chinese characters instead of Arabic numerals</para>
        /// </summary>
        [NameInMap("TextReportConfig")]
        [Validation(Required=false)]
        public string TextReportConfig { get; set; }

        /// <summary>
        /// <para>The list of user-specified skills.</para>
        /// </summary>
        [NameInMap("UserSpecifiedSkillList")]
        [Validation(Required=false)]
        public string UserSpecifiedSkillListShrink { get; set; }

        /// <summary>
        /// <para>The web report format.</para>
        /// <list type="bullet">
        /// <item><description>Input limit: up to 50,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Require all numbers in the web report to be written in Chinese characters instead of Arabic numerals</para>
        /// </summary>
        [NameInMap("WebReportConfig")]
        [Validation(Required=false)]
        public string WebReportConfig { get; set; }

        /// <summary>
        /// <para>The web report theme. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>default: default.</description></item>
        /// <item><description>journal: journal.</description></item>
        /// <item><description>legacy: classic.</description></item>
        /// <item><description>neobrutalism: stylized.</description></item>
        /// <item><description>infographic: infographic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
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
