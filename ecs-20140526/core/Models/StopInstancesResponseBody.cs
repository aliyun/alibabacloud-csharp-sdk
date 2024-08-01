// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesResponseBody : TeaModel {
        /// <summary>
        /// The instance-specific responses, which contain the status of each instance before and after the operation was called and the results of the operation.
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
                /// The error code returned for the instance. A return value of 200 indicates that the operation was successful. For more information, see the "Error codes" section of this topic.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The current status of the instance.
                /// </summary>
                [NameInMap("CurrentStatus")]
                [Validation(Required=false)]
                public string CurrentStatus { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The error message returned for the instance. A return value of success indicates that the operation was successful. For more information, see the "Error codes" section of this topic.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The status of the instance before the operation was called.
                /// </summary>
                [NameInMap("PreviousStatus")]
                [Validation(Required=false)]
                public string PreviousStatus { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
