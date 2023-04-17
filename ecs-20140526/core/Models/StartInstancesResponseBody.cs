// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information about the ECS instance. The information contains the status of each instance before and after the operation is called and the operation results.
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
                /// The error code that is returned for the operation on the ECS instance. A return value of 200 indicates that the operation is successful. For more information, see the "Error codes" section in this topic.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The status of the ECS instance after the operation is called.
                /// </summary>
                [NameInMap("CurrentStatus")]
                [Validation(Required=false)]
                public string CurrentStatus { get; set; }

                /// <summary>
                /// The ID of the ECS instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The error message that is returned for the operation on the ECS instance. A return value of success indicates that the operation is successful. For more information, see the "Error codes" section in this topic.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// The status of the ECS instance before the operation is called.
                /// </summary>
                [NameInMap("PreviousStatus")]
                [Validation(Required=false)]
                public string PreviousStatus { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
