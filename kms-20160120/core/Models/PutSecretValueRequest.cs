// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class PutSecretValueRequest : TeaModel {
        /// <summary>
        /// <para>The secret value. The value is encrypted and stored in the specified new version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>importantdata</para>
        /// </summary>
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        /// <summary>
        /// <para>The type of the secret value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>text (default)</para>
        /// </description></item>
        /// <item><description><para>binary</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        /// <summary>
        /// <para>The name or Alibaba Cloud Resource Name (ARN) of the secret.</para>
        /// <remarks>
        /// <para>When you access a secret in another Alibaba Cloud account, you must specify the ARN of the secret. The ARN of a secret is in the format of <c>acs:kms:${region}:${account}:secret/${secret-name}</c>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The version number of the secret. The value must be unique in the secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v3</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The stage labels that are used to mark the new version. If you do not specify this parameter, KMS marks the new version with ACSCurrent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ACSCurrent&quot;,&quot;ACSNext&quot;]</para>
        /// </summary>
        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public string VersionStages { get; set; }

    }

}
