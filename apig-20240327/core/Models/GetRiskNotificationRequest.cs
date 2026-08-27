// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetRiskNotificationRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GW_VERSION_EXPIRED</para>
        /// </summary>
        [NameInMap("riskCode")]
        [Validation(Required=false)]
        public string RiskCode { get; set; }

    }

}
