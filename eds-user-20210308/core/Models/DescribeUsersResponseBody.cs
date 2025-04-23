// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The token that determines the start point of the next query. If this parameter is left empty, all results are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The convenience accounts.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeUsersResponseBodyUsers> Users { get; set; }
        public class DescribeUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The work address of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou \<em>\</em>\*</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The profile picture of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn">https://cdn</a>.*****</para>
            /// </summary>
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// <para>The email address of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>The username of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            [NameInMap("ExternalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }

            [NameInMap("Extras")]
            [Validation(Required=false)]
            public DescribeUsersResponseBodyUsersExtras Extras { get; set; }
            public class DescribeUsersResponseBodyUsersExtras : TeaModel {
                [NameInMap("AssignedResourceCount")]
                [Validation(Required=false)]
                public Dictionary<string, object> AssignedResourceCount { get; set; }

            }

            /// <summary>
            /// <para>The user groups to which the convenience user belongs.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersGroups> Groups { get; set; }
            public class DescribeUsersResponseBodyUsersGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ug-12341234****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The name of the user group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User Group 1</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4205**</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the convenience user is an administrator. If the convenience user is of the administrator-activated type, you must specify a user administrator. Notifications such as password reset on a client are sent to the email address or mobile number of the user administrator. For more information, see <a href="https://help.aliyun.com/document_detail/214472.html">Create a convenience user</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsTenantManager")]
            [Validation(Required=false)]
            public bool? IsTenantManager { get; set; }

            /// <summary>
            /// <para>The employee number of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A10000**</para>
            /// </summary>
            [NameInMap("JobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            /// <summary>
            /// <para>The nickname of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Lee</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The ID of the organization to which the convenience user belongs.</para>
            /// <remarks>
            /// <para> This parameter will be deprecated in the future.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>org-4mdgc1cocc59z****</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The organizations to which the convenience user belongs.</para>
            /// </summary>
            [NameInMap("Orgs")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersOrgs> Orgs { get; set; }
            public class DescribeUsersResponseBodyUsersOrgs : TeaModel {
                /// <summary>
                /// <para>The organization ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org-4mdgc1cocc59z****</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The organization name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Organization 1</para>
                /// </summary>
                [NameInMap("OrgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

            }

            /// <summary>
            /// <para>The type of the convenience account.</para>
            /// <list type="bullet">
            /// <item><description>Administrator-activated type: The administrator specifies the username and password of the convenience account. User notifications such as password reset notifications are sent to the email address or mobile number of the administrator.</description></item>
            /// <item><description>User-activated type: The administrator specifies the username and the email address or mobile number of a convenience user. Notifications such as activation notifications that contain the default password are sent to the email address or mobile number of the convenience user.</description></item>
            /// </list>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>CreateFromManager</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>administrator-activated</para>
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>Normal</para>
            /// <!-- -->
            /// 
            /// <para>:</para>
            /// <!-- -->
            /// 
            /// <para>user-activated</para>
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The mobile number of the convenience user. If you leave this parameter empty, the value of this parameter is not returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersProperties> Properties { get; set; }
            public class DescribeUsersResponseBodyUsersProperties : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// <para>The remarks on the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestUser</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status of the convenience user.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: The convenience user is normal.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>9: The convenience user is locked.</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The globally unique ID of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>41fd1254d8f7****</para>
            /// </summary>
            [NameInMap("WyId")]
            [Validation(Required=false)]
            public string WyId { get; set; }

        }

    }

}
