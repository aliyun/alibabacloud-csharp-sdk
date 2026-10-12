// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateRiskNotificationRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to mute notifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isMute")]
        [Validation(Required=false)]
        public bool? IsMute { get; set; }

        /// <summary>
        /// <para>The risk item code. This parameter is required.</para>
        /// <para>The value is a numeric string (for example, 60010010002 or 50010010009). Call GetRiskNotification to query the code of the current risk item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60010010002</para>
        /// </summary>
        [NameInMap("riskCode")]
        [Validation(Required=false)]
        public string RiskCode { get; set; }

    }

}
