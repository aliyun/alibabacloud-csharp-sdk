// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetSiteLogDeliveryQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The log category. Valid values:</para>
        /// <ol>
        /// <item><description>dcdn_log_access_l1 (default): access logs.</description></item>
        /// <item><description>dcdn_log_er: Edge Routine logs.</description></item>
        /// <item><description>dcdn_log_waf: firewall logs.</description></item>
        /// <item><description>dcdn_log_ipa: TCP/UDP proxy logs.</description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dcdn_log_access_l1</para>
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
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
