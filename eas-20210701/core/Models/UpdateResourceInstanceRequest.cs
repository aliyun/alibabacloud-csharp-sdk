// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateResourceInstanceRequest : TeaModel {
        /// <summary>
        /// The operation that updates the scheduling state of the instance in a dedicated resource group. Valid values:
        /// 
        /// *   Uncordon: allows scheduling the service to this instance.
        /// *   Cordon: prohibits scheduling the service to this instance.
        /// *   Drain: evicts the service that has been scheduled to this instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

    }

}
