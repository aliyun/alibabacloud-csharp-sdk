// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class RemoveUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the convenience user deletion operation.</para>
        /// </summary>
        [NameInMap("RemoveUsersResult")]
        [Validation(Required=false)]
        public RemoveUsersResponseBodyRemoveUsersResult RemoveUsersResult { get; set; }
        public class RemoveUsersResponseBodyRemoveUsersResult : TeaModel {
            /// <summary>
            /// <para>The collection of information about users that failed to be deleted.</para>
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

            /// <summary>
            /// <para>The list of usernames of convenience users for which asynchronous deletion tasks already exist and have not finished. This request does not create duplicate deletion tasks for these users. The return of this field does not indicate that the users have been deleted.</para>
            /// </summary>
            [NameInMap("ProcessingUsers")]
            [Validation(Required=false)]
            public List<string> ProcessingUsers { get; set; }

            /// <summary>
            /// <para>The convenience users that were successfully deleted.</para>
            /// </summary>
            [NameInMap("RemovedUsers")]
            [Validation(Required=false)]
            public List<string> RemovedUsers { get; set; }

            /// <summary>
            /// <para>The list of usernames of convenience users for which asynchronous deletion tasks have been successfully accepted and created in this request. Asynchronous deletion is used when UnbindDesktops is set to true. Task acceptance does not mean that the convenience users have been deleted.</para>
            /// </summary>
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
