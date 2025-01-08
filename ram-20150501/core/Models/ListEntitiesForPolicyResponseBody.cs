// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListEntitiesForPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the RAM user groups.</para>
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyGroups Groups { get; set; }
        public class ListEntitiesForPolicyResponseBodyGroups : TeaModel {
            [NameInMap("Group")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyGroupsGroup> Group { get; set; }
            public class ListEntitiesForPolicyResponseBodyGroupsGroup : TeaModel {
                /// <summary>
                /// <para>The time when the policy was attached to the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-02-18T17:22:08Z</para>
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// <para>The description of the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test team</para>
                /// </summary>
                [NameInMap("Comments")]
                [Validation(Required=false)]
                public string Comments { get; set; }

                /// <summary>
                /// <para>The name of the RAM user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QA-Team</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B8A4E7D-6CFF-471D-84DF-195A7A241ECB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of RAM roles.</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyRoles Roles { get; set; }
        public class ListEntitiesForPolicyResponseBodyRoles : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyRolesRole> Role { get; set; }
            public class ListEntitiesForPolicyResponseBodyRolesRole : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:ram::123456789012****:role/ECSAdmin</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The time when the policy was attached to the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// <para>The description of the RAM role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS administrator</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the RAM role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122748924538****</para>
                /// </summary>
                [NameInMap("RoleId")]
                [Validation(Required=false)]
                public string RoleId { get; set; }

                /// <summary>
                /// <para>The name of the RAM role.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECSAdmin</para>
                /// </summary>
                [NameInMap("RoleName")]
                [Validation(Required=false)]
                public string RoleName { get; set; }

            }

        }

        /// <summary>
        /// <para>The list of the RAM users to which the policy is attached.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListEntitiesForPolicyResponseBodyUsers Users { get; set; }
        public class ListEntitiesForPolicyResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListEntitiesForPolicyResponseBodyUsersUser> User { get; set; }
            public class ListEntitiesForPolicyResponseBodyUsersUser : TeaModel {
                /// <summary>
                /// <para>The time when the policy was attached to the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("AttachDate")]
                [Validation(Required=false)]
                public string AttachDate { get; set; }

                /// <summary>
                /// <para>The display name of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhang*</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The unique ID of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>122748924538****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The name of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zhangq****</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
