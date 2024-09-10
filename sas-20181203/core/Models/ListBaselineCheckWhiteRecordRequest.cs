// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListBaselineCheckWhiteRecordRequest : TeaModel {
        /// <summary>
        /// The IDs of check items.
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

        /// <summary>
        /// The name of the check item. Fuzzy match is supported.
        /// </summary>
        [NameInMap("CheckItemFuzzy")]
        [Validation(Required=false)]
        public string CheckItemFuzzy { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The IDs of the whitelist rules.
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public List<long?> RecordIds { get; set; }

        /// <summary>
        /// The data source. If you leave this parameter empty, the default value is used. Valid values:
        /// 
        /// *   **default**: server
        /// *   **agentless**: agentless detection
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
