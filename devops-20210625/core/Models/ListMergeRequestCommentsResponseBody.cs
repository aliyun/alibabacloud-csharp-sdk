// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestCommentsResponseBody : TeaModel {
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListMergeRequestCommentsResponseBodyResult> Result { get; set; }
        public class ListMergeRequestCommentsResponseBodyResult : TeaModel {
            [NameInMap("author")]
            [Validation(Required=false)]
            public ListMergeRequestCommentsResponseBodyResultAuthor Author { get; set; }
            public class ListMergeRequestCommentsResponseBodyResultAuthor : TeaModel {
                [NameInMap("aliyunPk")]
                [Validation(Required=false)]
                public string AliyunPk { get; set; }

                [NameInMap("avatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                [NameInMap("email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("childComments")]
            [Validation(Required=false)]
            public List<ListMergeRequestCommentsResponseBodyResultChildComments> ChildComments { get; set; }
            public class ListMergeRequestCommentsResponseBodyResultChildComments : TeaModel {
                [NameInMap("author")]
                [Validation(Required=false)]
                public ListMergeRequestCommentsResponseBodyResultChildCommentsAuthor Author { get; set; }
                public class ListMergeRequestCommentsResponseBodyResultChildCommentsAuthor : TeaModel {
                    [NameInMap("aliyunPk")]
                    [Validation(Required=false)]
                    public string AliyunPk { get; set; }

                    [NameInMap("avatarUrl")]
                    [Validation(Required=false)]
                    public string AvatarUrl { get; set; }

                    [NameInMap("email")]
                    [Validation(Required=false)]
                    public string Email { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("state")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                [NameInMap("commentBizId")]
                [Validation(Required=false)]
                public string CommentBizId { get; set; }

                [NameInMap("commentTime")]
                [Validation(Required=false)]
                public string CommentTime { get; set; }

                [NameInMap("commentType")]
                [Validation(Required=false)]
                public string CommentType { get; set; }

                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                [NameInMap("filePath")]
                [Validation(Required=false)]
                public string FilePath { get; set; }

                [NameInMap("finalChildComments")]
                [Validation(Required=false)]
                public List<ListMergeRequestCommentsResponseBodyResultChildCommentsFinalChildComments> FinalChildComments { get; set; }
                public class ListMergeRequestCommentsResponseBodyResultChildCommentsFinalChildComments : TeaModel {
                    [NameInMap("author")]
                    [Validation(Required=false)]
                    public ListMergeRequestCommentsResponseBodyResultChildCommentsFinalChildCommentsAuthor Author { get; set; }
                    public class ListMergeRequestCommentsResponseBodyResultChildCommentsFinalChildCommentsAuthor : TeaModel {
                        [NameInMap("aliyunPk")]
                        [Validation(Required=false)]
                        public string AliyunPk { get; set; }

                        [NameInMap("avatarUrl")]
                        [Validation(Required=false)]
                        public string AvatarUrl { get; set; }

                        [NameInMap("email")]
                        [Validation(Required=false)]
                        public string Email { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("state")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        [NameInMap("username")]
                        [Validation(Required=false)]
                        public string Username { get; set; }

                    }

                    [NameInMap("commentBizId")]
                    [Validation(Required=false)]
                    public string CommentBizId { get; set; }

                    [NameInMap("commentTime")]
                    [Validation(Required=false)]
                    public string CommentTime { get; set; }

                    [NameInMap("commentType")]
                    [Validation(Required=false)]
                    public string CommentType { get; set; }

                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("deleted")]
                    [Validation(Required=false)]
                    public bool? Deleted { get; set; }

                    [NameInMap("filePath")]
                    [Validation(Required=false)]
                    public string FilePath { get; set; }

                    [NameInMap("lastEditTime")]
                    [Validation(Required=false)]
                    public string LastEditTime { get; set; }

                    [NameInMap("lineNumber")]
                    [Validation(Required=false)]
                    public string LineNumber { get; set; }

                    [NameInMap("parentCommentBizId")]
                    [Validation(Required=false)]
                    public string ParentCommentBizId { get; set; }

                    [NameInMap("relatedPatchSet")]
                    [Validation(Required=false)]
                    public ListMergeRequestCommentsResponseBodyResultChildCommentsFinalChildCommentsRelatedPatchSet RelatedPatchSet { get; set; }
                    public class ListMergeRequestCommentsResponseBodyResultChildCommentsFinalChildCommentsRelatedPatchSet : TeaModel {
                        [NameInMap("commitId")]
                        [Validation(Required=false)]
                        public string CommitId { get; set; }

                        [NameInMap("createdAt")]
                        [Validation(Required=false)]
                        public string CreatedAt { get; set; }

                        [NameInMap("patchSetBizId")]
                        [Validation(Required=false)]
                        public string PatchSetBizId { get; set; }

                        [NameInMap("patchSetName")]
                        [Validation(Required=false)]
                        public string PatchSetName { get; set; }

                        [NameInMap("patchSetNo")]
                        [Validation(Required=false)]
                        public string PatchSetNo { get; set; }

                        [NameInMap("relatedMergeItemType")]
                        [Validation(Required=false)]
                        public string RelatedMergeItemType { get; set; }

                        [NameInMap("shortId")]
                        [Validation(Required=false)]
                        public string ShortId { get; set; }

                    }

                    [NameInMap("resolved")]
                    [Validation(Required=false)]
                    public bool? Resolved { get; set; }

                    [NameInMap("rootCommentBizId")]
                    [Validation(Required=false)]
                    public string RootCommentBizId { get; set; }

                    [NameInMap("state")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                }

                [NameInMap("lastEditTime")]
                [Validation(Required=false)]
                public string LastEditTime { get; set; }

                [NameInMap("lineNumber")]
                [Validation(Required=false)]
                public string LineNumber { get; set; }

                [NameInMap("parentCommentBizId")]
                [Validation(Required=false)]
                public string ParentCommentBizId { get; set; }

                [NameInMap("relatedPatchSet")]
                [Validation(Required=false)]
                public ListMergeRequestCommentsResponseBodyResultChildCommentsRelatedPatchSet RelatedPatchSet { get; set; }
                public class ListMergeRequestCommentsResponseBodyResultChildCommentsRelatedPatchSet : TeaModel {
                    [NameInMap("commitId")]
                    [Validation(Required=false)]
                    public string CommitId { get; set; }

                    [NameInMap("createdAt")]
                    [Validation(Required=false)]
                    public string CreatedAt { get; set; }

                    [NameInMap("patchSetBizId")]
                    [Validation(Required=false)]
                    public string PatchSetBizId { get; set; }

                    [NameInMap("patchSetName")]
                    [Validation(Required=false)]
                    public string PatchSetName { get; set; }

                    [NameInMap("patchSetNo")]
                    [Validation(Required=false)]
                    public string PatchSetNo { get; set; }

                    [NameInMap("relatedMergeItemType")]
                    [Validation(Required=false)]
                    public string RelatedMergeItemType { get; set; }

                    [NameInMap("shortId")]
                    [Validation(Required=false)]
                    public string ShortId { get; set; }

                }

                [NameInMap("resolved")]
                [Validation(Required=false)]
                public bool? Resolved { get; set; }

                [NameInMap("rootCommentBizId")]
                [Validation(Required=false)]
                public string RootCommentBizId { get; set; }

                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            [NameInMap("commentBizId")]
            [Validation(Required=false)]
            public string CommentBizId { get; set; }

            [NameInMap("commentTime")]
            [Validation(Required=false)]
            public string CommentTime { get; set; }

            [NameInMap("commentType")]
            [Validation(Required=false)]
            public string CommentType { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }

            [NameInMap("filePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            [NameInMap("lastEditTime")]
            [Validation(Required=false)]
            public string LastEditTime { get; set; }

            [NameInMap("lineNumber")]
            [Validation(Required=false)]
            public string LineNumber { get; set; }

            [NameInMap("parentCommentBizId")]
            [Validation(Required=false)]
            public string ParentCommentBizId { get; set; }

            [NameInMap("relatedPatchSet")]
            [Validation(Required=false)]
            public ListMergeRequestCommentsResponseBodyResultRelatedPatchSet RelatedPatchSet { get; set; }
            public class ListMergeRequestCommentsResponseBodyResultRelatedPatchSet : TeaModel {
                [NameInMap("commitId")]
                [Validation(Required=false)]
                public string CommitId { get; set; }

                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public string CreatedAt { get; set; }

                [NameInMap("patchSetBizId")]
                [Validation(Required=false)]
                public string PatchSetBizId { get; set; }

                [NameInMap("patchSetName")]
                [Validation(Required=false)]
                public string PatchSetName { get; set; }

                [NameInMap("patchSetNo")]
                [Validation(Required=false)]
                public string PatchSetNo { get; set; }

                [NameInMap("relatedMergeItemType")]
                [Validation(Required=false)]
                public string RelatedMergeItemType { get; set; }

                [NameInMap("shortId")]
                [Validation(Required=false)]
                public string ShortId { get; set; }

            }

            [NameInMap("resolved")]
            [Validation(Required=false)]
            public bool? Resolved { get; set; }

            [NameInMap("rootCommentBizId")]
            [Validation(Required=false)]
            public string RootCommentBizId { get; set; }

            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
