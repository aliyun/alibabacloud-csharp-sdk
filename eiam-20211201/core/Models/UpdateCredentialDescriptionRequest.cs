// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class UpdateCredentialDescriptionRequest : TeaModel {
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
        /// <para>The credential ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("CredentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>The description of the credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_description</para>
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
