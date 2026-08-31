// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetCatalogAssetDetailsResponseBody : TeaModel {
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
        /// <para>The data catalog asset details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCatalogAssetDetailsResponseBodyData Data { get; set; }
        public class GetCatalogAssetDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The API call mode. Returned when the asset type is API. Valid values: 1=Synchronous call, 2=Asynchronous call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApiCallMode")]
            [Validation(Required=false)]
            public string ApiCallMode { get; set; }

            /// <summary>
            /// <para>The API group name. Returned when the asset type is API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default API group</para>
            /// </summary>
            [NameInMap("ApiGroupName")]
            [Validation(Required=false)]
            public string ApiGroupName { get; set; }

            /// <summary>
            /// <para>The API ID. Returned when the asset type is API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10441</para>
            /// </summary>
            [NameInMap("ApiId")]
            [Validation(Required=false)]
            public long? ApiId { get; set; }

            /// <summary>
            /// <para>The API operation type. Returned when the asset type is API. Valid values: 1=Get, 2=List, 3=Create, 4=Update, 5=Delete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApiRequestMethod")]
            [Validation(Required=false)]
            public string ApiRequestMethod { get; set; }

            /// <summary>
            /// <para>The description of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("AssetDescription")]
            [Validation(Required=false)]
            public string AssetDescription { get; set; }

            /// <summary>
            /// <para>The URL of the asset catalog detail page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dataphin.poc.lydaas.com/market/catalog/detail/table/">https://dataphin.poc.lydaas.com/market/catalog/detail/table/</a>...</para>
            /// </summary>
            [NameInMap("AssetDetailUrl")]
            [Validation(Required=false)]
            public string AssetDetailUrl { get; set; }

            /// <summary>
            /// <para>The display name of the asset. This parameter is returned when the asset type is TABLE, INDEX, or BIZ_INDEX.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc表</para>
            /// </summary>
            [NameInMap("AssetDisplayName")]
            [Validation(Required=false)]
            public string AssetDisplayName { get; set; }

            /// <summary>
            /// <para>The source of the asset. TABLE (physical table) returns &quot;Dataphin-workspace type-project Chinese name (project English name)&quot;. TABLE (logical table) returns &quot;Dataphin-workspace type-data domain Chinese name (data domain English name)&quot;. TABLE (data source table) returns &quot;source system name-data source name-database/schema name&quot;. INDEX (standard modeling metric) returns the asset source of the associated aggregate logical table. INDEX (custom metric) returns the asset source of the source table. API returns &quot;data service project name&quot;. PAGE returns &quot;application system name&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dataphin-中间层-服饰零售 (LD_Fashion)</para>
            /// </summary>
            [NameInMap("AssetFrom")]
            [Validation(Required=false)]
            public string AssetFrom { get; set; }

            /// <summary>
            /// <para>The full name of the asset. This parameter is returned when the asset type is TABLE or INDEX.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dwd_all.abc</para>
            /// </summary>
            [NameInMap("AssetFullName")]
            [Validation(Required=false)]
            public string AssetFullName { get; set; }

            /// <summary>
            /// <para>The name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <para>The tags of the asset.</para>
            /// </summary>
            [NameInMap("AssetTags")]
            [Validation(Required=false)]
            public List<string> AssetTags { get; set; }

            /// <summary>
            /// <para>The asset type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TABLE: table, including views and materialized views.</description></item>
            /// <item><description>INDEX: technical metric.</description></item>
            /// <item><description>BIZ_INDEX: business metric.</description></item>
            /// <item><description>API: API.</description></item>
            /// <item><description>PAGE: dashboard.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The BI workspace or folder to which the asset belongs. Returned when the asset type is PAGE (dashboard).</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataphin演示空间</para>
            /// </summary>
            [NameInMap("BiCatalog")]
            [Validation(Required=false)]
            public string BiCatalog { get; set; }

            /// <summary>
            /// <para>The ID of the data domain to which the asset belongs. This parameter is returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>6865277495315392</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The name of the data domain to which the asset belongs. This parameter is returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>服饰零售（LD_Fashion）</para>
            /// </summary>
            [NameInMap("BizUnitName")]
            [Validation(Required=false)]
            public string BizUnitName { get; set; }

            /// <summary>
            /// <para>The total number of charts. Returned when the asset type is PAGE (dashboard).</para>
            /// 
            /// <b>Example:</b>
            /// <para>23</para>
            /// </summary>
            [NameInMap("ChartCount")]
            [Validation(Required=false)]
            public long? ChartCount { get; set; }

            /// <summary>
            /// <para>The collection count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CollectionCount")]
            [Validation(Required=false)]
            public long? CollectionCount { get; set; }

            /// <summary>
            /// <para>The list of columns. This parameter is returned when the asset type is TABLE.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataColumns> Columns { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataColumns : TeaModel {
                /// <summary>
                /// <para>The associated entity. This parameter is returned when the business type is DIMENSION.</para>
                /// </summary>
                [NameInMap("AssociatedEntity")]
                [Validation(Required=false)]
                public GetCatalogAssetDetailsResponseBodyDataColumnsAssociatedEntity AssociatedEntity { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataColumnsAssociatedEntity : TeaModel {
                    /// <summary>
                    /// <para>The ID of the business unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7137404445633152</para>
                    /// </summary>
                    [NameInMap("BizUnitId")]
                    [Validation(Required=false)]
                    public long? BizUnitId { get; set; }

                    /// <summary>
                    /// <para>The name of the business unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LD_train</para>
                    /// </summary>
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                    /// <summary>
                    /// <para>The display name of the dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>上药erp数据源</para>
                    /// </summary>
                    [NameInMap("DimensionDisplayName")]
                    [Validation(Required=false)]
                    public string DimensionDisplayName { get; set; }

                    /// <summary>
                    /// <para>The ID of the dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68014359</para>
                    /// </summary>
                    [NameInMap("DimensionId")]
                    [Validation(Required=false)]
                    public long? DimensionId { get; set; }

                    /// <summary>
                    /// <para>The name of the dimension.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>etl_source</para>
                    /// </summary>
                    [NameInMap("DimensionName")]
                    [Validation(Required=false)]
                    public string DimensionName { get; set; }

                }

                /// <summary>
                /// <para>The business type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INDEX: metric.</description></item>
                /// <item><description>STAT_PERIOD: statistical period.</description></item>
                /// <item><description>DIMENSION: dimension.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DIMENSION</para>
                /// </summary>
                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                /// <summary>
                /// <para>The data classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/交易信息/0000001</para>
                /// </summary>
                [NameInMap("ClassifyName")]
                [Validation(Required=false)]
                public string ClassifyName { get; set; }

                /// <summary>
                /// <para>The data type of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>double</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The description of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Store traffic conversion rate</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The GUID of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dp_table.300023201.ld_fashion.dws_lulu_location.conversion_rate</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>The data classification level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>L4</para>
                /// </summary>
                [NameInMap("LevelShortName")]
                [Validation(Required=false)]
                public string LevelShortName { get; set; }

                /// <summary>
                /// <para>The name of the column.</para>
                /// 
                /// <b>Example:</b>
                /// <para>conversion_rate</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The quality score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("QualityScore")]
                [Validation(Required=false)]
                public double? QualityScore { get; set; }

                /// <summary>
                /// <para>The associated standards.</para>
                /// </summary>
                [NameInMap("Standards")]
                [Validation(Required=false)]
                public List<GetCatalogAssetDetailsResponseBodyDataColumnsStandards> Standards { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataColumnsStandards : TeaModel {
                    /// <summary>
                    /// <para>The code of the standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hr_person_id</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The ID of the standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120350</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The name of the standard.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The custom attributes. Returned when includeDetailedAttributes is set to true.</para>
            /// </summary>
            [NameInMap("CustomAttributes")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataCustomAttributes> CustomAttributes { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataCustomAttributes : TeaModel {
                /// <summary>
                /// <para>The attribute type. Valid values: BUSINESS (business attribute), MANAGEMENT (management attribute), TECHNOLOGY (technical attribute).</para>
                /// 
                /// <b>Example:</b>
                /// <para>MANAGEMENT</para>
                /// </summary>
                [NameInMap("AttrType")]
                [Validation(Required=false)]
                public string AttrType { get; set; }

                /// <summary>
                /// <para>The attribute code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gkglbm</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The attribute name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Supervising department</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The attribute value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the data domain. Returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>49837403</para>
            /// </summary>
            [NameInMap("DataCellId")]
            [Validation(Required=false)]
            public string DataCellId { get; set; }

            /// <summary>
            /// <para>The name of the data domain. Returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Course domain</para>
            /// </summary>
            [NameInMap("DataCellName")]
            [Validation(Required=false)]
            public string DataCellName { get; set; }

            /// <summary>
            /// <para>The name of the data source to which the asset belongs. This parameter is returned when the asset type is TABLE (data source tables only) or INDEX (technical metrics whose source table is a data source table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_mysql</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The ID of the data source to which the asset belongs. This parameter is returned when the asset type is TABLE (data source tables only) or INDEX (technical metrics whose source table is a data source table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>7305549302863001856</para>
            /// </summary>
            [NameInMap("DatasourceId")]
            [Validation(Required=false)]
            public long? DatasourceId { get; set; }

            /// <summary>
            /// <para>The directories to which the asset belongs, including topic ID, topic name, directory ID, and directory name.</para>
            /// </summary>
            [NameInMap("Directories")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataDirectories> Directories { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataDirectories : TeaModel {
                /// <summary>
                /// <para>The complete directory hierarchy chain from the top-level directory to the current directory, including the current directory.</para>
                /// </summary>
                [NameInMap("DirectoryChain")]
                [Validation(Required=false)]
                public List<GetCatalogAssetDetailsResponseBodyDataDirectoriesDirectoryChain> DirectoryChain { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataDirectoriesDirectoryChain : TeaModel {
                    /// <summary>
                    /// <para>The directory description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Data assets related to transactions</para>
                    /// </summary>
                    [NameInMap("DirectoryDescription")]
                    [Validation(Required=false)]
                    public string DirectoryDescription { get; set; }

                    /// <summary>
                    /// <para>The directory ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2001</para>
                    /// </summary>
                    [NameInMap("DirectoryId")]
                    [Validation(Required=false)]
                    public long? DirectoryId { get; set; }

                    /// <summary>
                    /// <para>The directory name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Transaction domain</para>
                    /// </summary>
                    [NameInMap("DirectoryName")]
                    [Validation(Required=false)]
                    public string DirectoryName { get; set; }

                    /// <summary>
                    /// <para>The folder level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public int? Level { get; set; }

                }

                /// <summary>
                /// <para>The directory description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data tables related to order details</para>
                /// </summary>
                [NameInMap("DirectoryDescription")]
                [Validation(Required=false)]
                public string DirectoryDescription { get; set; }

                /// <summary>
                /// <para>The directory ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102260</para>
                /// </summary>
                [NameInMap("DirectoryId")]
                [Validation(Required=false)]
                public long? DirectoryId { get; set; }

                /// <summary>
                /// <para>The directory name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Online e-commerce platform</para>
                /// </summary>
                [NameInMap("DirectoryName")]
                [Validation(Required=false)]
                public string DirectoryName { get; set; }

                /// <summary>
                /// <para>The topic description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Core data asset catalog for the entire company, covering all online and offline channels</para>
                /// </summary>
                [NameInMap("TopicDescription")]
                [Validation(Required=false)]
                public string TopicDescription { get; set; }

                /// <summary>
                /// <para>The topic ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101676</para>
                /// </summary>
                [NameInMap("TopicId")]
                [Validation(Required=false)]
                public long? TopicId { get; set; }

                /// <summary>
                /// <para>The topic name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Omni-channel data topic</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            /// <summary>
            /// <para>The time of the first listing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-22 10:06:20</para>
            /// </summary>
            [NameInMap("FirstOnShelveTime")]
            [Validation(Required=false)]
            public string FirstOnShelveTime { get; set; }

            /// <summary>
            /// <para>The user who performed the first listing.</para>
            /// </summary>
            [NameInMap("FirstOnShelveUser")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataFirstOnShelveUser FirstOnShelveUser { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataFirstOnShelveUser : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The statistical granularity name of the technical metric. Returned when the asset type is INDEX.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Course</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <para>The GUID of the asset, which serves as the unique identifier of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dp_ds_table.300023201.7311626611751680256.load_test.abc</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            /// <summary>
            /// <para>The usage instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Instruction")]
            [Validation(Required=false)]
            public string Instruction { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset is deleted.</para>
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public bool? IsDeleted { get; set; }

            /// <summary>
            /// <para>Indicates whether the table is a partitioned table. Returned when the asset type is TABLE. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The table is a partitioned table.</description></item>
            /// <item><description>false: The table is not a partitioned table.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsPartitionTable")]
            [Validation(Required=false)]
            public bool? IsPartitionTable { get; set; }

            /// <summary>
            /// <para>The time of the last DDL change.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("LastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <para>The time of the last DML update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("LastDmlTime")]
            [Validation(Required=false)]
            public string LastDmlTime { get; set; }

            /// <summary>
            /// <para>The time of the last listing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-22 10:06:20</para>
            /// </summary>
            [NameInMap("LastOnShelveTime")]
            [Validation(Required=false)]
            public string LastOnShelveTime { get; set; }

            /// <summary>
            /// <para>The user who performed the last listing.</para>
            /// </summary>
            [NameInMap("LastOnShelveUser")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataLastOnShelveUser LastOnShelveUser { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataLastOnShelveUser : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The listing maintenance user groups.</para>
            /// </summary>
            [NameInMap("MaintainUserGroups")]
            [Validation(Required=false)]
            public List<string> MaintainUserGroups { get; set; }

            /// <summary>
            /// <para>The IDs of the listing maintenance users.</para>
            /// </summary>
            [NameInMap("MaintainUserIds")]
            [Validation(Required=false)]
            public List<string> MaintainUserIds { get; set; }

            /// <summary>
            /// <para>The maximum sensitivity level. This parameter is returned when the asset type is TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L3</para>
            /// </summary>
            [NameInMap("MaxSecurityLevel")]
            [Validation(Required=false)]
            public string MaxSecurityLevel { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The owner.</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataOwner Owner { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataOwner : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The partition key. Returned when the asset type is TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds</para>
            /// </summary>
            [NameInMap("PartitionKey")]
            [Validation(Required=false)]
            public string PartitionKey { get; set; }

            /// <summary>
            /// <para>The primary key. Returned when the asset type is TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>employee_id</para>
            /// </summary>
            [NameInMap("PrimaryKey")]
            [Validation(Required=false)]
            public string PrimaryKey { get; set; }

            /// <summary>
            /// <para>The visibility scope type of the profiling report. This parameter is returned only when the asset type is TABLE or INDEX. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL_USERS_CAN_VIEW: Visible to all users.</description></item>
            /// <item><description>PART_USERS_CAN_VIEW: Visible to some users.</description></item>
            /// <item><description>ALL_USERS_CAN_NOT_VIEW: Not visible to any users.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL_USERS_CAN_VIEW</para>
            /// </summary>
            [NameInMap("ProfilingReportViewScopeType")]
            [Validation(Required=false)]
            public string ProfilingReportViewScopeType { get; set; }

            /// <summary>
            /// <para>The user groups within the profiling report visibility scope.</para>
            /// </summary>
            [NameInMap("ProfilingReportViewScopeUserGroups")]
            [Validation(Required=false)]
            public List<string> ProfilingReportViewScopeUserGroups { get; set; }

            /// <summary>
            /// <para>The users within the profiling report visibility scope.</para>
            /// </summary>
            [NameInMap("ProfilingReportViewScopeUserIds")]
            [Validation(Required=false)]
            public List<string> ProfilingReportViewScopeUserIds { get; set; }

            /// <summary>
            /// <para>The ID of the project to which the asset belongs. This parameter is returned when the asset type is TABLE (physical tables only) or INDEX (technical metrics whose source table is a physical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>6865331517728384</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the project to which the asset belongs. This parameter is returned when the asset type is TABLE (physical tables only) or INDEX (technical metrics whose source table is a physical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>train</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The quality score radar chart information. This parameter is returned only when includeDetailedAttributes is set to true. It contains the total score, the number of passed/validated rules, and the score details for each dimension.</para>
            /// </summary>
            [NameInMap("QualityScoreRadar")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataQualityScoreRadar QualityScoreRadar { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataQualityScoreRadar : TeaModel {
                /// <summary>
                /// <para>The list of dimension scores.</para>
                /// </summary>
                [NameInMap("CatalogScores")]
                [Validation(Required=false)]
                public List<GetCatalogAssetDetailsResponseBodyDataQualityScoreRadarCatalogScores> CatalogScores { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataQualityScoreRadarCatalogScores : TeaModel {
                    /// <summary>
                    /// <para>The dimension name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Completeness</para>
                    /// </summary>
                    [NameInMap("Catalog")]
                    [Validation(Required=false)]
                    public string Catalog { get; set; }

                    /// <summary>
                    /// <para>The number of field-level rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("FieldRuleCount")]
                    [Validation(Required=false)]
                    public int? FieldRuleCount { get; set; }

                    /// <summary>
                    /// <para>The pass rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.83</para>
                    /// </summary>
                    [NameInMap("PassRate")]
                    [Validation(Required=false)]
                    public double? PassRate { get; set; }

                    /// <summary>
                    /// <para>The number of passed rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("PassRuleCount")]
                    [Validation(Required=false)]
                    public int? PassRuleCount { get; set; }

                    /// <summary>
                    /// <para>The dimension score.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>85.5</para>
                    /// </summary>
                    [NameInMap("Score")]
                    [Validation(Required=false)]
                    public double? Score { get; set; }

                    /// <summary>
                    /// <para>The number of table-level rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("TableRuleCount")]
                    [Validation(Required=false)]
                    public int? TableRuleCount { get; set; }

                    /// <summary>
                    /// <para>The number of validated rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("ValidateRuleCount")]
                    [Validation(Required=false)]
                    public int? ValidateRuleCount { get; set; }

                }

                /// <summary>
                /// <para>The number of passed rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PassRuleCount")]
                [Validation(Required=false)]
                public int? PassRuleCount { get; set; }

                /// <summary>
                /// <para>The total quality score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85.5</para>
                /// </summary>
                [NameInMap("TotalScore")]
                [Validation(Required=false)]
                public double? TotalScore { get; set; }

                /// <summary>
                /// <para>The number of validated rules.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("ValidateRuleCount")]
                [Validation(Required=false)]
                public int? ValidateRuleCount { get; set; }

            }

            /// <summary>
            /// <para>The view count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ReadCount")]
            [Validation(Required=false)]
            public long? ReadCount { get; set; }

            /// <summary>
            /// <para>The visibility scope type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL_USERS_CAN_VIEW: Visible to all users.</description></item>
            /// <item><description>PART_USERS_CAN_VIEW: Visible to some users.</description></item>
            /// <item><description>PART_USERS_CAN_NOT_VIEW: Not visible to some users.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALL_USERS_CAN_VIEW</para>
            /// </summary>
            [NameInMap("ShelveViewScopeType")]
            [Validation(Required=false)]
            public string ShelveViewScopeType { get; set; }

            /// <summary>
            /// <para>The user groups within the visibility scope.</para>
            /// </summary>
            [NameInMap("ShelveViewScopeUserGroups")]
            [Validation(Required=false)]
            public List<string> ShelveViewScopeUserGroups { get; set; }

            /// <summary>
            /// <para>The users within the visibility scope.</para>
            /// </summary>
            [NameInMap("ShelveViewScopeUserIds")]
            [Validation(Required=false)]
            public List<string> ShelveViewScopeUserIds { get; set; }

            /// <summary>
            /// <para>The output nodes. Returned when the asset type is TABLE.</para>
            /// </summary>
            [NameInMap("SimpleNodeInfos")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfos> SimpleNodeInfos { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfos : TeaModel {
                /// <summary>
                /// <para>The business unit to which the node belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BizUnit")]
                [Validation(Required=false)]
                public string BizUnit { get; set; }

                /// <summary>
                /// <para>The environment to which the asset belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PROD</para>
                /// </summary>
                [NameInMap("Env")]
                [Validation(Required=false)]
                public string Env { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>n_7443633109495119872</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2345</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The scheduling type. Valid values: NORMAL (timed scheduling), MANUAL (manual scheduling).</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("NodeScheduleType")]
                [Validation(Required=false)]
                public string NodeScheduleType { get; set; }

                /// <summary>
                /// <para>The list of O&amp;M owners.</para>
                /// </summary>
                [NameInMap("Owners")]
                [Validation(Required=false)]
                public List<GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfosOwners> Owners { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfosOwners : TeaModel {
                    /// <summary>
                    /// <para>The username.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>John</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("UserId")]
                    [Validation(Required=false)]
                    public string UserId { get; set; }

                }

                /// <summary>
                /// <para>The project to which the node belongs.</para>
                /// </summary>
                [NameInMap("Project")]
                [Validation(Required=false)]
                public GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfosProject Project { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataSimpleNodeInfosProject : TeaModel {
                    /// <summary>
                    /// <para>The project ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6865331517728384</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    /// <summary>
                    /// <para>The project name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>fashion_cdm</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                }

                /// <summary>
                /// <para>The node type. Example valid values: DLINK (offline integration), PYTHON37 (Python compute node).</para>
                /// 
                /// <b>Example:</b>
                /// <para>DLINK</para>
                /// </summary>
                [NameInMap("SubBizType")]
                [Validation(Required=false)]
                public string SubBizType { get; set; }

            }

            /// <summary>
            /// <para>The subtype. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DIM_NORMAL: common logical dimension table.</description></item>
            /// <item><description>DIM_ENUM: enumeration logical dimension table.</description></item>
            /// <item><description>DIM_VIRTUAL: virtual logical dimension table.</description></item>
            /// <item><description>SUM_BIZ_UNIT: aggregate logical table.</description></item>
            /// <item><description>FACT_EVENT: event fact logical table.</description></item>
            /// <item><description>FACT_SNAPSHOT: snapshot fact logical table.</description></item>
            /// <item><description>DATASOURCE_TABLE: data source table.</description></item>
            /// <item><description>PHYSICAL_TABLE: physical table.</description></item>
            /// <item><description>DATASOURCE_VIEW: view (data source view).</description></item>
            /// <item><description>PHYSICAL_VIEW: physical view.</description></item>
            /// <item><description>MATERIALIZED_VIEW: materialized view.</description></item>
            /// <item><description>BIZ_INDEX: business metric.</description></item>
            /// <item><description>INDEX: technical metric (standard modeling metric).</description></item>
            /// <item><description>CUSTOM_INDEX: technical metric (custom metric).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DIM_NORMAL</para>
            /// </summary>
            [NameInMap("SubType")]
            [Validation(Required=false)]
            public string SubType { get; set; }

            /// <summary>
            /// <para>The GUID of the aggregate table to which the asset belongs. Returned when the asset type is INDEX.</para>
            /// 
            /// <b>Example:</b>
            /// <para>odps.300023201.test.ads_gross</para>
            /// </summary>
            [NameInMap("SumTableGuid")]
            [Validation(Required=false)]
            public string SumTableGuid { get; set; }

            /// <summary>
            /// <para>The name of the aggregate table to which the asset belongs. Returned when the asset type is INDEX.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ads_gross</para>
            /// </summary>
            [NameInMap("SumTableName")]
            [Validation(Required=false)]
            public string SumTableName { get; set; }

            /// <summary>
            /// <para>The lifecycle. Returned when the asset type is TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36000</para>
            /// </summary>
            [NameInMap("TableLifeCycle")]
            [Validation(Required=false)]
            public string TableLifeCycle { get; set; }

            /// <summary>
            /// <para>The storage size. This parameter is returned only when the asset type is TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TableSizeInBytes")]
            [Validation(Required=false)]
            public long? TableSizeInBytes { get; set; }

        }

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
        /// <para>The backend response exception details.</para>
        /// 
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

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
