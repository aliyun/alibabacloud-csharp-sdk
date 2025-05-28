// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class UpdateWorkspaceUsersRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7AAB95D7-2E11-4FE2-94BC-858E4FC0C976</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns the result of the interface execution.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateWorkspaceUsersRoleResponseBodyResult Result { get; set; }
        public class UpdateWorkspaceUsersRoleResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Number of users that failed to update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Failure")]
            [Validation(Required=false)]
            public int? Failure { get; set; }

            /// <summary>
            /// <para>Reasons for the update failures.</para>
            /// </summary>
            [NameInMap("FailureDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> FailureDetail { get; set; }

            /// <summary>
            /// <para>Number of users that were updated successfully.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public int? Success { get; set; }

            /// <summary>
            /// <para>Modify the total number of users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Value range:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful, some members may have been updated successfully while others failed, refer to FailureDetail in the response for reasons of failure</description></item>
        /// <item><description>false: The request failed, no data will be persisted</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
