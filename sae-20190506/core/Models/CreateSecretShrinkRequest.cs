// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateSecretShrinkRequest : TeaModel {
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
        public string SecretDataShrink { get; set; }

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
