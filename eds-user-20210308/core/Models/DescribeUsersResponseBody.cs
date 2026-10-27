// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of users that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The token for the next query. An empty NextToken indicates that no more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The collection of convenience user information.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeUsersResponseBodyUsers> Users { get; set; }
        public class DescribeUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The work address of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou***</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The URL of the profile picture.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://cdn">https://cdn</a>.*****</para>
            /// </summary>
            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            /// <summary>
            /// <para>The email address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:username@example.com">username@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable administrator access permissions.</para>
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The name of the externally imported user.</para>
            /// <remarks>
            /// <para>This field is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Ma**</para>
            /// </summary>
            [NameInMap("ExternalName")]
            [Validation(Required=false)]
            public string ExternalName { get; set; }

            /// <summary>
            /// <para>The extended information of the user.</para>
            /// </summary>
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public DescribeUsersResponseBodyUsersExtras Extras { get; set; }
            public class DescribeUsersResponseBodyUsersExtras : TeaModel {
                /// <summary>
                /// <para>The number of allocated cloud resources.</para>
                /// </summary>
                [NameInMap("AssignedResourceCount")]
                [Validation(Required=false)]
                public Dictionary<string, object> AssignedResourceCount { get; set; }

                /// <summary>
                /// <para>The list of resource policies associated with the user.</para>
                /// </summary>
                [NameInMap("ResourcePolicyList")]
                [Validation(Required=false)]
                public List<DescribeUsersResponseBodyUsersExtrasResourcePolicyList> ResourcePolicyList { get; set; }
                public class DescribeUsersResponseBodyUsersExtrasResourcePolicyList : TeaModel {
                    /// <summary>
                    /// <para>The ID of the resource policy.</para>
                    /// </summary>
                    [NameInMap("PolicyId")]
                    [Validation(Required=false)]
                    public string PolicyId { get; set; }

                    /// <summary>
                    /// <para>The Policy Name of the resource policy.</para>
                    /// </summary>
                    [NameInMap("PolicyName")]
                    [Validation(Required=false)]
                    public string PolicyName { get; set; }

                }

            }

            /// <summary>
            /// <para>The collection of user groups to which the convenience user belongs.</para>
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
            /// <para>Indicates whether the user is a tenant administrator. If the convenience user to be created uses the administrator activation type, you must specify a tenant administrator. Notifications such as password resets initiated by end users through the client are sent to the email address or mobile phone number of the tenant administrator. For more information, see <a href="https://help.aliyun.com/document_detail/214472.html">Create a convenience user</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsTenantManager")]
            [Validation(Required=false)]
            public bool? IsTenantManager { get; set; }

            /// <summary>
            /// <para>The employee ID of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A10000**</para>
            /// </summary>
            [NameInMap("JobNumber")]
            [Validation(Required=false)]
            public string JobNumber { get; set; }

            /// <summary>
            /// <para>The nickname of the user. The value is obtained in the following order:</para>
            /// <list type="bullet">
            /// <item><description>RealNickName</description></item>
            /// <item><description>Remark</description></item>
            /// <item><description>EndUserId</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Li**</para>
            /// </summary>
            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            /// <summary>
            /// <para>The ID of the department to which the convenience user belongs.</para>
            /// <remarks>
            /// <para><b>[Deprecated]</b> This parameter will be deprecated soon.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>org-4mdgc1cocc59z****</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The collection of departments to which the convenience user belongs.</para>
            /// </summary>
            [NameInMap("Orgs")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersOrgs> Orgs { get; set; }
            public class DescribeUsersResponseBodyUsersOrgs : TeaModel {
                /// <summary>
                /// <para>The ID of the department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org-4mdgc1cocc59z****</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The name of the department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Department 1</para>
                /// </summary>
                [NameInMap("OrgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                /// <summary>
                /// <para>The name path from the root organization to the current organization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product Department/Design Department</para>
                /// </summary>
                [NameInMap("OrgNamePath")]
                [Validation(Required=false)]
                public string OrgNamePath { get; set; }

            }

            /// <summary>
            /// <para>The convenience user type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateFromManager: administrator-activated. The administrator sets the username and password. User notifications such as password reset notifications are sent to the email address or mobile phone number of the administrator.</description></item>
            /// <item><description>Normal: user-activated. The administrator sets the username and the email address or mobile phone number for receiving notifications. User notifications such as cloud desktop activation notifications (including the initial password) are sent to the email address or mobile phone number of the user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The password validity period, in days. Valid values: 30 to 365. By default, the password never expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PasswordExpireDays")]
            [Validation(Required=false)]
            public int? PasswordExpireDays { get; set; }

            /// <summary>
            /// <para>The remaining days of the password validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PasswordExpireRestDays")]
            [Validation(Required=false)]
            public int? PasswordExpireRestDays { get; set; }

            /// <summary>
            /// <para>The mobile phone number. This parameter is not returned if it is not configured.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The user properties.</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersProperties> Properties { get; set; }
            public class DescribeUsersResponseBodyUsersProperties : TeaModel {
                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Role</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The property value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Student</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The display name of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Li**</para>
            /// </summary>
            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// <para>The remarks for the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test user.</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The status.</para>
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
