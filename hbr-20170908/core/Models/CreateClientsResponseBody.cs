// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateClientsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The status of the ECS instance. If you specify more than one instance IDs in the request and the status of an ECS instance does not meet the requirements to install an HBR client, an error message is returned based on the value of this parameter.
        /// </summary>
        [NameInMap("InstanceStatuses")]
        [Validation(Required=false)]
        public CreateClientsResponseBodyInstanceStatuses InstanceStatuses { get; set; }
        public class CreateClientsResponseBodyInstanceStatuses : TeaModel {
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public List<CreateClientsResponseBodyInstanceStatusesInstanceStatus> InstanceStatus { get; set; }
            public class CreateClientsResponseBodyInstanceStatusesInstanceStatus : TeaModel {
                /// <summary>
                /// The ID of the ECS instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// Indicates whether an HBR client can be installed on the ECS instance. Valid values:
                /// 
                /// *   true: An HBR client can be installed on the ECS instance.
                /// *   false: An HBR client cannot be installed on the ECS instance.
                /// </summary>
                [NameInMap("ValidInstance")]
                [Validation(Required=false)]
                public bool? ValidInstance { get; set; }

            }

        }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The ID of the asynchronous job. You can call the DescribeTask operation to query the execution result of an asynchronous job.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
