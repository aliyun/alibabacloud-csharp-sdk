// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDataAssetsResponseBody : TeaModel {
        [NameInMap("PagingInfo")]
        [Validation(Required=false)]
        public ListDataAssetsResponseBodyPagingInfo PagingInfo { get; set; }
        public class ListDataAssetsResponseBodyPagingInfo : TeaModel {
            [NameInMap("DataAssets")]
            [Validation(Required=false)]
            public List<ListDataAssetsResponseBodyPagingInfoDataAssets> DataAssets { get; set; }
            public class ListDataAssetsResponseBodyPagingInfoDataAssets : TeaModel {
                [NameInMap("DataAssetTagMappings")]
                [Validation(Required=false)]
                public List<ListDataAssetsResponseBodyPagingInfoDataAssetsDataAssetTagMappings> DataAssetTagMappings { get; set; }
                public class ListDataAssetsResponseBodyPagingInfoDataAssetsDataAssetTagMappings : TeaModel {
                    [NameInMap("AutoTraceEnabled")]
                    [Validation(Required=false)]
                    public bool? AutoTraceEnabled { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("Creator")]
                    [Validation(Required=false)]
                    public string Creator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>7259557313</para>
                    /// </summary>
                    [NameInMap("DataAssetId")]
                    [Validation(Required=false)]
                    public string DataAssetId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>UserDefined</para>
                    /// </summary>
                    [NameInMap("TagSource")]
                    [Validation(Required=false)]
                    public string TagSource { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Prod</para>
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7259557313</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ali_cn_es_gfn</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>54275</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACS::DataWorks::Task</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc1ec92159376</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
