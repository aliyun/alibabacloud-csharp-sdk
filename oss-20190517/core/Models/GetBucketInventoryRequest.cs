// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class GetBucketInventoryRequest : TeaModel {
        /// <summary>
        /// The ID of the inventory rule to query
        /// </summary>
        [NameInMap("inventoryId")]
        [Validation(Required=false)]
        public string InventoryId { get; set; }

    }

}
