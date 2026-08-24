// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user details.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserResponseBodyUser User { get; set; }
        public class GetUserResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The time when the user was first added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-22T17:46:47</para>
            /// </summary>
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public string AddTime { get; set; }

            /// <summary>
            /// <para>The user group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>users: ordinary permission group. This group is suitable for regular users who only need to commit and debug jobs.</para>
            /// </description></item>
            /// <item><description><para>wheel: sudo permission group. This group is suitable for administrators who need cluster management. In addition to committing and debugging jobs, members of this group can execute sudo commands to install software, restart nodes, and perform other operations.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>users</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The user group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

    }

}
