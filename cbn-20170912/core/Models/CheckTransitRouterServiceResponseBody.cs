// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CheckTransitRouterServiceResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the transit router feature is activated.
        /// 
        /// *   **true**: activated
        /// *   If this value is not returned, the system prompts that the current account does not have the transit router feature activated.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public string Enabled { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
