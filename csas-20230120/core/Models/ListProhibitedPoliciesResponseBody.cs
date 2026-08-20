// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListProhibitedPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of software prohibition policies, sorted by priority from highest to lowest.</para>
        /// </summary>
        [NameInMap("Policies")]
        [Validation(Required=false)]
        public List<ListProhibitedPoliciesResponseBodyPolicies> Policies { get; set; }
        public class ListProhibitedPoliciesResponseBodyPolicies : TeaModel {
            /// <summary>
            /// <para>Indicates whether endpoint users are allowed to submit a filing request for this policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Filing is allowed. The endpoint pop-up notification provides a filing entry.</description></item>
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
            /// <para>The creation time of the software prohibition policy, in the format of yyyy-MM-dd HH:mm:ss, using the UTC+8 time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-05-16 17:18:46</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the software prohibition policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <item><description><b>true</b>: The endpoint immediately terminates the running processes of the software when the policy is matched.</description></item>
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
            /// <para>The Chinese text of the primary button in the endpoint pop-up notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>去报备</para>
            /// </summary>
            [NameInMap("MainButtonTextCh")]
            [Validation(Required=false)]
            public string MainButtonTextCh { get; set; }

            /// <summary>
            /// <para>The English text of the primary button in the endpoint pop-up notification.</para>
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
            /// <item><description><b>UserGroupAll</b>: Associated with all users.</description></item>
            /// <item><description><b>UserGroupNormal</b>: Associated with specific user groups.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UserGroupNormal</para>
            /// </summary>
            [NameInMap("MatchMode")]
            [Validation(Required=false)]
            public string MatchMode { get; set; }

            /// <summary>
            /// <para>The Chinese text of the secondary button in the endpoint pop-up notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>我知道了</para>
            /// </summary>
            [NameInMap("MinorButtonTextCh")]
            [Validation(Required=false)]
            public string MinorButtonTextCh { get; set; }

            /// <summary>
            /// <para>The English text of the secondary button in the endpoint pop-up notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Got it</para>
            /// </summary>
            [NameInMap("MinorButtonTextEn")]
            [Validation(Required=false)]
            public string MinorButtonTextEn { get; set; }

            /// <summary>
            /// <para>The name of the software prohibition policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object type of the controlled target. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>App</b>: Controls by prohibited software. The controlled objects are specified by SoftwareIds.</description></item>
            /// <item><description><b>Tag</b>: Controls by prohibited software tag. The controlled objects are specified by TagIds. All prohibited software under the tag is controlled.</description></item>
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
            /// <para>pid-42f19f1b6a3e****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The action to take. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ban</b>: Blocks the software from running and displays a pop-up notification on the endpoint to alert the user.</description></item>
            /// <item><description><b>BanSilent</b>: Blocks the software from running without notifying the user. The blocking is silent.</description></item>
            /// <item><description><b>Warn</b>: Only displays a pop-up notification on the endpoint to alert the user without blocking the software from running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Warn</para>
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
            /// <para>The Chinese prompt content displayed in the endpoint pop-up notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This software has been blocked by the enterprise security policy. To use it, submit an approval request</para>
            /// </summary>
            [NameInMap("PromptCh")]
            [Validation(Required=false)]
            public string PromptCh { get; set; }

            /// <summary>
            /// <para>The English prompt content displayed in the endpoint pop-up notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This software is blocked by your enterprise security policy.</para>
            /// </summary>
            [NameInMap("PromptEn")]
            [Validation(Required=false)]
            public string PromptEn { get; set; }

            /// <summary>
            /// <para>The collection of prohibited software directly controlled by this policy.</para>
            /// </summary>
            [NameInMap("SoftwareIds")]
            [Validation(Required=false)]
            public List<ListProhibitedPoliciesResponseBodyPoliciesSoftwareIds> SoftwareIds { get; set; }
            public class ListProhibitedPoliciesResponseBodyPoliciesSoftwareIds : TeaModel {
                /// <summary>
                /// <para>Indicates whether the prohibited software is a system built-in entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: A system built-in prohibited software entry shared by all Alibaba Cloud accounts. Modification and deletion are not supported.</description></item>
                /// <item><description><b>false</b>: Custom prohibited software under the current Alibaba Cloud account.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <para>The prohibited software ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>swb-9a0bfde19662****</para>
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
            /// <para>The Chinese title of the endpoint pop-up notification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>软件禁用提醒</para>
            /// </summary>
            [NameInMap("TitleCh")]
            [Validation(Required=false)]
            public string TitleCh { get; set; }

            /// <summary>
            /// <para>The English title of the endpoint pop-up notification.</para>
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
        /// <para>03362EE0-C6F7-51ED-91FF-0BFFA5A2AB67</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of software prohibition policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
