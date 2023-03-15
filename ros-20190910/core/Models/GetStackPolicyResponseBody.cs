// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackPolicyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The structure that contains the stack policy body. The stack policy body must be 1 to 16,384 bytes in length.
        /// </summary>
        [NameInMap("StackPolicyBody")]
        [Validation(Required=false)]
        public Dictionary<string, object> StackPolicyBody { get; set; }

    }

}
