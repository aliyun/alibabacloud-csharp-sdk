// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetUserLogDeliveryQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The log category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dcdn_log_access_l1 (default): access logs.</description></item>
        /// <item><description>dcdn_log_er: Edge Routine logs.</description></item>
        /// <item><description>dcdn_log_waf: firewall logs.</description></item>
        /// <item><description>dcdn_log_ipa: TCP/UDP proxy logs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The remaining quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FreeQuota")]
        [Validation(Required=false)]
        public long? FreeQuota { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34DCBC8A-<b><b>-</b></b>-****-6DAA11D7DDBD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
