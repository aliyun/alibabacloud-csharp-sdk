// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class ListKnowledgeBaseChunksResponseBody : TeaModel {
        /// <summary>
        /// <para>切片列表</para>
        /// </summary>
        [NameInMap("KnowledgeBaseChunks")]
        [Validation(Required=false)]
        public List<ListKnowledgeBaseChunksResponseBodyKnowledgeBaseChunks> KnowledgeBaseChunks { get; set; }
        public class ListKnowledgeBaseChunksResponseBodyKnowledgeBaseChunks : TeaModel {
            /// <summary>
            /// <para>切片附属信息</para>
            /// </summary>
            [NameInMap("ChunkAttachment")]
            [Validation(Required=false)]
            public List<ListKnowledgeBaseChunksResponseBodyKnowledgeBaseChunksChunkAttachment> ChunkAttachment { get; set; }
            public class ListKnowledgeBaseChunksResponseBodyKnowledgeBaseChunksChunkAttachment : TeaModel {
                /// <summary>
                /// <para>下载地址</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://mybucket.oss-cn-shanghai.aliyuncs.com/">https://mybucket.oss-cn-shanghai.aliyuncs.com/</a>...</para>
                /// </summary>
                [NameInMap("DownloadUrl")]
                [Validation(Required=false)]
                public string DownloadUrl { get; set; }

                /// <summary>
                /// <para>占位符ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>IMAGE_PLACEHOLDER_0</para>
                /// </summary>
                [NameInMap("PlaceholderId")]
                [Validation(Required=false)]
                public string PlaceholderId { get; set; }

                /// <summary>
                /// <para>类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>image</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>路径</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://mybucket/path/file.txt</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>切片内容</para>
            /// 
            /// <b>Example:</b>
            /// <para>content</para>
            /// </summary>
            [NameInMap("ChunkContent")]
            [Validation(Required=false)]
            public string ChunkContent { get; set; }

            /// <summary>
            /// <para>切片结束位置</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000</para>
            /// </summary>
            [NameInMap("ChunkEnd")]
            [Validation(Required=false)]
            public int? ChunkEnd { get; set; }

            /// <summary>
            /// <para>切片顺序</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ChunkSequence")]
            [Validation(Required=false)]
            public int? ChunkSequence { get; set; }

            /// <summary>
            /// <para>切片大小</para>
            /// 
            /// <b>Example:</b>
            /// <para>1873</para>
            /// </summary>
            [NameInMap("ChunkSize")]
            [Validation(Required=false)]
            public int? ChunkSize { get; set; }

            /// <summary>
            /// <para>切片起始位置</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ChunkStart")]
            [Validation(Required=false)]
            public int? ChunkStart { get; set; }

            /// <summary>
            /// <para>切片状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("ChunkStatus")]
            [Validation(Required=false)]
            public string ChunkStatus { get; set; }

            /// <summary>
            /// <para>切片下载地址</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://mybucket.oss-cn-shanghai.aliyuncs.com/">https://mybucket.oss-cn-shanghai.aliyuncs.com/</a>...</para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>切片ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>123e4567-e89b-12d3-a456-426655440000</para>
            /// </summary>
            [NameInMap("KnowledgeBaseChunkId")]
            [Validation(Required=false)]
            public string KnowledgeBaseChunkId { get; set; }

            /// <summary>
            /// <para>知识库ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-ix****o9</para>
            /// </summary>
            [NameInMap("KnowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>原始文件信息</para>
            /// </summary>
            [NameInMap("MetaData")]
            [Validation(Required=false)]
            public ListKnowledgeBaseChunksResponseBodyKnowledgeBaseChunksMetaData MetaData { get; set; }
            public class ListKnowledgeBaseChunksResponseBodyKnowledgeBaseChunksMetaData : TeaModel {
                /// <summary>
                /// <para>文件元数据ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>xd8e****79du</para>
                /// </summary>
                [NameInMap("FileMetaId")]
                [Validation(Required=false)]
                public string FileMetaId { get; set; }

                /// <summary>
                /// <para>文件名</para>
                /// 
                /// <b>Example:</b>
                /// <para>file1.txt</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>文件地址</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://mybucketpath/file1.txt</para>
                /// </summary>
                [NameInMap("FileUri")]
                [Validation(Required=false)]
                public string FileUri { get; set; }

            }

            /// <summary>
            /// <para>切片缩略图</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://mybucket.oss-cn-shanghai.aliyuncs.com/">https://mybucket.oss-cn-shanghai.aliyuncs.com/</a>...</para>
            /// </summary>
            [NameInMap("ThumbnailUrl")]
            [Validation(Required=false)]
            public string ThumbnailUrl { get; set; }

            /// <summary>
            /// <para>知识库版本</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>963BD7F9-0C02-5594-9550-BCC6DD43E3C0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
