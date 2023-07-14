// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDataSourceItemResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The information about the topics that are returned.
        /// </summary>
        [NameInMap("DataSourceItems")]
        [Validation(Required=false)]
        public ListDataSourceItemResponseBodyDataSourceItems DataSourceItems { get; set; }
        public class ListDataSourceItemResponseBodyDataSourceItems : TeaModel {
            [NameInMap("dataSourceItem")]
            [Validation(Required=false)]
            public List<ListDataSourceItemResponseBodyDataSourceItemsDataSourceItem> DataSourceItem { get; set; }
            public class ListDataSourceItemResponseBodyDataSourceItemsDataSourceItem : TeaModel {
                /// <summary>
                /// The ID of the topic of the data source.
                /// </summary>
                [NameInMap("DataSourceItemId")]
                [Validation(Required=false)]
                public long? DataSourceItemId { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=false)]
                public string DeviceName { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=false)]
                public string ProductKey { get; set; }

                [NameInMap("ScopeType")]
                [Validation(Required=false)]
                public string ScopeType { get; set; }

                /// <summary>
                /// The name of the topic of the data source.
                /// </summary>
                [NameInMap("Topic")]
                [Validation(Required=false)]
                public string Topic { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
