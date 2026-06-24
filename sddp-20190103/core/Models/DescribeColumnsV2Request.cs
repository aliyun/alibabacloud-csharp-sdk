// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsV2Request : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The type of the database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>MariaDB</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>SQLServer</b></para>
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
        /// <para>The ID of the data asset instance to which the data in the column belongs.</para>
        /// <remarks>
        /// <para>Query data in columns of a data asset table based on the ID of the data asset instance. The data asset table must be authorized in Data Security Center. To obtain the ID of the data asset instance, call the <a href="https://help.aliyun.com/document_detail/141708.html">DescribeInstances</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the data asset instance to which the data in the column belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp17t1htja573l5i8****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Simplified Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English</para>
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
        /// <para>The keyword for the search. Fuzzy match is supported.</para>
        /// <para>For example, if you enter <b>test</b>, all data that contains <b>test</b> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the product to which the data in the column of the data asset table belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The ID of the risk level for the sensitive data detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: N/A</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: S1</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4</para>
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
        /// <para>The unique ID of the sensitive data detection rule that is hit by the data in the column.</para>
        /// <remarks>
        /// <para>Query data in columns of a data asset table based on the ID of the sensitive data detection rule that is hit. The data asset table must be authorized in Data Security Center. To obtain the ID of the sensitive data detection rule, call the <a href="https://help.aliyun.com/document_detail/141389.html">DescribeRules</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11122200</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the sensitive data detection rule that is hit by the data in the column.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The name of the sensitivity level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>N/A</b>: No sensitive data is detected.</para>
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
        /// <para>The unique ID of the data asset table that contains the column. The table can be in a data asset such as MaxCompute or RDS.</para>
        /// <remarks>
        /// <para>Query data in columns of a data asset table by the table ID. The data asset table must be authorized in Data Security Center. To obtain the ID of the data asset table, call the <a href="https://help.aliyun.com/document_detail/141709.html">DescribeTables</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11132334</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>The name of the data asset table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>it_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
