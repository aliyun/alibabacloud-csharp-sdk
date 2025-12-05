// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DeleteSecretRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly delete the secret. If this parameter is set to true, the secret cannot be recovered.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default value)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceDeleteWithoutRecovery")]
        [Validation(Required=false)]
        public string ForceDeleteWithoutRecovery { get; set; }

        /// <summary>
        /// <para>Specifies the recovery period of the secret if you do not forcibly delete it. Default value: 30. Unit: Days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecoveryWindowInDays")]
        [Validation(Required=false)]
        public string RecoveryWindowInDays { get; set; }

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

    }

}
