// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectColumnDetailV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>Page number for paginated queries. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>List of recognition results for the columns in the data table.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataObjectColumnDetailV2ResponseBodyItems> Items { get; set; }
        public class DescribeDataObjectColumnDetailV2ResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>List of industry categories for sensitive data.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>Comment for the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>column comment</para>
            /// </summary>
            [NameInMap("ColumnComment")]
            [Validation(Required=false)]
            public string ColumnComment { get; set; }

            /// <summary>
            /// <para>Column name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hide14</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>Data type of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>Engine type. Values:</para>
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
            /// <para>Unique identifier ID of the data object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1392973973691383808</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Instance name of the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp17t1htja573l5i8****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>Column encryption status. Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>-1</b>: Not encrypted</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Encryption successful</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Encryption failed</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MaskingStatus")]
            [Validation(Required=false)]
            public int? MaskingStatus { get; set; }

            /// <summary>
            /// <para>List of data tags.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeDataObjectColumnDetailV2ResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeDataObjectColumnDetailV2ResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>ID corresponding to the data tag name. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>101</b>: Personal Sensitive Information.</description></item>
                /// <item><description><b>102</b>: Personal Information.</description></item>
                /// <item><description><b>107</b>: General Information.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Data tag name. Values:</para>
                /// <list type="bullet">
                /// <item><description>Personal Sensitive Information.</description></item>
                /// <item><description>Personal Information.</description></item>
                /// <item><description>General Information.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>personal sensitive information</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>Whether the column is a primary key. Value explanation:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Primary key.</description></item>
            /// <item><description><b>false</b>: Not a primary key.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public bool? PrimaryKey { get; set; }

            /// <summary>
            /// <para>ID corresponding to the product name of the data object. Values:</para>
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
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>Region where the asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Risk level ID. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A: No sensitive data detected.</description></item>
            /// <item><description><b>2</b>: S1: Level 1 sensitive data.</description></item>
            /// <item><description><b>3</b>: S2: Level 2 sensitive data.</description></item>
            /// <item><description><b>4</b>: S3: Level 3 sensitive data.</description></item>
            /// <item><description><b>5</b>: S4: Level 4 sensitive data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>Risk level name. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>N/A</b>: No sensitive data was identified.</description></item>
            /// <item><description><b>S1</b>: Level 1 sensitive data.</description></item>
            /// <item><description><b>S2</b>: Level 2 sensitive data.</description></item>
            /// <item><description><b>S3</b>: Level 3 sensitive data.</description></item>
            /// <item><description><b>S4</b>: Level 4 sensitive data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S1</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The ID of the matched recognition model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>51</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the matched recognition model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>Table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>it_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>When performing a paginated query, set the maximum number of data asset instances to display per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of this call request, which is a unique identifier generated by Alibaba Cloud for the request, and can be used for troubleshooting and problem localization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-42DF-9B72-7077A8989C13</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total number of data entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>231</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
