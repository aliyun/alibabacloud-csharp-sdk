// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateRiskNotificationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isMute")]
        [Validation(Required=false)]
        public bool? IsMute { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GW_VERSION_EXPIRED</para>
        /// </summary>
        [NameInMap("riskCode")]
        [Validation(Required=false)]
        public string RiskCode { get; set; }

    }

}
