// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretRotationPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic rotation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables automatic rotation.</description></item>
        /// <item><description>false: does not enable automatic rotation. This is the default value.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        /// <summary>
        /// <para>The interval for automatic rotation. Valid values: 6 hours to 8,760 hours (365 days).</para>
        /// <para>The value is in the <c>integer[unit]</c> format.````</para>
        /// <para>The unit can be d (day), h (hour), m (minute), or s (second). For example, both 7d and 604800s indicate a seven-day interval.</para>
        /// <remarks>
        /// <para> This parameter is required if you set the EnableAutomaticRotation parameter to true. This parameter is ignored if you set the EnableAutomaticRotation parameter to false or does not specify the EnableAutomaticRotation parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30d</para>
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RdsSecret/Mysql5.4/MyCred</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
