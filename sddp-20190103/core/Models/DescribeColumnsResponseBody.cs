// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page displayed in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Column data in the data asset table.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeColumnsResponseBodyItems> Items { get; set; }
        public class DescribeColumnsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The creation time of the column data in the data asset table, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The data type of the column data in the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>Database engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The unique ID of the column in the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>268</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the asset instance to which the column data in the data asset table belongs.</para>
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
            /// <para>Column encryption status. Valid values:</para>
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
            /// <para>The list of data tags hit by the detection model.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeColumnsResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeColumnsResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>The data tag ID of the detection model.</para>
                /// <list type="bullet">
                /// <item><description><para><b>101</b>: Personal sensitive information.</para>
                /// </description></item>
                /// <item><description><para><b>102</b>: Personal information.</para>
                /// </description></item>
                /// <item><description><para><b>103</b>: Important data.</para>
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
                /// <para>The data tag name of the detection model.</para>
                /// <list type="bullet">
                /// <item><description><para>Personal sensitive information.</para>
                /// </description></item>
                /// <item><description><para>Personal information.</para>
                /// </description></item>
                /// <item><description><para>Important data.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>personal sensitive data</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the column in the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gxdata</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The risk level name of the asset. Valid values:</para>
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
            /// <para>S3</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// <para>The risk level code of the asset. Valid values:</para>
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
            /// <para>3</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelValue")]
            [Validation(Required=false)]
            public int? OdpsRiskLevelValue { get; set; }

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
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>The region where the asset is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-***</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Correction record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("RevisionId")]
            [Validation(Required=false)]
            public long? RevisionId { get; set; }

            /// <summary>
            /// <para>Correction status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: Corrected.</para>
            /// </description></item>
            /// <item><description><para>0: Not corrected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RevisionStatus")]
            [Validation(Required=false)]
            public long? RevisionStatus { get; set; }

            /// <summary>
            /// <para>The risk level ID of the column data in the data asset table. Valid values:</para>
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
            /// <para>The risk level name of the column data in the data asset table. Valid values:</para>
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
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The ID of the sensitive data detection rule hit by the column data in the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// <para>Indicates whether the column data in the data asset table contains sensitive data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The column data in the data asset table contains sensitive data.</para>
            /// </description></item>
            /// <item><description><para>false: The column data in the data asset table does not contain sensitive data.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The ID of the asset table to which the column data in the data asset table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public long? TableId { get; set; }

            /// <summary>
            /// <para>The name of the table to which the target column for correction belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>it_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The number of data entries displayed per page in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID of the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>769FB3C1-F4C9-4******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of data entries in the results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
