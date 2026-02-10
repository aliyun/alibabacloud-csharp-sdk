// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetAuthorizationRuleResponseBody : TeaModel {
        [NameInMap("AuthorizationRule")]
        [Validation(Required=false)]
        public GetAuthorizationRuleResponseBodyAuthorizationRule AuthorizationRule { get; set; }
        public class GetAuthorizationRuleResponseBodyAuthorizationRule : TeaModel {
            /// <summary>
            /// <para>授权资源范围，枚举值：global（项目下所有资源）、custom（指定资源）。</para>
            /// 
            /// <b>Example:</b>
            /// <para>global</para>
            /// </summary>
            [NameInMap("AuthorizationResourceScope")]
            [Validation(Required=false)]
            public string AuthorizationResourceScope { get; set; }

            /// <summary>
            /// <para>授权规则的创建类型，枚举类型：user_created（用户创建)，approval_created（审批创建)。</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_custom</para>
            /// </summary>
            [NameInMap("AuthorizationRuleCreationType")]
            [Validation(Required=false)]
            public string AuthorizationRuleCreationType { get; set; }

            /// <summary>
            /// <para>授权规则标识。</para>
            /// 
            /// <b>Example:</b>
            /// <para>arrule_01kf143ug06fg7m9f43u7vahxxxx</para>
            /// </summary>
            [NameInMap("AuthorizationRuleId")]
            [Validation(Required=false)]
            public string AuthorizationRuleId { get; set; }

            /// <summary>
            /// <para>授权规则名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-name</para>
            /// </summary>
            [NameInMap("AuthorizationRuleName")]
            [Validation(Required=false)]
            public string AuthorizationRuleName { get; set; }

            /// <summary>
            /// <para>授权规则主体ID，主体类型对应的主体ID。</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectId")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectId { get; set; }

            /// <summary>
            /// <para>授权规则主体范围，枚举类型：shared（共享型，即支持所有主体，包括账户、应用），exclusive（专属类型）</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectScope")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectScope { get; set; }

            /// <summary>
            /// <para>授权规则主体类型，枚举类型：application（应用)，user（账户)。</para>
            /// </summary>
            [NameInMap("AuthorizationRuleSubjectType")]
            [Validation(Required=false)]
            public string AuthorizationRuleSubjectType { get; set; }

            /// <summary>
            /// <para>创建时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>授权规则描述，长度限制为128字符。</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>实例ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>授权规则关联的项目标识。</para>
            /// 
            /// <b>Example:</b>
            /// <para>iprj_system_default</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            /// <summary>
            /// <para>授权规则状态，枚举值：enabled（启用）、disabled（禁用）。</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>最近一次更新时间，Unix时间戳格式，单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1652085686179</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
