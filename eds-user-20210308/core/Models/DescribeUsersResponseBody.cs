// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class DescribeUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of users that meet the query conditions</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. An empty NextToken indicates that no more results exist.</para>
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
        /// <para>The collection of convenience account information.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<DescribeUsersResponseBodyUsers> Users { get; set; }
        public class DescribeUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The work address of the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou ***</para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The URL of the user\&quot;s profile picture.</para>
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
            /// <para>Indicates whether administrator access permissions are enabled.</para>
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
            /// <para>The username imported from an external source.</para>
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
            /// <para>The extended user information.</para>
            /// </summary>
            [NameInMap("Extras")]
            [Validation(Required=false)]
            public DescribeUsersResponseBodyUsersExtras Extras { get; set; }
            public class DescribeUsersResponseBodyUsersExtras : TeaModel {
                /// <summary>
                /// <para>The number of assigned cloud resources.</para>
                /// </summary>
                [NameInMap("AssignedResourceCount")]
                [Validation(Required=false)]
                public Dictionary<string, object> AssignedResourceCount { get; set; }

                [NameInMap("ResourcePolicyList")]
                [Validation(Required=false)]
                public List<DescribeUsersResponseBodyUsersExtrasResourcePolicyList> ResourcePolicyList { get; set; }
                public class DescribeUsersResponseBodyUsersExtrasResourcePolicyList : TeaModel {
                    [NameInMap("PolicyId")]
                    [Validation(Required=false)]
                    public string PolicyId { get; set; }

                    [NameInMap("PolicyName")]
                    [Validation(Required=false)]
                    public string PolicyName { get; set; }

                }

            }

            /// <summary>
            /// <para>The collection of user groups to which the convenience account belongs.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersGroups> Groups { get; set; }
            public class DescribeUsersResponseBodyUsersGroups : TeaModel {
                /// <summary>
                /// <para>The user group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ug-12341234****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The user group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UserGroup1</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The convenience account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4205**</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is a user administrator. If the convenience account is of the administrator-activated type, a user administrator must be specified. Notifications such as password resets initiated by end users through the client are sent to the user administrator\&quot;s email or phone. For more information, see <a href="https://help.aliyun.com/document_detail/214472.html">Create a convenience account</a>.</para>
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
            /// <para>The nickname of the user. The value is determined in the following order:</para>
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
            /// <para>The department ID to which the convenience account belongs.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated soon.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>org-4mdgc1cocc59z****</para>
            /// </summary>
            [NameInMap("OrgId")]
            [Validation(Required=false)]
            public string OrgId { get; set; }

            /// <summary>
            /// <para>The collection of departments to which the convenience account belongs.</para>
            /// </summary>
            [NameInMap("Orgs")]
            [Validation(Required=false)]
            public List<DescribeUsersResponseBodyUsersOrgs> Orgs { get; set; }
            public class DescribeUsersResponseBodyUsersOrgs : TeaModel {
                /// <summary>
                /// <para>The department ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org-4mdgc1cocc59z****</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The department name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Department1</para>
                /// </summary>
                [NameInMap("OrgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                [NameInMap("OrgNamePath")]
                [Validation(Required=false)]
                public string OrgNamePath { get; set; }

            }

            /// <summary>
            /// <para>The convenience account type, which includes:</para>
            /// <list type="bullet">
            /// <item><description>Administrator-activated type: The administrator sets the username and password. User notifications such as password resets are sent to the administrator\&quot;s email or phone.</description></item>
            /// <item><description>User-activated type: The administrator sets the username and the user\&quot;s email or phone for receiving notifications. User notifications such as cloud computer provisioning notifications (including the initial password) are sent to the user\&quot;s email or phone.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            [NameInMap("PasswordExpireDays")]
            [Validation(Required=false)]
            public int? PasswordExpireDays { get; set; }

            [NameInMap("PasswordExpireRestDays")]
            [Validation(Required=false)]
            public int? PasswordExpireRestDays { get; set; }

            /// <summary>
            /// <para>The phone number. This parameter is not returned if it is not set.</para>
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
            /// <para>The remark of the convenience account.</para>
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
            /// <para>The globally unique ID of the convenience account.</para>
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
