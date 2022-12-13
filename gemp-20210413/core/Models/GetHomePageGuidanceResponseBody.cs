// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetHomePageGuidanceResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetHomePageGuidanceResponseBodyData Data { get; set; }
        public class GetHomePageGuidanceResponseBodyData : TeaModel {
            [NameInMap("notifySubscriptionStatus")]
            [Validation(Required=false)]
            public bool? NotifySubscriptionStatus { get; set; }

            [NameInMap("serviceGroupStatus")]
            [Validation(Required=false)]
            public bool? ServiceGroupStatus { get; set; }

            [NameInMap("serviceStatus")]
            [Validation(Required=false)]
            public bool? ServiceStatus { get; set; }

            [NameInMap("usersStatus")]
            [Validation(Required=false)]
            public bool? UsersStatus { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
