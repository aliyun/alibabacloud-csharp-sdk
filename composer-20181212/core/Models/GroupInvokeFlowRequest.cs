// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Composer20181212.Models
{
    public class GroupInvokeFlowRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The information required by the group execution. Set this parameter to a JSON array of strings in the following format:`{"Items": []}`. Each string provides the information required by one time of execution. The string must use the format of the Data parameter in the InvokeFlow operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// The ID of the workflow that you want to execute.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// The name of the group. The name must be unique among the groups.
        /// </summary>
        [NameInMap("GroupKey")]
        [Validation(Required=false)]
        public string GroupKey { get; set; }

        /// <summary>
        /// The tag that is attached to each time of execution. The value is a JSON array. The number of tags in the array is the same as the value of the TotalCount parameter.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The number of times of execution. The value must be the same as the number of strings in the value of the Data parameter.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
