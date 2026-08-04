// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateRegistrationPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The restriction count for company devices.</para>
        /// </summary>
        [NameInMap("CompanyLimitCount")]
        [Validation(Required=false)]
        public string CompanyLimitCountShrink { get; set; }

        /// <summary>
        /// <para>The restriction type for company devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Unlimited</b>: No restrictions.</para>
        /// </description></item>
        /// <item><description><para><b>LimitAll</b>: Limit by total count.</para>
        /// </description></item>
        /// <item><description><para><b>LimitDiff</b>: Limit by device category.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LimitAll</para>
        /// </summary>
        [NameInMap("CompanyLimitType")]
        [Validation(Required=false)]
        public string CompanyLimitType { get; set; }

        /// <summary>
        /// <para>A description of the device registration policy. The description must be 1 to 128 characters in length. It can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一条设备注册策略</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The target type for policy matching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>UserGroupAll</b>: Apply to all users.</para>
        /// </description></item>
        /// <item><description><para><b>UserGroupNormal</b>: Apply to selected user groups.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The name of the device registration policy. The name must be 1 to 128 characters in length. It can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registration_policy_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The restriction count for personal devices.</para>
        /// </summary>
        [NameInMap("PersonalLimitCount")]
        [Validation(Required=false)]
        public string PersonalLimitCountShrink { get; set; }

        /// <summary>
        /// <para>The restriction type for personal devices. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Unlimited</b>: No restrictions.</para>
        /// </description></item>
        /// <item><description><para><b>LimitAll</b>: Limit by total count.</para>
        /// </description></item>
        /// <item><description><para><b>LimitDiff</b>: Limit by device category.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LimitDiff</para>
        /// </summary>
        [NameInMap("PersonalLimitType")]
        [Validation(Required=false)]
        public string PersonalLimitType { get; set; }

        /// <summary>
        /// <para>The priority of the device registration policy. A value of 0 indicates the highest priority. A value of 99 indicates the lowest priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The IDs of user groups to which the device registration policy applies. Required if MatchMode is set to <b>UserGroupNormal</b>. A maximum of 100 user groups can be specified per policy.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of usernames in the whitelist for the device registration policy. You can specify up to 1,000 usernames.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
