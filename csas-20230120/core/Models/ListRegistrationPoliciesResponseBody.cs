// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListRegistrationPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of device registration policies.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListRegistrationPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListRegistrationPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>The creation time of the device registration policy.</para>
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
            public List<ListRegistrationPoliciesResponseBodyPoliciesLimitDetail> LimitDetail { get; set; }
            public class ListRegistrationPoliciesResponseBodyPoliciesLimitDetail : TeaModel {
                /// <summary>
                /// <para>The device ownership. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Company</b>: Company device.</para>
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
                /// <para>The number of device registration limits.</para>
                /// </summary>
                [NameInMap("LimitCount")]
                [Validation(Required=false)]
                public ListRegistrationPoliciesResponseBodyPoliciesLimitDetailLimitCount LimitCount { get; set; }
                public class ListRegistrationPoliciesResponseBodyPoliciesLimitDetailLimitCount : TeaModel {
                    /// <summary>
                    /// <para>The total number of device registration limits. This field is valid when the device registration limit type is <b>LimitAll</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("All")]
                    [Validation(Required=false)]
                    public int? All { get; set; }

                    /// <summary>
                    /// <para>The number of mobile client log ons allowed for device registration. This field is valid when the device registration limit type is <b>LimitDiff</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public int? Mobile { get; set; }

                    /// <summary>
                    /// <para>The number of PC client log ons allowed for device registration. This field is valid when the device registration limit type is <b>LimitDiff</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PC")]
                    [Validation(Required=false)]
                    public int? PC { get; set; }

                }

                /// <summary>
                /// <para>The type of device registration limit. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Unlimited</b>: No limit.</para>
                /// </description></item>
                /// <item><description><para><b>LimitAll</b>: Limit by total number.</para>
                /// </description></item>
                /// <item><description><para><b>LimitDiff</b>: Limit by device categorization.</para>
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
            /// <para>The policy matching target type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>UserGroupAll</b>: Associate all users.</para>
            /// </description></item>
            /// <item><description><para><b>UserGroupNormal</b>: Associate some user groups.</para>
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
            /// <para>The policy priority for device registration. A value of 0 indicates the highest priority, and 99 indicates the lowest priority.</para>
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
            /// <para>A collection of user group IDs for the device registration policy. This field has a value when the policy matching target type is <b>UserGroupNormal</b>.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            /// <summary>
            /// <para>The whitelist of users for the device registration policy.</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public List<string> Whitelist { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A8FE38A-E29C-5678-B84A-FEDBCB83552F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of device registration policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public string TotalNum { get; set; }

    }

}
