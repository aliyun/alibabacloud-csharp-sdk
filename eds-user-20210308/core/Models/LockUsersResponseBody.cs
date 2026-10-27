// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class LockUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the lock operation for the convenience accounts.</para>
        /// </summary>
        [NameInMap("LockUsersResult")]
        [Validation(Required=false)]
        public LockUsersResponseBodyLockUsersResult LockUsersResult { get; set; }
        public class LockUsersResponseBodyLockUsersResult : TeaModel {
            /// <summary>
            /// <para>The list of convenience accounts that failed to be locked.</para>
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<LockUsersResponseBodyLockUsersResultFailedUsers> FailedUsers { get; set; }
            public class LockUsersResponseBodyLockUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// <para>The convenience account that failed to be locked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alice</para>
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
            /// <para>The list of convenience accounts that are successfully locked.</para>
            /// </summary>
            [NameInMap("LockedUsers")]
            [Validation(Required=false)]
            public List<string> LockedUsers { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
