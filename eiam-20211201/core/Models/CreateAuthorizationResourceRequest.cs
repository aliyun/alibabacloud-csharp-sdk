// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateAuthorizationResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the resource entity associated with the authorization resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>carole_01kmek49aqxxxx</para>
        /// </summary>
        [NameInMap("AuthorizationResourceEntityId")]
        [Validation(Required=false)]
        public string AuthorizationResourceEntityId { get; set; }

        /// <summary>
        /// <para>The type of the resource entity associated with the authorization resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_account_role: cloud role.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_account_role</para>
        /// </summary>
        [NameInMap("AuthorizationResourceEntityType")]
        [Validation(Required=false)]
        public string AuthorizationResourceEntityType { get; set; }

        /// <summary>
        /// <para>The authorization rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arrule_01kf143ug06fg7m9f43u7vahxxxx</para>
        /// </summary>
        [NameInMap("AuthorizationRuleId")]
        [Validation(Required=false)]
        public string AuthorizationRuleId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate a parameter value, but make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see References <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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

    }

}
