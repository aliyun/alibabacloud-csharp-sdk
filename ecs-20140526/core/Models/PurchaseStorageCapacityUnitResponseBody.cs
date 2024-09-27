// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class PurchaseStorageCapacityUnitResponseBody : TeaModel {
        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>204135153880****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The IDs of the SCUs.</para>
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
