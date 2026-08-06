// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class AddDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;,&quot;AuthPrincipalOwnerId&quot;:&quot;1234567890123456&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,&quot;AuthPrincipalDisplayName&quot;:&quot;1234567890123456&quot;,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;AuthAction&quot;:&quot;milvusknowledgebase:ListDatasets&quot;}</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public AddDocumentsResponseBodyData Data { get; set; }
        public class AddDocumentsResponseBodyData : TeaModel {
            [NameInMap("documents")]
            [Validation(Required=false)]
            public List<AddDocumentsResponseBodyDataDocuments> Documents { get; set; }
            public class AddDocumentsResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("chunkCount")]
                [Validation(Required=false)]
                public int? ChunkCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>naive</para>
                /// </summary>
                [NameInMap("chunkMethod")]
                [Validation(Required=false)]
                public string ChunkMethod { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>kb-123</para>
                /// </summary>
                [NameInMap("datasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>doc-123</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>uploaded/doc-id/example.pdf</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("progress")]
                [Validation(Required=false)]
                public float? Progress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("run")]
                [Validation(Required=false)]
                public string Run { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("suffix")]
                [Validation(Required=false)]
                public string Suffix { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("tokenCount")]
                [Validation(Required=false)]
                public int? TokenCount { get; set; }

            }

            [NameInMap("errors")]
            [Validation(Required=false)]
            public List<string> Errors { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DDDBE0E5-4314-156F-B7F1-C4BCFD25A509</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
