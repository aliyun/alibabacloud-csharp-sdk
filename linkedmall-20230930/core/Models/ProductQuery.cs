// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductQuery : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("distributorShopId")]
        [Validation(Required=false)]
        public string DistributorShopId { get; set; }

        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

    }

}
