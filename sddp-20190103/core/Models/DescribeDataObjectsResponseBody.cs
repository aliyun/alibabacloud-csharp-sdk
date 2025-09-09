// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>When performing a paginated query, set the current page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>List of data objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataObjectsResponseBodyItems> Items { get; set; }
        public class DescribeDataObjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>List of industry categories for the sensitive data.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            /// <summary>
            /// <para>The unique identifier ID of the data object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instance description of the data object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>Data asset instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-12*****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Latest file modification time, in milliseconds.</para>
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
            /// <para>Member account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>List of data tags.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeDataObjectsResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeDataObjectsResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>Data tag ID. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>101</b>: Personal sensitive information.</description></item>
                /// <item><description><b>102</b>: Personal information.</description></item>
                /// <item><description><b>107</b>: General information.</description></item>
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
                /// <item><description><b>Personal sensitive information.</b></description></item>
                /// <item><description><b>Personal information.</b></description></item>
                /// <item><description><b>General information.</b></description></item>
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
            /// <para>File category name.</para>
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
            /// <para>The product name that the data object belongs to. Values:</para>
            /// <list type="bullet">
            /// <item><description><b>MaxCompute</b></description></item>
            /// <item><description><b>OSS</b></description></item>
            /// <item><description><b>ADB-MYSQL</b></description></item>
            /// <item><description><b>TableStore</b></description></item>
            /// <item><description><b>RDS</b></description></item>
            /// <item><description><b>SELF_DB</b></description></item>
            /// <item><description><b>PolarDB-X</b></description></item>
            /// <item><description><b>PolarDB</b></description></item>
            /// <item><description><b>ADB-PG</b></description></item>
            /// <item><description><b>OceanBase</b></description></item>
            /// <item><description><b>MongoDB</b></description></item>
            /// <item><description><b>Redis</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            /// <summary>
            /// <para>The ID corresponding to the product name that the data object belongs to. Values:</para>
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
            /// <para>The region ID to which the OSS storage object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>List of matched identification models.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeDataObjectsResponseBodyItemsRuleList> RuleList { get; set; }
            public class DescribeDataObjectsResponseBodyItemsRuleList : TeaModel {
                /// <summary>
                /// <para>Risk level ID for sensitive data identification rules. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: N/A: No sensitive data identified.</description></item>
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
                /// <para>Risk level name for the data asset table. Values:</para>
                /// <list type="bullet">
                /// <item><description><b>N/A</b>: No sensitive data identified.</description></item>
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
                /// <para>Number of matched identification models.</para>
                /// 
                /// <b>Example:</b>
                /// <para>590</para>
                /// </summary>
                [NameInMap("RuleCount")]
                [Validation(Required=false)]
                public int? RuleCount { get; set; }

                /// <summary>
                /// <para>Identification model ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>Identification model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

            }

            /// <summary>
            /// <para>Number of sensitive data items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>Industry template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

        }

        /// <summary>
        /// <para>When performing a paginated query, this sets the maximum number of data asset instances to display per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of this call request is a unique identifier generated by Alibaba Cloud for the request, which can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F6460E-4330-549A-BD89-C183FB17571E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
