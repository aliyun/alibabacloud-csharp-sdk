// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListCatalogAssetsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCatalogAssetsResponseBodyData Data { get; set; }
        public class ListCatalogAssetsResponseBodyData : TeaModel {
            [NameInMap("AssetList")]
            [Validation(Required=false)]
            public List<ListCatalogAssetsResponseBodyDataAssetList> AssetList { get; set; }
            public class ListCatalogAssetsResponseBodyDataAssetList : TeaModel {
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
                public List<ListCatalogAssetsResponseBodyDataAssetListDirectories> Directories { get; set; }
                public class ListCatalogAssetsResponseBodyDataAssetListDirectories : TeaModel {
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

                [NameInMap("IsDeleted")]
                [Validation(Required=false)]
                public bool? IsDeleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>L3</para>
                /// </summary>
                [NameInMap("MaxSecurityLevel")]
                [Validation(Required=false)]
                public string MaxSecurityLevel { get; set; }

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

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

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
