// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCorrectOrderDetailRequest : TeaModel {
        /// <summary>
        /// The information about the data change ticket.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The status of the precheck. Valid values:
        /// 
        /// *   **WAITING**: The ticket is pending precheck.
        /// *   **RUNNING**: The ticket is being prechecked.
        /// *   **SUCCESS**: The ticket passes the precheck.
        /// *   **FAIL**: The ticket fails the precheck.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
