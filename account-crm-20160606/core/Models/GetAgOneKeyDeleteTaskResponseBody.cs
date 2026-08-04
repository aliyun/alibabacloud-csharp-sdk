// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Account_crm20160606.Models
{
    public class GetAgOneKeyDeleteTaskResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskDto")]
        [Validation(Required=false)]
        public GetAgOneKeyDeleteTaskResponseBodyTaskDto TaskDto { get; set; }
        public class GetAgOneKeyDeleteTaskResponseBodyTaskDto : TeaModel {
            [NameInMap("DeleteStatus")]
            [Validation(Required=false)]
            public string DeleteStatus { get; set; }

            [NameInMap("ExistQuietPeriod")]
            [Validation(Required=false)]
            public bool? ExistQuietPeriod { get; set; }

            [NameInMap("QuietPeriodEndTime")]
            [Validation(Required=false)]
            public string QuietPeriodEndTime { get; set; }

        }

    }

}
