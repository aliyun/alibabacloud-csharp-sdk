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
        /// <item><description><para>global: all resources within the project.</para>
        /// </description></item>
        /// <item><description><para>custom: specified resources within the project.</para>
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
        /// <para>The name of the authorization rule. The name can be up to 64 characters long.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_rule</para>
        /// </summary>
        [NameInMap("AuthorizationRuleName")]
        [Validation(Required=false)]
        public string AuthorizationRuleName { get; set; }

        /// <summary>
        /// <para>A unique identifier that you provide to ensure the idempotence of the request. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the authorization rule. The description can be up to 128 characters long.</para>
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
        /// <para>The ID of the project to associate with the authorization rule. If you are unsure which project to use, you can associate the rule with the default project, iprj_system_default.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>iprj_system_default</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
