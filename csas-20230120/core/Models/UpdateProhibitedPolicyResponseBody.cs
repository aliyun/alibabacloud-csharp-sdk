// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class UpdateProhibitedPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the software prohibition policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public UpdateProhibitedPolicyResponseBodyPolicy Policy { get; set; }
        public class UpdateProhibitedPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>Specifies whether endpoint users are allowed to submit a filing request for this policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Filing is allowed. A filing entry is provided in the pop-up notification on the endpoint.</description></item>
            /// <item><description><b>false</b>: Filing is not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AllowReport")]
            [Validation(Required=false)]
            public bool? AllowReport { get; set; }

            /// <summary>
            /// <para>The time when the software prohibition policy was created, in the yyyy-MM-dd HH:mm:ss format. The time is in the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-08-19 10:24:31</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the software prohibition policy.</para>
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
            /// <item><description><b>true</b>: Enabled. The policy is delivered to endpoints and takes effect.</description></item>
            /// <item><description><b>false</b>: Disabled. The policy configuration is retained but not delivered to endpoints.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly terminate running software processes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The endpoint immediately terminates the running processes of the software when the policy is triggered.</description></item>
            /// <item><description><b>false</b>: Running processes are not terminated. Only subsequent launches are blocked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ForceKill")]
            [Validation(Required=false)]
            public bool? ForceKill { get; set; }

            /// <summary>
            /// <para>The Chinese text of the primary button in the pop-up notification on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Submit Filing</para>
            /// </summary>
            [NameInMap("MainButtonTextCh")]
            [Validation(Required=false)]
            public string MainButtonTextCh { get; set; }

            /// <summary>
            /// <para>The English text of the primary button in the pop-up notification on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Report</para>
            /// </summary>
            [NameInMap("MainButtonTextEn")]
            [Validation(Required=false)]
            public string MainButtonTextEn { get; set; }

            /// <summary>
            /// <para>The scope in which the policy takes effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: Takes effect for all users under the current Alibaba Cloud account. No user group needs to be specified.</description></item>
            /// <item><description><b>UserGroupNormal</b>: Takes effect only for users in the user groups specified by UserGroupIds.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <para>The Chinese text of the secondary button in the pop-up notification on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Got It</para>
            /// </summary>
            [NameInMap("MinorButtonTextCh")]
            [Validation(Required=false)]
            public string MinorButtonTextCh { get; set; }

            /// <summary>
            /// <para>The English text of the secondary button in the pop-up notification on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>I know</para>
            /// </summary>
            [NameInMap("MinorButtonTextEn")]
            [Validation(Required=false)]
            public string MinorButtonTextEn { get; set; }

            /// <summary>
            /// <para>The name of the software prohibition policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest_c51af82d</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>App</b>: Controls by prohibited software. The controlled objects are specified by SoftwareIds.</description></item>
            /// <item><description><b>Tag</b>: Controls by prohibited software tag. The controlled objects are specified by TagIds. All prohibited software under the specified tags is controlled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>App</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The ID of the software prohibition policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pid-ef8eb37cff62****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The action to take. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ban</b>: Blocks the software from running and displays a pop-up notification on the endpoint to alert the user.</description></item>
            /// <item><description><b>BanSilent</b>: Blocks the software from running without notifying the user (silent blocking).</description></item>
            /// <item><description><b>Warn</b>: Displays a pop-up notification on the endpoint to alert the user without blocking the software from running.</description></item>
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
            /// <para>The Chinese prompt content displayed in the pop-up notification on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PromptCh")]
            [Validation(Required=false)]
            public string PromptCh { get; set; }

            /// <summary>
            /// <para>The English prompt content displayed in the pop-up notification on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>After analysis and monitoring, the software has been disabled as a security risk.</para>
            /// </summary>
            [NameInMap("PromptEn")]
            [Validation(Required=false)]
            public string PromptEn { get; set; }

            /// <summary>
            /// <para>The collection of prohibited software directly controlled by this policy.</para>
            /// </summary>
            [NameInMap("SoftwareIds")]
            [Validation(Required=false)]
            public List<UpdateProhibitedPolicyResponseBodyPolicySoftwareIds> SoftwareIds { get; set; }
            public class UpdateProhibitedPolicyResponseBodyPolicySoftwareIds : TeaModel {
                /// <summary>
                /// <para>Indicates whether the prohibited software is a system built-in entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: A system built-in prohibited software entry shared across all Alibaba Cloud accounts. It cannot be modified or deleted.</description></item>
                /// <item><description><b>false</b>: A custom prohibited software entry under the current Alibaba Cloud account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The ID of the prohibited software.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swb-f024ee962344****</para>
                /// </summary>
                [NameInMap("SoftwareId")]
                [Validation(Required=false)]
                public string SoftwareId { get; set; }

            }

            /// <summary>
            /// <para>The collection of prohibited software tag IDs controlled by this policy.</para>
            /// </summary>
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <para>The Chinese title of the pop-up notification on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Software Prohibition Reminder</para>
            /// </summary>
            [NameInMap("TitleCh")]
            [Validation(Required=false)]
            public string TitleCh { get; set; }

            /// <summary>
            /// <para>The English title of the pop-up notification on the endpoint.</para>
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

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>C4F48DD4-B70D-5342-80B9-2BF5498262FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
