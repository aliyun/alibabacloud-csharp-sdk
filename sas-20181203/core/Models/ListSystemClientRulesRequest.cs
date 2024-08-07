// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemClientRulesRequest : TeaModel {
        /// <summary>
        /// The IDs of the aggregation types for rules.
        /// </summary>
        [NameInMap("AggregationIds")]
        [Validation(Required=false)]
        public List<int?> AggregationIds { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Specifies whether to query only container images. Valid values:
        /// 
        /// *   **0**: no
        /// *   **1**: yes
        /// </summary>
        [NameInMap("IsContainer")]
        [Validation(Required=false)]
        public int? IsContainer { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the system defense rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The types of the system defense rules.
        /// </summary>
        [NameInMap("RuleTypes")]
        [Validation(Required=false)]
        public List<int?> RuleTypes { get; set; }

        /// <summary>
        /// The type of the OS. Valid values:
        /// 
        /// *   **2**: Windows
        /// *   **1**: Linux
        /// *   **0**: all types
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public int? SystemType { get; set; }

    }

}
