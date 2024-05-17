// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartInstancesResponseBody : TeaModel {
        /// <summary>
        /// The status of the instances before and after the operation is called and the operation results.
        /// </summary>
        [NameInMap("InstanceResponses")]
        [Validation(Required=false)]
        public StartInstancesResponseBodyInstanceResponses InstanceResponses { get; set; }
        public class StartInstancesResponseBodyInstanceResponses : TeaModel {
            [NameInMap("InstanceResponse")]
            [Validation(Required=false)]
            public List<StartInstancesResponseBodyInstanceResponsesInstanceResponse> InstanceResponse { get; set; }
            public class StartInstancesResponseBodyInstanceResponsesInstanceResponse : TeaModel {
                /// <summary>
                /// The error code returned for the operation on the instance. The status code 200 indicates that the request was successful. For more information, see the "Error codes" section of this topic.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The status of the instance after the operation is called.
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
                /// The error message returned for the operation on the instance. The status code 200 indicates that the request was successful. For more information, see the "Error codes" section of this topic.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The status of the instance before the operation is called.
                /// </summary>
                [NameInMap("PreviousStatus")]
                [Validation(Required=false)]
                public string PreviousStatus { get; set; }

            }

        }

        /// <summary>
        /// The information about the ECS instance, such as the status of each instance before and after the operation is called and the operation results.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
