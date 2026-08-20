// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateProhibitedPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether end users are allowed to submit a report request for this policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Reporting is allowed. The pop-up window on the endpoint provides a reporting entry.</description></item>
        /// <item><description><b>false</b>: Reporting is not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowReport")]
        [Validation(Required=false)]
        public string AllowReport { get; set; }

        /// <summary>
        /// <para>The description of the software ban policy. The description can be up to 128 characters in length and can be left empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project name pass the check</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the policy is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled. The policy is delivered to the endpoint and takes effect.</description></item>
        /// <item><description><b>false</b>: Disabled. The policy configuration is retained but not delivered to the endpoint.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully terminate running software processes. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceKill")]
        [Validation(Required=false)]
        public bool? ForceKill { get; set; }

        /// <summary>
        /// <para>The Chinese text of the primary button in the pop-up window on the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Submit Filing</para>
        /// </summary>
        [NameInMap("MainButtonTextCh")]
        [Validation(Required=false)]
        public string MainButtonTextCh { get; set; }

        /// <summary>
        /// <para>The English text of the primary button in the pop-up window on the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Report</para>
        /// </summary>
        [NameInMap("MainButtonTextEn")]
        [Validation(Required=false)]
        public string MainButtonTextEn { get; set; }

        /// <summary>
        /// <para>The scope in which the policy takes effect. Valid values:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserGroupAll</para>
        /// </summary>
        [NameInMap("MatchMode")]
        [Validation(Required=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// <para>The Chinese text of the secondary button in the pop-up window on the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Got It</para>
        /// </summary>
        [NameInMap("MinorButtonTextCh")]
        [Validation(Required=false)]
        public string MinorButtonTextCh { get; set; }

        /// <summary>
        /// <para>The English text of the secondary button in the pop-up window on the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I know</para>
        /// </summary>
        [NameInMap("MinorButtonTextEn")]
        [Validation(Required=false)]
        public string MinorButtonTextEn { get; set; }

        /// <summary>
        /// <para>Policy Name of the software ban policy. Policy Name must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest_a0344d22</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The object type. Valid values:</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>App</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

        /// <summary>
        /// <para>The action to take. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Ban</b>: Blocks the software from running and displays a pop-up notification to the end user.</description></item>
        /// <item><description><b>BanSilent</b>: Blocks the software from running without notifying the end user (silent blocking).</description></item>
        /// <item><description><b>Warn</b>: Displays a pop-up notification to the end user without blocking the software from running.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Warn</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

        /// <summary>
        /// <para>The policy priority. Valid values: 0 to 99. A smaller value indicates a higher priority.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The Chinese prompt content displayed in the pop-up window on the endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PromptCh")]
        [Validation(Required=false)]
        public string PromptCh { get; set; }

        /// <summary>
        /// <para>The English prompt content displayed in the pop-up window on the endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto test prohibition prompt</para>
        /// </summary>
        [NameInMap("PromptEn")]
        [Validation(Required=false)]
        public string PromptEn { get; set; }

        /// <summary>
        /// <para>The collection of banned software directly controlled by this policy.</para>
        /// </summary>
        [NameInMap("SoftwareIds")]
        [Validation(Required=false)]
        public List<CreateProhibitedPolicyRequestSoftwareIds> SoftwareIds { get; set; }
        public class CreateProhibitedPolicyRequestSoftwareIds : TeaModel {
            /// <summary>
            /// <para>Specifies whether the blocked software is a built-in blocked software entry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: A built-in blocked software entry that is shared across all Alibaba Cloud accounts. Built-in entries cannot be modified or deleted.</description></item>
            /// <item><description><b>false</b>: A custom blocked software entry under the current Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software. You can obtain the value from the following operations:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~ListProhibitedSoftware~~">ListProhibitedSoftware</a>: Lists prohibited software.</description></item>
            /// <item><description><a href="~~CreateProhibitedSoftware~~">CreateProhibitedSoftware</a>: Creates custom prohibited software.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>swb-df1fa76d889b****</para>
            /// </summary>
            [NameInMap("SoftwareId")]
            [Validation(Required=false)]
            public string SoftwareId { get; set; }

        }

        /// <summary>
        /// <para>The collection of banned software tag IDs controlled by this policy.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// <para>The Chinese title of the pop-up window on the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Software Ban Reminder</para>
        /// </summary>
        [NameInMap("TitleCh")]
        [Validation(Required=false)]
        public string TitleCh { get; set; }

        /// <summary>
        /// <para>The English title of the pop-up window on the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Software Blocked</para>
        /// </summary>
        [NameInMap("TitleEn")]
        [Validation(Required=false)]
        public string TitleEn { get; set; }

        /// <summary>
        /// <para>The collection of user group IDs for which the policy takes effect.</para>
        /// </summary>
        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public List<string> UserGroupIds { get; set; }

        /// <summary>
        /// <para>The list of exempted usernames.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public List<string> Whitelist { get; set; }

    }

}
