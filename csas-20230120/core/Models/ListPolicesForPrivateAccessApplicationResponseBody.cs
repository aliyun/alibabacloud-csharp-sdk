// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListPolicesForPrivateAccessApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of private access applications.</para>
        /// </summary>
        [NameInMap("Applications")]
        [Validation(Required=false)]
        public List<ListPolicesForPrivateAccessApplicationResponseBodyApplications> Applications { get; set; }
        public class ListPolicesForPrivateAccessApplicationResponseBodyApplications : TeaModel {
            /// <summary>
            /// <para>The ID of the private access application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pa-application-b927baf3e592****</para>
            /// </summary>
            [NameInMap("ApplicationId")]
            [Validation(Required=false)]
            public string ApplicationId { get; set; }

            /// <summary>
            /// <para>The collection of private access policies.</para>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListPolicesForPrivateAccessApplicationResponseBodyApplicationsPolicies> Policies { get; set; }
            public class ListPolicesForPrivateAccessApplicationResponseBodyApplicationsPolicies : TeaModel {
                /// <summary>
                /// <para>The application type of the private access policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Application</b>: Application.</para>
                /// </description></item>
                /// <item><description><para><b>Tag</b>: Tag.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Application</para>
                /// </summary>
                [NameInMap("ApplicationType")]
                [Validation(Required=false)]
                public string ApplicationType { get; set; }

                /// <summary>
                /// <para>The time when the private access policy was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-09-27 18:10:25</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The collection of custom user group attributes. If you specify multiple attributes, the relationship between them is OR.</para>
                /// </summary>
                [NameInMap("CustomUserAttributes")]
                [Validation(Required=false)]
                public List<ListPolicesForPrivateAccessApplicationResponseBodyApplicationsPoliciesCustomUserAttributes> CustomUserAttributes { get; set; }
                public class ListPolicesForPrivateAccessApplicationResponseBodyApplicationsPoliciesCustomUserAttributes : TeaModel {
                    /// <summary>
                    /// <para>The ID of the identity provider (IdP) for the user group. This parameter is returned when the custom user group type is <b>department</b>.</para>
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
                    /// <item><description><para><b>username</b>: Username.</para>
                    /// </description></item>
                    /// <item><description><para><b>department</b>: Department.</para>
                    /// </description></item>
                    /// <item><description><para><b>email</b>: Email.</para>
                    /// </description></item>
                    /// <item><description><para><b>telephone</b>: Mobile number.</para>
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
                    /// <para>The value of the user group attribute.</para>
                    /// <list type="bullet">
                    /// <item><description><para>If the user group type is <b>username</b>, this parameter specifies the value of the username. The value can be 1 to 128 characters in length and can contain Chinese characters, letters, digits, periods (.), underscores (_), and hyphens (-).</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>department</b>, this parameter specifies the value of the department. Example: OU=Department 1,OU=SASE DingTalk.</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>email</b>, this parameter specifies the value of the email address. Example: username\@example.com.</para>
                    /// </description></item>
                    /// <item><description><para>If the user group type is <b>telephone</b>, this parameter specifies the value of the mobile number. Example: 13900001234.</para>
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
                /// <para>The description of the private access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条内网访问策略</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The name of the private access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>private_access_policy_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The action of the private access policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Block</b>: Blocks access.</para>
                /// </description></item>
                /// <item><description><para><b>Allow</b>: Allows access.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Allow</para>
                /// </summary>
                [NameInMap("PolicyAction")]
                [Validation(Required=false)]
                public string PolicyAction { get; set; }

                /// <summary>
                /// <para>The ID of the private access policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pa-policy-867ef4007c8a****</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <para>The priority of the private access policy. The value 1 indicates the highest priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The status of the private access policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Enabled</b>: The policy is enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: The policy is disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enabled</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The user group type of the private access policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Normal</b>: Regular user group.</para>
                /// </description></item>
                /// <item><description><para><b>Custom</b>: Custom user group.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("UserGroupType")]
                [Validation(Required=false)]
                public string UserGroupType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4AB972E2-D702-5464-B132-B1911498B8BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
