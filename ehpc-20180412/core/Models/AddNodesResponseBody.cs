// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class AddNodesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// 
        /// >  AddNodes is an asynchronous API operation. If a request succeeds, a response is immediately generated before ECS instances are created. Therefore, the value of the parameter is null. You can call the [ListNodes](~~87161~~) operation to obtain the IDs of the ECS instances.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public AddNodesResponseBodyInstanceIds InstanceIds { get; set; }
        public class AddNodesResponseBodyInstanceIds : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public List<string> InstanceId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
