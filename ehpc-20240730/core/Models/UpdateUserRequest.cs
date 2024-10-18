// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UpdateUserRequest : TeaModel {
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
        /// <para>The user group attribute of the user that you want to update. Valid values:</para>
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
        /// <para>The password attribute of the user that you want to update. The password must be 6 to 30 characters in length and must contain three of the following four character types:</para>
        /// <list type="bullet">
        /// <item><description>Uppercase letters</description></item>
        /// <item><description>Lowercase letters</description></item>
        /// <item><description>Digits</description></item>
        /// <item><description>Special characters ()~!@#$%^&amp;\*-_+=|{}[]:;\&quot;/&lt;&gt;,.?/</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123****</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testuser</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
