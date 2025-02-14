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

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which data in the column of the table belongs.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/141708.html">DescribeInstances</a> operation to obtain the ID of the instance to which the data in the column of the table belongs.</para>
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
        /// <item><description><b>zh_cn</b>: simplified Chinese</description></item>
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
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
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
        /// <para>The ID of the sensitivity level of the data that hits the sensitive data detection rule. Valid values:</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/141389.html">DescribeRules</a> operation to obtain the ID of the sensitive data detection rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11122200</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the sensitive data detection rule that data in the column of the table hits.</para>
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
        /// <item><description><b>N/A</b>: indicates that no sensitive data is detected.</description></item>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/141709.html">DescribeTables</a> operation to obtain the ID of the table.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>11132334</para>
        /// </summary>
        [NameInMap("TableId")]
        [Validation(Required=false)]
        public string TableId { get; set; }

        /// <summary>
        /// <para>The name of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>it_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
