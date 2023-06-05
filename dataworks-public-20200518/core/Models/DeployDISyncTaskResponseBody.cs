// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeployDISyncTaskResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the real-time synchronization node or data synchronization solution is deployed. Valid values:
        /// 
        /// *   success: The real-time synchronization node or data synchronization solution is deployed.
        /// *   fail: The real-time synchronization node or data synchronization solution fails to be deployed.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeployDISyncTaskResponseBodyData Data { get; set; }
        public class DeployDISyncTaskResponseBodyData : TeaModel {
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The cause of the failure to deploy the real-time synchronization node or data synchronization solution.
            /// 
            /// If the real-time synchronization node or data synchronization solution is deployed, the value null is returned.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The result of deploying the real-time synchronization node or data synchronization solution.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request. You can query logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
