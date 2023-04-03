// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultDetailRequest : TeaModel {
        /// <summary>
        /// The type of the batch operation. Valid values:
        /// 
        /// *   **DOMAIN_ADD**: adds domain names in batches.
        /// *   **DOMAIN_DEL**: deletes domain names in batches.
        /// *   **RR_ADD**: adds DNS records in batches.
        /// *   **RR_DEL**: deletes DNS records in batches.
        /// </summary>
        [NameInMap("BatchType")]
        [Validation(Required=false)]
        public string BatchType { get; set; }

        /// <summary>
        /// The language type.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
