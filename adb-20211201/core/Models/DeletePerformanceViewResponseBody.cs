// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DeletePerformanceViewResponseBody : TeaModel {
        /// <summary>
        /// The details about the access denial.
        /// 
        /// >  This parameter is returned only if Resource Access Management (RAM) permission verification failed.
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        [NameInMap("DeleteStatus")]
        [Validation(Required=false)]
        public bool? DeleteStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
