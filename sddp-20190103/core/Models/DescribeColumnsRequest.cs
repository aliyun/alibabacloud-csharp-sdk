// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsRequest : TeaModel {
        /// <summary>
        /// <para>The page number for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The database engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The ID of the asset instance to which the column data in the data asset table belongs.</para>
        /// <remarks>
        /// <para>Queries column data in data asset tables authorized for connection by Data Security Center based on the asset instance ID. You can call the <a href="~~DescribeRules~~">DescribeInstances</a> operation to obtain the instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the asset instance to which the column data in the data asset table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp17t1htja573l5i8****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese.</description></item>
        /// <item><description><b>en_us</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The data tag.</para>
        /// <list type="bullet">
        /// <item><description><para>101: personal sensitive information</para>
        /// </description></item>
        /// <item><description><para>102: personal information</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ModelTagId")]
        [Validation(Required=false)]
        public string ModelTagId { get; set; }

        /// <summary>
        /// <para>The keyword to search for. Fuzzy match is supported.</para>
        /// <para>For example, if you enter <b>test</b>, all data entries that contain <b>test</b> in the search fields are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the product to which the column data in the data asset table belongs. Valid values: <b>MaxCompute, OSS, ADS, OTS, RDS</b>, and others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID that corresponds to the product name to which the data object belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute</description></item>
        /// <item><description><b>2</b>: OSS</description></item>
        /// <item><description><b>3</b>: ADB-MYSQL</description></item>
        /// <item><description><b>4</b>: TableStore</description></item>
        /// <item><description><b>5</b>: RDS</description></item>
        /// <item><description><b>6</b>: SELF_DB</description></item>
        /// <item><description><b>7</b>: PolarDB-X</description></item>
        /// <item><description><b>8</b>: PolarDB</description></item>
        /// <item><description><b>9</b>: ADB-PG</description></item>
        /// <item><description><b>10</b>: OceanBase</description></item>
        /// <item><description><b>11</b>: MongoDB</description></item>
        /// <item><description><b>25</b>: Redis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The risk level ID of the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: N/A.</description></item>
        /// <item><description><b>2</b>: S1.</description></item>
        /// <item><description><b>3</b>: S2.</description></item>
        /// <item><description><b>4</b>: S3.</description></item>
        /// <item><description><b>5</b>: S4.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The unique ID of the sensitive data detection rule that the column data matches.</para>
        /// <remarks>
        /// <para>Queries column data in data asset tables authorized for connection by Data Security Center based on the ID of the sensitive data detection rule that the column data matches. You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation to obtain the rule ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the sensitive data detection rule that the column data in the data asset table matches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The sensitivity level name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>N/A</b>: No sensitive data is detected.</description></item>
        /// <item><description><b>S1</b>: Level-1 sensitive data.</description></item>
        /// <item><description><b>S2</b>: Level-2 sensitive data.</description></item>
        /// <item><description><b>S3</b>: Level-3 sensitive data.</description></item>
        /// <item><description><b>S4</b>: Level-4 sensitive data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>S2</para>
        /// </summary>
        [NameInMap("SensLevelName")]
        [Validation(Required=false)]
        public string SensLevelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-zhangjiakou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The unique ID of the data asset table to which the columns belong in MaxCompute, ApsaraDB RDS, or other assets.</para>
        /// <remarks>
        /// <para>Queries column data in data asset tables authorized for connection by Data Security Center based on the table ID. You can call the <a href="~~DescribeTables~~">DescribeTables</a> operation to obtain the table ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11132334</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        /// <summary>
        /// <para>The name of the data asset table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>it_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The industry template ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2399296.html">DescribeCategoryTemplateList</a> operation to obtain the industry template ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the matched template rule.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/410143.html">DescribeCategoryTemplateRuleList</a> operation to obtain the matched template rule ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1542</para>
        /// </summary>
        [NameInMap("TemplateRuleId")]
        [Validation(Required=false)]
        public string TemplateRuleId { get; set; }

    }

}
