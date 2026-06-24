// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsV2ResponseBody : TeaModel {
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
        /// <para>A list of detection results for the columns in the data table.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeColumnsV2ResponseBodyItems> Items { get; set; }
        public class DescribeColumnsV2ResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the data in the column of the data asset table was created. The value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The data type of the data in the column of the data asset table.</para>
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
            /// <para>The unique ID of the column in the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the data asset instance to which the data in the column belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232122</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the data asset instance to which the data in the column belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-1234</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The column encryption status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>-1</b>: not encrypted</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: encryption successful</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: encryption failed</para>
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
            /// <para>A list of data tags.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeColumnsV2ResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeColumnsV2ResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>The ID of the data tag. Valid values:</para>
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
                /// <para>The name of the data tag. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>Personal sensitive information</para>
                /// </description></item>
                /// <item><description><para>Personal information</para>
                /// </description></item>
                /// <item><description><para>General information</para>
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
            /// <para>The name of the column in the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obj_id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the risk level for the data asset. Valid values:</para>
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
            /// <para>S4</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// <para>The code of the risk level for the data asset. Valid values:</para>
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
            /// <remarks>
            /// <para>A return value that is less than or equal to 1 indicates N/A.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelValue")]
            [Validation(Required=false)]
            public int? OdpsRiskLevelValue { get; set; }

            /// <summary>
            /// <para>The name of the product to which the data in the column of the data asset table belongs. Valid values include <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the product to which the data asset belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: ADS</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: OTS</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: RDS</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: SELF_DB</para>
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
            /// <para>The region where the data asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ID of the revision record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("RevisionId")]
            [Validation(Required=false)]
            public long? RevisionId { get; set; }

            /// <summary>
            /// <para>The revision status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: revised</para>
            /// </description></item>
            /// <item><description><para>0: not revised</para>
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
            /// <para>The ID of the risk level for the data in the column of the data asset table. Valid values:</para>
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
            /// <remarks>
            /// <para>A return value that is less than or equal to 1 indicates N/A.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the risk level for the data in the column of the data asset table. Valid values:</para>
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
            /// <para>S1</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The ID of the sensitive data detection rule that is hit by the data in the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1004</para>
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
            /// <para>Indicates whether the data in the column of the data asset table is sensitive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: The data in the column is sensitive.</para>
            /// </description></item>
            /// <item><description><para>false: The data in the column is not sensitive.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The ID of the data asset table to which the data in the column belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public long? TableId { get; set; }

            /// <summary>
            /// <para>The name of the table that contains the revised target column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>it_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID generated by Alibaba Cloud for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B1F2BB1F-04EC-5D36-B136-B4DE17FD8DE0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
