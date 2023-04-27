// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateFreeLockCorrectOrderResponseBody : TeaModel {
        [NameInMap("CreateOrderResult")]
        [Validation(Required=false)]
        public List<long?> CreateOrderResult { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The execution mode of the ticket after the ticket is approved. Valid values:
        /// 
        /// *   **COMMITOR**: The data change is performed by the user who submits the ticket.
        /// *   **AUTO**: The data change is automatically performed after the ticket is approved.
        /// *   **LAST_AUDITOR**: The data change is performed by the last approver of the ticket.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The reason for the data change.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
