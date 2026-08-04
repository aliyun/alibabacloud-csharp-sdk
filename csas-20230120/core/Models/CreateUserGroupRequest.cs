// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateUserGroupRequest : TeaModel {
        /// <summary>
        /// <para>The collection of user group attributes. You can specify a maximum of 3,000 attributes. The attributes are combined using a logical OR.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public List<CreateUserGroupRequestAttributes> Attributes { get; set; }
        public class CreateUserGroupRequestAttributes : TeaModel {
            /// <summary>
            /// <para>The ID of the identity provider (IdP) for the user group. This parameter is used when UserGroupType is set to <b>department</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("IdpId")]
            [Validation(Required=false)]
            public int? IdpId { get; set; }

            /// <summary>
            /// <para>The relationship for the user group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Equal</b>: Equal to.</para>
            /// </description></item>
            /// <item><description><para><b>Unequal</b>: Not equal to.</para>
            /// </description></item>
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
            /// <item><description><para><b>username</b>: Username.</para>
            /// </description></item>
            /// <item><description><para><b>department</b>: Department.</para>
            /// </description></item>
            /// <item><description><para><b>email</b>: Email.</para>
            /// </description></item>
            /// <item><description><para><b>telephone</b>: Mobile phone.</para>
            /// </description></item>
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
            /// <item><description><para>If UserGroupType is set to <b>username</b>, this parameter specifies the username value. The value must be 1 to 128 characters long. It can contain Chinese characters, letters, digits, periods (.), underscores (_), hyphens (-), asterisks (\*), at signs (@), and spaces.</para>
            /// </description></item>
            /// <item><description><para>If UserGroupType is set to <b>department</b>, this parameter specifies the department value. For example: OU=Department 1,OU=SASE DingTalk.</para>
            /// </description></item>
            /// <item><description><para>If UserGroupType is set to <b>email</b>, this parameter specifies the email address. For example: username\@example.com.</para>
            /// </description></item>
            /// <item><description><para>If UserGroupType is set to <b>telephone</b>, this parameter specifies the mobile phone number. For example: 13900001234.</para>
            /// </description></item>
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
        /// <para>The user group description. The description must be 1 to 128 characters long and can contain Chinese characters, letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条用户组</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The user group name. The name must be 1 to 128 characters long and can contain Chinese characters, letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user_group_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
