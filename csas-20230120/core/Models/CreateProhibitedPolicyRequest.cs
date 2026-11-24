// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateProhibitedPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to allow terminal users to submit an exception request for the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Exception requests are allowed. The terminal pop-up window provides an entry for the request.</description></item>
        /// <item><description><b>false</b>: Exception requests are not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AllowReport")]
        [Validation(Required=false)]
        public string AllowReport { get; set; }

        /// <summary>
        /// <para>The description of the prohibited software policy. The description can be up to 128 characters in length and can be empty.</para>
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
        /// <item><description><b>true</b>: The policy is enabled, delivered to terminals, and takes effect.</description></item>
        /// <item><description><b>false</b>: The policy is disabled. The configuration is retained but not delivered to terminals.</description></item>
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
        /// <para>Specifies whether to forcibly terminate running processes of the software. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The terminal immediately terminates the running processes of the software when the policy is matched.</description></item>
        /// <item><description><b>false</b>: The terminal does not terminate running processes but only prevents subsequent startups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceKill")]
        [Validation(Required=false)]
        public bool? ForceKill { get; set; }

        /// <summary>
        /// <para>The Chinese text of the primary button in the terminal pop-up window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apply for exemption</para>
        /// </summary>
        [NameInMap("MainButtonTextCh")]
        [Validation(Required=false)]
        public string MainButtonTextCh { get; set; }

        /// <summary>
        /// <para>The English text of the primary button in the terminal pop-up window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Report</para>
        /// </summary>
        [NameInMap("MainButtonTextEn")]
        [Validation(Required=false)]
        public string MainButtonTextEn { get; set; }

        /// <summary>
        /// <para>The effective scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>UserGroupAll</b>: The policy takes effect for all users under the current Alibaba Cloud account. You do not need to specify user groups.</description></item>
        /// <item><description><b>UserGroupNormal</b>: The policy takes effect only for users in the user groups specified by UserGroupIds.</description></item>
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
        /// <para>The Chinese text of the secondary button in the terminal pop-up window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Got it</para>
        /// </summary>
        [NameInMap("MinorButtonTextCh")]
        [Validation(Required=false)]
        public string MinorButtonTextCh { get; set; }

        /// <summary>
        /// <para>The English text of the secondary button in the terminal pop-up window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I know</para>
        /// </summary>
        [NameInMap("MinorButtonTextEn")]
        [Validation(Required=false)]
        public string MinorButtonTextEn { get; set; }

        /// <summary>
        /// <para>Policy Name of the prohibited software policy. Policy Name must be 1 to 128 characters in length and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-). Spaces are not supported.</para>
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
        /// <list type="bullet">
        /// <item><description><b>App</b>: controls disable software. The managed objects are specified by SoftwareIds.</description></item>
        /// <item><description><b>Tag</b>: controls disable software labels. The managed objects are specified by TagIds. All disable software within the labels is managed.</description></item>
        /// </list>
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
        /// <item><description><b>Ban</b>: blocks the software from running and displays a pop-up window on the terminal to notify the user.</description></item>
        /// <item><description><b>BanSilent</b>: blocks the software from running without notifying the user.</description></item>
        /// <item><description><b>Warn</b>: displays a pop-up window on the terminal to notify the user without blocking the software from running.</description></item>
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
        /// <para>The Chinese prompt content in the terminal pop-up window.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("PromptCh")]
        [Validation(Required=false)]
        public string PromptCh { get; set; }

        /// <summary>
        /// <para>The English prompt content in the terminal pop-up window.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto test prohibition prompt</para>
        /// </summary>
        [NameInMap("PromptEn")]
        [Validation(Required=false)]
        public string PromptEn { get; set; }

        /// <summary>
        /// <para>The collection of prohibited software directly managed by the policy.</para>
        /// </summary>
        [NameInMap("SoftwareIds")]
        [Validation(Required=false)]
        public List<CreateProhibitedPolicyRequestSoftwareIds> SoftwareIds { get; set; }
        public class CreateProhibitedPolicyRequestSoftwareIds : TeaModel {
            /// <summary>
            /// <para>Specifies whether the prohibited software is built-in. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The software is built-in, shared by all Alibaba Cloud accounts, and cannot be modified or deleted.</description></item>
            /// <item><description><b>false</b>: The software is custom prohibited software under the current Alibaba Cloud account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software. You can obtain the value from the following sources:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~ListProhibitedSoftware~~">ListProhibitedSoftware</a>: queries prohibited software in batches.</description></item>
            /// <item><description><a href="~~CreateProhibitedSoftware~~">CreateProhibitedSoftware</a>: creates custom prohibited software.</description></item>
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
        /// <para>The collection of prohibited software tag IDs managed by the policy.</para>
        /// </summary>
        [NameInMap("TagIds")]
        [Validation(Required=false)]
        public List<string> TagIds { get; set; }

        /// <summary>
        /// <para>The Chinese title of the terminal pop-up window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prohibited software reminder</para>
        /// </summary>
        [NameInMap("TitleCh")]
        [Validation(Required=false)]
        public string TitleCh { get; set; }

        /// <summary>
        /// <para>The English title of the terminal pop-up window.</para>
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
