// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetWorkitemCommentListResponseBody : TeaModel {
        [NameInMap("commentList")]
        [Validation(Required=false)]
        public List<GetWorkitemCommentListResponseBodyCommentList> CommentList { get; set; }
        public class GetWorkitemCommentListResponseBodyCommentList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>066961</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1667205617061</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RICHTEXT/MARKDOWN</para>
            /// </summary>
            [NameInMap("formatType")]
            [Validation(Required=false)]
            public string FormatType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6573</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("isTop")]
            [Validation(Required=false)]
            public bool? IsTop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1646323200000</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1013131897677566</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9144ef6b72d8exxxxx9e61a4d0</para>
            /// </summary>
            [NameInMap("targetIdentifier")]
            [Validation(Required=false)]
            public string TargetIdentifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>workitem</para>
            /// </summary>
            [NameInMap("targetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1667205617089</para>
            /// </summary>
            [NameInMap("topTime")]
            [Validation(Required=false)]
            public long? TopTime { get; set; }

            [NameInMap("user")]
            [Validation(Required=false)]
            public GetWorkitemCommentListResponseBodyCommentListUser User { get; set; }
            public class GetWorkitemCommentListResponseBodyCommentListUser : TeaModel {
                [NameInMap("account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("realName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Openapi.RequestError</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>error</para>
        /// </summary>
        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
