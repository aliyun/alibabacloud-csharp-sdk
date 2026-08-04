// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetRegistrationPolicyResponseBody : TeaModel {
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
        /// <para>The list of limit details of the device registration policy.</para>
        /// </summary>
        [NameInMap("LimitDetail")]
        [Validation(Required=false)]
        public List<GetRegistrationPolicyResponseBodyLimitDetail> LimitDetail { get; set; }
        public class GetRegistrationPolicyResponseBodyLimitDetail : TeaModel {
            /// <summary>
            /// <para>The ownership of the device. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Company</b>: company-owned device.</description></item>
            /// <item><description><b>Personal</b>: personal device.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Personal</para>
            /// </summary>
            [NameInMap("DeviceBelong")]
            [Validation(Required=false)]
            public string DeviceBelong { get; set; }

            /// <summary>
            /// <para>The device registration limit count.</para>
            /// </summary>
            [NameInMap("LimitCount")]
            [Validation(Required=false)]
            public GetRegistrationPolicyResponseBodyLimitDetailLimitCount LimitCount { get; set; }
            public class GetRegistrationPolicyResponseBodyLimitDetailLimitCount : TeaModel {
                /// <summary>
                /// <para>The total device registration limit. This parameter is valid when the device registration limit type is <b>LimitAll</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("All")]
                [Validation(Required=false)]
                public int? All { get; set; }

                /// <summary>
                /// <para>The number of mobile logins allowed by the device registration limit. This parameter is valid when the device registration limit type is <b>LimitDiff</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public int? Mobile { get; set; }

                /// <summary>
                /// <para>The number of PC logins allowed by the device registration limit. This parameter is valid when the device registration limit type is <b>LimitDiff</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PC")]
                [Validation(Required=false)]
                public int? PC { get; set; }

            }

            /// <summary>
            /// <para>The type of the device registration limit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unlimited</b>: no limit.</description></item>
            /// <item><description><b>LimitAll</b>: limit by total count.</description></item>
            /// <item><description><b>LimitDiff</b>: limit by terminal category.</description></item>
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
        /// <para>The match mode of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: associated with all users.</description></item>
        /// <item><description><b>UserGroupNormal</b>: associated with specific user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
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
        /// <para>The priority of the device registration policy. The value 0 indicates the highest priority, and the value 99 indicates the lowest priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47363C2B-1AAA-5954-8847-0E50FCC54117</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the device registration policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enabled.</description></item>
        /// <item><description><b>Disabled</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IDs of the user groups associated with the device registration policy. This parameter is valid when the match mode of the policy is <b>UserGroupNormal</b>.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of whitelisted users in the device registration policy.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
