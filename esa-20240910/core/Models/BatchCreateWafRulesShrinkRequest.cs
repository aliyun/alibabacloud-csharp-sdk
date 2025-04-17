// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateWafRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A list of configurations for each rule, specifying detailed configurations for each rule.</para>
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public string ConfigsShrink { get; set; }

        /// <summary>
        /// <para>WAF rule type, with values:</para>
        /// <list type="bullet">
        /// <item><description><b>http_anti_scan</b>: Scan protection.</description></item>
        /// <item><description><b>http_bot</b>: Bots.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>http_anti_scan</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        /// <summary>
        /// <para>Ruleset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000001</para>
        /// </summary>
        [NameInMap("RulesetId")]
        [Validation(Required=false)]
        public long? RulesetId { get; set; }

        /// <summary>
        /// <para>Shared configuration for multiple rules, specifying common attributes of multiple rules.</para>
        /// </summary>
        [NameInMap("Shared")]
        [Validation(Required=false)]
        public string SharedShrink { get; set; }

        /// <summary>
        /// <para>Site ID, which can be obtained by calling the <a href="https://help.aliyun.com/document_detail/2850189.html">ListSites</a> interface.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Site version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
