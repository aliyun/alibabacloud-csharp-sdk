// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class CreateUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the parent user group. You can add new user groups to this group:</para>
        /// <list type="bullet">
        /// <item><description>If you enter the ID of a parent user group, the new user group is added to the user group with the ID.</description></item>
        /// <item><description>If you enter -1, the new user group is added to the root directory.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3d2c23d4-2b41-4af8-a1f5-f6390f32****</para>
        /// </summary>
        [NameInMap("ParentUserGroupId")]
        [Validation(Required=false)]
        public string ParentUserGroupId { get; set; }

        /// <summary>
        /// <para>The description of the user group.</para>
        /// <list type="bullet">
        /// <item><description>Format verification: Maximum length 255</description></item>
        /// <item><description>Special format verification: Chinese and English digits_ \ / | () ] [</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User group description</para>
        /// </summary>
        [NameInMap("UserGroupDescription")]
        [Validation(Required=false)]
        public string UserGroupDescription { get; set; }

        /// <summary>
        /// <para>The unique ID of the user group.</para>
        /// <list type="bullet">
        /// <item><description>If you specify the UserGroupId parameter, the system automatically generates the UserGroupId parameter. If you specify the UserGroupId parameter, the user ID is used as the user group ID. You must ensure that the user ID is unique within the organization.</description></item>
        /// <item><description>Format verification: Maximum length 64, cannot be -1,</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pop0001</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

        /// <summary>
        /// <para>The name of the RAM user group.</para>
        /// <list type="bullet">
        /// <item><description>Format verification: Maximum length 255</description></item>
        /// <item><description>Special format verification: Chinese and English digits_ \ / | () ] [</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou Financial Report</para>
        /// </summary>
        [NameInMap("UserGroupName")]
        [Validation(Required=false)]
        public string UserGroupName { get; set; }

    }

}
