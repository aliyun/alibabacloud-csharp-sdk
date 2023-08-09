// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesResponseBody : TeaModel {
        /// <summary>
        /// The error code that is returned for the operation on the ECS instance. When a value of 200 is returned, the operation is successful. For more information, see the "Error codes" section in this topic.
        /// </summary>
        [NameInMap("InstanceResponses")]
        [Validation(Required=false)]
        public StopInstancesResponseBodyInstanceResponses InstanceResponses { get; set; }
        public class StopInstancesResponseBodyInstanceResponses : TeaModel {
            [NameInMap("InstanceResponse")]
            [Validation(Required=false)]
            public List<StopInstancesResponseBodyInstanceResponsesInstanceResponse> InstanceResponse { get; set; }
            public class StopInstancesResponseBodyInstanceResponsesInstanceResponse : TeaModel {
                /// <summary>
                /// The error message that is returned for the operation on the ECS instance. When Success is returned, the operation is successful. For more information, see the "Error codes" section in this topic.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The state of the instance before the operation is called.
                /// </summary>
                [NameInMap("CurrentStatus")]
                [Validation(Required=false)]
                public string CurrentStatus { get; set; }

                /// <summary>
                /// The current state of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ECS instance ID.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("PreviousStatus")]
                [Validation(Required=false)]
                public string PreviousStatus { get; set; }

            }

        }

        /// <summary>
        /// Details about the responses returned for the instances, which contain the state of each instance before and after the operation is called, and the results of the operation.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
