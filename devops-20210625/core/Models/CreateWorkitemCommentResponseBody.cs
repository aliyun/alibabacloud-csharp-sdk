// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateWorkitemCommentResponseBody : TeaModel {
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public CreateWorkitemCommentResponseBodyComment Comment { get; set; }
        public class CreateWorkitemCommentResponseBodyComment : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1667202662000</para>
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
            /// <para>true/false</para>
            /// </summary>
            [NameInMap("isTop")]
            [Validation(Required=false)]
            public bool? IsTop { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1637995553000</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>79d523806bdxxxxx95612a5154</para>
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
            /// <para>1667202662000</para>
            /// </summary>
            [NameInMap("topTime")]
            [Validation(Required=false)]
            public long? TopTime { get; set; }

            [NameInMap("user")]
            [Validation(Required=false)]
            public CreateWorkitemCommentResponseBodyCommentUser User { get; set; }
            public class CreateWorkitemCommentResponseBodyCommentUser : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>13164xxxxx41068</para>
                /// </summary>
                [NameInMap("account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://xxxxx/thumbnail/112m7150e256dbba0d6456bafbb65c81f90d/w/200/h/200">https://xxxxx/thumbnail/112m7150e256dbba0d6456bafbb65c81f90d/w/200/h/200</a></para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1e9903d8bxxxxxxe9df9286ef5</para>
                /// </summary>
                [NameInMap("identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("realName")]
                [Validation(Required=false)]
                public string RealName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>workitem</para>
                /// </summary>
                [NameInMap("targetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
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
