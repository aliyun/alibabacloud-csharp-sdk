// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateAuthorizationRuleRequest : TeaModel {
        /// <summary>
        /// <para>The scope of authorized resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>global: global resources under the project</description></item>
        /// <item><description>custom: resources under a specified project scope</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>global</para>
        /// </summary>
        [NameInMap("AuthorizationResourceScope")]
        [Validation(Required=false)]
        public string AuthorizationResourceScope { get; set; }

        /// <summary>
        /// <para>The name of the authorization rule. The name can be up to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_rule</para>
        /// </summary>
        [NameInMap("AuthorizationRuleName")]
        [Validation(Required=false)]
        public string AuthorizationRuleName { get; set; }

        /// <summary>
        /// <para>The scenario label of the authorization rule. The label can be up to 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>privileged_cloud_account</para>
        /// </summary>
        [NameInMap("AuthorizationRuleScenarioLabel")]
        [Validation(Required=false)]
        public string AuthorizationRuleScenarioLabel { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the value from your client and make sure that the value is unique across different requests. The ClientToken parameter only supports ASCII characters and cannot exceed 64 characters in length. For more information, see References: <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the authorization rule. The description can be up to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test rule</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the project associated with the authorization rule. If you are unsure about the project to associate, you can use the default project. The ID of the default project is iprj_system_default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iprj_system_default</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The type of subject to which the authorization rule applies, such as user (for human users) or application (for machine users). When explicitly specified, only privileged cloud account rules with a custom resource scope are supported. If this field is omitted for custom scope rules in this scenario, the default value is user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("SubjectType")]
        [Validation(Required=false)]
        public string SubjectType { get; set; }

    }

}
