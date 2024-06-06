// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetFootprintListRequest : TeaModel {
        /// <summary>
        /// The enterprise code.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The pagination parameter. The number of the page that starts from 1.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("currentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned on each page.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// Product type: 1 indicates that the carbon footprint of the product is requested, and 5 indicates that the carbon footprint of the supply chain is requested.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public long? ProductType { get; set; }

    }

}
