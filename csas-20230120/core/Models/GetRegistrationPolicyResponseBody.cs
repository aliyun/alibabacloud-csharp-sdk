// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetRegistrationPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the device registration policy was created. The time is in the YYYY-MM-DD HH:mm:ss format.</para>
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
        /// <para>This is a device registration policy</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The list of limit details for the device registration policy.</para>
        /// </summary>
        [NameInMap("LimitDetail")]
        [Validation(Required=false)]
        public List<GetRegistrationPolicyResponseBodyLimitDetail> LimitDetail { get; set; }
        public class GetRegistrationPolicyResponseBodyLimitDetail : TeaModel {
            /// <summary>
            /// <para>The device ownership. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Company</b>: Corporate device.</description></item>
            /// <item><description><b>Personal</b>: Personal device.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Personal</para>
            /// </summary>
            [NameInMap("DeviceBelong")]
            [Validation(Required=false)]
            public string DeviceBelong { get; set; }

            /// <summary>
            /// <para>The limit on the number of device registrations.</para>
            /// </summary>
            [NameInMap("LimitCount")]
            [Validation(Required=false)]
            public GetRegistrationPolicyResponseBodyLimitDetailLimitCount LimitCount { get; set; }
            public class GetRegistrationPolicyResponseBodyLimitDetailLimitCount : TeaModel {
                /// <summary>
                /// <para>The total limit on the number of device registrations. This field is valid only when the type of device registration limit is <b>LimitAll</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("All")]
                [Validation(Required=false)]
                public int? All { get; set; }

                /// <summary>
                /// <para>The limit on the number of mobile logons for device registration. This field is valid only when the type of device registration limit is <b>LimitDiff</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Mobile")]
                [Validation(Required=false)]
                public int? Mobile { get; set; }

                /// <summary>
                /// <para>The limit on the number of PC logons for device registration. This field is valid only when the type of device registration limit is <b>LimitDiff</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("PC")]
                [Validation(Required=false)]
                public int? PC { get; set; }

            }

            /// <summary>
            /// <para>The type of device registration limit. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unlimited</b>: Unlimited.</description></item>
            /// <item><description><b>LimitAll</b>: Limited by total count.</description></item>
            /// <item><description><b>LimitDiff</b>: Limited by endpoint category.</description></item>
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
        /// <item><description><b>UserGroupAll</b>: All users.</description></item>
        /// <item><description><b>UserGroupNormal</b>: Specific user groups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The policy name of the device registration policy.</para>
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
        /// <para>The policy priority of the device registration policy. A value of 0 indicates the highest priority, and a value of 99 indicates the lowest priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IDs of the user groups associated with the device registration policy. This field has a value only when the target type for policy matching is <b>UserGroupNormal</b>.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of whitelisted users for the device registration policy.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
