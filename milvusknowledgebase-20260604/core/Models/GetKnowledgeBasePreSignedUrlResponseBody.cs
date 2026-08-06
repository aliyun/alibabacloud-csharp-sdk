// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class GetKnowledgeBasePreSignedUrlResponseBody : TeaModel {
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
        public GetKnowledgeBasePreSignedUrlResponseBodyData Data { get; set; }
        public class GetKnowledgeBasePreSignedUrlResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>knowledgebase-fileupload</para>
            /// </summary>
            [NameInMap("bucketName")]
            [Validation(Required=false)]
            public string BucketName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("expiresIn")]
            [Validation(Required=false)]
            public int? ExpiresIn { get; set; }

            [NameInMap("preSignedUrls")]
            [Validation(Required=false)]
            public List<string> PreSignedUrls { get; set; }

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
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
