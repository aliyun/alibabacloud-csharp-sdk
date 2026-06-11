// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateCustomAgentShrinkRequest : TeaModel {
        [NameInMap("CallbackConfig")]
        [Validation(Required=false)]
        public string CallbackConfigShrink { get; set; }

        /// <summary>
        /// <para>The ID of the DMS unit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <para>The data range, specified as a <b>JSON string</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>General parameters</para>
        /// <list type="bullet">
        /// <item><description><para><c>tableFlag</c>: Set to <c>true</c> to specify a data range.</para>
        /// </description></item>
        /// <item><description><para><c>scope</c>: The value must be <c>personal</c>.</para>
        /// </description></item>
        /// <item><description><para><c>personal</c>: Contains the parameters for a file or database.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para><b>File type</b>: Use the following parameters.</para>
        /// <list type="bullet">
        /// <item><description><para><c>DataSourceType</c>: The value must be <c>remote_data_center</c>.</para>
        /// </description></item>
        /// <item><description><para><c>FileId</c>: The ID of the file.</para>
        /// </description></item>
        /// <item><description><para><c>Database</c>: The name of the database returned by the <c>ListDataCenterTable</c> operation. This is typically the file name.</para>
        /// </description></item>
        /// <item><description><para><c>Tables</c>: The names of the tables returned by the <c>ListDataCenterTable</c> operation.</para>
        /// </description></item>
        /// <item><description><para><c>TableIds</c>: The table IDs returned by the <c>ListDataCenterTable</c> operation.</para>
        /// </description></item>
        /// <item><description><para><c>RegionId</c>: The current region.</para>
        /// </description></item>
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
        /// <para><b>Database type</b>: Use the following parameters.</para>
        /// <list type="bullet">
        /// <item><description><para><c>DataSourceType</c>: The value must be <c>database</c>.</para>
        /// </description></item>
        /// <item><description><para><c>DmsInstanceId</c>: The ID of the DMS instance returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>DmsDatabaseId</c>: The ID of the DMS database returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>FileId</c>: The instance name. This parameter is deprecated.</para>
        /// </description></item>
        /// <item><description><para><c>DbName</c>: The name of the database returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>Database</c>: The name of the database returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>Tables</c>: The names of the tables returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>TableIds</c>: The table IDs returned by the data center API.</para>
        /// </description></item>
        /// <item><description><para><c>Engine</c>: The database engine. Valid values: <c>mysql</c> and <c>postgresql</c>.</para>
        /// </description></item>
        /// <item><description><para><c>RegionId</c>: The current region.</para>
        /// </description></item>
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
        ///     &quot;Database&quot; : &quot;测试表格</b></b></b>.xlsx&quot;,
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
        /// <para>Agent测试描述</para>
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
        /// <para>The instruction for the custom agent.</para>
        /// <list type="bullet">
        /// <item><description>Maximum length: 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>核心指标定义：
        /// 1、GMV（成交总额）指订单金额总和，含已支付及未支付成功订单；
        /// 2、订单量为每日有效下单笔数；
        /// 3、UV（独立访客）指访问网站或APP的去重用户数；
        /// 4、转化率=支付订单数 / UV，反映流量转化效率；</para>
        /// </summary>
        [NameInMap("Instruction")]
        [Validation(Required=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// <para>The knowledge for the custom agent.</para>
        /// <list type="bullet">
        /// <item><description>Maximum length: 10,000 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>核心指标定义：
        /// 1、GMV（成交总额）指订单金额总和，含已支付及未支付成功订单；
        /// 2、订单量为每日有效下单笔数；
        /// 3、UV（独立访客）指访问网站或APP的去重用户数；
        /// 4、转化率=支付订单数 / UV，反映流量转化效率；</para>
        /// </summary>
        [NameInMap("Knowledge")]
        [Validation(Required=false)]
        public string Knowledge { get; set; }

        /// <summary>
        /// <para>A list of external knowledge bases.</para>
        /// </summary>
        [NameInMap("KnowledgeConfigList")]
        [Validation(Required=false)]
        public string KnowledgeConfigListShrink { get; set; }

        /// <summary>
        /// <para>The name of the custom agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent测试名称</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RelatedSessionId")]
        [Validation(Required=false)]
        public string RelatedSessionId { get; set; }

        /// <summary>
        /// <para>The configuration for the scheduled task.</para>
        /// </summary>
        [NameInMap("ScheduleTaskConfig")]
        [Validation(Required=false)]
        public string ScheduleTaskConfigShrink { get; set; }

        /// <summary>
        /// <para>The formatting requirements for the text report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文字报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
        /// </summary>
        [NameInMap("TextReportConfig")]
        [Validation(Required=false)]
        public string TextReportConfig { get; set; }

        /// <summary>
        /// <para>The formatting requirements for the web report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>网页报告要求所有数字不使用阿拉伯数字，全部转为中文数字</para>
        /// </summary>
        [NameInMap("WebReportConfig")]
        [Validation(Required=false)]
        public string WebReportConfig { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56kv1pvl9uvt9**********bb</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
