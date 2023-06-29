// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyDefaultLevelRequest : TeaModel {
        /// <summary>
        /// The default sensitivity level of data that Data Security Center (DSC) cannot classify as sensitive or insensitive. Valid values:
        /// 
        /// *   **1**: N/A
        /// *   **2**: S1
        /// *   **3**: S2
        /// *   **4**: S3
        /// *   **5**: S4
        /// </summary>
        [NameInMap("DefaultId")]
        [Validation(Required=false)]
        public long? DefaultId { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh_cn**. Valid values:
        /// 
        /// *   **zh_cn**: Chinese
        /// *   **en_us**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The sensitivity level ID of data that DSC classifies as sensitive. Separate multiple IDs with commas (,). Valid values:
        /// 
        /// *   **1**: N/A
        /// *   **2**: S1
        /// *   **3**: S2
        /// *   **4**: S3
        /// *   **5**: S4
        /// </summary>
        [NameInMap("SensitiveIds")]
        [Validation(Required=false)]
        public string SensitiveIds { get; set; }

    }

}
