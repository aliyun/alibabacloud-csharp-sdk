// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyPerformanceViewResponseBody : TeaModel {
        /// <summary>
        /// The details about the access denial. This parameter is returned only if Resource Access Management (RAM) permission verification failed.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// The modification result. Valid values:
        /// 
        /// *   **SUCCESS**
        /// *   **FAILED**
        /// </summary>
        [NameInMap("ModifyStatus")]
        [Validation(Required=false)]
        public string ModifyStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
