// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ModifyUserPasswordsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the asynchronous mode for this request.</para>
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
        public List<ModifyUserPasswordsRequestUser> User { get; set; }
        public class ModifyUserPasswordsRequestUser : TeaModel {
            /// <summary>
            /// <para>The username of the user whose password you want to change.</para>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188572.html">ListUsers</a> operation to query the usernames in the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The new password for the user. The password must be 8 to 30 characters in length and contain at least three of the following character types:</para>
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
            /// <para>1@a****</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

    }

}
