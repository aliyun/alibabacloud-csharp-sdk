// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeColumnsV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number in a paged query. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of column detection results in the data asset table.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeColumnsV2ResponseBodyItems> Items { get; set; }
        public class DescribeColumnsV2ResponseBodyItems : TeaModel {
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
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

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
            /// <para>The unique ID of the column in the data asset table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance ID of the asset to which the column data in the data asset table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232122</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the asset instance to which the column data in the data asset table belongs.</para>
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
            /// <item><description><para><b>-1</b>: not encrypted.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: encryption succeeded.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: encryption failed.</para>
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
            /// <para>The list of data tags.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeColumnsV2ResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeColumnsV2ResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>The data tag ID. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>101</b>: personal sensitive information</description></item>
                /// <item><description><b>102</b>: personal information</description></item>
                /// <item><description><b>107</b>: general information</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>101</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The data tag name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>个人敏感信息</description></item>
                /// <item><description>个人信息</description></item>
                /// <item><description>通用信息</description></item>
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
            /// <para>The risk level name of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N/A</b>: no sensitive data detected.</description></item>
            /// <item><description><b>S1</b>: Level 1 sensitive data.</description></item>
            /// <item><description><b>S2</b>: Level 2 sensitive data.</description></item>
            /// <item><description><b>S3</b>: Level 3 sensitive data.</description></item>
            /// <item><description><b>S4</b>: Level 4 sensitive data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S4</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// <para>The risk level code of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A.</description></item>
            /// <item><description><b>2</b>: S1.</description></item>
            /// <item><description><b>3</b>: S2.</description></item>
            /// <item><description><b>4</b>: S3.</description></item>
            /// <item><description><b>5</b>: S4.</description></item>
            /// </list>
            /// <remarks>
            /// <para>A return value less than or equal to 1 indicates N/A.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelValue")]
            [Validation(Required=false)]
            public int? OdpsRiskLevelValue { get; set; }

            /// <summary>
            /// <para>The name of the product to which the column data in the data asset table belongs. Valid values: <b>MaxCompute, OSS, ADS, OTS, RDS</b>, and others.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID that corresponds to the product name of the data asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: MaxCompute.</description></item>
            /// <item><description><b>2</b>: OSS.</description></item>
            /// <item><description><b>3</b>: ADS.</description></item>
            /// <item><description><b>4</b>: OTS.</description></item>
            /// <item><description><b>5</b>: ApsaraDB RDS.</description></item>
            /// <item><description><b>6</b>: SELF_DB.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

            /// <summary>
            /// <para>The region where the asset resides.</para>
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
            /// <item><description>1: revised.</description></item>
            /// <item><description>0: not revised.</description></item>
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
            /// <item><description><b>1</b>: N/A.</description></item>
            /// <item><description><b>2</b>: S1.</description></item>
            /// <item><description><b>3</b>: S2.</description></item>
            /// <item><description><b>4</b>: S3.</description></item>
            /// <item><description><b>5</b>: S4.</description></item>
            /// </list>
            /// <remarks>
            /// <para>A return value less than or equal to 1 indicates N/A.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The risk level name of the column data in the data asset table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N/A</b>: no sensitive data detected.</description></item>
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
            /// <para>The ID of the sensitive data detection rule that the column data in the data asset table matches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1004</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the sensitive data detection rule that the column data in the data asset table matches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The sensitivity level name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N/A</b>: no sensitive data detected.</description></item>
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
            /// <para>Indicates whether the column data in the data asset table contains sensitive data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The column data contains sensitive data.</description></item>
            /// <item><description>false: The column data does not contain sensitive data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The ID of the data asset table to which the column data belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public long? TableId { get; set; }

            /// <summary>
            /// <para>The name of the table to which the revised target column belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>it_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Default value: <b>10</b>.</para>
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
