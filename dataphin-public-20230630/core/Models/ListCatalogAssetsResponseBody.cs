// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListCatalogAssetsResponseBody : TeaModel {
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
        /// <para>The data catalog asset list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCatalogAssetsResponseBodyData Data { get; set; }
        public class ListCatalogAssetsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The asset list.</para>
            /// </summary>
            [NameInMap("AssetList")]
            [Validation(Required=false)]
            public List<ListCatalogAssetsResponseBodyDataAssetList> AssetList { get; set; }
            public class ListCatalogAssetsResponseBodyDataAssetList : TeaModel {
                /// <summary>
                /// <para>The API call mode. Returned when the asset type is API. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Synchronous call.</description></item>
                /// <item><description>2: Asynchronous call.</description></item>
                /// </list>
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
                /// <para>Default API Group</para>
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
                /// <para>The API operation type. Returned when the asset type is API. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Get.</description></item>
                /// <item><description>2: List.</description></item>
                /// <item><description>3: Create.</description></item>
                /// <item><description>4: Update.</description></item>
                /// <item><description>5: Delete.</description></item>
                /// </list>
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
                /// <para>The display name of the asset. This parameter is returned when the asset type is TABLE, INDEX, or BIZ_INDEX.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc table</para>
                /// </summary>
                [NameInMap("AssetDisplayName")]
                [Validation(Required=false)]
                public string AssetDisplayName { get; set; }

                /// <summary>
                /// <para>The source of the asset. For TABLE (physical table), the value is returned in the format of &quot;Dataphin-Workspace Type-Project Chinese Name (Project English Name)&quot;. For TABLE (logical table), the value is returned in the format of &quot;Dataphin-Workspace Type-Data Domain Chinese Name (Data Domain English Name)&quot;. For TABLE (data source table), the value is returned in the format of &quot;Source System Name-Data Source Name-Database/Schema Name&quot;. For INDEX (standard modeling metric), the value is the asset source of the associated aggregate table. For INDEX (custom metric), the value is the asset source of the source table. For API, the value is the data service project name. For PAGE, the value is the application system name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Dataphin-Middle Layer-Fashion Retail (LD_Fashion)</para>
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
                /// <para>The BI space or folder to which the asset belongs. Returned when the asset type is PAGE (dashboard).</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataphin demo space</para>
                /// </summary>
                [NameInMap("BiCatalog")]
                [Validation(Required=false)]
                public string BiCatalog { get; set; }

                /// <summary>
                /// <para>The ID of the business unit to which the asset belongs. This parameter is returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
                /// 
                /// <b>Example:</b>
                /// <para>6865277495315392</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The name of the business unit to which the asset belongs. This parameter is returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Fashion Retail (LD_Fashion)</para>
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
                /// <para>The ID of the data domain to which the asset belongs. This parameter is returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
                /// 
                /// <b>Example:</b>
                /// <para>49837403</para>
                /// </summary>
                [NameInMap("DataCellId")]
                [Validation(Required=false)]
                public string DataCellId { get; set; }

                /// <summary>
                /// <para>The name of the data domain to which the asset belongs. Returned when the asset type is TABLE (logical tables only) or INDEX (technical metrics whose source table is a logical table only).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Course Domain</para>
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
                public List<ListCatalogAssetsResponseBodyDataAssetListDirectories> Directories { get; set; }
                public class ListCatalogAssetsResponseBodyDataAssetListDirectories : TeaModel {
                    /// <summary>
                    /// <para>The ID of the directory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>102260</para>
                    /// </summary>
                    [NameInMap("DirectoryId")]
                    [Validation(Required=false)]
                    public long? DirectoryId { get; set; }

                    /// <summary>
                    /// <para>The name of the directory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Online E-commerce Platform</para>
                    /// </summary>
                    [NameInMap("DirectoryName")]
                    [Validation(Required=false)]
                    public string DirectoryName { get; set; }

                    /// <summary>
                    /// <para>The ID of the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101676</para>
                    /// </summary>
                    [NameInMap("TopicId")]
                    [Validation(Required=false)]
                    public long? TopicId { get; set; }

                    /// <summary>
                    /// <para>The name of the topic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Omni-channel Data Topic</para>
                    /// </summary>
                    [NameInMap("TopicName")]
                    [Validation(Required=false)]
                    public string TopicName { get; set; }

                }

                /// <summary>
                /// <para>The statistical granularity name of the technical metric. This parameter is returned when the asset type is INDEX.</para>
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
                /// <para>Indicates whether the asset is deleted.</para>
                /// </summary>
                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

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
                /// <para>The subtype of the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DIM_NORMAL: common logical dimension table.</description></item>
                /// <item><description>DIM_ENUM: enumeration logical dimension table.</description></item>
                /// <item><description>DIM_VIRTUAL: virtual logical dimension table.</description></item>
                /// <item><description>SUM_BIZ_UNIT: aggregate table.</description></item>
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
                /// <para>The GUID of the aggregate table to which the asset belongs. This parameter is returned when the asset type is INDEX.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odps.300023201.test.ads_gross</para>
                /// </summary>
                [NameInMap("SumTableGuid")]
                [Validation(Required=false)]
                public string SumTableGuid { get; set; }

                /// <summary>
                /// <para>The name of the aggregate table to which the asset belongs. This parameter is returned when the asset type is INDEX.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ads_gross</para>
                /// </summary>
                [NameInMap("SumTableName")]
                [Validation(Required=false)]
                public string SumTableName { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
