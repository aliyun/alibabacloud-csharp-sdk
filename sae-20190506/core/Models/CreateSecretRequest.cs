// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateSecretRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the namespace where the Secret resides. If the namespace is the default namespace, you need to only enter the region ID, such as <c>cn-beijing</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        /// <summary>
        /// <para>The Secret data.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public CreateSecretRequestSecretData SecretData { get; set; }
        public class CreateSecretRequestSecretData : TeaModel {
            /// <summary>
            /// <para>The information about the key-value pairs of the Secret. This parameter is required. The following formats are supported:</para>
            /// <para>{&quot;Data&quot;:&quot;{&quot;k1&quot;:&quot;v1&quot;, &quot;k2&quot;:&quot;v2&quot;}&quot;}</para>
            /// <para>k specifies a key and v specifies a value.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;.dockerconfigjson&quot;:&quot;eyJhdXRocyI6eyJyZWdpc3RyeS12cGMuY24tYmVpamluZy5hbGl5dW5jcy5jb20iOnsidXNlcm5hbWUiOiJ1c2VybmFtZSIsInBhc3N3b3JkIjoicGFzc3dvcmQiLCJhdXRoIjoiZFhObGNtNWhiV1U2Y0dGemMzZHZjbVE9In0sInJlZ2lzdHJ5LmNuLWJlaWppbmcuYWxpeXVuY3MuY29tIjp7InVzZXJuYW1lIjoidXNlcm5hbWUiLCJwYXNzd29yZCI6InBhc3N3b3JkIiwiYXV0aCI6ImRYTmxjbTVoYldVNmNHRnpjM2R2Y21RPSJ9fX0=&quot;}</para>
            /// </summary>
            [NameInMap("SecretData")]
            [Validation(Required=false)]
            public string SecretData { get; set; }

        }

        /// <summary>
        /// <para>The Secret name. The name can contain digits, letters, and underscores (_). The name must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry-auth-acree</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The supported Secret type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>kubernetes.io/dockerconfigjson</b>: the Secret for the username and password of the image repository. The Secret is used for authentication when images are pulled during application deployment.</description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Opaque</description></item>
        /// <item><description>kubernetes.io/dockerconfigjson</description></item>
        /// <item><description>kubernetes.io/tls</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes.io/dockerconfigjson</para>
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

    }

}
