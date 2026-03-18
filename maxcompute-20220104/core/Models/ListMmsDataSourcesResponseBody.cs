// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListMmsDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListMmsDataSourcesResponseBodyData Data { get; set; }
        public class ListMmsDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of data sources.</para>
            /// </summary>
            [NameInMap("objectList")]
            [Validation(Required=false)]
            public List<ListMmsDataSourcesResponseBodyDataObjectList> ObjectList { get; set; }
            public class ListMmsDataSourcesResponseBodyDataObjectList : TeaModel {
                /// <summary>
                /// <para>Indicates whether the data source instance or its associated agent is started.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("agentIsOnline")]
                [Validation(Required=false)]
                public bool? AgentIsOnline { get; set; }

                /// <summary>
                /// <para>The configurations of the data source.</para>
                /// </summary>
                [NameInMap("config")]
                [Validation(Required=false)]
                public List<ListMmsDataSourcesResponseBodyDataObjectListConfig> Config { get; set; }
                public class ListMmsDataSourcesResponseBodyDataObjectListConfig : TeaModel {
                    /// <summary>
                    /// <para>The description of the configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>范围分区表迁移方式</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <para>The enumerated values for the configuration.</para>
                    /// </summary>
                    [NameInMap("enums")]
                    [Validation(Required=false)]
                    public List<string> Enums { get; set; }

                    /// <summary>
                    /// <para>The configuration group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>basic_group</para>
                    /// </summary>
                    [NameInMap("group")]
                    [Validation(Required=false)]
                    public string Group { get; set; }

                    /// <summary>
                    /// <para>The English identifier for the configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bigquery.range.partition.migrate.type</para>
                    /// </summary>
                    [NameInMap("key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The name of the configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>范围分区表迁移方式</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>An example value for the configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cluster or Partition</para>
                    /// </summary>
                    [NameInMap("placeHolder")]
                    [Validation(Required=false)]
                    public string PlaceHolder { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the configuration is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("required")]
                    [Validation(Required=false)]
                    public bool? Required { get; set; }

                    /// <summary>
                    /// <para>If \<c>type\\</c> is set to \<c>file\\</c>, \<c>subType\\</c> specifies the file type, such as \<c>.keytab\\</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>.keytab</para>
                    /// </summary>
                    [NameInMap("subType")]
                    [Validation(Required=false)]
                    public string SubType { get; set; }

                    /// <summary>
                    /// <para>The type of the configuration. Valid values: \<c>boolean\\</c>, \<c>int\\</c>, \<c>map\\</c>, \<c>string\\</c>, \<c>password\\</c>, and \<c>file\\</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The value of the configuration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Partition</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                }

                /// <summary>
                /// <para>The time when the data source was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-17 09:29:58</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The number of databases in the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("dbNum")]
                [Validation(Required=false)]
                public int? DbNum { get; set; }

                /// <summary>
                /// <para>The default destination MaxCompute project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mms_test</para>
                /// </summary>
                [NameInMap("dstProject")]
                [Validation(Required=false)]
                public string DstProject { get; set; }

                /// <summary>
                /// <para>The list of destination MaxCompute projects.</para>
                /// </summary>
                [NameInMap("dstProjects")]
                [Validation(Required=false)]
                public List<string> DstProjects { get; set; }

                /// <summary>
                /// <para>The reason why the data source instance failed to start or shut down. This parameter is returned only when the value of \<c>status\\</c> is \<c>START_FAILED\\</c> or \<c>STOP_FAILED\\</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>unexpected exception</para>
                /// </summary>
                [NameInMap("errMsg")]
                [Validation(Required=false)]
                public string ErrMsg { get; set; }

                /// <summary>
                /// <para>The data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000015</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The last time when the metadata was synchronized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-12-17 15:44:17</para>
                /// </summary>
                [NameInMap("lastUpdateTime")]
                [Validation(Required=false)]
                public string LastUpdateTime { get; set; }

                /// <summary>
                /// <para>The name of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The MaxCompute network connectivity ID is the region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-2zebqp6uojhdla46677tl:cn-beijing</para>
                /// </summary>
                [NameInMap("networklink")]
                [Validation(Required=false)]
                public string Networklink { get; set; }

                /// <summary>
                /// <para>The number of partitions in the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000000</para>
                /// </summary>
                [NameInMap("partitionNum")]
                [Validation(Required=false)]
                public int? PartitionNum { get; set; }

                /// <summary>
                /// <para>The number of partitions that are being migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2332</para>
                /// </summary>
                [NameInMap("partitionsDoingNum")]
                [Validation(Required=false)]
                public int? PartitionsDoingNum { get; set; }

                /// <summary>
                /// <para>The number of partitions that have been migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("partitionsDoneNum")]
                [Validation(Required=false)]
                public int? PartitionsDoneNum { get; set; }

                /// <summary>
                /// <para>The number of partitions that failed to be migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2323</para>
                /// </summary>
                [NameInMap("partitionsFailedNum")]
                [Validation(Required=false)]
                public int? PartitionsFailedNum { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The ID of the metadata synchronization task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000253</para>
                /// </summary>
                [NameInMap("scanId")]
                [Validation(Required=false)]
                public long? ScanId { get; set; }

                /// <summary>
                /// <para>The status of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STARTED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The number of tables in the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("tableNum")]
                [Validation(Required=false)]
                public int? TableNum { get; set; }

                /// <summary>
                /// <para>The number of tables that are being migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("tablesDoingNum")]
                [Validation(Required=false)]
                public int? TablesDoingNum { get; set; }

                /// <summary>
                /// <para>The number of tables that have been migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2323</para>
                /// </summary>
                [NameInMap("tablesDoneNum")]
                [Validation(Required=false)]
                public int? TablesDoneNum { get; set; }

                /// <summary>
                /// <para>The number of tables that failed to be migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("tablesFailedNum")]
                [Validation(Required=false)]
                public int? TablesFailedNum { get; set; }

                /// <summary>
                /// <para>The number of tables that are partially migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("tablesPartDoneNum")]
                [Validation(Required=false)]
                public int? TablesPartDoneNum { get; set; }

                /// <summary>
                /// <para>The type of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIGQUERY</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNum")]
            [Validation(Required=false)]
            public int? PageNum { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1F7715F-D316-5AB6-BD02-5241083F4003</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
