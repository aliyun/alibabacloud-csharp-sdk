// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataAssetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataAssetsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataAssetsResponseBodyPagingInfo : TeaModel {
            /// <summary>
            /// <para>The data assets.</para>
            /// </summary>
            [NameInMap("DataAssets")]
            [Validation(Required=false)]
            public List<ListDataAssetsResponseBodyPagingInfoDataAssets> DataAssets { get; set; }
            public class ListDataAssetsResponseBodyPagingInfoDataAssets : TeaModel {
                /// <summary>
                /// <para>The mappings between data assets and tags.</para>
                /// </summary>
                [NameInMap("DataAssetTagMappings")]
                [Validation(Required=false)]
                public List<ListDataAssetsResponseBodyPagingInfoDataAssetsDataAssetTagMappings> DataAssetTagMappings { get; set; }
                public class ListDataAssetsResponseBodyPagingInfoDataAssetsDataAssetTagMappings : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the lineage-based automatic backtrack feature is enabled for the mapping.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("AutoTraceEnabled")]
                    [Validation(Required=false)]
                    public bool? AutoTraceEnabled { get; set; }

                    /// <summary>
                    /// <para>The creator of the mapping between the data asset and the tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    /// <summary>
                    /// <para>The data asset ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7259557313</para>
                    /// </summary>
                    [NameInMap("DataAssetId")]
                    [Validation(Required=false)]
                    public string DataAssetId { get; set; }

                    /// <summary>
                    /// <para>The tag key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The way in which the mapping between the data asset and the tag is created. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>System</description></item>
                    /// <item><description>UserDefined</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>UserDefined</para>
                    /// </summary>
                    [NameInMap("TagSource")]
                    [Validation(Required=false)]
                    public string TagSource { get; set; }

                    /// <summary>
                    /// <para>The tag value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The environment of the workspace to which the data asset belongs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Dev: development environment</description></item>
                /// <item><description>Prod: production environment</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <para>The data asset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7259557313</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The name of the data asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ali_cn_es_gfn</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The DataWorks workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>54275</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The type of the data asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ACS::DataWorks::Table</description></item>
                /// <item><description>ACS::DataWorks::Task</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ACS::DataWorks::Task</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
