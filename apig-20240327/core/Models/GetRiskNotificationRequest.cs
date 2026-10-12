// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetRiskNotificationRequest : TeaModel {
        /// <summary>
        /// <para>The code of the risk item, such as the code for version risk or capacity risk.</para>
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
