// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetNodeGroupResponseBody : TeaModel {
        /// <summary>
        /// The node group.
        /// </summary>
        [NameInMap("NodeGroup")]
        [Validation(Required=false)]
        public NodeGroup NodeGroup { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
