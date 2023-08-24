// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class TransformToPrePaidResponseBody : TeaModel {
        /// <summary>
        /// Specifies whether to enable auto-renewal. Default value: false. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no. In this case, you can renew your instance in the ApsaraDB for Redis console. For more information, see [Manually renew an instance](~~26352~~).
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **TransformToPrePaid**.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
