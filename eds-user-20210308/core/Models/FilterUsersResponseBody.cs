// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The token for the next query. If a query does not return all results, the returned NextToken is not empty. You can pass the returned NextToken in a subsequent query to continue the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
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
        public List<FilterUsersResponseBodyUsers> Users { get; set; }
        public class FilterUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The date when the account is automatically locked, in the YYYY-MM-DD format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-03</para>
            /// </summary>
            [NameInMap("AutoLockTime")]
            [Validation(Required=false)]
            public string AutoLockTime { get; set; }

            /// <summary>
            /// <para>The number of cloud computers assigned to the user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public long? DesktopCount { get; set; }

            /// <summary>
            /// <para>The number of cloud computer pools authorized for the user. This value is returned when <c>IncludeDesktopGroupCount</c> is set to <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public long? DesktopGroupCount { get; set; }

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
            /// <para>Indicates whether the user is a local administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>The extended user information.</para>
            /// </summary>
            [NameInMap("ExternalInfo")]
            [Validation(Required=false)]
            public FilterUsersResponseBodyUsersExternalInfo ExternalInfo { get; set; }
            public class FilterUsersResponseBodyUsersExternalInfo : TeaModel {
                /// <summary>
                /// <para>The name of the external account associated with the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>account</para>
                /// </summary>
                [NameInMap("ExternalName")]
                [Validation(Required=false)]
                public string ExternalName { get; set; }

                /// <summary>
                /// <para>The external account, student ID, or employee ID associated with the user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>030801</para>
                /// </summary>
                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

            }

            /// <summary>
            /// <para>The list of user groups to which the convenience user belongs.</para>
            /// </summary>
            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersGroups> Groups { get; set; }
            public class FilterUsersResponseBodyUsersGroups : TeaModel {
                /// <summary>
                /// <para>The user group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ug-2412ojkwtybd****</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The user group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestGroup</para>
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4205**</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is a tenant administrator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsTenantManager")]
            [Validation(Required=false)]
            public bool? IsTenantManager { get; set; }

            /// <summary>
            /// <para>The list of organizations to which the user belongs.</para>
            /// </summary>
            [NameInMap("OrgList")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersOrgList> OrgList { get; set; }
            public class FilterUsersResponseBodyUsersOrgList : TeaModel {
                /// <summary>
                /// <para>The organization structure ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>org-1mox****</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The organization structure name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Design Department</para>
                /// </summary>
                [NameInMap("OrgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                /// <summary>
                /// <para>The organization structure name path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product Department/Design Department</para>
                /// </summary>
                [NameInMap("OrgNamePath")]
                [Validation(Required=false)]
                public string OrgNamePath { get; set; }

            }

            /// <summary>
            /// <para>The ownership type of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The password of the user account is valid permanently by default. You can use this parameter to set a password validity period of 30 to 365 days. After the password expires, the end user must change the password before logging on again.</para>
            /// <remarks>
            /// <para>This feature is currently in invitational preview. To use this feature, submit a ticket.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PasswordExpireDays")]
            [Validation(Required=false)]
            public int? PasswordExpireDays { get; set; }

            /// <summary>
            /// <para>The remaining days of the password validity period for the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PasswordExpireRestDays")]
            [Validation(Required=false)]
            public int? PasswordExpireRestDays { get; set; }

            /// <summary>
            /// <para>The mobile phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The user nickname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Xiaoming</para>
            /// </summary>
            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// <para>The user remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>For testing only</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The list of resource policies associated with the convenience user.</para>
            /// </summary>
            [NameInMap("ResourcePolicyList")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersResourcePolicyList> ResourcePolicyList { get; set; }
            public class FilterUsersResponseBodyUsersResourcePolicyList : TeaModel {
                /// <summary>
                /// <para>The resource policy ID.</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <para>The resource policy name.</para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

            }

            /// <summary>
            /// <para>The status of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The supported logon identity sources.</para>
            /// </summary>
            [NameInMap("SupportLoginIdps")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersSupportLoginIdps> SupportLoginIdps { get; set; }
            public class FilterUsersResponseBodyUsersSupportLoginIdps : TeaModel {
                /// <summary>
                /// <para>The enterprise identity source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>idp-hlyexfvwert9m8****</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public string IdpId { get; set; }

                /// <summary>
                /// <para>The enterprise identity source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DingTalk</para>
                /// </summary>
                [NameInMap("IdpName")]
                [Validation(Required=false)]
                public string IdpName { get; set; }

            }

            /// <summary>
            /// <para>The collection of user properties.</para>
            /// </summary>
            [NameInMap("UserSetPropertiesModels")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersUserSetPropertiesModels> UserSetPropertiesModels { get; set; }
            public class FilterUsersResponseBodyUsersUserSetPropertiesModels : TeaModel {
                /// <summary>
                /// <para>The user property ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("PropertyId")]
                [Validation(Required=false)]
                public long? PropertyId { get; set; }

                /// <summary>
                /// <para>The user property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>The user property number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PropertyType")]
                [Validation(Required=false)]
                public int? PropertyType { get; set; }

                /// <summary>
                /// <para>The user property value.</para>
                /// </summary>
                [NameInMap("PropertyValues")]
                [Validation(Required=false)]
                public List<FilterUsersResponseBodyUsersUserSetPropertiesModelsPropertyValues> PropertyValues { get; set; }
                public class FilterUsersResponseBodyUsersUserSetPropertiesModelsPropertyValues : TeaModel {
                    /// <summary>
                    /// <para>The user property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dev</para>
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                    /// <summary>
                    /// <para>The user property value ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>42</para>
                    /// </summary>
                    [NameInMap("PropertyValueId")]
                    [Validation(Required=false)]
                    public long? PropertyValueId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the user to which the property is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4205**</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The username of the user to which the property is bound.</para>
                /// 
                /// <b>Example:</b>
                /// <para>alice</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
