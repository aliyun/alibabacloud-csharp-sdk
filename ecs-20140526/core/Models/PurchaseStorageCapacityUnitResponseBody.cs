// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class PurchaseStorageCapacityUnitResponseBody : TeaModel {
        /// <summary>
        /// The order ID.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The IDs of the SCUs.
        /// </summary>
        [NameInMap("StorageCapacityUnitIds")]
        [Validation(Required=false)]
        public PurchaseStorageCapacityUnitResponseBodyStorageCapacityUnitIds StorageCapacityUnitIds { get; set; }
        public class PurchaseStorageCapacityUnitResponseBodyStorageCapacityUnitIds : TeaModel {
            [NameInMap("StorageCapacityUnitId")]
            [Validation(Required=false)]
            public List<string> StorageCapacityUnitId { get; set; }

        }

    }

}
