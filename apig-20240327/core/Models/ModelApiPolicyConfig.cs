// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ModelApiPolicyConfig : TeaModel {
        /// <summary>
        /// <para>The AI security protection settings.</para>
        /// </summary>
        [NameInMap("aiSecurityGuardConfig")]
        [Validation(Required=false)]
        public AiSecurityGuardConfig AiSecurityGuardConfig { get; set; }

        /// <summary>
        /// <para>The AI observability and request log configuration.</para>
        /// </summary>
        [NameInMap("aiStatisticsConfig")]
        [Validation(Required=false)]
        public AiStatisticsConfig AiStatisticsConfig { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The policy type. Only AiStatistics and AiSecurityGuard are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AiStatistics</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
