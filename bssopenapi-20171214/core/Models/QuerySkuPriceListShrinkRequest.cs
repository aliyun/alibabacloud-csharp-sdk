// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QuerySkuPriceListShrinkRequest : TeaModel {
        /// <summary>
        /// The code of the service.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The token that is used to retrieve the next page. You do not need to set this parameter if you query coverage details for the first time. The response returns a token that you can use to query coverage details of the next page. If a null value is returned for the NextPageToken parameter, no more coverage details can be queried.
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// The number of entries to be returned on each page. Maximum value: 50.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The code of the pricing object.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PriceEntityCode")]
        [Validation(Required=false)]
        public string PriceEntityCode { get; set; }

        /// <summary>
        /// The conditions of the pricing factors.
        /// </summary>
        [NameInMap("PriceFactorConditionMap")]
        [Validation(Required=false)]
        public string PriceFactorConditionMapShrink { get; set; }

    }

}
