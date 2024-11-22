// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafFilterRequest : TeaModel {
        /// <summary>
        /// <para>The WAF rule category to which the filter conditions to query belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_bot</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The website ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The condition for matching incoming requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>characteristics</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The rule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_custom_cc</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
