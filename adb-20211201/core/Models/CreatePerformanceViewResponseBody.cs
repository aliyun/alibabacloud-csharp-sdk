// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreatePerformanceViewResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The creation result. Valid values:
        /// 
        /// *   **SUCCESS**
        /// *   **FAILED**
        /// </summary>
        [NameInMap("CreateStatus")]
        [Validation(Required=false)]
        public string CreateStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
