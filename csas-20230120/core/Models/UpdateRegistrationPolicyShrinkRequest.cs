// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateRegistrationPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The registration limit for corporate devices.</para>
        /// </summary>
        [NameInMap("CompanyLimitCount")]
        [Validation(Required=false)]
        public string CompanyLimitCountShrink { get; set; }

        /// <summary>
        /// <para>The registration limit type for corporate devices. Valid values:</para>
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
        [NameInMap("CompanyLimitType")]
        [Validation(Required=false)]
        public string CompanyLimitType { get; set; }

        /// <summary>
        /// <para>The description of the device registration policy. The description can be 1 to 128 characters long and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条设备注册策略</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The name of the device registration policy. The name must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>registration_policy_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The registration limit for personal devices.</para>
        /// </summary>
        [NameInMap("PersonalLimitCount")]
        [Validation(Required=false)]
        public string PersonalLimitCountShrink { get; set; }

        /// <summary>
        /// <para>The registration limit type for personal devices. Valid values:</para>
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
        /// <para>LimitDiff</para>
        /// </summary>
        [NameInMap("PersonalLimitType")]
        [Validation(Required=false)]
        public string PersonalLimitType { get; set; }

        /// <summary>
        /// <para>The ID of the device registration policy. You can obtain the ID by calling one of the following operations:</para>
        /// <list type="bullet">
        /// <item><description><para><a href="~~ListRegistrationPolicies~~">ListRegistrationPolicies</a></para>
        /// </description></item>
        /// <item><description><para><a href="~~GetRegistrationPolicy~~">GetRegistrationPolicy</a></para>
        /// </description></item>
        /// <item><description><para><a href="~~CreateRegistrationPolicy~~">CreateRegistrationPolicy</a></para>
        /// </description></item>
        /// <item><description><para><a href="~~UpdateRegistrationPolicy~~">UpdateRegistrationPolicy</a></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reg-policy-63b2f1844b86****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The priority of the device registration policy. A smaller value indicates a higher priority. The value 0 indicates the highest priority, and 99 indicates the lowest priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public long? Priority { get; set; }

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
        /// <para>The IDs of user groups. This parameter is required when MatchMode is set to <b>UserGroupNormal</b>. A policy can be associated with up to 100 user groups.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of whitelisted users for the device registration policy. You can add up to 1,000 usernames.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
