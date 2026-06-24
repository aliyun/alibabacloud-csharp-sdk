// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>A list of data objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataObjectsResponseBodyItems> Items { get; set; }
        public class DescribeDataObjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>An array of industry categories to which the sensitive data belongs.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The comment on the column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The data type of the database column.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataBaseName</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The code for the file category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FileCategoryCode")]
            [Validation(Required=false)]
            public int? FileCategoryCode { get; set; }

            /// <summary>
            /// <para>The unique ID of the data object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The description of the data asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The ID of the data asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-12*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The revision status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("IsRevision")]
            [Validation(Required=false)]
            public int? IsRevision { get; set; }

            /// <summary>
            /// <para>The last modification time of the file, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687676649830</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public long? LastModifiedTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the last scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1687676649830</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The name of the Logstore in SLS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logStore</para>
            /// </summary>
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            /// <summary>
            /// <para>The column encryption status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-1</para>
            /// </summary>
            [NameInMap("MaskStatus")]
            [Validation(Required=false)]
            public int? MaskStatus { get; set; }

            /// <summary>
            /// <para>The ID of the member account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>A list of data tags.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeDataObjectsResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeDataObjectsResponseBodyItemsModelTags : TeaModel {
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
                /// <item><description><para><b>Personal sensitive information</b></para>
                /// </description></item>
                /// <item><description><para><b>Personal information</b></para>
                /// </description></item>
                /// <item><description><para><b>General information</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Personal sensitive information</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The name of the data object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t_sddp_selfmysql_pers0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the file category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text file</para>
            /// </summary>
            [NameInMap("ObjectFileCategory")]
            [Validation(Required=false)]
            public string ObjectFileCategory { get; set; }

            /// <summary>
            /// <para>The type of the data object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text type</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The path of the data object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-12**.db_***</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The name of the product to which the data object belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MaxCompute</b></para>
            /// </description></item>
            /// <item><description><para><b>OSS</b></para>
            /// </description></item>
            /// <item><description><para><b>ADB-MYSQL</b></para>
            /// </description></item>
            /// <item><description><para><b>Table Store</b></para>
            /// </description></item>
            /// <item><description><para><b>RDS</b></para>
            /// </description></item>
            /// <item><description><para><b>SELF_DB</b></para>
            /// </description></item>
            /// <item><description><para><b>PolarDB-X</b></para>
            /// </description></item>
            /// <item><description><para><b>PolarDB</b></para>
            /// </description></item>
            /// <item><description><para><b>ADB-PG</b></para>
            /// </description></item>
            /// <item><description><para><b>OceanBase</b></para>
            /// </description></item>
            /// <item><description><para><b>MongoDB</b></para>
            /// </description></item>
            /// <item><description><para><b>Redis</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID of the product to which the data object belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: MaxCompute</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: OSS</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: ADB-MYSQL</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: Table Store</para>
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
            /// <para>The name of the Simple Log Service (SLS) project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The ID of the region where the data object is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RiskLevelId")]
            [Validation(Required=false)]
            public int? RiskLevelId { get; set; }

            /// <summary>
            /// <para>The number of matched rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

            /// <summary>
            /// <para>A list of matched detection models.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeDataObjectsResponseBodyItemsRuleList> RuleList { get; set; }
            public class DescribeDataObjectsResponseBodyItemsRuleList : TeaModel {
                /// <summary>
                /// <para>The ID of the risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: N/A - No sensitive data is detected</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: S1 - Level-1 sensitive data</para>
                /// </description></item>
                /// <item><description><para><b>3</b>: S2 - Level-2 sensitive data</para>
                /// </description></item>
                /// <item><description><para><b>4</b>: S3 - Level-3 sensitive data</para>
                /// </description></item>
                /// <item><description><para><b>5</b>: S4 - Level-4 sensitive data</para>
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
                /// <para>The name of the risk level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>N/A</b>: No sensitive data is detected</para>
                /// </description></item>
                /// <item><description><para><b>S1</b>: Level-1 sensitive data</para>
                /// </description></item>
                /// <item><description><para><b>S2</b>: Level-2 sensitive data</para>
                /// </description></item>
                /// <item><description><para><b>S3</b>: Level-3 sensitive data</para>
                /// </description></item>
                /// <item><description><para><b>S4</b>: Level-4 sensitive data</para>
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
                /// <para>The hierarchical category of the rule, from the top-level to the leaf-level category in the template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Personal sensitive information-ID card</para>
                /// </summary>
                [NameInMap("RuleCategoryNameList")]
                [Validation(Required=false)]
                public string RuleCategoryNameList { get; set; }

                /// <summary>
                /// <para>The number of matched detection models.</para>
                /// 
                /// <b>Example:</b>
                /// <para>590</para>
                /// </summary>
                [NameInMap("RuleCount")]
                [Validation(Required=false)]
                public int? RuleCount { get; set; }

                /// <summary>
                /// <para>The ID of the detection model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The name of the detection model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The sample data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;Lucy&quot;，&quot;Tom&quot;]</para>
                /// </summary>
                [NameInMap("SampleList")]
                [Validation(Required=false)]
                public string SampleList { get; set; }

            }

            /// <summary>
            /// <para>The number of sensitive data fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The size of the file in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>A comma-separated string that specifies the count of matched rules for each risk level. The string follows the format <c>S1,S2...S10</c>, where the value at each position represents the count for the corresponding risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3,0,0,0,0,5,0,0</para>
            /// </summary>
            [NameInMap("Sx")]
            [Validation(Required=false)]
            public string Sx { get; set; }

            /// <summary>
            /// <para>The name of the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tableName</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The name of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-task</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The task number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("TaskNumber")]
            [Validation(Required=false)]
            public long? TaskNumber { get; set; }

            /// <summary>
            /// <para>The ID of the industry template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The number of data asset instances to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. Alibaba Cloud generates this ID to help you troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F6460E-4330-549A-BD89-C183FB17571E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
