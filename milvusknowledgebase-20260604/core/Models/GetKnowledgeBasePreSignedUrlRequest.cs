// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class GetKnowledgeBasePreSignedUrlRequest : TeaModel {
        [NameInMap("Documents")]
        [Validation(Required=false)]
        public List<GetKnowledgeBasePreSignedUrlRequestDocuments> Documents { get; set; }
        public class GetKnowledgeBasePreSignedUrlRequestDocuments : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CHANGELOG.md</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>本地上传时为预签名上传使用的批次相对路径；不同 ImportType 下含义由导入类型定义。</para>
            /// 
            /// <b>Example:</b>
            /// <para>contract-2026.md</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("ExpiresIn")]
        [Validation(Required=false)]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>kb-3bd02617e9be335f</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

    }

}
