// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class RefreshTaobaoItemRequest : TeaModel {
        [NameInMap("OuterId")]
        [Validation(Required=false)]
        public string OuterId { get; set; }

        [NameInMap("SkuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

        [NameInMap("TaobaoItemId")]
        [Validation(Required=false)]
        public string TaobaoItemId { get; set; }

    }

}
