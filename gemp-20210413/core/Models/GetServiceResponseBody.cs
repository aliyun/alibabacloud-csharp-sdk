// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceResponseBodyData Data { get; set; }
        public class GetServiceResponseBodyData : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("escalationPlanId")]
            [Validation(Required=false)]
            public long? EscalationPlanId { get; set; }

            [NameInMap("serviceDescription")]
            [Validation(Required=false)]
            public string ServiceDescription { get; set; }

            [NameInMap("serviceGroupIdList")]
            [Validation(Required=false)]
            public List<long?> ServiceGroupIdList { get; set; }

            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
