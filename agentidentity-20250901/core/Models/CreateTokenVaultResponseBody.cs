// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateTokenVaultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2A48EB1D-D645-5758-91AF-EDF8E36E257B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TokenVault")]
        [Validation(Required=false)]
        public CreateTokenVaultResponseBodyTokenVault TokenVault { get; set; }
        public class CreateTokenVaultResponseBodyTokenVault : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-05-08T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>example description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EncryptionConfig")]
            [Validation(Required=false)]
            public CreateTokenVaultResponseBodyTokenVaultEncryptionConfig EncryptionConfig { get; set; }
            public class CreateTokenVaultResponseBodyTokenVaultEncryptionConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>SERVICE_MANAGED_KEY</para>
                /// </summary>
                [NameInMap("KeyType")]
                [Validation(Required=false)]
                public string KeyType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>acs:kms:cn-beijing:123456:key/key-bjxxxxxxxx</para>
                /// </summary>
                [NameInMap("KmsKeyArn")]
                [Validation(Required=false)]
                public string KmsKeyArn { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::123456:role/AliyunAgentIdentityVaultRole</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:tokenvault/default</para>
            /// </summary>
            [NameInMap("TokenVaultArn")]
            [Validation(Required=false)]
            public string TokenVaultArn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("TokenVaultName")]
            [Validation(Required=false)]
            public string TokenVaultName { get; set; }

        }

    }

}
