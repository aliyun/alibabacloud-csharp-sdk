// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesResponseBody : TeaModel {
        [NameInMap("InstanceResponses")]
        [Validation(Required=false)]
        public StopInstancesResponseBodyInstanceResponses InstanceResponses { get; set; }
        public class StopInstancesResponseBodyInstanceResponses : TeaModel {
            [NameInMap("InstanceResponse")]
            [Validation(Required=false)]
            public List<StopInstancesResponseBodyInstanceResponsesInstanceResponse> InstanceResponse { get; set; }
            public class StopInstancesResponseBodyInstanceResponsesInstanceResponse : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("CurrentStatus")]
                [Validation(Required=false)]
                public string CurrentStatus { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("PreviousStatus")]
                [Validation(Required=false)]
                public string PreviousStatus { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
