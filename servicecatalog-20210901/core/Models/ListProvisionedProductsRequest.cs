// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class ListProvisionedProductsRequest : TeaModel {
        /// <summary>
        /// The access filter. Valid values:
        /// 
        /// *   User: queries the product instances that are created by the current requester. This is the default value.
        /// *   Account: queries the product instances that belong to the current Alibaba Cloud account.
        /// </summary>
        [NameInMap("AccessLevelFilter")]
        [Validation(Required=false)]
        public string AccessLevelFilter { get; set; }

        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<ListProvisionedProductsRequestFilters> Filters { get; set; }
        public class ListProvisionedProductsRequestFilters : TeaModel {
            /// <summary>
            /// The name of the filter condition. Valid values:
            /// 
            /// *   ProvisionedProductName: performs exact matches by product instance name. Product instance names are not case-sensitive.
            /// *   FullTextSearch: performs full-text searches by product instance name. Fuzzy match is supported.
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
        /// The field that is used to sort the queried data.
        /// 
        /// Set the value to CreateTime, which specifies the time when the product instance was created.
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// The sorting method. Valid values:
        /// 
        /// *   Asc: the ascending order.
        /// *   Desc (default): the descending order.
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
