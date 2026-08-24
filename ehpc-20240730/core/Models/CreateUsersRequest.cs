// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateUsersRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The list of users.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public List<CreateUsersRequestUser> User { get; set; }
        public class CreateUsersRequestUser : TeaModel {
            /// <summary>
            /// <para>The public key of the Nth user to add.</para>
            /// <para>Valid values of N: 1 to 20.</para>
            /// <para>This parameter is mutually exclusive with the Password parameter. This parameter takes effect when the cluster authentication method is set to key (not recommended).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Abc****</para>
            /// </summary>
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            /// <summary>
            /// <para>The user group of the Nth user to add. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>users: ordinary permission group. This group is suitable for regular users who only need to commit and debug jobs.</description></item>
            /// <item><description>wheel: sudo permission group. This group is suitable for administrators who need to perform cluster management. In addition to committing and debugging jobs, users in this group can execute sudo commands to install software, restart nodes, and perform other operations.</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>users</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The password of the Nth user to add. The password must be 8 to 30 characters in length and contain at least three of the following four character types:</para>
            /// <list type="bullet">
            /// <item><description>Uppercase letters</description></item>
            /// <item><description>Lowercase letters</description></item>
            /// <item><description>Digits</description></item>
            /// <item><description>Special characters: ()~!@#$%^&amp;*-_+=|{}[]:;\&quot;/&lt;&gt;,.?/</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 20.</para>
            /// <para>This parameter is mutually exclusive with the AuthKey parameter. This parameter takes effect when the cluster authentication method is set to password (recommended).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1@a2****</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The username of the Nth user to add. The username must be 1 to 30 characters in length, start with a letter, and can contain digits and special characters (.).</para>
            /// <para>Valid values of N: 1 to 20.</para>
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
