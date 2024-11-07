// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class ResetUserPasswordResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32D05B39-E6EE-4D7A-9FD0-762A26859D0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of resetting the password of the convenience user.</para>
        /// </summary>
        [NameInMap("ResetUsersResult")]
        [Validation(Required=false)]
        public ResetUserPasswordResponseBodyResetUsersResult ResetUsersResult { get; set; }
        public class ResetUserPasswordResponseBodyResetUsersResult : TeaModel {
            /// <summary>
            /// <para>The information about the convenience users whose passwords failed to be reset.</para>
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<ResetUserPasswordResponseBodyResetUsersResultFailedUsers> FailedUsers { get; set; }
            public class ResetUserPasswordResponseBodyResetUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// <para>The ID of the convenience user whose password failed to be reset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123</para>
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidUsername</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test123 is an invalid username.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>The convenience users to which the system sent a password reset email.</para>
            /// </summary>
            [NameInMap("ResetUsers")]
            [Validation(Required=false)]
            public List<string> ResetUsers { get; set; }

        }

    }

}
