// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayQuotaRuleStatusRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clear historical quota usage when enabling or disabling the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("clearHistory")]
        [Validation(Required=false)]
        public bool? ClearHistory { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

    }

}
