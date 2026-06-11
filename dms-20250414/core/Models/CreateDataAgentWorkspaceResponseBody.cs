// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateDataAgentWorkspaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDataAgentWorkspaceResponseBodyData Data { get; set; }
        public class CreateDataAgentWorkspaceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time the workspace was created, as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765960516</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The user ID of the workspace creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20282*****7591</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>Indicates whether session sharing is enabled for the workspace.</para>
            /// </summary>
            [NameInMap("IsSessionShareEnabled")]
            [Validation(Required=false)]
            public bool? IsSessionShareEnabled { get; set; }

            /// <summary>
            /// <para>The time the workspace was last modified, as a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1765961516</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public long? ModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the user\&quot;s role in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>owner</para>
            /// </summary>
            [NameInMap("RoleName")]
            [Validation(Required=false)]
            public string RoleName { get; set; }

            /// <summary>
            /// <para>The number of members in the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalMember")]
            [Validation(Required=false)]
            public long? TotalMember { get; set; }

            /// <summary>
            /// <para>The description of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>space for test</para>
            /// </summary>
            [NameInMap("WorkspaceDesc")]
            [Validation(Required=false)]
            public string WorkspaceDesc { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20923*****7291</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workspaceTest</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

            /// <summary>
            /// <para>The status of the workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>active</para>
            /// </summary>
            [NameInMap("WorkspaceStatus")]
            [Validation(Required=false)]
            public string WorkspaceStatus { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DMS-DA-40114</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
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
