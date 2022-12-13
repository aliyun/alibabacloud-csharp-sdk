// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetServiceGroupSpecialPersonSchedulingResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetServiceGroupSpecialPersonSchedulingResponseBodyData> Data { get; set; }
        public class GetServiceGroupSpecialPersonSchedulingResponseBodyData : TeaModel {
            [NameInMap("schedulingDate")]
            [Validation(Required=false)]
            public string SchedulingDate { get; set; }

            [NameInMap("schedulingEndTime")]
            [Validation(Required=false)]
            public string SchedulingEndTime { get; set; }

            [NameInMap("schedulingStartTime")]
            [Validation(Required=false)]
            public string SchedulingStartTime { get; set; }

            [NameInMap("schedulingUserId")]
            [Validation(Required=false)]
            public long? SchedulingUserId { get; set; }

            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }

            [NameInMap("serviceGroupName")]
            [Validation(Required=false)]
            public string ServiceGroupName { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
