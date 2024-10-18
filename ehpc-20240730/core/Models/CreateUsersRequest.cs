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
        /// <para>The users that you want to add.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public List<CreateUsersRequestUser> User { get; set; }
        public class CreateUsersRequestUser : TeaModel {
            /// <summary>
            /// <para>The public key of the user.</para>
            /// <para>You can add up to 20 users in a call.</para>
            /// <para>Specify one of the Password and AuthKey parameters. The AuthKey parameter takes effect only when the cluster authentication method is set to Key. Key authentication is not recommended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Abc****</para>
            /// </summary>
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            /// <summary>
            /// <para>The permission group to which the user belongs. Valid values:</para>
            /// <para>users: ordinary permissions, which are suitable for ordinary users that need only to submit and debug jobs. wheel: sudo permissions, which are suitable for administrators who need to manage clusters. In addition to submitting and debugging jobs, you can also run sudo commands to install software and restart nodes. You can add up to 20 users in a call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>users</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The password of the user. The password must be 6 to 30 characters in length and must contain three of the following character types:</para>
            /// <list type="bullet">
            /// <item><description>Uppercase letters</description></item>
            /// <item><description>Lowercase letters</description></item>
            /// <item><description>Digits</description></item>
            /// <item><description>Special characters ()~!@#$%^&amp;\*-_+=|{}[]:;\&quot;/&lt;&gt;,.?/</description></item>
            /// </list>
            /// <para>You can add up to 20 users in a call.</para>
            /// <para>Specify one of the Password and AuthKey parameters. The Password parameter takes effect only when the cluster authentication method is set to Password. Password authentication is recommended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1@a2****</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The username. The username must be 1 to 30 characters in length. It must start with a letter and can contain digits, letters, and periods (.).</para>
            /// <para>You can add up to 20 users in a call.</para>
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
