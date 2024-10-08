// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchCreateWafRulesRequest : TeaModel {
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<WafRuleConfig> Configs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>http_custom</para>
        /// </summary>
        [NameInMap("Phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("Shared")]
        [Validation(Required=false)]
        public WafBatchRuleShared Shared { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        [NameInMap("SiteVersion")]
        [Validation(Required=false)]
        public int? SiteVersion { get; set; }

    }

}
