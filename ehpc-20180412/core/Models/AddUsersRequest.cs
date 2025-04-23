// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddUsersRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to use asynchronous message links to add the users.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to obtain the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The users. You can specify 1 to 100 users.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public List<AddUsersRequestUser> User { get; set; }
        public class AddUsersRequestUser : TeaModel {
            /// <summary>
            /// <para>The permission group of the new user. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>users: ordinary permissions, which are suitable for ordinary users that need only to submit and debug jobs.</description></item>
            /// <item><description>wheel: sudo permissions, which are suitable for administrators who need to manage clusters. In addition to submitting and debugging jobs, you can also run sudo commands to install software and restart nodes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>users</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The username of the new user. The username must be 6 to 30 characters in length, and can contain letters, digits and periods (.). The username must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The password of the new user. The password must be 8 to 30 characters in length and must contain at least three of the following character types:</para>
            /// <list type="bullet">
            /// <item><description>Uppercase letter</description></item>
            /// <item><description>Lowercase letter</description></item>
            /// <item><description>Digit</description></item>
            /// <item><description>Special character: <c>()~!@#$%^&amp;*-_+=|{}[]:;\\&quot;/&lt;&gt;,.?/</c></description></item>
            /// </list>
            /// <remarks>
            /// <para> We recommend that you use HTTPS to call this operation to avoid password leaks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1@a2****</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

    }

}
