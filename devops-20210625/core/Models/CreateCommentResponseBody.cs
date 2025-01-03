// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCommentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public CreateCommentResponseBodyResult Result { get; set; }
        public class CreateCommentResponseBodyResult : TeaModel {
            [NameInMap("author")]
            [Validation(Required=false)]
            public CreateCommentResponseBodyResultAuthor Author { get; set; }
            public class CreateCommentResponseBodyResultAuthor : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>284692704493684695</para>
                /// </summary>
                [NameInMap("aliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19927</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>active</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test-codeup</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5c399e3685e542a28db16d93e9f82abb</para>
            /// </summary>
            [NameInMap("commentBizId")]
            [Validation(Required=false)]
            public string CommentBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18 14:24:54</para>
            /// </summary>
            [NameInMap("commentTime")]
            [Validation(Required=false)]
            public string CommentTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GLOBAL_COMMENT</para>
            /// </summary>
            [NameInMap("commentType")]
            [Validation(Required=false)]
            public string CommentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>src/main/update.txt</para>
            /// </summary>
            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-03-18 14:24:54</para>
            /// </summary>
            [NameInMap("lastEditTime")]
            [Validation(Required=false)]
            public string LastEditTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("lineNumber")]
            [Validation(Required=false)]
            public string LineNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4c5dcec6a8dc41e69c369737dadc1841</para>
            /// </summary>
            [NameInMap("parentCommentBizId")]
            [Validation(Required=false)]
            public string ParentCommentBizId { get; set; }

            [NameInMap("relatedPatchSet")]
            [Validation(Required=false)]
            public CreateCommentResponseBodyResultRelatedPatchSet RelatedPatchSet { get; set; }
            public class CreateCommentResponseBodyResultRelatedPatchSet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1a072f5367c21f9de3464b8c0ee8546e47764d2d</para>
                /// </summary>
                [NameInMap("commitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-03-18 14:24:54</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>513fcfd81a9142d2bb0db4f72c0aa15b</para>
                /// </summary>
                [NameInMap("patchSetBizId")]
                [Validation(Required=false)]
                public string PatchSetBizId { get; set; }

                [NameInMap("patchSetName")]
                [Validation(Required=false)]
                public string PatchSetName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("patchSetNo")]
                [Validation(Required=false)]
                public string PatchSetNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MERGE_SOURCE</para>
                /// </summary>
                [NameInMap("relatedMergeItemType")]
                [Validation(Required=false)]
                public string RelatedMergeItemType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1a072f53</para>
                /// </summary>
                [NameInMap("shortId")]
                [Validation(Required=false)]
                public string ShortId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("resolved")]
            [Validation(Required=false)]
            public bool? Resolved { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dcf2b23cebfc418f98dbd35e423d9fd3</para>
            /// </summary>
            [NameInMap("rootCommentBizId")]
            [Validation(Required=false)]
            public string RootCommentBizId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OPENED</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
