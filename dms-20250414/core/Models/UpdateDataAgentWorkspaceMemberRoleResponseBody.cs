// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateDataAgentWorkspaceMemberRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateDataAgentWorkspaceMemberRoleResponseBodyData Data { get; set; }
        public class UpdateDataAgentWorkspaceMemberRoleResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the user joined the workspace. This is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765961516</para>
            /// </summary>
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public long? JoinTime { get; set; }

            /// <summary>
            /// <para>The UID of the member whose role was changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20282*****7591</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public string MemberId { get; set; }

            /// <summary>
            /// <para>The new role of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>admin</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The number of running tasks for the user in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RunningTaskNumber")]
            [Validation(Required=false)]
            public long? RunningTaskNumber { get; set; }

            /// <summary>
            /// <para>The total number of tasks for the user in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalTaskNumber")]
            [Validation(Required=false)]
            public long? TotalTaskNumber { get; set; }

            /// <summary>
            /// <para>The RAM username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yunqitest</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DMS-DA-40114</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Specified parameter is not valid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E0D2-*****-A63B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
