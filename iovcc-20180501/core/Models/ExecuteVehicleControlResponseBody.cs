// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ExecuteVehicleControlResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExecutionInfo")]
        [Validation(Required=false)]
        public ExecuteVehicleControlResponseBodyExecutionInfo ExecutionInfo { get; set; }
        public class ExecuteVehicleControlResponseBodyExecutionInfo : TeaModel {
            [NameInMap("ExecutionId")]
            [Validation(Required=false)]
            public string ExecutionId { get; set; }
        };

    }

}
