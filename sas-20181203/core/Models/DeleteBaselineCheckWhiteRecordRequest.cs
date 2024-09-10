// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteBaselineCheckWhiteRecordRequest : TeaModel {
        /// <summary>
        /// The IDs of check items.
        /// </summary>
        [NameInMap("CheckIds")]
        [Validation(Required=false)]
        public List<long?> CheckIds { get; set; }

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
        /// The IDs of the whitelist records.
        /// </summary>
        [NameInMap("RecordIds")]
        [Validation(Required=false)]
        public List<long?> RecordIds { get; set; }

        /// <summary>
        /// The data source. Valid values:
        /// 
        /// *   **default**: host baseline
        /// *   **agentless**: agentless detection
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
