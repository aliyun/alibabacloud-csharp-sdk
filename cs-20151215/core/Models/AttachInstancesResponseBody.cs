// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class AttachInstancesResponseBody : TeaModel {
        /// <summary>
        /// The details of the added nodes.
        /// </summary>
        [NameInMap("list")]
        [Validation(Required=false)]
        public List<AttachInstancesResponseBodyList> List { get; set; }
        public class AttachInstancesResponseBodyList : TeaModel {
            /// <summary>
            /// The code that indicates the task result.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Indicates whether the ECS instances are successfully added to the ACK cluster.
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
