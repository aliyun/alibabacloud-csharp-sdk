// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProductsAsAdminRequest : TeaModel {
        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListProductsAsAdminRequestFilters> Filters { get; set; }
        public class ListProductsAsAdminRequestFilters : TeaModel {
            /// <summary>
            /// The name of the filter condition. Valid values:
            /// 
            /// *   ProductName: performs exact matches by product name. Product names are not case-sensitive.
            /// *   FullTextSearch: performs full-text searches by product name, product provider, or product description. Fuzzy match is supported.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the filter condition.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the product portfolio.
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// The query scope. Valid values:
        /// 
        /// *   Local: the products that are created by using the current account. This is the default value.
        /// *   Import: the products that are imported from other accounts.
        /// *   All: all available products.
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// The field that is used to sort the queried data.
        /// 
        /// Set the value to CreateTime, which specifies the time when the product was created.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The order in which you want to sort the queried data. Valid values:
        /// 
        /// *   Asc: the ascending order
        /// *   Desc: the descending order
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
