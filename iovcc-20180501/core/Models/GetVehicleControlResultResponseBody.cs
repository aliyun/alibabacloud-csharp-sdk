// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class GetVehicleControlResultResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ExecutionInfo")]
        [Validation(Required=false)]
        public GetVehicleControlResultResponseBodyExecutionInfo ExecutionInfo { get; set; }
        public class GetVehicleControlResultResponseBodyExecutionInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public string SubStatus { get; set; }
        };

    }

}
