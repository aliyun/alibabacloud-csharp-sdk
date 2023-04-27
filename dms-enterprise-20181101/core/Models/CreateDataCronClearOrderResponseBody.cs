// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataCronClearOrderResponseBody : TeaModel {
        [NameInMap("CreateOrderResult")]
        [Validation(Required=false)]
        public List<long?> CreateOrderResult { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Specifies whether to specify an end time for the task. Valid values:
        /// 
        /// *   **true**: specifies an end time for the task. The task is automatically suspended after this end time.
        /// *   **false**: does not specify an end time for the task. The task is stopped after the historical data is cleared.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
