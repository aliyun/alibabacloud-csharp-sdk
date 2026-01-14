// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAILangStudio20240710.Models
{
    public class ListKnowledgeBaseChunksRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("ChunkStatus")]
        [Validation(Required=false)]
        public string ChunkStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MetaData")]
        [Validation(Required=false)]
        public ListKnowledgeBaseChunksRequestMetaData MetaData { get; set; }
        public class ListKnowledgeBaseChunksRequestMetaData : TeaModel {
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
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("VersionName")]
        [Validation(Required=false)]
        public string VersionName { get; set; }

    }

}
