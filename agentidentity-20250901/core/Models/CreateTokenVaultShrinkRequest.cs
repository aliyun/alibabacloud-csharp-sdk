// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateTokenVaultShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the token vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The encryption configuration of the token vault. The value is a JSON string.</para>
        /// </summary>
        [NameInMap("EncryptionConfig")]
        [Validation(Required=false)]
        public string EncryptionConfigShrink { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role used to authorize the AgentIdentity service to access other cloud resources such as KMS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456:role/AliyunAgentIdentityVaultRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The name of the token vault. The name must be unique within the current Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

    }

}
