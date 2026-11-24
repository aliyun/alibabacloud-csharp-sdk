// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetProhibitedPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the prohibited software policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public GetProhibitedPolicyResponseBodyPolicy Policy { get; set; }
        public class GetProhibitedPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// <para>Indicates whether terminal users are allowed to submit applications for this policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Applications are allowed. The terminal pop-up window provides an entry for submitting applications.</description></item>
            /// <item><description><b>false</b>: Applications are not allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowReport")]
            [Validation(Required=false)]
            public bool? AllowReport { get; set; }

            /// <summary>
            /// <para>The time when the prohibited software policy was created. The time is displayed in the yyyy-MM-dd HH:mm:ss format and uses the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-29 11:26:02</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the prohibited software policy.</para>
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
            /// <item><description><b>true</b>: The policy is enabled, delivered to terminals, and takes effect.</description></item>
            /// <item><description><b>false</b>: The policy is disabled. The configuration is retained but not delivered to terminals.</description></item>
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
            /// <para>The target matching mode of the policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserGroupAll</b>: Applies to all users.</description></item>
            /// <item><description><b>UserGroupNormal</b>: Applies to specific user groups.</description></item>
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
            /// <para>The name of the prohibited software policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PolicyC</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The managed object type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>App</b>: Managed by prohibited software. The managed objects are specified by SoftwareIds.</description></item>
            /// <item><description><b>Tag</b>: Managed by prohibited software tag. The managed objects are specified by TagIds, and all prohibited software under the tag is managed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>App</para>
            /// </summary>
            [NameInMap("ObjectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

            /// <summary>
            /// <para>The ID of the prohibited software policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pid-36ee4a5869f3****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The enforcement action. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ban</b>: Blocks the software from running and displays a pop-up window to notify the terminal user.</description></item>
            /// <item><description><b>BanSilent</b>: Blocks the software from running silently without notifying the terminal user.</description></item>
            /// <item><description><b>Warn</b>: Displays a pop-up window to notify the terminal user without blocking the software from running.</description></item>
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
            /// <para>该软件已被企业安全策略禁止运行，如需使用请提交报备申请</para>
            /// </summary>
            [NameInMap("PromptCh")]
            [Validation(Required=false)]
            public string PromptCh { get; set; }

            /// <summary>
            /// <para>The English prompt content in the terminal pop-up window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This software is blocked by your enterprise security policy.</para>
            /// </summary>
            [NameInMap("PromptEn")]
            [Validation(Required=false)]
            public string PromptEn { get; set; }

            /// <summary>
            /// <para>The ID of the approval process bound to the policy. If no approval process is bound, an empty string is returned, and applications submitted by terminal users are approved by the IT administrator. You can bind an approval process by calling <a href="~~AttachPolicy2ApprovalProcess~~">AttachPolicy2ApprovalProcess</a> and unbind it by calling <a href="~~DetachPolicy2ApprovalProcess~~">DetachPolicy2ApprovalProcess</a>. You can obtain the value from the following operations:</para>
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
            /// <para>The list of prohibited software directly managed by the policy.</para>
            /// </summary>
            [NameInMap("SoftwareIds")]
            [Validation(Required=false)]
            public List<GetProhibitedPolicyResponseBodyPolicySoftwareIds> SoftwareIds { get; set; }
            public class GetProhibitedPolicyResponseBodyPolicySoftwareIds : TeaModel {
                /// <summary>
                /// <para>Indicates whether the prohibited software is a built-in prohibited software. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The software is a built-in prohibited software that is shared by all Alibaba Cloud accounts and cannot be modified or deleted.</description></item>
                /// <item><description><b>false</b>: The software is a custom prohibited software under the current Alibaba Cloud account.</description></item>
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
                /// <para>swb-050216aafaae****</para>
                /// </summary>
                [NameInMap("SoftwareId")]
                [Validation(Required=false)]
                public string SoftwareId { get; set; }

            }

            /// <summary>
            /// <para>The list of prohibited software tag IDs managed by the policy.</para>
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
            /// <para>The list of user group IDs to which the policy applies.</para>
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
