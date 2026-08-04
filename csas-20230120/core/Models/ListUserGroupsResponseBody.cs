// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListUserGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4AB972E2-D702-5464-B132-B1911498B8BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of user groups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// <para>A list of user groups.</para>
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListUserGroupsResponseBodyUserGroups> UserGroups { get; set; }
        public class ListUserGroupsResponseBodyUserGroups : TeaModel {
            /// <summary>
            /// <para>A collection of user group properties. Multiple properties are combined with OR logic.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<ListUserGroupsResponseBodyUserGroupsAttributes> Attributes { get; set; }
            public class ListUserGroupsResponseBodyUserGroupsAttributes : TeaModel {
                /// <summary>
                /// <para>The identity provider ID for the user group. This parameter appears only when the user group type is <b>department</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public int? IdpId { get; set; }

                /// <summary>
                /// <para>The relation for the user group. Valid values:</para>
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
                /// <item><description><para><b>username</b>: Username.</para>
                /// </description></item>
                /// <item><description><para><b>department</b>: Department.</para>
                /// </description></item>
                /// <item><description><para><b>email</b>: Email address.</para>
                /// </description></item>
                /// <item><description><para><b>telephone</b>: Phone number.</para>
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
                /// <item><description><para>If the user group type is <b>username</b>, this is the username. The value must be 1 to 128 characters in length. It can contain letters, digits, periods (.), underscores (_), and hyphens (-). It supports both uppercase and lowercase letters and Chinese characters.</para>
                /// </description></item>
                /// <item><description><para>If the user group type is <b>department</b>, this is the department name. Example: OU=Department 1,OU=SASE DingTalk.</para>
                /// </description></item>
                /// <item><description><para>If the user group type is <b>email</b>, this is the email address. Example: username\@example.com.</para>
                /// </description></item>
                /// <item><description><para>If the user group type is <b>telephone</b>, this is the phone number. Example: 13900001234.</para>
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
            /// <para>A description of the user group.</para>
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
