// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The set of user group attributes. The maximum total number is 3000. Multiple user group attributes have an OR relationship and take effect as a union.</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public List<UpdateUserGroupRequestAttributes> Attributes { get; set; }
        public class UpdateUserGroupRequestAttributes : TeaModel {
            /// <summary>
            /// <para>The identity provider ID of the user group. This value exists when the custom user group type is <b>department</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public int? IdpId { get; set; }

            /// <summary>
            /// <para>The relation of the user group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Equal</b>: equal to.</description></item>
            /// <item><description><b>Unequal</b>: not equal to.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Equal</para>
            /// </summary>
            [NameInMap("Relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

            /// <summary>
            /// <para>The type of the user group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>username</b>: username.</description></item>
            /// <item><description><b>department</b>: department.</description></item>
            /// <item><description><b>email</b>: email.</description></item>
            /// <item><description><b>telephone</b>: mobile phone.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>department</para>
            /// </summary>
            [NameInMap("UserGroupType")]
            [Validation(Required=false)]
            public string UserGroupType { get; set; }

            /// <summary>
            /// <para>The value of the user group attribute.</para>
            /// <list type="bullet">
            /// <item><description>If the user group type is <b>username</b>, this parameter indicates the username value. The value must be 1 to 128 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), asterisks (*), at signs (@), and spaces.</description></item>
            /// <item><description>If the user group type is <b>department</b>, this parameter indicates the department value. Example: OU=Department1,OU=SASEDingTalk.</description></item>
            /// <item><description>If the user group type is <b>email</b>, this parameter indicates the email value. Example: <a href="mailto:username@example.com">username@example.com</a>.</description></item>
            /// <item><description>If the user group type is <b>telephone</b>, this parameter indicates the mobile phone value. Example: 13900001234.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OU=部门1,OU=SASE钉钉</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The description of the user group. The description must be 1 to 128 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条用户组</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The modification type of the user group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b> (default): overwrites the original user group attribute set with the value of the <b>Attributes</b> parameter.</description></item>
        /// <item><description><b>Append</b>: separately appends the values entered in the <b>Attributes</b> parameter to the user group attribute set.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The ID of the user group. Value sources:</para>
        /// <list type="bullet">
        /// <item><description><a href="~~ListUserGroups~~">ListUserGroups</a>: queries user groups in batches.</description></item>
        /// <item><description><a href="~~CreateUserGroup~~">CreateUserGroup</a>: creates a user group.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>usergroup-6f1ef2fc56b6****</para>
        /// </summary>
        [NameInMap("UserGroupId")]
        [Validation(Required=false)]
        public string UserGroupId { get; set; }

    }

}
