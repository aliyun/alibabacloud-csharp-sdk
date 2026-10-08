// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTableResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTableResponseBodyData Data { get; set; }
        public class GetTableResponseBodyData : TeaModel {
            [NameInMap("AssetTags")]
            [Validation(Required=false)]
            public List<string> AssetTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2011</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>LD_test01</para>
            /// </summary>
            [NameInMap("BizUnitName")]
            [Validation(Required=false)]
            public string BizUnitName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30011211</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>211</para>
            /// </summary>
            [NameInMap("DataDomainId")]
            [Validation(Required=false)]
            public long? DataDomainId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>课程域</para>
            /// </summary>
            [NameInMap("DataDomainName")]
            [Validation(Required=false)]
            public string DataDomainName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3301</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>学生</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public string FileId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dp_ds_table.300023201.7311626611751680256.load_test.abc</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            [NameInMap("Instructions")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyDataInstructions> Instructions { get; set; }
            public class GetTableResponseBodyDataInstructions : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>示例内容</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 00:00:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30011211</para>
                /// </summary>
                [NameInMap("OwnerId")]
                [Validation(Required=false)]
                public string OwnerId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("OwnerNickName")]
                [Validation(Required=false)]
                public string OwnerNickName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>使用指南</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("IsBasicMode")]
            [Validation(Required=false)]
            public bool? IsBasicMode { get; set; }

            [NameInMap("IsPartitionTable")]
            [Validation(Required=false)]
            public bool? IsPartitionTable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("LastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("LastDmlTime")]
            [Validation(Required=false)]
            public string LastDmlTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("LastQueryTime")]
            [Validation(Required=false)]
            public string LastQueryTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LifeCycle")]
            [Validation(Required=false)]
            public long? LifeCycle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t_test01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NodeIds")]
            [Validation(Required=false)]
            public List<string> NodeIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30011211</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParentModelId")]
            [Validation(Required=false)]
            public string ParentModelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1011</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testPrj</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SecurityLevel")]
            [Validation(Required=false)]
            public long? SecurityLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>高</para>
            /// </summary>
            [NameInMap("SecurityLevelAbbreviation")]
            [Validation(Required=false)]
            public string SecurityLevelAbbreviation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>高级</para>
            /// </summary>
            [NameInMap("SecurityLevelName")]
            [Validation(Required=false)]
            public string SecurityLevelName { get; set; }

            [NameInMap("SimpleNodeInfos")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyDataSimpleNodeInfos> SimpleNodeInfos { get; set; }
            public class GetTableResponseBodyDataSimpleNodeInfos : TeaModel {
                [NameInMap("BizUnit")]
                [Validation(Required=false)]
                public GetTableResponseBodyDataSimpleNodeInfosBizUnit BizUnit { get; set; }
                public class GetTableResponseBodyDataSimpleNodeInfosBizUnit : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>测试板块</para>
                    /// </summary>
                    [NameInMap("BizUnitDisplayName")]
                    [Validation(Required=false)]
                    public string BizUnitDisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2011</para>
                    /// </summary>
                    [NameInMap("BizUnitId")]
                    [Validation(Required=false)]
                    public string BizUnitId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LD_test01</para>
                    /// </summary>
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n_7443xxxx</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2345</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("NodeScheduleType")]
                [Validation(Required=false)]
                public string NodeScheduleType { get; set; }

                [NameInMap("Owners")]
                [Validation(Required=false)]
                public List<GetTableResponseBodyDataSimpleNodeInfosOwners> Owners { get; set; }
                public class GetTableResponseBodyDataSimpleNodeInfosOwners : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public GetTableResponseBodyDataSimpleNodeInfosProject Project { get; set; }
                public class GetTableResponseBodyDataSimpleNodeInfosProject : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>测试项目</para>
                    /// </summary>
                    [NameInMap("ProjectDisplayName")]
                    [Validation(Required=false)]
                    public string ProjectDisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1011</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>testPrj</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DLINK</para>
                /// </summary>
                [NameInMap("SubBizType")]
                [Validation(Required=false)]
                public string SubBizType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HIVE</para>
            /// </summary>
            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            [NameInMap("StreamTableConfig")]
            [Validation(Required=false)]
            public List<GetTableResponseBodyDataStreamTableConfig> StreamTableConfig { get; set; }
            public class GetTableResponseBodyDataStreamTableConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10241024</para>
            /// </summary>
            [NameInMap("TableSizeInBytes")]
            [Validation(Required=false)]
            public long? TableSizeInBytes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("VisitCount30d")]
            [Validation(Required=false)]
            public long? VisitCount30d { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
