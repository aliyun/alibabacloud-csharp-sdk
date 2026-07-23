// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteLogDeliveryQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of real-time logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dcdn_log_access_l1 (default)</b>: access logs.</description></item>
        /// <item><description><b>dcdn_log_er</b>: edge function logs.</description></item>
        /// <item><description><b>dcdn_log_waf</b>: security protection logs.</description></item>
        /// <item><description><b>dcdn_log_ipa</b>: Layer 4 acceleration logs.</description></item>
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
        /// <para>4C14840EF0EAAB6D97CDE0C5F6554ACE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
