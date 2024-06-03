// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ManualTriggerMaskingProcessRequest : TeaModel {
        /// <summary>
        /// The ID of the de-identification task.
        /// 
        /// The ID of the de-identification task is a string. You can call the DescribeDataMaskingTasks operation to query the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The language of the content within the request and response, default value zh_cn. Valid values:
        /// 
        /// *   **zh_cn**: Chinese
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
