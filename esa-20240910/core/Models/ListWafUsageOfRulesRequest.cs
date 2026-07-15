// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafUsageOfRulesRequest : TeaModel {
        /// <summary>
        /// <para>The WAF instance ID.</para>
        /// <para>If this parameter is left empty, the API returns an empty result. We recommend that you always specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esa-site-b0wdsrlba3nk</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The phase in which the WAF rule runs. This parameter is required.</para>
        /// <para>Common values: http_custom, http_ratelimit, http_anti_scan, http_bot, http_managed, http_whitelist, and http_threat_intelligence.</para>
        /// <remarks>
        /// <para>Note: This parameter is required on the server side. If this parameter is not specified, the API returns InvalidParameter (400).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The site ID. You can call the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation to obtain the site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
