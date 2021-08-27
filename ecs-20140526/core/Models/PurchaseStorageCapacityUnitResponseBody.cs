// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class PurchaseStorageCapacityUnitResponseBody : TeaModel {
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StorageCapacityUnitIds")]
        [Validation(Required=false)]
        public PurchaseStorageCapacityUnitResponseBodyStorageCapacityUnitIds StorageCapacityUnitIds { get; set; }
        public class PurchaseStorageCapacityUnitResponseBodyStorageCapacityUnitIds : TeaModel {
            [NameInMap("StorageCapacityUnitId")]
            [Validation(Required=false)]
            public List<string> StorageCapacityUnitId { get; set; }
        };

    }

}
