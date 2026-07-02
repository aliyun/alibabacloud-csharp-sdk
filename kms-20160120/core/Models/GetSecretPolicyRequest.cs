// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetSecretPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the credential policy. Only the static field default is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The name or Alibaba Cloud Resource Name (ARN) of the credential.</para>
        /// <remarks>
        /// <para>If you access a credential that belongs to another Alibaba Cloud account, you must specify the ARN of the credential. The ARN of a credential must be in the <c>acs:kms:${region}:${account}:secret/${secret-name}</c> format.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret_test</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
