// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateRegistrationPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The device registration policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public UpdateRegistrationPolicyResponseBodyPolicy Policy { get; set; }
        public class UpdateRegistrationPolicyResponseBodyPolicy : TeaModel {
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
            /// <para>这是一条设备注册策略</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of limit details for the device registration policy.</para>
            /// </summary>
            [NameInMap("LimitDetail")]
            [Validation(Required=false)]
            public List<UpdateRegistrationPolicyResponseBodyPolicyLimitDetail> LimitDetail { get; set; }
            public class UpdateRegistrationPolicyResponseBodyPolicyLimitDetail : TeaModel {
                /// <summary>
                /// <para>The owner of the device. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Company</b>: Corporate device.</para>
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
                /// <para>The registration limit count.</para>
                /// </summary>
                [NameInMap("LimitCount")]
                [Validation(Required=false)]
                public UpdateRegistrationPolicyResponseBodyPolicyLimitDetailLimitCount LimitCount { get; set; }
                public class UpdateRegistrationPolicyResponseBodyPolicyLimitDetailLimitCount : TeaModel {
                    /// <summary>
                    /// <para>The total number of devices that can be registered. This parameter is valid only when LimitType is set to <b>LimitAll</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("All")]
                    [Validation(Required=false)]
                    public int? All { get; set; }

                    /// <summary>
                    /// <para>The number of mobile devices that can be registered. This parameter is valid only when LimitType is set to <b>LimitDiff</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Mobile")]
                    [Validation(Required=false)]
                    public int? Mobile { get; set; }

                    /// <summary>
                    /// <para>The number of PCs that can be registered. This parameter is valid only when LimitType is set to <b>LimitDiff</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("PC")]
                    [Validation(Required=false)]
                    public int? PC { get; set; }

                }

                /// <summary>
                /// <para>The registration limit type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Unlimited</b>: No limit.</para>
                /// </description></item>
                /// <item><description><para><b>LimitAll</b>: Limits the total number of devices.</para>
                /// </description></item>
                /// <item><description><para><b>LimitDiff</b>: Limits devices by terminal type.</para>
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
            /// <para>The matching target type of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>UserGroupAll</b>: Associates with all users.</para>
            /// </description></item>
            /// <item><description><para><b>UserGroupNormal</b>: Associates with specific user groups.</para>
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
            /// <para>设备注册策略ID</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The priority of the device registration policy. A smaller value indicates a higher priority. The value 0 indicates the highest priority, and 99 indicates the lowest priority.</para>
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
            /// <item><description><para><b>Enabled</b></para>
            /// </description></item>
            /// <item><description><para><b>Disabled</b></para>
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
            /// <para>The collection of user group IDs for the device registration policy. This field has a value when the policy target type is <b>UserGroupNormal</b>.</para>
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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>27064ECA-0936-59F3-8A98-EC821E5BD08F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
