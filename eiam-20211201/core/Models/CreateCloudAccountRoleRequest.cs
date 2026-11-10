// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class CreateCloudAccountRoleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate a parameter value, but you must make sure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see References: <a href="https://www.alibabacloud.com/help/zh/ecs/developer-reference/how-to-ensure-idempotence">How to ensure idempotence</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client-token-example</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cloud account ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca_01kmegjc11qa1txxxxx</para>
        /// </summary>
        [NameInMap("CloudAccountId")]
        [Validation(Required=false)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// <para>The cloud role name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>role-test</para>
        /// </summary>
        [NameInMap("CloudAccountRoleName")]
        [Validation(Required=false)]
        public string CloudAccountRoleName { get; set; }

        /// <summary>
        /// <para>The cloud role type. The specific format depends on the cloud account type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>role: applicable to Alibaba Cloud accounts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>role</para>
        /// </summary>
        [NameInMap("CloudAccountRoleType")]
        [Validation(Required=false)]
        public string CloudAccountRoleType { get; set; }

        /// <summary>
        /// <para>The cloud role description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_account_role_description</para>
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

    }

}
