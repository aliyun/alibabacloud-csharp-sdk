// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details about the responses returned for the instances, which contain the status of each instance before and after the operation is called and the operation results.
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
                /// The error code that is returned for the operation on the instance. A return value of 200 indicates success. For more information, see the "Error codes" section in this topic.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The current state of the instance.
                /// </summary>
                [NameInMap("CurrentStatus")]
                [Validation(Required=false)]
                public string CurrentStatus { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The error message that is returned for the operation on the instance. A return value of Success indicates that this operation is successful. For more information, see the "Error codes" section in this topic.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The state of the instance before the operation is called.
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
