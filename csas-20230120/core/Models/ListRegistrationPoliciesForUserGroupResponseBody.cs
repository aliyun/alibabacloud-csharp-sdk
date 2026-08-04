// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRegistrationPoliciesForUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58D6B23E-E5DA-5418-8F61-51A3B5A30049</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of user groups.</para>
        /// </summary>
        [NameInMap("UserGroups")]
        [Validation(Required=false)]
        public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroups> UserGroups { get; set; }
        public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroups : TeaModel {
            /// <summary>
            /// <para>The collection of device registration policies.</para>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPolicies> Policies { get; set; }
            public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPolicies : TeaModel {
                /// <summary>
                /// <para>The time when the device registration policy was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-16 17:18:46</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The description of the device registration policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>这是一条设备注册策略。</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The list of device registration policy limit details.</para>
                /// </summary>
                [NameInMap("LimitDetail")]
                [Validation(Required=false)]
                public List<ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetail> LimitDetail { get; set; }
                public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetail : TeaModel {
                    /// <summary>
                    /// <para>Device ownership. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Company</b>: Company-owned device.</para>
                    /// </description></item>
                    /// <item><description><para><b>Personal</b>: Personal device.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Company</para>
                    /// </summary>
                    [NameInMap("DeviceBelong")]
                    [Validation(Required=false)]
                    public string DeviceBelong { get; set; }

                    /// <summary>
                    /// <para>The number of allowed device registrations.</para>
                    /// </summary>
                    [NameInMap("LimitCount")]
                    [Validation(Required=false)]
                    public ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetailLimitCount LimitCount { get; set; }
                    public class ListRegistrationPoliciesForUserGroupResponseBodyUserGroupsPoliciesLimitDetailLimitCount : TeaModel {
                        /// <summary>
                        /// <para>The total number of allowed device registrations. This field is valid only when LimitType is set to <b>LimitAll</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("All")]
                        [Validation(Required=false)]
                        public string All { get; set; }

                        /// <summary>
                        /// <para>The number of allowed mobile logons. This field is valid only when LimitType is set to <b>LimitDiff</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Mobile")]
                        [Validation(Required=false)]
                        public string Mobile { get; set; }

                        /// <summary>
                        /// <para>The number of allowed PC logons. This field is valid only when LimitType is set to <b>LimitDiff</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("PC")]
                        [Validation(Required=false)]
                        public string PC { get; set; }

                    }

                    /// <summary>
                    /// <para>The device registration limit type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Unlimited</b>: No limit.</para>
                    /// </description></item>
                    /// <item><description><para><b>LimitAll</b>: Limit by total count.</para>
                    /// </description></item>
                    /// <item><description><para><b>LimitDiff</b>: Limit by device category.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LimitAll</para>
                    /// </summary>
                    [NameInMap("LimitType")]
                    [Validation(Required=false)]
                    public string LimitType { get; set; }

                }

                /// <summary>
                /// <para>The target type for policy matching. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>UserGroupAll</b>: Associate with all users.</para>
                /// </description></item>
                /// <item><description><para><b>UserGroupNormal</b>: Associate with specific user groups.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>UserGroupNormal</para>
                /// </summary>
                [NameInMap("MatchMode")]
                [Validation(Required=false)]
                public string MatchMode { get; set; }

                /// <summary>
                /// <para>The name of the device registration policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registration_policy_name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The ID of the device registration policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reg-policy-dcbfd33cb004****</para>
                /// </summary>
                [NameInMap("PolicyId")]
                [Validation(Required=false)]
                public string PolicyId { get; set; }

                /// <summary>
                /// <para>The policy priority. The number 0 indicates the highest priority. The number 99 indicates the lowest priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public long? Priority { get; set; }

                /// <summary>
                /// <para>The status of the device registration policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Enabled</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>Disabled</b>: Disabled.</para>
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
                /// <para>The list of users on the device registration policy whitelist.</para>
                /// </summary>
                [NameInMap("Whitelist")]
                [Validation(Required=false)]
                public List<string> Whitelist { get; set; }

            }

            /// <summary>
            /// <para>The user group ID.</para>
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
