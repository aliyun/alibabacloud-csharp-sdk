// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class DescribeItemsRequest : TeaModel {
        [NameInMap("BePromotion")]
        [Validation(Required=false)]
        public bool? BePromotion { get; set; }

        [NameInMap("ItemBarCode")]
        [Validation(Required=false)]
        public string ItemBarCode { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

        [NameInMap("ItemTitle")]
        [Validation(Required=false)]
        public string ItemTitle { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SkuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

    }

}
