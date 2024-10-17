// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>An array that consists of tables.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeTablesResponseBodyItems> Items { get; set; }
        public class DescribeTablesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The point in time when the table was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The ID of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>222</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The description of the data asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description 1</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The ID of the data asset to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the data asset to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Data Asset 1</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gxdata</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtdep-239-******</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The name of the service to which the table belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>. For more information about the types of data assets from which DSC can scan for sensitive data, see <a href="https://help.aliyun.com/document_detail/212906.html">Supported data assets</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the service to which the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The sensitivity level of the table. Each sensitivity level ID corresponds to a sensitivity level name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
            /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
            /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
            /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
            /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level for the table. Valid values:</para>
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
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The information about the sensitive data detection rules that are hit.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeTablesResponseBodyItemsRuleList> RuleList { get; set; }
            public class DescribeTablesResponseBodyItemsRuleList : TeaModel {
                /// <summary>
                /// <para>The total number of rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The name of the rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Rule name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The sensitivity level of the sensitive data that hits the sensitive data detection rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
                /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
                /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
                /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
                /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the table contains sensitive fields. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The total number of sensitive fields in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The percentage of sensitive fields in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>21%</para>
            /// </summary>
            [NameInMap("SensitiveRatio")]
            [Validation(Required=false)]
            public string SensitiveRatio { get; set; }

            /// <summary>
            /// <para>The name of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tenant 1</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The total number of fields in the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
