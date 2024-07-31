// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePauseProtectionStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether WAF protection is paused.
        /// 
        /// *   **0**: indicates that WAF protection is not paused. This is the default value.
        /// *   **1**: indicates that WAF protection is paused.
        /// </summary>
        [NameInMap("PauseStatus")]
        [Validation(Required=false)]
        public int? PauseStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
