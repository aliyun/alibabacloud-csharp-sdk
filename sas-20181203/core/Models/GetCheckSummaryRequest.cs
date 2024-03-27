// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckSummaryRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the statistics of the check items, including the number of check items supported by the system and the number of check items available to you.
        /// </summary>
        [NameInMap("IsItemStatistic")]
        [Validation(Required=false)]
        public bool? IsItemStatistic { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The account ID of the resource directory.
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public string ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// The cloud service providers.
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
