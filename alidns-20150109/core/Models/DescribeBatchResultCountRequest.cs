// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeBatchResultCountRequest : TeaModel {
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
        /// The ID of the task.
        /// 
        /// If you specify TaskId, the execution result of the specified task is returned. If you do not specify TaskId, the execution result of the last task is returned.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
