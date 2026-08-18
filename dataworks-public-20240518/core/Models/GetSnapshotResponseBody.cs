// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetSnapshotResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc14115-1234-5678-ABCD-159376359</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The snapshot.</para>
        /// </summary>
        [NameInMap("Snapshot")]
        [Validation(Required=false)]
        public GetSnapshotResponseBodySnapshot Snapshot { get; set; }
        public class GetSnapshotResponseBodySnapshot : TeaModel {
            /// <summary>
            /// <para>The submit comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>snapshot comment</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The structured snapshot content. This parameter is mutually exclusive with ContentUrl.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public GetSnapshotResponseBodySnapshotContent Content { get; set; }
            public class GetSnapshotResponseBodySnapshotContent : TeaModel {
                /// <summary>
                /// <para>The node script content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT 1</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>FlowSpec JSON</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;version&quot;:&quot;1.1.0&quot;}</para>
                /// </summary>
                [NameInMap("Spec")]
                [Validation(Required=false)]
                public string Spec { get; set; }

                /// <summary>
                /// <para>The stage code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("StageCode")]
                [Validation(Required=false)]
                public string StageCode { get; set; }

            }

            /// <summary>
            /// <para>The OSS pre-signed download URL. This parameter is mutually exclusive with Content.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://oss.example.com/presigned">https://oss.example.com/presigned</a></para>
            /// </summary>
            [NameInMap("ContentUrl")]
            [Validation(Required=false)]
            public string ContentUrl { get; set; }

            /// <summary>
            /// <para>The snapshot creation time in millisecond timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782370983000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The employee ID of the submitter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>209508679263509059</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The unique ID of the snapshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8b723a9e8bd443af920b77e39aeb4f63</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1389623</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The unique ID of the object to which the snapshot belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8467231038932407294</para>
            /// </summary>
            [NameInMap("ObjectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The snapshot type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Saved</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
