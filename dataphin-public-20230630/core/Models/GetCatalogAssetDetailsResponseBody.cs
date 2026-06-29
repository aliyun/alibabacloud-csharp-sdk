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
            /// <para>The API call mode. Returned when the asset type is API. Valid values: 1 (synchronous call) and 2 (asynchronous call).</para>
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
            /// <para>默认API分组</para>
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
            /// <para>The API operation type. Returned when the asset type is API. Valid values: 1 (Get), 2 (List), 3 (Create), 4 (Update), and 5 (Delete).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApiRequestMethod")]
            [Validation(Required=false)]
            public string ApiRequestMethod { get; set; }

            /// <summary>
            /// <para>The asset description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("AssetDescription")]
            [Validation(Required=false)]
            public string AssetDescription { get; set; }

            /// <summary>
            /// <para>The URL of the asset catalog details page.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dataphin.poc.lydaas.com/market/catalog/detail/table/">https://dataphin.poc.lydaas.com/market/catalog/detail/table/</a>...</para>
            /// </summary>
            [NameInMap("AssetDetailUrl")]
            [Validation(Required=false)]
            public string AssetDetailUrl { get; set; }

            /// <summary>
            /// <para>The asset display name. Returned when the asset type is TABLE, INDEX, or BIZ_INDEX.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc表</para>
            /// </summary>
            [NameInMap("AssetDisplayName")]
            [Validation(Required=false)]
            public string AssetDisplayName { get; set; }

            /// <summary>
            /// <para>The asset source. For TABLE (physical table), the value is in the format of &quot;Dataphin-Workspace Type-Project Chinese Name (Project English Name)&quot;. For TABLE (logical table), the value is in the format of &quot;Dataphin-Workspace Type-Data Domain Chinese Name (Data Domain English Name)&quot;. For TABLE (data source table), the value is in the format of &quot;Source System Name-Data Source Name-Database/Schema Name&quot;. For INDEX (standard modeling metric), the value is the asset source of the associated aggregate table. For INDEX (custom metric), the value is the asset source of the source table. For API, the value is the data service project name. For PAGE, the value is the application system name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Dataphin-中间层-服饰零售 (LD_Fashion)</para>
            /// </summary>
            [NameInMap("AssetFrom")]
            [Validation(Required=false)]
            public string AssetFrom { get; set; }

            /// <summary>
            /// <para>The full name of the asset. Returned when the asset type is TABLE or INDEX.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dwd_all.abc</para>
            /// </summary>
            [NameInMap("AssetFullName")]
            [Validation(Required=false)]
            public string AssetFullName { get; set; }

            /// <summary>
            /// <para>The asset name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// <para>The asset tags.</para>
            /// </summary>
            [NameInMap("AssetTags")]
            [Validation(Required=false)]
            public List<string> AssetTags { get; set; }

            /// <summary>
            /// <para>The asset type. Valid values: TABLE (table, including views and materialized views), INDEX (technical metric), BIZ_INDEX (business metric), API, and PAGE (dashboard).</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// <para>The BI workspace or directory to which the asset belongs. Returned when the asset type is PAGE (dashboard).</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataphin演示空间</para>
            /// </summary>
            [NameInMap("BiCatalog")]
            [Validation(Required=false)]
            public string BiCatalog { get; set; }

            /// <summary>
            /// <para>The ID of the business unit to which the asset belongs. Returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>6865277495315392</para>
            /// </summary>
            [NameInMap("BizUnitId")]
            [Validation(Required=false)]
            public long? BizUnitId { get; set; }

            /// <summary>
            /// <para>The name of the business unit to which the asset belongs. Returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
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
            /// <para>The number of favorites.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CollectionCount")]
            [Validation(Required=false)]
            public long? CollectionCount { get; set; }

            /// <summary>
            /// <para>The field list. Returned when the asset type is TABLE.</para>
            /// </summary>
            [NameInMap("Columns")]
            [Validation(Required=false)]
            public List<GetCatalogAssetDetailsResponseBodyDataColumns> Columns { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataColumns : TeaModel {
                /// <summary>
                /// <para>The associated entity. Returned when the business type is DIMENSION.</para>
                /// </summary>
                [NameInMap("AssociatedEntity")]
                [Validation(Required=false)]
                public GetCatalogAssetDetailsResponseBodyDataColumnsAssociatedEntity AssociatedEntity { get; set; }
                public class GetCatalogAssetDetailsResponseBodyDataColumnsAssociatedEntity : TeaModel {
                    /// <summary>
                    /// <para>The business unit ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7137404445633152</para>
                    /// </summary>
                    [NameInMap("BizUnitId")]
                    [Validation(Required=false)]
                    public long? BizUnitId { get; set; }

                    /// <summary>
                    /// <para>The business unit name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LD_train</para>
                    /// </summary>
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                    /// <summary>
                    /// <para>The dimension display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>上药erp数据源</para>
                    /// </summary>
                    [NameInMap("DimensionDisplayName")]
                    [Validation(Required=false)]
                    public string DimensionDisplayName { get; set; }

                    /// <summary>
                    /// <para>The dimension ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>68014359</para>
                    /// </summary>
                    [NameInMap("DimensionId")]
                    [Validation(Required=false)]
                    public long? DimensionId { get; set; }

                    /// <summary>
                    /// <para>The dimension name.</para>
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
                /// <item><description>INDEX: Metric.</description></item>
                /// <item><description>STAT_PERIOD: Statistical period.</description></item>
                /// <item><description>DIMENSION: Dimension.</description></item>
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
                /// <para>The field data type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>double</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// <para>The field description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The field display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>门店客流转化率</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The field GUID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dp_table.300023201.ld_fashion.dws_lulu_location.conversion_rate</para>
                /// </summary>
                [NameInMap("Guid")]
                [Validation(Required=false)]
                public string Guid { get; set; }

                /// <summary>
                /// <para>The data sensitivity level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>L4</para>
                /// </summary>
                [NameInMap("LevelShortName")]
                [Validation(Required=false)]
                public string LevelShortName { get; set; }

                /// <summary>
                /// <para>The field name.</para>
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
                    /// <para>The standard code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hr_person_id</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The standard ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120350</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The standard name.</para>
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
                /// <para>The attribute type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>BUSINESS: Business attribute.</description></item>
                /// <item><description>MANAGEMENT: Management attribute.</description></item>
                /// <item><description>TECHNOLOGY: Technical attribute.</description></item>
                /// </list>
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
                /// <para>归口管理部门</para>
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
            /// <para>The ID of the subject domain to which the asset belongs. Returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>49837403</para>
            /// </summary>
            [NameInMap("DataCellId")]
            [Validation(Required=false)]
            public string DataCellId { get; set; }

            /// <summary>
            /// <para>The name of the subject domain to which the asset belongs. Returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>课程域</para>
            /// </summary>
            [NameInMap("DataCellName")]
            [Validation(Required=false)]
            public string DataCellName { get; set; }

            /// <summary>
            /// <para>The name of the data source to which the asset belongs. Returned when the asset type is TABLE (data source tables only) or INDEX (technical metrics whose source table is a data source table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo_mysql</para>
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// <para>The ID of the data source to which the asset belongs. Returned when the asset type is TABLE (data source tables only) or INDEX (technical metrics whose source table is a data source table only).</para>
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
                /// <para>线上电商平台</para>
                /// </summary>
                [NameInMap("DirectoryName")]
                [Validation(Required=false)]
                public string DirectoryName { get; set; }

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
                /// <para>全渠道数据专题</para>
                /// </summary>
                [NameInMap("TopicName")]
                [Validation(Required=false)]
                public string TopicName { get; set; }

            }

            /// <summary>
            /// <para>The first listing time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-22 10:06:20</para>
            /// </summary>
            [NameInMap("FirstOnShelveTime")]
            [Validation(Required=false)]
            public string FirstOnShelveTime { get; set; }

            /// <summary>
            /// <para>The user who first listed the asset.</para>
            /// </summary>
            [NameInMap("FirstOnShelveUser")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataFirstOnShelveUser FirstOnShelveUser { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataFirstOnShelveUser : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
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
            /// <para>课程</para>
            /// </summary>
            [NameInMap("Granularity")]
            [Validation(Required=false)]
            public string Granularity { get; set; }

            /// <summary>
            /// <para>The asset GUID, which serves as the unique identifier of the asset.</para>
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
            /// <item><description>true: Yes.</description></item>
            /// <item><description>false: No.</description></item>
            /// </list>
            /// </summary>
            [NameInMap("IsPartitionTable")]
            [Validation(Required=false)]
            public bool? IsPartitionTable { get; set; }

            /// <summary>
            /// <para>The last DDL change time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("LastDdlTime")]
            [Validation(Required=false)]
            public string LastDdlTime { get; set; }

            /// <summary>
            /// <para>The last DML update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-11 16:10:19</para>
            /// </summary>
            [NameInMap("LastDmlTime")]
            [Validation(Required=false)]
            public string LastDmlTime { get; set; }

            /// <summary>
            /// <para>The last listing time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-22 10:06:20</para>
            /// </summary>
            [NameInMap("LastOnShelveTime")]
            [Validation(Required=false)]
            public string LastOnShelveTime { get; set; }

            /// <summary>
            /// <para>The user who last listed the asset.</para>
            /// </summary>
            [NameInMap("LastOnShelveUser")]
            [Validation(Required=false)]
            public GetCatalogAssetDetailsResponseBodyDataLastOnShelveUser LastOnShelveUser { get; set; }
            public class GetCatalogAssetDetailsResponseBodyDataLastOnShelveUser : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
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
            /// <para>The listing maintenance personnel.</para>
            /// </summary>
            [NameInMap("MaintainUserIds")]
            [Validation(Required=false)]
            public List<string> MaintainUserIds { get; set; }

            /// <summary>
            /// <para>The highest sensitivity level. Returned when the asset type is TABLE.</para>
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
                /// <para>张三</para>
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
            /// <para>The partition field. Returned when the asset type is TABLE.</para>
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
            /// <para>The visibility scope type of the profiling report. Returned when the asset type is TABLE or INDEX. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ALL_USERS_CAN_VIEW: Visible to all users.</description></item>
            /// <item><description>PART_USERS_CAN_VIEW: Visible to some users.</description></item>
            /// <item><description>ALL_USERS_CAN_NOT_VIEW: Not visible to any user.</description></item>
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
            /// <para>The ID of the project to which the asset belongs. Returned when the asset type is TABLE (physical tables only) or INDEX (technical metrics whose source table is a physical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>6865331517728384</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The name of the project to which the asset belongs. Returned when the asset type is TABLE (physical tables only) or INDEX (technical metrics whose source table is a physical table only).</para>
            /// 
            /// <b>Example:</b>
            /// <para>train</para>
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// <para>The number of views.</para>
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
                /// <para>The environment to which the node belongs.</para>
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
                /// <para>The scheduling method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NORMAL: Timed scheduling.</description></item>
                /// <item><description>MANUAL: Manual scheduling.</description></item>
                /// </list>
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
                    /// <para>张三</para>
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
                /// <para>The node type. Example valid values: DLINK (offline integration) and PYTHON37 (Python compute node).</para>
                /// 
                /// <b>Example:</b>
                /// <para>DLINK</para>
                /// </summary>
                [NameInMap("SubBizType")]
                [Validation(Required=false)]
                public string SubBizType { get; set; }

            }

            /// <summary>
            /// <para>The subtype. Valid values: DIM_NORMAL (common logical dimension table), DIM_ENUM (enumeration logical dimension table), DIM_VIRTUAL (virtual logical dimension table), SUM_BIZ_UNIT (aggregate table), FACT_EVENT (event fact logical table), FACT_SNAPSHOT (snapshot fact logical table), DATASOURCE_TABLE (data source table), PHYSICAL_TABLE (physical table), DATASOURCE_VIEW (data source view), PHYSICAL_VIEW (physical view), MATERIALIZED_VIEW (materialized view), BIZ_INDEX (business metric), INDEX (technical metric - standard modeling metric), and CUSTOM_INDEX (technical metric - custom metric).</para>
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
            /// <para>The storage size in bytes. Returned when the asset type is TABLE.</para>
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
        /// <para>The details of the backend response exception.</para>
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
