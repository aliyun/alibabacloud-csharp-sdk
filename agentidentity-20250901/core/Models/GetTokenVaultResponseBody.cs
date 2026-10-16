// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetTokenVaultResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A48EB1D-D645-5758-91AF-EDF8E36E257B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the token vault.</para>
        /// </summary>
        [NameInMap("TokenVault")]
        [Validation(Required=false)]
        public GetTokenVaultResponseBodyTokenVault TokenVault { get; set; }
        public class GetTokenVaultResponseBodyTokenVault : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-08T06:19:17Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The encryption configuration of the token vault.</para>
            /// </summary>
            [NameInMap("EncryptionConfig")]
            [Validation(Required=false)]
            public GetTokenVaultResponseBodyTokenVaultEncryptionConfig EncryptionConfig { get; set; }
            public class GetTokenVaultResponseBodyTokenVaultEncryptionConfig : TeaModel {
                /// <summary>
                /// <para>The type of the encryption key. Valid values: SERVICE_MANAGED_KEY (service-managed key) and CUSTOMER_MANAGED_KEY (customer-managed KMS key).</para>
                /// 
                /// <b>Example:</b>
                /// <para>SERVICE_MANAGED_KEY</para>
                /// </summary>
                [NameInMap("KeyType")]
                [Validation(Required=false)]
                public string KeyType { get; set; }

                /// <summary>
                /// <para>The ARN of the KMS key used when KeyType is set to CUSTOMER_MANAGED_KEY.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs:kms:cn-beijing:123456:key/key-bjxxxxxxxx</para>
                /// </summary>
                [NameInMap("KmsKeyArn")]
                [Validation(Required=false)]
                public string KmsKeyArn { get; set; }

            }

            /// <summary>
            /// <para>The ARN of the RAM role used to authorize the AgentIdentity service to access other cloud resources such as KMS.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::123456:role/AliyunAgentIdentityVaultRole</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The ARN of the token vault.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:agentidentity:cn-beijing:123456:tokenvault/default</para>
            /// </summary>
            [NameInMap("TokenVaultArn")]
            [Validation(Required=false)]
            public string TokenVaultArn { get; set; }

            /// <summary>
            /// <para>The name of the token vault. The name must be unique within the current Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("TokenVaultName")]
            [Validation(Required=false)]
            public string TokenVaultName { get; set; }

            /// <summary>
            /// <para>The update time in UTC ISO 8601 format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-08T06:19:17Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
