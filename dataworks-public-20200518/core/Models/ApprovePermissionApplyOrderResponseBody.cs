// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ApprovePermissionApplyOrderResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the permission request order is processed.
        /// </summary>
        [NameInMap("ApproveSuccess")]
        [Validation(Required=false)]
        public bool? ApproveSuccess { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
