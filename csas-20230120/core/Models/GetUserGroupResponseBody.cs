// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1310DBC7-7E1F-55D3-B4B4-E4BE912517FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user group.</para>
        /// </summary>
        [NameInMap("UserGroup")]
        [Validation(Required=false)]
        public GetUserGroupResponseBodyUserGroup UserGroup { get; set; }
        public class GetUserGroupResponseBodyUserGroup : TeaModel {
            /// <summary>
            /// <para>The collection of user group properties. The properties are evaluated with a logical OR operator.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<GetUserGroupResponseBodyUserGroupAttributes> Attributes { get; set; }
            public class GetUserGroupResponseBodyUserGroupAttributes : TeaModel {
                /// <summary>
                /// <para>The ID of the identity provider (IdP) for the user group. This parameter is returned when UserGroupType is set to <b>department</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public int? IdpId { get; set; }

                /// <summary>
                /// <para>The relationship of the user group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Equal</b>: Equal to.</para>
                /// </description></item>
                /// <item><description><para><b>Unequal</b>: Not equal to.</para>
                /// </description></item>
                /// </list>
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
                /// <item><description><para><b>username</b>: The username.</para>
                /// </description></item>
                /// <item><description><para><b>department</b>: The department.</para>
                /// </description></item>
                /// <item><description><para><b>email</b>: The email address.</para>
                /// </description></item>
                /// <item><description><para><b>telephone</b>: The mobile phone number.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

                /// <summary>
                /// <para>The value of the user group property.</para>
                /// <list type="bullet">
                /// <item><description><para>If UserGroupType is set to <b>username</b>, this parameter specifies the value of the username. The value can be 1 to 128 characters in length and can contain Chinese characters, letters, digits, periods (.), underscores (_), and hyphens (-).</para>
                /// </description></item>
                /// <item><description><para>If UserGroupType is set to <b>department</b>, this parameter specifies the value of the department. Example: OU=Department 1,OU=SASE DingTalk.</para>
                /// </description></item>
                /// <item><description><para>If UserGroupType is set to <b>email</b>, this parameter specifies the value of the email address. Example: username\@example.com.</para>
                /// </description></item>
                /// <item><description><para>If UserGroupType is set to <b>telephone</b>, this parameter specifies the value of the mobile phone number. Example: 13900001234.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OU=部门1,OU=SASE钉钉</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time when the user group was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-10-10 11:39:22</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一条用户组</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_group_name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usergroup-6f1ef2fc56b6****</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
