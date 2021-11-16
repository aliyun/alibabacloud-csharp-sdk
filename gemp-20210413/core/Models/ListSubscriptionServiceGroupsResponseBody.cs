// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListSubscriptionServiceGroupsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<ListSubscriptionServiceGroupsResponseBodyData> Data { get; set; }
        public class ListSubscriptionServiceGroupsResponseBodyData : TeaModel {
            /// <summary>
            /// 服务组描述
            /// </summary>
            [NameInMap("serviceGroupDescription")]
            [Validation(Required=false)]
            public string ServiceGroupDescription { get; set; }

            /// <summary>
            /// 主键
            /// </summary>
            [NameInMap("serviceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }

            /// <summary>
            /// 服务组名称
            /// </summary>
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
