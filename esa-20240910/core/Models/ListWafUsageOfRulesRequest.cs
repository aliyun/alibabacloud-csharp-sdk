// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafUsageOfRulesRequest : TeaModel {
        /// <summary>
        /// <para>The WAF rule category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ListWafUsageOfRules</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
