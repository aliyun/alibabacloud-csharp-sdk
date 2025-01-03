// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class UpdateWorkitemCommentResponseBody : TeaModel {
        [NameInMap("comment")]
        [Validation(Required=false)]
        public UpdateWorkitemCommentResponseBodyComment Comment { get; set; }
        public class UpdateWorkitemCommentResponseBodyComment : TeaModel {
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
            /// <para>MARKDOWN/RICHTEXT</para>
            /// </summary>
            [NameInMap("formatType")]
            [Validation(Required=false)]
            public string FormatType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1964584</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

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
            /// <para>2684432</para>
            /// </summary>
            [NameInMap("parentId")]
            [Validation(Required=false)]
            public long? ParentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>deafe5f33xxxxx6a259d8dafd</para>
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
            public UpdateWorkitemCommentResponseBodyCommentUser User { get; set; }
            public class UpdateWorkitemCommentResponseBodyCommentUser : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1316458xxxxx41068</para>
                /// </summary>
                [NameInMap("account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112m7150e256dbba0d6456bafbb65c81f90d/w/200/h/200">https://tcs-devops.aliyuncs.com/thumbnail/112m7150e256dbba0d6456bafbb65c81f90d/w/200/h/200</a></para>
                /// </summary>
                [NameInMap("avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9144ef6b72d8exxxxx9e61a4d0</para>
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

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParam.NotFound</para>
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
        /// <para>F7B85D1B-D1C2-140F-A039-341859F130B9</para>
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
        public string Success { get; set; }

    }

}
