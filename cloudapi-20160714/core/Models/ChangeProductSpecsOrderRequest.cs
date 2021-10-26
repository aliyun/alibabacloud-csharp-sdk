// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ChangeProductSpecsOrderRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public List<ChangeProductSpecsOrderRequestOrder> Order { get; set; }
        public class ChangeProductSpecsOrderRequestOrder : TeaModel {
            [NameInMap("ProductSpecsId")]
            [Validation(Required=false)]
            public long? ProductSpecsId { get; set; }

            [NameInMap("ProductSpecsOrder")]
            [Validation(Required=false)]
            public int? ProductSpecsOrder { get; set; }

        }

    }

}
