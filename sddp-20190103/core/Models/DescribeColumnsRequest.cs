// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The engine type. Valid values:</para>
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
        /// <para>The ID of the instance to which data in the column of the table belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeRules~~">DescribeInstances</a> operation to query the IDs of instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the instance to which data in the column of the table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp17t1htja573l5i8****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
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
        /// <item><description>101: personal sensitive information</description></item>
        /// <item><description>102: personal information</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("ModelTagId")]
        [Validation(Required=false)]
        public string ModelTagId { get; set; }

        /// <summary>
        /// <para>The search keyword. Fuzzy match is supported.</para>
        /// <para>For example, if you enter <b>test</b>, all columns whose names contain <b>test</b> are retrieved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the service to which data in the column of the table belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the data object belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: MaxCompute</description></item>
        /// <item><description><b>2</b>: Object Storage Service (OSS)</description></item>
        /// <item><description><b>3</b>: AnalyticDB for MySQL</description></item>
        /// <item><description><b>4</b>: Tablestore (OTS)</description></item>
        /// <item><description><b>5</b>: ApsaraDB RDS</description></item>
        /// <item><description><b>6</b>: self-managed database</description></item>
        /// <item><description><b>7</b>: PolarDB for Xscale (PolarDB-X)</description></item>
        /// <item><description><b>8</b>: PolarDB</description></item>
        /// <item><description><b>9</b>: AnalyticDB for PostgreSQL</description></item>
        /// <item><description><b>10</b>: ApsaraDB for OceanBase</description></item>
        /// <item><description><b>11</b>: ApsaraDB for MongoDB</description></item>
        /// <item><description><b>25</b>: ApsaraDB for Redis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the sensitive data that hits the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: N/A</description></item>
        /// <item><description><b>2</b>: S1</description></item>
        /// <item><description><b>3</b>: S2</description></item>
        /// <item><description><b>4</b>: S3</description></item>
        /// <item><description><b>5</b>: S4</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive data detection rule that data in the column of the table hits.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation to query the IDs of sensitive data detection rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the sensitive data detection rule that data in the column of the table hits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ID card number (the Chinese mainland)</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The name of the sensitivity level of the data that hits the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>N/A</b>: No sensitive data is detected.</description></item>
        /// <item><description><b>S1</b>: indicates the low sensitivity level.</description></item>
        /// <item><description><b>S2</b>: indicates the medium sensitivity level.</description></item>
        /// <item><description><b>S3</b>: indicates the high sensitivity level.</description></item>
        /// <item><description><b>S4</b>: indicates the highest sensitivity level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>S2</para>
        /// </summary>
        [NameInMap("SensLevelName")]
        [Validation(Required=false)]
        public string SensLevelName { get; set; }

        /// <summary>
        /// <para>The ID of the table to which the column belongs.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeTables~~">DescribeTables</a> operation to query the IDs of tables.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11132334</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public long? TableId { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>it_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the industry-specific classification template.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2399296.html">DescribeCategoryTemplateList</a> operation to obtain the IDs of industry-specific classification templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the template rule that is hit.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/410143.html">DescribeCategoryTemplateRuleList</a> operation to obtain the IDs of hit template rules.</para>
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
