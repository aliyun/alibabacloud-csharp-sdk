// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetCatalogAssetDetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCatalogAssetDetailsResponseBodyData Data { get; set; }
        public class GetCatalogAssetDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApiCallMode")]
            [Validation(Required=false)]
            public string ApiCallMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>默认API分组</para>
            /// </summary>
            [NameInMap("ApiGroupName")]
            [Validation(Required=false)]
            public string ApiGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10441</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApiRequestMethod")]
            [Validation(Required=false)]
            public string ApiRequestMethod { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("AssetDescription")]
            [Validation(Required=false)]
            public string AssetDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://dataphin.poc.lydaas.com/market/catalog/detail/table/">https://dataphin.poc.lydaas.com/market/catalog/detail/table/</a>...</para>
            /// </summary>
            [NameInMap("AssetDetailUrl")]
            [Validation(Required=false)]
            public string AssetDetailUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc表</para>
            /// </summary>
            [NameInMap("AssetDisplayName")]
            [Validation(Required=false)]
            public string AssetDisplayName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Dataphin-中间层-服饰零售 (LD_Fashion)</para>
            /// </summary>
            [NameInMap("AssetFrom")]
            [Validation(Required=false)]
            public string AssetFrom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dwd_all.abc</para>
            /// </summary>
            [NameInMap("AssetFullName")]
            [Validation(Required=false)]
            public string AssetFullName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            [NameInMap("AssetTags")]
            [Validation(Required=false)]
            public List<string> AssetTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dataphin演示空间</para>
            /// </summary>
            [NameInMap("BiCatalog")]
            [Validation(Required=false)]
            public string BiCatalog { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6865277495315392</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>服饰零售（LD_Fashion）</para>
            /// </summary>
            [NameInMap("BizUnitName")]
            [Validation(Required=false)]
            public string BizUnitName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("ChartCount")]
            [Validation(Required=false)]
            public long? ChartCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CollectionCount")]
            [Validation(Required=false)]
            public long? CollectionCount { get; set; }

            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataColumns> Columns { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataColumns : TeaModel {
                [NameInMap("AssociatedEntity")]
                [Validation(Required=false)]
                public GetCatalogAssetDetailsResponseBodyDataColumnsAssociatedEntity AssociatedEntity { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataColumnsAssociatedEntity : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7137404445633152</para>
                    /// </summary>
                    [NameInMap("BizUnitId")]
                    [Validation(Required=false)]
                    public long? BizUnitId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LD_train</para>
                    /// </summary>
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>上药erp数据源</para>
                    /// </summary>
                    [NameInMap("DimensionDisplayName")]
                    [Validation(Required=false)]
                    public string DimensionDisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>68014359</para>
                    /// </summary>
                    [NameInMap("DimensionId")]
                    [Validation(Required=false)]
                    public long? DimensionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>etl_source</para>
                    /// </summary>
                    [NameInMap("DimensionName")]
                    [Validation(Required=false)]
                    public string DimensionName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DIMENSION</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/交易信息/0000001</para>
                /// </summary>
                [NameInMap("ClassifyName")]
                [Validation(Required=false)]
                public string ClassifyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>double</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>门店客流转化率</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dp_table.300023201.ld_fashion.dws_lulu_location.conversion_rate</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>L4</para>
                /// </summary>
                [NameInMap("LevelShortName")]
                [Validation(Required=false)]
                public string LevelShortName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>conversion_rate</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("QualityScore")]
                [Validation(Required=false)]
                public double? QualityScore { get; set; }

                [NameInMap("Standards")]
                [Validation(Required=false)]
                public List<GetCatalogAssetDetailsResponseBodyDataColumnsStandards> Standards { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataColumnsStandards : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hr_person_id</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>120350</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataCustomAttributes> CustomAttributes { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataCustomAttributes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>MANAGEMENT</para>
                /// </summary>
                [NameInMap("AttrType")]
                [Validation(Required=false)]
                public string AttrType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gkglbm</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>归口管理部门</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>49837403</para>
            /// </summary>
            [NameInMap("DataCellId")]
            [Validation(Required=false)]
            public string DataCellId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>课程域</para>
            /// </summary>
            [NameInMap("DataCellName")]
            [Validation(Required=false)]
            public string DataCellName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo_mysql</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7305549302863001856</para>
            /// </summary>
            [NameInMap("DatasourceId")]
            [Validation(Required=false)]
            public long? DatasourceId { get; set; }

            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataDirectories> Directories { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataDirectories : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>102260</para>
                /// </summary>
                [NameInMap("DirectoryId")]
                [Validation(Required=false)]
                public long? DirectoryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>线上电商平台</para>
                /// </summary>
                [NameInMap("DirectoryName")]
                [Validation(Required=false)]
                public string DirectoryName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>101676</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>全渠道数据专题</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-22 10:06:20</para>
            /// </summary>
            [NameInMap("FirstOnShelveTime")]
            [Validation(Required=false)]
            public string FirstOnShelveTime { get; set; }

            [NameInMap("FirstOnShelveUser")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataFirstOnShelveUser FirstOnShelveUser { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataFirstOnShelveUser : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>课程</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dp_ds_table.300023201.7311626611751680256.load_test.abc</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            [NameInMap("Instruction")]
            [Validation(Required=false)]
            public string Instruction { get; set; }

            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            [NameInMap("IsPartitionTable")]
            [Validation(Required=false)]
            public bool? IsPartitionTable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("LastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("LastDmlTime")]
            [Validation(Required=false)]
            public string LastDmlTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-05-22 10:06:20</para>
            /// </summary>
            [NameInMap("LastOnShelveTime")]
            [Validation(Required=false)]
            public string LastOnShelveTime { get; set; }

            [NameInMap("LastOnShelveUser")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataLastOnShelveUser LastOnShelveUser { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataLastOnShelveUser : TeaModel {
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

            [NameInMap("MaintainUserGroups")]
            [Validation(Required=false)]
            public List<string> MaintainUserGroups { get; set; }

            [NameInMap("MaintainUserIds")]
            [Validation(Required=false)]
            public List<string> MaintainUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>L3</para>
            /// </summary>
            [NameInMap("MaxSecurityLevel")]
            [Validation(Required=false)]
            public string MaxSecurityLevel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataOwner Owner { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataOwner : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds</para>
            /// </summary>
            [NameInMap("PartitionKey")]
            [Validation(Required=false)]
            public string PartitionKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>employee_id</para>
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALL_USERS_CAN_VIEW</para>
            /// </summary>
            [NameInMap("ProfilingReportViewScopeType")]
            [Validation(Required=false)]
            public string ProfilingReportViewScopeType { get; set; }

            [NameInMap("ProfilingReportViewScopeUserGroups")]
            [Validation(Required=false)]
            public List<string> ProfilingReportViewScopeUserGroups { get; set; }

            [NameInMap("ProfilingReportViewScopeUserIds")]
            [Validation(Required=false)]
            public List<string> ProfilingReportViewScopeUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6865331517728384</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>train</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReadCount")]
            [Validation(Required=false)]
            public long? ReadCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ALL_USERS_CAN_VIEW</para>
            /// </summary>
            [NameInMap("ShelveViewScopeType")]
            [Validation(Required=false)]
            public string ShelveViewScopeType { get; set; }

            [NameInMap("ShelveViewScopeUserGroups")]
            [Validation(Required=false)]
            public List<string> ShelveViewScopeUserGroups { get; set; }

            [NameInMap("ShelveViewScopeUserIds")]
            [Validation(Required=false)]
            public List<string> ShelveViewScopeUserIds { get; set; }

            [NameInMap("SimpleNodeInfos")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfos> SimpleNodeInfos { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfos : TeaModel {
                [NameInMap("BizUnit")]
                [Validation(Required=false)]
                public string BizUnit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PROD</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>n_7443633109495119872</para>
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
                public List<GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfosOwners> Owners { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfosOwners : TeaModel {
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
                public GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfosProject Project { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfosProject : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6865331517728384</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>fashion_cdm</para>
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
            /// <para>DIM_NORMAL</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>odps.300023201.test.ads_gross</para>
            /// </summary>
            [NameInMap("SumTableGuid")]
            [Validation(Required=false)]
            public string SumTableGuid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ads_gross</para>
            /// </summary>
            [NameInMap("SumTableName")]
            [Validation(Required=false)]
            public string SumTableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>36000</para>
            /// </summary>
            [NameInMap("TableLifeCycle")]
            [Validation(Required=false)]
            public string TableLifeCycle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TableSizeInBytes")]
            [Validation(Required=false)]
            public long? TableSizeInBytes { get; set; }

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
        /// <para>Id of the request</para>
        /// 
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
