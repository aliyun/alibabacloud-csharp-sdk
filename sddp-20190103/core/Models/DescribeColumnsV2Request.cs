// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsV2Request : TeaModel {
        /// <summary>
        /// <para>When performing a paginated query, sets the current page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Engine type. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b>.</description></item>
        /// <item><description><b>MariaDB</b>.</description></item>
        /// <item><description><b>Oracle</b>.</description></item>
        /// <item><description><b>PostgreSQL</b>.</description></item>
        /// <item><description><b>SQLServer</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>ID of the asset instance to which the column data in the data asset table belongs.</para>
        /// <remarks>
        /// <para>Query the data in the columns of the data assets authorized by the Data Security Center based on the ID of the asset instance to which the column data in the data asset table belongs. The asset instance ID can be obtained by calling the <a href="https://help.aliyun.com/document_detail/141708.html">DescribeInstances</a> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>Name of the asset instance to which the column data in the data asset table belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp17t1htja573l5i8****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Sets the language type for requests and received messages, default is <b>zh_cn</b>.
        /// Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Simplified Chinese</description></item>
        /// <item><description><b>en_us</b>: English (United States)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Search keyword, supports fuzzy matching.</para>
        /// <para>For example, entering <b>test</b> will search for all data information containing <b>test</b> in the search items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>When performing a paginated query, sets the maximum number of data asset instances displayed per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Product name to which the column data in the data asset table belongs. Values: <b>MaxCompute, OSS, ADS, OTS, RDS</b>, etc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxCompute</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Risk level ID of the sensitive data recognition rule. Values:</para>
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
        /// <para>Unique identifier ID of the sensitive data recognition rule hit by the column data in the asset table.</para>
        /// <remarks>
        /// <para>Query the data in the columns of the data assets authorized by the Data Security Center based on the ID of the sensitive data recognition rule hit by the column data in the asset table. The sensitive data recognition rule ID can be obtained by calling the <a href="https://help.aliyun.com/document_detail/141389.html">DescribeRules</a> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11122200</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>Name of the sensitive data recognition rule hit by the column data in the data asset table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>Sensitive level name. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>N/A</b>: No sensitive data detected.</description></item>
        /// <item><description><b>S1</b>: Level 1 sensitive data.</description></item>
        /// <item><description><b>S2</b>: Level 2 sensitive data.</description></item>
        /// <item><description><b>S3</b>: Level 3 sensitive data.</description></item>
        /// <item><description><b>S4</b>: Level 4 sensitive data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>S2</para>
        /// </summary>
        [NameInMap("SensLevelName")]
        [Validation(Required=false)]
        public string SensLevelName { get; set; }

        /// <summary>
        /// <para>Unique identifier ID of the asset table to which the column in MaxCompute, RDS, etc., belongs.</para>
        /// <remarks>
        /// <para>Query the data in the columns of the data assets authorized by the Data Security Center based on the ID of the asset table. The asset table ID can be obtained by calling the <a href="https://help.aliyun.com/document_detail/141709.html">DescribeTables</a> interface.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11132334</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>Name of the data asset table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>it_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
