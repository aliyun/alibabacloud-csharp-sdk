// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class UnlockUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>023F4EC4-3602-4A3E-A514-4970847D59DB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of unlocking the convenience user.</para>
        /// </summary>
        [NameInMap("UnlockUsersResult")]
        [Validation(Required=false)]
        public UnlockUsersResponseBodyUnlockUsersResult UnlockUsersResult { get; set; }
        public class UnlockUsersResponseBodyUnlockUsersResult : TeaModel {
            /// <summary>
            /// <para>The convenience users that failed to be unlocked.</para>
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<UnlockUsersResponseBodyUnlockUsersResultFailedUsers> FailedUsers { get; set; }
            public class UnlockUsersResponseBodyUnlockUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// <para>The ID of the convenience user that failed to be unlocked.</para>
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
            /// <para>The convenience users that were unlocked.</para>
            /// </summary>
            [NameInMap("UnlockedUsers")]
            [Validation(Required=false)]
            public List<string> UnlockedUsers { get; set; }

        }

    }

}
