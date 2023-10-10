// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AbortChangeOrderRequest : TeaModel {
        /// <summary>
        /// The ID of the change process. You can call the [GetChangeOrderInfo](~~62072~~) operation to query the change process ID.
        /// </summary>
        [NameInMap("ChangeOrderId")]
        [Validation(Required=false)]
        public string ChangeOrderId { get; set; }

    }

}
