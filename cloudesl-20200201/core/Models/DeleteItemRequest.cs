// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20200201.Models
{
    public class DeleteItemRequest : TeaModel {
        [NameInMap("ItemBarCode")]
        [Validation(Required=false)]
        public string ItemBarCode { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("UnbindEslDevice")]
        [Validation(Required=false)]
        public bool? UnbindEslDevice { get; set; }

    }

}
