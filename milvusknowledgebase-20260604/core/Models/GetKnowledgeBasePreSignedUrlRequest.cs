// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class GetKnowledgeBasePreSignedUrlRequest : TeaModel {
        /// <summary>
        /// <para>The list of files to upload. You can specify 1 to 100 files.</para>
        /// </summary>
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public List<GetKnowledgeBasePreSignedUrlRequestDocuments> Documents { get; set; }
        public class GetKnowledgeBasePreSignedUrlRequestDocuments : TeaModel {
            /// <summary>
            /// <para>The display name of the file. If not specified, the file name from Path is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CHANGELOG.md</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The file name or relative path for local upload scenarios. The value cannot start with <c>direct_upload/</c> or <c>uploaded/</c>, cannot contain empty segments, <c>.</c>, or <c>..</c>, and must be 1024 bytes or less.</para>
            /// 
            /// <b>Example:</b>
            /// <para>contract-2026.md</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The file size in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the pre-signed URL in seconds. Default value: <c>3600</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("ExpiresIn")]
        [Validation(Required=false)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// <para>The knowledge base ID. Either this parameter or datasetId must be specified. This parameter takes priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-3bd02617e9be335f</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

    }

}
