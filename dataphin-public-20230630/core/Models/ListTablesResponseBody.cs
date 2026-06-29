// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of the backend exception.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListTablesResponseBodyPageResult PageResult { get; set; }
        public class ListTablesResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of tables.</para>
            /// </summary>
            [NameInMap("TableList")]
            [Validation(Required=false)]
            public List<ListTablesResponseBodyPageResultTableList> TableList { get; set; }
            public class ListTablesResponseBodyPageResultTableList : TeaModel {
                /// <summary>
                /// <para>The asset inventory tags.</para>
                /// </summary>
                [NameInMap("AssetTagList")]
                [Validation(Required=false)]
                public List<string> AssetTagList { get; set; }

                /// <summary>
                /// <para>The ID of the business unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2011</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The name of the business unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD_test01</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <para>The comment of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30011211</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The ID of the data domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>211</para>
                /// </summary>
                [NameInMap("DataDomainId")]
                [Validation(Required=false)]
                public long? DataDomainId { get; set; }

                /// <summary>
                /// <para>The name of the data domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>211</para>
                /// </summary>
                [NameInMap("DataDomainName")]
                [Validation(Required=false)]
                public string DataDomainName { get; set; }

                /// <summary>
                /// <para>The ID of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3301</para>
                /// </summary>
                [NameInMap("DataSourceId")]
                [Validation(Required=false)]
                public long? DataSourceId { get; set; }

                /// <summary>
                /// <para>The display name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>学生</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The environment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>dev</description></item>
                /// <item><description>prod.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dev</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The file ID. This value is used to navigate to the ODM model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                /// <summary>
                /// <para>The GUID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10011</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>Indicates whether the project or business version to which the table belongs is in Basic mode.</para>
                /// </summary>
                [NameInMap("IsBasicMode")]
                [Validation(Required=false)]
                public bool? IsBasicMode { get; set; }

                /// <summary>
                /// <para>Indicates whether the table is a partitioned table.</para>
                /// </summary>
                [NameInMap("IsPartitionTable")]
                [Validation(Required=false)]
                public bool? IsPartitionTable { get; set; }

                /// <summary>
                /// <para>The time when the table DDL was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("LastDdlTime")]
                [Validation(Required=false)]
                public string LastDdlTime { get; set; }

                /// <summary>
                /// <para>The time when the table data was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("LastDmlTime")]
                [Validation(Required=false)]
                public string LastDmlTime { get; set; }

                /// <summary>
                /// <para>The time when the data was last viewed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("LastQueryTime")]
                [Validation(Required=false)]
                public string LastQueryTime { get; set; }

                /// <summary>
                /// <para>The lifecycle of the table, in days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("LifeCycle")]
                [Validation(Required=false)]
                public long? LifeCycle { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_test01</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The Dataphin user ID of the table owner. This value may be empty if the owner is not bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30011211</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The ID of the parent model. This value is used to navigate to the ODM model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParentModelId")]
                [Validation(Required=false)]
                public string ParentModelId { get; set; }

                /// <summary>
                /// <para>The ID of the logical project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1011</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The name of the logical project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testPrj</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The security classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SecurityLevel")]
                [Validation(Required=false)]
                public long? SecurityLevel { get; set; }

                /// <summary>
                /// <para>The abbreviation of the security classification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>高级</para>
                /// </summary>
                [NameInMap("SecurityLevelAbbreviation")]
                [Validation(Required=false)]
                public string SecurityLevelAbbreviation { get; set; }

                /// <summary>
                /// <para>The name of the security classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>高级</para>
                /// </summary>
                [NameInMap("SecurityLevelName")]
                [Validation(Required=false)]
                public string SecurityLevelName { get; set; }

                /// <summary>
                /// <para>The storage type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HIVE</description></item>
                /// <item><description>MAX_COMPUTE.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HIVE</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The dynamic properties of the real-time meta table.</para>
                /// </summary>
                [NameInMap("StreamTableConfig")]
                [Validation(Required=false)]
                public List<ListTablesResponseBodyPageResultTableListStreamTableConfig> StreamTableConfig { get; set; }
                public class ListTablesResponseBodyPageResultTableListStreamTableConfig : TeaModel {
                    /// <summary>
                    /// <para>The configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>k1</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the configuration item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The total storage size of the table, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10241024</para>
                /// </summary>
                [NameInMap("TableSizeInBytes")]
                [Validation(Required=false)]
                public long? TableSizeInBytes { get; set; }

                /// <summary>
                /// <para>The number of visits in the last 30 days.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("VisitCount30d")]
                [Validation(Required=false)]
                public long? VisitCount30d { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
