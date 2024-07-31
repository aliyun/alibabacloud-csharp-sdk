// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreatePermissionApplyOrderResponseBody : TeaModel {
        /// <summary>
        /// The request order ID.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public List<string> FlowId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
