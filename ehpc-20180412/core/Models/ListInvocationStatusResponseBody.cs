// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListInvocationStatusResponseBody : TeaModel {
        /// <summary>
        /// The ID of the command.
        /// </summary>
        [NameInMap("CommandId")]
        [Validation(Required=false)]
        public string CommandId { get; set; }

        /// <summary>
        /// The list of statuses. A list is returned for each node.
        /// </summary>
        [NameInMap("InvokeInstances")]
        [Validation(Required=false)]
        public ListInvocationStatusResponseBodyInvokeInstances InvokeInstances { get; set; }
        public class ListInvocationStatusResponseBodyInvokeInstances : TeaModel {
            [NameInMap("InvokeInstance")]
            [Validation(Required=false)]
            public List<ListInvocationStatusResponseBodyInvokeInstancesInvokeInstance> InvokeInstance { get; set; }
            public class ListInvocationStatusResponseBodyInvokeInstancesInvokeInstance : TeaModel {
                /// <summary>
                /// The ID of the node.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The status of the node. Valid values:
                /// 
                /// *   Finished
                /// *   Running
                /// *   Failed
                /// *   Stopped
                /// </summary>
                [NameInMap("InstanceInvokeStatus")]
                [Validation(Required=false)]
                public string InstanceInvokeStatus { get; set; }

            }

        }

        /// <summary>
        /// The overall status of all nodes in the cluster. Valid values:
        /// 
        /// - Finished
        /// - Running
        /// - Failed
        /// - Stopped
        /// </summary>
        [NameInMap("InvokeStatus")]
        [Validation(Required=false)]
        public string InvokeStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
