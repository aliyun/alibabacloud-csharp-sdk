// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class RemoveUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of removing the convenience user.</para>
        /// </summary>
        [NameInMap("RemoveUsersResult")]
        [Validation(Required=false)]
        public RemoveUsersResponseBodyRemoveUsersResult RemoveUsersResult { get; set; }
        public class RemoveUsersResponseBodyRemoveUsersResult : TeaModel {
            /// <summary>
            /// <para>The convenience users that failed to be removed.</para>
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<RemoveUsersResponseBodyRemoveUsersResultFailedUsers> FailedUsers { get; set; }
            public class RemoveUsersResponseBodyRemoveUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// <para>The ID of the convenience user that failed to be removed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test2</para>
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
                /// <para>test2 is an invalid username.</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>The convenience users that were removed.</para>
            /// </summary>
            [NameInMap("RemovedUsers")]
            [Validation(Required=false)]
            public List<string> RemovedUsers { get; set; }

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
