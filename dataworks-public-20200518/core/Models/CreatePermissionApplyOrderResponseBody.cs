// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreatePermissionApplyOrderResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request order. If you request permissions on multiple objects but each object has a different request approver, one request order is generated for each object and is sent to the related approver. In this case, an array is returned.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public List<string> FlowId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
