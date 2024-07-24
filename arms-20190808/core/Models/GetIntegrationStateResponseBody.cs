// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetIntegrationStateResponseBody : TeaModel {
        /// <summary>
        /// Status code. 200 means success, other status codes are exceptions.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The prompt information of the returned result.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The integration state of Prometheus dashboards and collection rules. Valid values:
        /// 
        /// *   `true`: The Prometheus dashboards and collection rules that monitor the software are integrated.
        /// *   `false`: The Prometheus dashboards and collection rules that monitor the software are not integrated.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public bool? State { get; set; }

    }

}
