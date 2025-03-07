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
        /// <para>A list of column recognition results of the data table.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeColumnsV2ResponseBodyItems> Items { get; set; }
        public class DescribeColumnsV2ResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The time when the data in the column of the table is created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1536751124000</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public long? CreationTime { get; set; }

            /// <summary>
            /// <para>The type of data in the column of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The ID of the column of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111111</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which data in the column of the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1232122</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance to which data in the column of the table belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-1234</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

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
                /// <para>The tag ID. Valid values:</para>
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
                /// <para>The tag name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Personal sensitive information</description></item>
                /// <item><description>Personal information</description></item>
                /// <item><description>General information</description></item>
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
            /// <para>The name of the column of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obj_id</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level for asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N/A</b>: indicates that no sensitive data is detected.</description></item>
            /// <item><description><b>S1</b>: indicates the low sensitivity level.</description></item>
            /// <item><description><b>S2</b>: indicates the medium sensitivity level.</description></item>
            /// <item><description><b>S3</b>: indicates the high sensitivity level.</description></item>
            /// <item><description><b>S4</b>: indicates the highest sensitivity level.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S4</para>
            /// </summary>
            [NameInMap("OdpsRiskLevelName")]
            [Validation(Required=false)]
            public string OdpsRiskLevelName { get; set; }

            /// <summary>
            /// <para>The ID of the sensitivity level of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A</description></item>
            /// <item><description><b>2</b>: S1</description></item>
            /// <item><description><b>3</b>: S2</description></item>
            /// <item><description><b>4</b>: S3</description></item>
            /// <item><description><b>5</b>: S4<remarks>
            /// <para>The return value &lt;=1 means N/A.</para>
            /// </remarks>
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
            /// <para>The name of the service to which data in the column of the table belongs. Valid values: <b>MaxCompute, OSS, ADS, OTS, and RDS</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public long? ProductId { get; set; }

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
            /// <para>Indicates whether the column is revised. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: yes</description></item>
            /// <item><description>0: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RevisionStatus")]
            [Validation(Required=false)]
            public long? RevisionStatus { get; set; }

            /// <summary>
            /// <para>The ID of the sensitivity level of data in the column of the table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: N/A</description></item>
            /// <item><description><b>2</b>: S1</description></item>
            /// <item><description><b>3</b>: S2</description></item>
            /// <item><description><b>4</b>: S3</description></item>
            /// <item><description><b>5</b>: S4</description></item>
            /// </list>
            /// <remarks>
            /// <para>The return value &lt;=1 means N/A.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public long? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The name of the sensitivity level for data in the column of the table. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>N/A</b>: indicates that no sensitive data is detected.</description></item>
            /// <item><description><b>S1</b>: indicates the low sensitivity level.</description></item>
            /// <item><description><b>S2</b>: indicates the medium sensitivity level.</description></item>
            /// <item><description><b>S3</b>: indicates the high sensitivity level.</description></item>
            /// <item><description><b>S4</b>: indicates the highest sensitivity level.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>S1</para>
            /// </summary>
            [NameInMap("RiskLevelName")]
            [Validation(Required=false)]
            public string RiskLevelName { get; set; }

            /// <summary>
            /// <para>The ID of the sensitive data detection rule that data in the column of the table hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1004</para>
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
            /// <para>Indicates whether the column contains sensitive data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Sensitive")]
            [Validation(Required=false)]
            public bool? Sensitive { get; set; }

            /// <summary>
            /// <para>The ID of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("TableId")]
            [Validation(Required=false)]
            public long? TableId { get; set; }

            /// <summary>
            /// <para>The name of the table to which the revised column belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>it_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

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
        /// <para>The request ID.</para>
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
