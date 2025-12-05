// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class PutSecretValueRequest : TeaModel {
        /// <summary>
        /// <para>The secret value. The value is encrypted and then stored in the new version.</para>
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
        /// <item><description>text: This is the default value.</description></item>
        /// <item><description>binary</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The new version of the secret value. Version numbers must be unique in each secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00000000000000000000000000000000203</para>
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// <para>The stage labels that are used to mark the new version. If you do not specify this parameter, Secrets Manager marks the new version with ACSCurrent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ACSCurrent&quot;,&quot;ACSNext&quot;]</para>
        /// </summary>
        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public string VersionStages { get; set; }

    }

}
