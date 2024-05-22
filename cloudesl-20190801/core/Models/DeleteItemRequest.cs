// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DeleteItemRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ItemBarCode")]
        [Validation(Required=false)]
        public string ItemBarCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

    }

}
