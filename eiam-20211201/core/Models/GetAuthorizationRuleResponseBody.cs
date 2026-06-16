// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetAuthorizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>Authorization rule object.</para>
        /// </summary>
        [NameInMap("AuthorizationRule")]
        [Validation(Required=false)]
        public GetAuthorizationRuleResponseBodyAuthorizationRule AuthorizationRule { get; set; }
        public class GetAuthorizationRuleResponseBodyAuthorizationRule : TeaModel {
            /// <summary>
            /// <para>Authorization resource scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>global: Global resources under the project</para>
            /// </description></item>
            /// <item><description><para>custom: Resources within the specified project scope</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("AuthorizationResourceScope")]
            [Validation(Required=false)]
            public string AuthorizationResourceScope { get; set; }

            /// <summary>
            /// <para>Authorization rule creation type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>system_init: System created</para>
            /// </description></item>
            /// <item><description><para>user_custom: User created</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("AuthorizationRuleCreationType")]
            [Validation(Required=false)]
            public string AuthorizationRuleCreationType { get; set; }

            /// <summary>
            /// <para>Authorization rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arrule_01kf143ug06fg7m9f43u7vahxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationRuleId")]
            [Validation(Required=false)]
            public string AuthorizationRuleId { get; set; }

            /// <summary>
            /// <para>Authorization rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("AuthorizationRuleName")]
            [Validation(Required=false)]
            public string AuthorizationRuleName { get; set; }

            /// <summary>
            /// <para>Subject ID associated with the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_d6sbsuumeta4h66ec3il7yxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectId")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectId { get; set; }

            /// <summary>
            /// <para>Authorization rule subject scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>shared: Shared type, supports all subjects, including accounts and applications</para>
            /// </description></item>
            /// <item><description><para>exclusive: Exclusive type</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>shared</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectScope")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectScope { get; set; }

            /// <summary>
            /// <para>Subject type associated with the authorization rule. Valid when the authorization rule subject scope is exclusive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>application: Application</para>
            /// </description></item>
            /// <item><description><para>user: Account</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectType")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectType { get; set; }

            /// <summary>
            /// <para>Creation time, in UNIX timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>Authorization rule description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Project ID associated with the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iprj_system_default</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>Authorization rule status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: Enabled</para>
            /// </description></item>
            /// <item><description><para>disabled: Disabled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Last update time, in UNIX timestamp format, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
