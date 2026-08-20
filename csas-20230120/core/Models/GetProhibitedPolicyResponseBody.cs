// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetProhibitedPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the software prohibition policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetProhibitedPolicyResponseBodyPolicy Policy { get; set; }
        public class GetProhibitedPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>Indicates whether end users are allowed to submit a filing request for this policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Filing is allowed. The terminal pop-up window provides a filing entry.</description></item>
            /// <item><description><b>false</b>: Filing is not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowReport")]
            [Validation(Required=false)]
            public bool? AllowReport { get; set; }

            /// <summary>
            /// <para>The creation time of the software prohibition policy, in the yyyy-MM-dd HH:mm:ss format using the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-29 11:26:02</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the software prohibition policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled. The policy is delivered to terminals and takes effect.</description></item>
            /// <item><description><b>false</b>: Disabled. The policy configuration is retained but not delivered to terminals.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Indicates whether to forcibly terminate running software processes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The terminal immediately terminates the running processes of the software when the policy is triggered.</description></item>
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
            /// <para>The Chinese text of the primary button in the terminal pop-up window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>前往报备</para>
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
            /// <para>The policy matching target type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: Associates with all users.</description></item>
            /// <item><description><b>UserGroupNormal</b>: Associates with specific user groups.</description></item>
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
            /// <para>我知道了</para>
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
            /// <para>The name of the software prohibition policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolicyC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object type of the controlled target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>App</b>: Controls by prohibited software. The controlled objects are specified by SoftwareIds.</description></item>
            /// <item><description><b>Tag</b>: Controls by prohibited software labels. The controlled objects are specified by TagIds. All prohibited software under the labels is controlled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>App</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The software prohibition policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pid-36ee4a5869f3****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The action type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ban</b>: Blocks the software from running and displays a pop-up notification to the end user.</description></item>
            /// <item><description><b>BanSilent</b>: Blocks the software from running without notifying the end user (silent blocking).</description></item>
            /// <item><description><b>Warn</b>: Displays a pop-up notification to the end user without blocking the software from running.</description></item>
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
            /// <para>The Chinese prompt content displayed in the terminal pop-up window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This software has been blocked by the enterprise security policy. To use it, submit an approval request</para>
            /// </summary>
            [NameInMap("PromptCh")]
            [Validation(Required=false)]
            public string PromptCh { get; set; }

            /// <summary>
            /// <para>The English prompt content displayed in the terminal pop-up window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This software is blocked by your enterprise security policy.</para>
            /// </summary>
            [NameInMap("PromptEn")]
            [Validation(Required=false)]
            public string PromptEn { get; set; }

            /// <summary>
            /// <para>The approval process ID bound to this policy. An empty string is returned if no approval process is bound. In this case, filing requests submitted by end users are approved by the IT administrator as a fallback. Approval processes are bound by using <a href="~~AttachPolicy2ApprovalProcess~~">AttachPolicy2ApprovalProcess</a> and unbound by using <a href="~~DetachPolicy2ApprovalProcess~~">DetachPolicy2ApprovalProcess</a>. You can obtain this value from the following operation:</para>
            /// <list type="bullet">
            /// <item><description><a href="~~ListApprovalProcesses~~">ListApprovalProcesses</a>: Lists approval processes.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>approval-process-6c2f8a1b7d3e****</para>
            /// </summary>
            [NameInMap("ReportProcessId")]
            [Validation(Required=false)]
            public string ReportProcessId { get; set; }

            /// <summary>
            /// <para>The collection of prohibited software directly controlled by this policy.</para>
            /// </summary>
            [NameInMap("SoftwareIds")]
            [Validation(Required=false)]
            public List<GetProhibitedPolicyResponseBodyPolicySoftwareIds> SoftwareIds { get; set; }
            public class GetProhibitedPolicyResponseBodyPolicySoftwareIds : TeaModel {
                /// <summary>
                /// <para>Indicates whether the prohibited software is a system built-in entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: A system built-in prohibited software entry shared by all Alibaba Cloud accounts. Modification and deletion are not supported.</description></item>
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
                /// <para>The prohibited software ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swb-050216aafaae****</para>
                /// </summary>
                [NameInMap("SoftwareId")]
                [Validation(Required=false)]
                public string SoftwareId { get; set; }

            }

            /// <summary>
            /// <para>The collection of prohibited software label IDs controlled by this policy.</para>
            /// </summary>
            [NameInMap("TagIds")]
            [Validation(Required=false)]
            public List<string> TagIds { get; set; }

            /// <summary>
            /// <para>The Chinese title of the terminal pop-up window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>软件禁用提醒</para>
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
            /// <para>The collection of user group IDs to which this policy applies.</para>
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
        /// <para>E966413B-7538-5332-99B4-C3DA016B9453</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
