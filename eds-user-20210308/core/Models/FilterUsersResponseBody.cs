// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_user20210308.Models
{
    public class FilterUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If not all results are returned in a query, a value is returned for the NextToken parameter. In this case, you can use the returned NextToken value to start the next query.</para>
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
        /// <para>DBD276B5-00FF-5E04-8EF7-5CBA09BF112A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the convenience accounts.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public List<FilterUsersResponseBodyUsers> Users { get; set; }
        public class FilterUsersResponseBodyUsers : TeaModel {
            /// <summary>
            /// <para>The date when a convenience account is automatically locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-03</para>
            /// </summary>
            [NameInMap("AutoLockTime")]
            [Validation(Required=false)]
            public string AutoLockTime { get; set; }

            /// <summary>
            /// <para>The number of cloud desktops that are assigned to the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopCount")]
            [Validation(Required=false)]
            public long? DesktopCount { get; set; }

            /// <summary>
            /// <para>The number of cloud desktop pools that are assigned to the convenience user. This value is returned if you set <c>IncludeDesktopGroupCount</c> to <c>true</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public long? DesktopGroupCount { get; set; }

            /// <summary>
            /// <para>The email address of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:testName@example.com">testName@example.com</a></para>
            /// </summary>
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            /// <summary>
            /// <para>Indicates whether the convenience user is a local administrator.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>false</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableAdminAccess")]
            [Validation(Required=false)]
            public bool? EnableAdminAccess { get; set; }

            /// <summary>
            /// <para>The username of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testName</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The additional information about the convenience user.</para>
            /// </summary>
            [NameInMap("ExternalInfo")]
            [Validation(Required=false)]
            public FilterUsersResponseBodyUsersExternalInfo ExternalInfo { get; set; }
            public class FilterUsersResponseBodyUsersExternalInfo : TeaModel {
                /// <summary>
                /// <para>The account that is associated with the convenience user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ExternalName")]
                [Validation(Required=false)]
                public string ExternalName { get; set; }

                /// <summary>
                /// <para>The account, student ID, or employee ID that is associated with the convenience user.</para>
                /// 
                /// <b>Example:</b>
                /// <para>030801</para>
                /// </summary>
                [NameInMap("JobNumber")]
                [Validation(Required=false)]
                public string JobNumber { get; set; }

            }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersGroups> Groups { get; set; }
            public class FilterUsersResponseBodyUsersGroups : TeaModel {
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the convenience user is a tenant administrator.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- -->
            /// </description></item>
            /// <item><description><para>false</para>
            /// <!-- -->
            /// 
            /// <!-- -->
            /// 
            /// <!-- --></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsTenantManager")]
            [Validation(Required=false)]
            public bool? IsTenantManager { get; set; }

            /// <summary>
            /// <para>The organizations to which the user belongs.</para>
            /// </summary>
            [NameInMap("OrgList")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersOrgList> OrgList { get; set; }
            public class FilterUsersResponseBodyUsersOrgList : TeaModel {
                /// <summary>
                /// <para>The organization ID.</para>
                /// </summary>
                [NameInMap("OrgId")]
                [Validation(Required=false)]
                public string OrgId { get; set; }

                /// <summary>
                /// <para>The organization name.</para>
                /// </summary>
                [NameInMap("OrgName")]
                [Validation(Required=false)]
                public string OrgName { get; set; }

                /// <summary>
                /// <para>The organization name path.</para>
                /// </summary>
                [NameInMap("OrgNamePath")]
                [Validation(Required=false)]
                public string OrgNamePath { get; set; }

            }

            /// <summary>
            /// <para>The type of the account ownership.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CreateFromManager: administrator-activated</description></item>
            /// <item><description>Normal: user-activated</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("OwnerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>By default, user account passwords do not expire. However, you can set a validity period between 30 and 365 days. Once the period expires, end users must change their password before they can log on to terminals.</para>
            /// <remarks>
            /// <para> The feature is in invitational preview. If you want to use this feature, submit a ticket.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PasswordExpireDays")]
            [Validation(Required=false)]
            public int? PasswordExpireDays { get; set; }

            /// <summary>
            /// <para>The number of days remaining until the account password expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PasswordExpireRestDays")]
            [Validation(Required=false)]
            public int? PasswordExpireRestDays { get; set; }

            /// <summary>
            /// <para>The mobile number of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1381111****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>The nickname of the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Oliver</para>
            /// </summary>
            [NameInMap("RealNickName")]
            [Validation(Required=false)]
            public string RealNickName { get; set; }

            /// <summary>
            /// <para>The remarks on the convenience user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// <para>The remarks on the convenience account.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The convenience account is normal.</description></item>
            /// <item><description>9: The convenience account is locked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            /// <summary>
            /// <para>The supported identity provider logon methods.</para>
            /// </summary>
            [NameInMap("SupportLoginIdps")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersSupportLoginIdps> SupportLoginIdps { get; set; }
            public class FilterUsersResponseBodyUsersSupportLoginIdps : TeaModel {
                /// <summary>
                /// <para>The enterprise identity provider ID.</para>
                /// </summary>
                [NameInMap("IdpId")]
                [Validation(Required=false)]
                public string IdpId { get; set; }

                /// <summary>
                /// <para>The enterprise identity provider name.</para>
                /// </summary>
                [NameInMap("IdpName")]
                [Validation(Required=false)]
                public string IdpName { get; set; }

            }

            /// <summary>
            /// <para>The information about the properties.</para>
            /// </summary>
            [NameInMap("UserSetPropertiesModels")]
            [Validation(Required=false)]
            public List<FilterUsersResponseBodyUsersUserSetPropertiesModels> UserSetPropertiesModels { get; set; }
            public class FilterUsersResponseBodyUsersUserSetPropertiesModels : TeaModel {
                /// <summary>
                /// <para>The property ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("PropertyId")]
                [Validation(Required=false)]
                public long? PropertyId { get; set; }

                /// <summary>
                /// <para>The property name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>department</para>
                /// </summary>
                [NameInMap("PropertyKey")]
                [Validation(Required=false)]
                public string PropertyKey { get; set; }

                /// <summary>
                /// <para>The property type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PropertyType")]
                [Validation(Required=false)]
                public int? PropertyType { get; set; }

                /// <summary>
                /// <para>The property values.</para>
                /// </summary>
                [NameInMap("PropertyValues")]
                [Validation(Required=false)]
                public List<FilterUsersResponseBodyUsersUserSetPropertiesModelsPropertyValues> PropertyValues { get; set; }
                public class FilterUsersResponseBodyUsersUserSetPropertiesModelsPropertyValues : TeaModel {
                    /// <summary>
                    /// <para>The property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("PropertyValue")]
                    [Validation(Required=false)]
                    public string PropertyValue { get; set; }

                    /// <summary>
                    /// <para>The ID of the property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>42</para>
                    /// </summary>
                    [NameInMap("PropertyValueId")]
                    [Validation(Required=false)]
                    public long? PropertyValueId { get; set; }

                }

                /// <summary>
                /// <para>The ID of the convenience user that is bound to the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// <para>The username of the convenience user that is bound to the property.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testName</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

    }

}
