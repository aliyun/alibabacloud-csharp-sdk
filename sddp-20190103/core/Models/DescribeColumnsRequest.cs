// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsRequest : TeaModel {
        /// <summary>
        /// <para>The page number for paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Engine type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b>.</para>
        /// </description></item>
        /// <item><description><para><b>MariaDB</b>.</para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b>.</para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b>.</para>
        /// </description></item>
        /// <item><description><para><b>SQLServer</b>.</para>
        /// </description></item>
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
        /// <para>Query column data in data asset tables authorized to connect to Data Security Center using the ID of the asset instance to which the column data in the data asset table belongs. Obtain the asset instance ID by calling the <a href="~~DescribeRules~~">DescribeInstances</a> API.</para>
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
        /// <para>The language type for requests and responses. The default value is <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Data tag.</para>
        /// <list type="bullet">
        /// <item><description><para>101: Personal sensitive information</para>
        /// </description></item>
        /// <item><description><para>102: Personal information</para>
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
        /// <para>The keyword for search. Supports fuzzy match.</para>
        /// <para>For example, entering <b>test</b> returns all data containing <b>test</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of data entries displayed per page in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The product name to which the column data in the data asset table belongs. Valid values: <b>MaxCompute, OSS, ADS, OTS, RDS</b>, and others.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID corresponding to the product name to which the data object belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: MaxCompute</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: OSS</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: ADB-MYSQL</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: TableStore</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: RDS</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: SELF_DB</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: PolarDB-X</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: PolarDB</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: ADB-PG</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: OceanBase</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: MongoDB</para>
        /// </description></item>
        /// <item><description><para><b>25</b>: Redis</para>
        /// </description></item>
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
        /// <item><description><para><b>1</b>: N/A.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: S1.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The unique ID of the sensitive data detection rule hit by the column data in the asset table.</para>
        /// <remarks>
        /// <para>Query column data in data asset tables authorized to connect to Data Security Center using the ID of the sensitive data detection rule hit by the column data in the asset table. Obtain the sensitive data detection rule ID by calling the <a href="~~DescribeRules~~">DescribeRules</a> API.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the sensitive data detection rule hit by the column data in the data asset table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Sensitivity level name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>N/A</b>: No sensitive data detected.</para>
        /// </description></item>
        /// <item><description><para><b>S1</b>: Level 1 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>S2</b>: Level 2 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>S3</b>: Level 3 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>S4</b>: Level 4 sensitive data.</para>
        /// </description></item>
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
        /// <para>The unique ID of the asset table that contains the columns in data asset tables such as MaxCompute and RDS.</para>
        /// <remarks>
        /// <para>Query column data in data asset tables authorized to connect to Data Security Center using the asset table ID. Obtain the asset table ID by calling the <a href="~~DescribeTables~~">DescribeTables</a> API.</para>
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
        /// <para>Industry template ID.</para>
        /// <remarks>
        /// <para>Obtain the industry template ID by calling <a href="https://help.aliyun.com/document_detail/2399296.html">DescribeCategoryTemplateList</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the hit template rule.</para>
        /// <remarks>
        /// <para>Obtain the hit template rule ID by calling <a href="https://help.aliyun.com/document_detail/410143.html">DescribeCategoryTemplateRuleList</a>.</para>
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
