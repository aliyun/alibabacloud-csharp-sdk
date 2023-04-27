// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTaskFlowNotificationResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Notification")]
        [Validation(Required=false)]
        public GetTaskFlowNotificationResponseBodyNotification Notification { get; set; }
        public class GetTaskFlowNotificationResponseBodyNotification : TeaModel {
            [NameInMap("DagNotificationFail")]
            [Validation(Required=false)]
            public bool? DagNotificationFail { get; set; }

            [NameInMap("DagNotificationSla")]
            [Validation(Required=false)]
            public bool? DagNotificationSla { get; set; }

            [NameInMap("DagNotificationSuccess")]
            [Validation(Required=false)]
            public bool? DagNotificationSuccess { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
