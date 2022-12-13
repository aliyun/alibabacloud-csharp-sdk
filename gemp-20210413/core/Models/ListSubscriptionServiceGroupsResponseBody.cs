// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSubscriptionServiceGroupsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListSubscriptionServiceGroupsResponseBodyData> Data { get; set; }
        public class ListSubscriptionServiceGroupsResponseBodyData : TeaModel {
            [NameInMap("serviceGroupDescription")]
            [Validation(Required=false)]
            public string ServiceGroupDescription { get; set; }

            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
