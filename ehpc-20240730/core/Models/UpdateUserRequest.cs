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
        /// <para>The user group property to update. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>users: ordinary permission group. This group is suitable for regular users who only need to submit and debug jobs.</para>
        /// </description></item>
        /// <item><description><para>wheel: sudo permission group. This group is suitable for administrators who need cluster management. In addition to submitting and debugging jobs, users in this group can execute sudo commands to install software, restart nodes, and perform other operations.</para>
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
        /// <para>The user password property to update. The password must be 8 to 30 characters in length and must contain at least three of the following four character types:</para>
        /// <list type="bullet">
        /// <item><description>Uppercase letters</description></item>
        /// <item><description>Lowercase letters</description></item>
        /// <item><description>Digits</description></item>
        /// <item><description>Special characters: ()~!@#$%^&amp;*-_+=|{}[]:;\&quot;/&lt;&gt;,.?/</description></item>
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
