// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeDataObjectsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paged query. Settings for paging. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        [NameInMap("HasPrevious")]
        [Validation(Required=false)]
        public bool? HasPrevious { get; set; }

        /// <summary>
        /// <para>The associate filter values used to return filtered values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;linxiu&quot;,&quot;sddptest&quot;]</para>
        /// </summary>
        [NameInMap("HitValues")]
        [Validation(Required=false)]
        public List<string> HitValues { get; set; }

        /// <summary>
        /// <para>The list of data objects.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDataObjectsResponseBodyItems> Items { get; set; }
        public class DescribeDataObjectsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The list of industry categories to which the sensitive data belongs.</para>
            /// </summary>
            [NameInMap("Categories")]
            [Validation(Required=false)]
            public List<string> Categories { get; set; }

            [NameInMap("ClusterType")]
            [Validation(Required=false)]
            public string ClusterType { get; set; }

            /// <summary>
            /// <para>The column comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The database column type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DataBaseName</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The file type.</para>
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
            /// <para>The instance description of the data object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance description</para>
            /// </summary>
            [NameInMap("InstanceDescription")]
            [Validation(Required=false)]
            public string InstanceDescription { get; set; }

            /// <summary>
            /// <para>The data asset instance ID.</para>
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
            /// <para>The SLS Logstore.</para>
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
            /// <para>The member accounts ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>**********8103</para>
            /// </summary>
            [NameInMap("MemberAccount")]
            [Validation(Required=false)]
            public long? MemberAccount { get; set; }

            /// <summary>
            /// <para>The list of data labels.</para>
            /// </summary>
            [NameInMap("ModelTags")]
            [Validation(Required=false)]
            public List<DescribeDataObjectsResponseBodyItemsModelTags> ModelTags { get; set; }
            public class DescribeDataObjectsResponseBodyItemsModelTags : TeaModel {
                /// <summary>
                /// <para>The data label ID. Valid values:</para>
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
                /// <para>The data label name. Valid values:</para>
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
            /// <para>The file category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text file</para>
            /// </summary>
            [NameInMap("ObjectFileCategory")]
            [Validation(Required=false)]
            public string ObjectFileCategory { get; set; }

            /// <summary>
            /// <para>The object type of the data object.</para>
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
            /// <para>The product name to which the data object belongs. Valid values:</para>
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
            /// <para>The ID that corresponds to the product name to which the data object belongs. Valid values:</para>
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
            /// <para>The Simple Log Service (SLS) project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The region ID to which the data object belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The region name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

            /// <summary>
            /// <para>The sensitivity level.</para>
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
            /// <para>The list of matched detection models.</para>
            /// </summary>
            [NameInMap("RuleList")]
            [Validation(Required=false)]
            public List<DescribeDataObjectsResponseBodyItemsRuleList> RuleList { get; set; }
            public class DescribeDataObjectsResponseBodyItemsRuleList : TeaModel {
                /// <summary>
                /// <para>The risk level ID of the sensitive data detection rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: N/A. No sensitive data is detected.</description></item>
                /// <item><description><b>2</b>: S1. Level 1 sensitive data.</description></item>
                /// <item><description><b>3</b>: S2. Level 2 sensitive data.</description></item>
                /// <item><description><b>4</b>: S3. Level 3 sensitive data.</description></item>
                /// <item><description><b>5</b>: S4. Level 4 sensitive data.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RiskLevelId")]
                [Validation(Required=false)]
                public long? RiskLevelId { get; set; }

                /// <summary>
                /// <para>The risk level name of the data asset table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>N/A</b>: No sensitive data is detected.</description></item>
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
                /// <para>The rule information described from the top to the bottom of the template.</para>
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
                /// <para>The detection model ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1080</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The detection model name.</para>
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
            /// <para>The number of sensitive data entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SensitiveCount")]
            [Validation(Required=false)]
            public int? SensitiveCount { get; set; }

            /// <summary>
            /// <para>The file size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The array that consists of the number of rules matched at each sensitivity level, in the format &quot;S1,S2,S3,S4,S5,S6,S7,S8,S9,S10&quot;, where S1 represents the number of rules matched at sensitivity level S1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1,2,3,0,0,0,0,5,0,0</para>
            /// </summary>
            [NameInMap("Sx")]
            [Validation(Required=false)]
            public string Sx { get; set; }

            /// <summary>
            /// <para>The table name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tableName</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-task</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The user task number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("TaskNumber")]
            [Validation(Required=false)]
            public long? TaskNumber { get; set; }

            /// <summary>
            /// <para>The industry template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        [NameInMap("NextCursor")]
        [Validation(Required=false)]
        public string NextCursor { get; set; }

        /// <summary>
        /// <para>The maximum number of data asset instances to return per page in a paged query. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PreviousCursor")]
        [Validation(Required=false)]
        public string PreviousCursor { get; set; }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F6460E-4330-549A-BD89-C183FB17571E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SyncStatus")]
        [Validation(Required=false)]
        public string SyncStatus { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
