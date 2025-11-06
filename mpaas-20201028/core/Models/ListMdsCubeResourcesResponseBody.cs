// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class ListMdsCubeResourcesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public ListMdsCubeResourcesResponseBodyResultContent ResultContent { get; set; }
        public class ListMdsCubeResourcesResponseBodyResultContent : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public ListMdsCubeResourcesResponseBodyResultContentData Data { get; set; }
            public class ListMdsCubeResourcesResponseBodyResultContentData : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public ListMdsCubeResourcesResponseBodyResultContentDataContent Content { get; set; }
                public class ListMdsCubeResourcesResponseBodyResultContentDataContent : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0.0.1</para>
                    /// </summary>
                    [NameInMap("CurrentMaxAndroidVersion")]
                    [Validation(Required=false)]
                    public string CurrentMaxAndroidVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0.0.1</para>
                    /// </summary>
                    [NameInMap("CurrentMaxIosVersion")]
                    [Validation(Required=false)]
                    public string CurrentMaxIosVersion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("FirstPage")]
                    [Validation(Required=false)]
                    public bool? FirstPage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("FirstResult")]
                    [Validation(Required=false)]
                    public long? FirstResult { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("LastPage")]
                    [Validation(Required=false)]
                    public bool? LastPage { get; set; }

                    [NameInMap("List")]
                    [Validation(Required=false)]
                    public List<ListMdsCubeResourcesResponseBodyResultContentDataContentList> List { get; set; }
                    public class ListMdsCubeResourcesResponseBodyResultContentDataContentList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0.0.1</para>
                        /// </summary>
                        [NameInMap("AndroidMaxVersion")]
                        [Validation(Required=false)]
                        public string AndroidMaxVersion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0.0.1</para>
                        /// </summary>
                        [NameInMap("AndroidMinVersion")]
                        [Validation(Required=false)]
                        public string AndroidMinVersion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>570DA89281533-default</para>
                        /// </summary>
                        [NameInMap("AppCode")]
                        [Validation(Required=false)]
                        public string AppCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1fbfd6c422762c7083f3bb01c638e48e</para>
                        /// </summary>
                        [NameInMap("BinFileMd5")]
                        [Validation(Required=false)]
                        public string BinFileMd5 { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>url</para>
                        /// </summary>
                        [NameInMap("BinPrivateFileUrl")]
                        [Validation(Required=false)]
                        public string BinPrivateFileUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>url</para>
                        /// </summary>
                        [NameInMap("BinPublicFileUrl")]
                        [Validation(Required=false)]
                        public string BinPublicFileUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>&quot;&quot;</para>
                        /// </summary>
                        [NameInMap("ExtendInfo")]
                        [Validation(Required=false)]
                        public string ExtendInfo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2025-10-24 16:42:45</para>
                        /// </summary>
                        [NameInMap("GmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2025-10-24 16:42:45</para>
                        /// </summary>
                        [NameInMap("GmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0.0.1</para>
                        /// </summary>
                        [NameInMap("IosMaxVersion")]
                        [Validation(Required=false)]
                        public string IosMaxVersion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0.0.1</para>
                        /// </summary>
                        [NameInMap("IosMinVersion")]
                        [Validation(Required=false)]
                        public string IosMinVersion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>url</para>
                        /// </summary>
                        [NameInMap("JsonPrivateFileUrl")]
                        [Validation(Required=false)]
                        public string JsonPrivateFileUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>url</para>
                        /// </summary>
                        [NameInMap("JsonPublicFileUrl")]
                        [Validation(Required=false)]
                        public string JsonPublicFileUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>&quot;&quot;</para>
                        /// </summary>
                        [NameInMap("MinCubeSdkVersion")]
                        [Validation(Required=false)]
                        public string MinCubeSdkVersion { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>url</para>
                        /// </summary>
                        [NameInMap("MockDataDownloadUrl")]
                        [Validation(Required=false)]
                        public string MockDataDownloadUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>default</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Android</para>
                        /// </summary>
                        [NameInMap("Platform")]
                        [Validation(Required=false)]
                        public string Platform { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>url</para>
                        /// </summary>
                        [NameInMap("PreviewPictureUrl")]
                        [Validation(Required=false)]
                        public string PreviewPictureUrl { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("ResourceStatus")]
                        [Validation(Required=false)]
                        public long? ResourceStatus { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>test_template</para>
                        /// </summary>
                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>resource desc</para>
                        /// </summary>
                        [NameInMap("TemplateResourceDesc")]
                        [Validation(Required=false)]
                        public string TemplateResourceDesc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0.0.0.1</para>
                        /// </summary>
                        [NameInMap("TemplateResourceVersion")]
                        [Validation(Required=false)]
                        public string TemplateResourceVersion { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NextPage")]
                    [Validation(Required=false)]
                    public long? NextPage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PageNo")]
                    [Validation(Required=false)]
                    public int? PageNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("PageSize")]
                    [Validation(Required=false)]
                    public int? PageSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("PrePage")]
                    [Validation(Required=false)]
                    public long? PrePage { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public int? TotalCount { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NONE</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
                /// </summary>
                [NameInMap("RequestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("ResultMsg")]
                [Validation(Required=false)]
                public string ResultMsg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("Success")]
                [Validation(Required=false)]
                public bool? Success { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11E66B29-9E5E-5C10-B64E-B5A0E0F26355</para>
            /// </summary>
            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
