// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateProhibitedPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the software blocking policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public CreateProhibitedPolicyResponseBodyPolicy Policy { get; set; }
        public class CreateProhibitedPolicyResponseBodyPolicy : TeaModel {
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
            public bool? AllowReport { get; set; }

            /// <summary>
            /// <para>The time when the software blocking policy was created. The time is in the yyyy-MM-dd HH:mm:ss format and displayed in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-29 11:26:02</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the software blocking policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
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
            /// <para>The Policy Name of the software disable policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest_846acf98</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object type of the managed object. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>App</b>: Manages disable software. The managed objects are specified by SoftwareIds.</description></item>
            /// <item><description><b>Tag</b>: Manages disable software by label. The managed objects are specified by TagIds, and all disable software under the labels is managed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>App</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The ID of the software blocking policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pid-dcbfd33cb004****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The action to take. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ban</b>: blocks the software from running and displays a pop-up window on the terminal to notify the user.</description></item>
            /// <item><description><b>BanSilent</b>: blocks the software from running without notifying the user.</description></item>
            /// <item><description><b>Warn</b>: displays a pop-up window on the terminal to notify the user without blocking the software from running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Ban</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// <para>The policy priority. Valid values: 0 to 99. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The Chinese prompt content in the terminal pop-up window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PromptCh")]
            [Validation(Required=false)]
            public string PromptCh { get; set; }

            /// <summary>
            /// <para>The English prompt content in the terminal pop-up window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L0 auto test prompt</para>
            /// </summary>
            [NameInMap("PromptEn")]
            [Validation(Required=false)]
            public string PromptEn { get; set; }

            /// <summary>
            /// <para>The collection of prohibited software directly managed by the policy.</para>
            /// </summary>
            [NameInMap("SoftwareIds")]
            [Validation(Required=false)]
            public List<CreateProhibitedPolicyResponseBodyPolicySoftwareIds> SoftwareIds { get; set; }
            public class CreateProhibitedPolicyResponseBodyPolicySoftwareIds : TeaModel {
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
                /// <para>swb-9a0bfde19662****</para>
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
            /// <para>The IDs of the user groups to which the policy applies.</para>
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

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>215060E3-03D2-548D-A014-17941EA3B6C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
