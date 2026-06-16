// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListAuthorizationRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of authorization rules.</para>
        /// </summary>
        [NameInMap("AuthorizationRules")]
        [Validation(Required=false)]
        public List<ListAuthorizationRulesResponseBodyAuthorizationRules> AuthorizationRules { get; set; }
        public class ListAuthorizationRulesResponseBodyAuthorizationRules : TeaModel {
            /// <summary>
            /// <para>The scope of resources to authorize. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>global: global resources in the project</para>
            /// </description></item>
            /// <item><description><para>custom: resources in a specific project</para>
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
            /// <para>The type of authorization rule creation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>system_init: created by the system</para>
            /// </description></item>
            /// <item><description><para>user_custom: created by a user</para>
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
            /// <para>The ID of the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arrule_01kf143ug06fg7m9f43u7vahxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationRuleId")]
            [Validation(Required=false)]
            public string AuthorizationRuleId { get; set; }

            /// <summary>
            /// <para>The name of the authorization rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("AuthorizationRuleName")]
            [Validation(Required=false)]
            public string AuthorizationRuleName { get; set; }

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
            /// <para>The scope of subjects for the authorization rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>shared: applies to all subjects, such as accounts and applications</para>
            /// </description></item>
            /// <item><description><para>exclusive: applies only to a specific subject</para>
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
            /// <para>The type of subject associated with the authorization rule. This parameter takes effect only when AuthorizationRuleSubjectScope is exclusive. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>application</para>
            /// </description></item>
            /// <item><description><para>user</para>
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
            /// <para>The time when the authorization rule was created, in Unix timestamp format. Unit: milliseconds.</para>
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
            /// <para>The ID of the instance.</para>
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
            /// <para>The status of the authorization rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled</para>
            /// </description></item>
            /// <item><description><para>disabled</para>
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
            /// <para>The time when the authorization rule was last updated, in Unix timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token returned by this call. Use it in the next call to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
