// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateRegistrationPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The device registration policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public CreateRegistrationPolicyResponseBodyPolicy Policy { get; set; }
        public class CreateRegistrationPolicyResponseBodyPolicy : TeaModel {
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
            /// <para>A description of the device registration policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>这是一条设备注册策略</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of device registration limits.</para>
            /// </summary>
            [NameInMap("LimitDetail")]
            [Validation(Required=false)]
            public List<CreateRegistrationPolicyResponseBodyPolicyLimitDetail> LimitDetail { get; set; }
            public class CreateRegistrationPolicyResponseBodyPolicyLimitDetail : TeaModel {
                /// <summary>
                /// <para>The ownership of the device. Valid values:</para>
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
                /// <para>The restriction count for device registration.</para>
                /// </summary>
                [NameInMap("LimitCount")]
                [Validation(Required=false)]
                public CreateRegistrationPolicyResponseBodyPolicyLimitDetailLimitCount LimitCount { get; set; }
                public class CreateRegistrationPolicyResponseBodyPolicyLimitDetailLimitCount : TeaModel {
                    /// <summary>
                    /// <para>The total restriction count for device registration. This parameter takes effect only when LimitType is set to <b>LimitAll</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("All")]
                    [Validation(Required=false)]
                    public int? All { get; set; }

                    /// <summary>
                    /// <para>The restriction count for mobile logins. This parameter takes effect only when LimitType is set to <b>LimitDiff</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public int? Mobile { get; set; }

                    /// <summary>
                    /// <para>The restriction count for PC logins. This parameter takes effect only when LimitType is set to <b>LimitDiff</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("PC")]
                    [Validation(Required=false)]
                    public int? PC { get; set; }

                }

                /// <summary>
                /// <para>The restriction type for device registration. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Unlimited</b>: No restrictions.</para>
                /// </description></item>
                /// <item><description><para><b>LimitAll</b>: Limit by total count.</para>
                /// </description></item>
                /// <item><description><para><b>LimitDiff</b>: Limit by device category.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LimitDiff</para>
                /// </summary>
                [NameInMap("LimitType")]
                [Validation(Required=false)]
                public string LimitType { get; set; }

            }

            /// <summary>
            /// <para>The target type for policy matching. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>UserGroupAll</b>: Apply to all users.</para>
            /// </description></item>
            /// <item><description><para><b>UserGroupNormal</b>: Apply to selected user groups.</para>
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
            /// <para>The priority of the device registration policy. A value of 0 indicates the highest priority. A value of 99 indicates the lowest priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

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
            /// <para>The IDs of user groups to which the device registration policy applies. This field has a value only when MatchMode is set to <b>UserGroupNormal</b>.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            /// <summary>
            /// <para>The list of usernames in the whitelist for the device registration policy.</para>
            /// </summary>
            [NameInMap("Whitelist")]
            [Validation(Required=false)]
            public List<string> Whitelist { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEF1144C-95D1-5F7C-81EF-9DB70EA49FCE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
