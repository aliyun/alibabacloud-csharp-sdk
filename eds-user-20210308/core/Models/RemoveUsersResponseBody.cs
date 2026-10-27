// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class RemoveUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of deleting the convenience users.</para>
        /// </summary>
        [NameInMap("RemoveUsersResult")]
        [Validation(Required=false)]
        public RemoveUsersResponseBodyRemoveUsersResult RemoveUsersResult { get; set; }
        public class RemoveUsersResponseBodyRemoveUsersResult : TeaModel {
            /// <summary>
            /// <para>The information about the users that failed to be deleted.</para>
            /// </summary>
            [NameInMap("FailedUsers")]
            [Validation(Required=false)]
            public List<RemoveUsersResponseBodyRemoveUsersResultFailedUsers> FailedUsers { get; set; }
            public class RemoveUsersResponseBodyRemoveUsersResultFailedUsers : TeaModel {
                /// <summary>
                /// <para>The convenience user that failed to be deleted.</para>
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

            [NameInMap("ProcessingUsers")]
            [Validation(Required=false)]
            public List<string> ProcessingUsers { get; set; }

            /// <summary>
            /// <para>The convenience users that are successfully deleted.</para>
            /// </summary>
            [NameInMap("RemovedUsers")]
            [Validation(Required=false)]
            public List<string> RemovedUsers { get; set; }

            [NameInMap("SubmittedUsers")]
            [Validation(Required=false)]
            public List<string> SubmittedUsers { get; set; }

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
