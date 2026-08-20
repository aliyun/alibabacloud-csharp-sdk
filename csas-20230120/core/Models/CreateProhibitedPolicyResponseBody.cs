// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class CreateProhibitedPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the software prohibition policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public CreateProhibitedPolicyResponseBodyPolicy Policy { get; set; }
        public class CreateProhibitedPolicyResponseBodyPolicy : TeaModel {
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
            public bool? AllowReport { get; set; }

            /// <summary>
            /// <para>The time when the software prohibition policy was created, in the yyyy-MM-dd HH:mm:ss format. The time is displayed in UTC+8.</para>
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
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the policy is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled. The policy is delivered to the endpoint and takes effect.</description></item>
            /// <item><description><b>false</b>: Disabled. The policy retains its configuration but is not delivered to the endpoint.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Specifies whether to forcibly terminate running software processes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The terminal immediately terminates the running process of the software when the policy is hit.</description></item>
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
            /// <para>The scope of the policy. Valid values:</para>
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
            /// <para>The Policy Name of the software disable policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>autotest_846acf98</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object type of the controlled target. Valid values:</para>
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
            /// <para>pid-dcbfd33cb004****</para>
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// <para>The action to take. Valid values:</para>
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
            /// <para>The Chinese prompt content displayed in the pop-up window on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("PromptCh")]
            [Validation(Required=false)]
            public string PromptCh { get; set; }

            /// <summary>
            /// <para>The English prompt content displayed in the pop-up window on the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L0 auto test prompt</para>
            /// </summary>
            [NameInMap("PromptEn")]
            [Validation(Required=false)]
            public string PromptEn { get; set; }

            /// <summary>
            /// <para>The collection of banned software directly controlled by this policy.</para>
            /// </summary>
            [NameInMap("SoftwareIds")]
            [Validation(Required=false)]
            public List<CreateProhibitedPolicyResponseBodyPolicySoftwareIds> SoftwareIds { get; set; }
            public class CreateProhibitedPolicyResponseBodyPolicySoftwareIds : TeaModel {
                /// <summary>
                /// <para>Indicates whether the banned software is a system built-in banned software. Valid values:</para>
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
                /// <para>swb-9a0bfde19662****</para>
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
