// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class AddDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the permission verification failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;,&quot;AuthPrincipalOwnerId&quot;:&quot;1234567890123456&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,&quot;AuthPrincipalDisplayName&quot;:&quot;1234567890123456&quot;,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;AuthAction&quot;:&quot;milvusknowledgebase:ListDatasets&quot;}</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AddDocumentsResponseBodyData Data { get; set; }
        public class AddDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of documents.</para>
            /// </summary>
            [NameInMap("documents")]
            [Validation(Required=false)]
            public List<AddDocumentsResponseBodyDataDocuments> Documents { get; set; }
            public class AddDocumentsResponseBodyDataDocuments : TeaModel {
                /// <summary>
                /// <para>The chunk count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("chunkCount")]
                [Validation(Required=false)]
                public int? ChunkCount { get; set; }

                /// <summary>
                /// <para>The chunk method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>naive</para>
                /// </summary>
                [NameInMap("chunkMethod")]
                [Validation(Required=false)]
                public string ChunkMethod { get; set; }

                /// <summary>
                /// <para>The knowledge base ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kb-123</para>
                /// </summary>
                [NameInMap("datasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                /// <summary>
                /// <para>The document ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>doc-123</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The object path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>uploaded/doc-id/example.pdf</para>
                /// </summary>
                [NameInMap("location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                /// <summary>
                /// <para>The document name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.pdf</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The processing progress.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("progress")]
                [Validation(Required=false)]
                public float? Progress { get; set; }

                /// <summary>
                /// <para>The processing status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RUNNING</para>
                /// </summary>
                [NameInMap("run")]
                [Validation(Required=false)]
                public string Run { get; set; }

                /// <summary>
                /// <para>The file size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The file extension.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pdf</para>
                /// </summary>
                [NameInMap("suffix")]
                [Validation(Required=false)]
                public string Suffix { get; set; }

                /// <summary>
                /// <para>The thumbnail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("thumbnail")]
                [Validation(Required=false)]
                public string Thumbnail { get; set; }

                /// <summary>
                /// <para>The token count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("tokenCount")]
                [Validation(Required=false)]
                public int? TokenCount { get; set; }

            }

            /// <summary>
            /// <para>The list of errors.</para>
            /// </summary>
            [NameInMap("errors")]
            [Validation(Required=false)]
            public List<string> Errors { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DDDBE0E5-4314-156F-B7F1-C4BCFD25A509</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
