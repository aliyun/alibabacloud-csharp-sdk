// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyRouterInterfaceSpecResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The specification of the router interface. Valid values:
        /// 
        /// *   **Mini.2**: 2 Mbit/s
        /// *   **Mini.5**: 5 Mbit/s
        /// *   **Small.1**: 10 Mbit/s
        /// *   **Small.2**: 20 Mbit/s
        /// *   **Small.5**: 50 Mbit/s
        /// *   **Middle.1**: 100 Mbit/s
        /// *   **Middle.2**: 200 Mbit/s
        /// *   **Middle.5**: 500 Mbit/s
        /// *   **Large.1**: 1,000 Mbit/s
        /// *   **Large.2**: 2,000 Mbit/s
        /// *   **Large.5**: 5,000 Mbit/s
        /// *   **Xlarge.1**: 10,000 Mbit/s
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
