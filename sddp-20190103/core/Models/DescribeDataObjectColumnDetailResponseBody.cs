// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectColumnDetailResponseBody : TeaModel {
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
        /// <para>The details of the columns.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataObjectColumnDetailResponseBodyItems> Items { get; set; }
        public class DescribeDataObjectColumnDetailResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The industry-specific data classifications.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The comment on the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>column comment</para>
            /// </summary>
            [NameInMap("ColumnComment")]
            [Validation(Required=false)]
            public string ColumnComment { get; set; }

            /// <summary>
            /// <para>The name of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hide14</para>
            /// </summary>
            [NameInMap("ColumnName")]
            [Validation(Required=false)]
            public string ColumnName { get; set; }

            /// <summary>
            /// <para>The data type of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

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
            /// <para>The ID of the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1509415150052786176</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the instance where the table is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-1234</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The data masking status of the column. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>-1</b>: Not masked</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Masked</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Masking failed</para>
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
            /// <para>The data labels.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeDataObjectColumnDetailResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeDataObjectColumnDetailResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>The ID of the data label. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>101</b>: Personal sensitive information</para>
                /// </description></item>
                /// <item><description><para><b>102</b>: Personal information</para>
                /// </description></item>
                /// <item><description><para><b>107</b>: General information</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The name of the data label. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Personal sensitive information</b></para>
                /// </description></item>
                /// <item><description><para><b>Personal information</b></para>
                /// </description></item>
                /// <item><description><para><b>General information</b></para>
                /// </description></item>
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
            /// <para>Indicates whether the column is a primary key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The column is a primary key.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The column is not a primary key.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public bool? PrimaryKey { get; set; }

            /// <summary>
            /// <para>The ID of the service to which the data object belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: ADB-MYSQL</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Tablestore</para>
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
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>The ID of the region where the data asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the sensitivity level. Valid values:</para>
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
            /// <para>The name of the sensitivity level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>N/A</b></para>
            /// </description></item>
            /// <item><description><para><b>S1</b></para>
            /// </description></item>
            /// <item><description><para><b>S2</b></para>
            /// </description></item>
            /// <item><description><para><b>S3</b></para>
            /// </description></item>
            /// <item><description><para><b>S4</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S1</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The ID of the sensitive data detection rule that was matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1004</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the sensitive data detection rule that was matched.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

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

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
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
        /// <para>8C8036CC-961D-514E-88E8-3088B5A50CA9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
