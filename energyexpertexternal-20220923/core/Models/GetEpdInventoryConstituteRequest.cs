// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetEpdInventoryConstituteRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The product id.
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// Product type: 1 indicates that the carbon footprint of the product is requested, and 5 indicates that the carbon footprint of the supply chain is requested.
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public long? ProductType { get; set; }

    }

}
