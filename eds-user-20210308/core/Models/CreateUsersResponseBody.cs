// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class CreateUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of user creation.</para>
        /// </summary>
        [NameInMap("CreateResult")]
        [Validation(Required=false)]
        public CreateUsersResponseBodyCreateResult CreateResult { get; set; }
        public class CreateUsersResponseBodyCreateResult : TeaModel {
            /// <summary>
            /// <para>Details of the created convenience users.</para>
            /// </summary>
            [NameInMap("CreatedUsers")]
            [Validation(Required=false)]
            public List<CreateUsersResponseBodyCreateResultCreatedUsers> CreatedUsers { get; set; }
            public class CreateUsersResponseBodyCreateResultCreatedUsers : TeaModel {
                /// <summary>
                /// <para>The email address of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:username@example.com">username@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The name of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test1</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The mobile number of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1381111****</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The display name of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Bean</para>
                /// </summary>
                [NameInMap("RealNickName")]
                [Validation(Required=false)]
                public string RealNickName { get; set; }

                /// <summary>
                /// <para>The remarks of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>remark1</para>
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

            }

            /// <summary>
            /// <para>Details of the convenience users that failed to be created.</para>
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<CreateUsersResponseBodyCreateResultFailedUsers> FailedUsers { get; set; }
            public class CreateUsersResponseBodyCreateResultFailedUsers : TeaModel {
                /// <summary>
                /// <para>The email address of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:username2@example.com">username2@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>The name of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The error code returned if the request failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ExistedEndUserId</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The username test is used by another user.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The mobile number of the end user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1390000****</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
