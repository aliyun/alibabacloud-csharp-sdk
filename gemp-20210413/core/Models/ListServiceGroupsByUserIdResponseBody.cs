// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class ListServiceGroupsByUserIdResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListServiceGroupsByUserIdResponseBodyData Data { get; set; }
        public class ListServiceGroupsByUserIdResponseBodyData : TeaModel {
            [NameInMap("isScheduled")]
            [Validation(Required=false)]
            public bool? IsScheduled { get; set; }

            [NameInMap("serviceGroupId")]
            [Validation(Required=false)]
            public long? ServiceGroupId { get; set; }

            [NameInMap("serviceGroupName")]
            [Validation(Required=false)]
            public string ServiceGroupName { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
