// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class ObtainCloudAccountRoleAccessCredentialRequest : TeaModel {
        /// <summary>
        /// <para>The business identifier of the cloud account role.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::xxx:role/role-test</para>
        /// </summary>
        [NameInMap("cloudAccountRoleExternalId")]
        [Validation(Required=false)]
        public string CloudAccountRoleExternalId { get; set; }

        /// <summary>
        /// <para>Specifies the validity duration of the temporary security credentials (STS Token) for the cloud account role, in seconds. Valid values: 900 to 43200 (15 minutes to 12 hours).
        /// Constraints:</para>
        /// <list type="bullet">
        /// <item><description>The minimum value cannot be less than 900 seconds.</description></item>
        /// <item><description>The maximum value is subject to the maximum session duration of the cloud provider role or service account. For example, the default maximum session duration for an AWS role is 3600 seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1800</para>
        /// </summary>
        [NameInMap("durationSeconds")]
        [Validation(Required=false)]
        public int? DurationSeconds { get; set; }

    }

}
