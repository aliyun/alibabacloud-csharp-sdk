// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListWafTemplateRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The WAF rule category, which is used to filter template rules of a specific category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>The query parameter, which is used to filter template rules based on criteria such as the rule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("QueryArgs")]
        [Validation(Required=false)]
        public string QueryArgsShrink { get; set; }

        /// <summary>
        /// <para>站点ID，可通过调用<a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a>接口获取。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
