// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CheckSampleDataSetResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The state of the built-in dataset. Valid values:
        /// 
        /// *   **SUCCEED**: The dataset is loaded.
        /// *   **INIT**: The dataset is being loaded.
        /// *   **FAILED**: The dataset failed to be loaded.
        /// *   **UNINITIALIZED**: The dataset is not loaded.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
