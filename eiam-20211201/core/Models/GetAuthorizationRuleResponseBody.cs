// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetAuthorizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorization rule object.</para>
        /// </summary>
        [NameInMap("AuthorizationRule")]
        [Validation(Required=false)]
        public GetAuthorizationRuleResponseBodyAuthorizationRule AuthorizationRule { get; set; }
        public class GetAuthorizationRuleResponseBodyAuthorizationRule : TeaModel {
            /// <summary>
            /// <para>The authorization resource scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>custom: Resources within the specified project scope.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("AuthorizationResourceScope")]
            [Validation(Required=false)]
            public string AuthorizationResourceScope { get; set; }

            /// <summary>
            /// <para>The creation type of the authorization rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system_init: Created by the system.</description></item>
            /// <item><description>user_custom: Created by the user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("AuthorizationRuleCreationType")]
            [Validation(Required=false)]
            public string AuthorizationRuleCreationType { get; set; }

            /// <summary>
            /// <para>The authorization rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arrule_01kf143ug06fg7m9f43u7vahxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationRuleId")]
            [Validation(Required=false)]
            public string AuthorizationRuleId { get; set; }

            /// <summary>
            /// <para>The authorization rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("AuthorizationRuleName")]
            [Validation(Required=false)]
            public string AuthorizationRuleName { get; set; }

            /// <summary>
            /// <para>The scenario label of the authorization rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>privileged_cloud_account (Privileged cloud account scenario)</description></item>
            /// <item><description>asset (Asset scenario)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>privileged_cloud_account</para>
            /// </summary>
            [NameInMap("AuthorizationRuleScenarioLabel")]
            [Validation(Required=false)]
            public string AuthorizationRuleScenarioLabel { get; set; }

            /// <summary>
            /// <para>The ID of the subject associated with the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectId")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectId { get; set; }

            /// <summary>
            /// <para>The subject scope of the authorization rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>shared: Shared. A single rule can be used by multiple subjects that meet the rule constraints.</description></item>
            /// <item><description>exclusive: Exclusive. A single rule can only be used by the specified subject.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>shared</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectScope")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectScope { get; set; }

            /// <summary>
            /// <para>The subject category to which the authorization rule applies. For an exclusive rule, this field indicates the type of the specified subject. For a shared rule with a configured subject category, this field indicates the subject category that the rule allows to be associated with. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>application: Application.</description></item>
            /// <item><description>user: Account. For a shared privileged cloud account rule, this value indicates the human user category, which can be associated with accounts, user groups, and organizations.
            /// If no subject category is configured for the rule, this field may be empty. The actual subjects associated with a shared rule are determined by the subject association query results.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectType")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectType { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The ID of the project associated with the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iprj_system_default</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>The authorization rule status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: Enabled.</description></item>
            /// <item><description>disabled: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The last update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
