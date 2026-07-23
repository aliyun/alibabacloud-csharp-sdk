// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteLogDeliveryQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The type of real-time logs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>dcdn_log_access_l1 (default)</b>: access logs.</description></item>
        /// <item><description><b>dcdn_log_er</b>: edge function logs.</description></item>
        /// <item><description><b>dcdn_log_waf</b>: security protection logs.</description></item>
        /// <item><description><b>dcdn_log_ipa</b>: Layer 4 acceleration logs.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
