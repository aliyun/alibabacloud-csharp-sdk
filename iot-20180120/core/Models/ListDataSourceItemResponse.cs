// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListDataSourceItemResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("DataSourceItems")]
        [Validation(Required=true)]
        public ListDataSourceItemResponseDataSourceItems DataSourceItems { get; set; }
        public class ListDataSourceItemResponseDataSourceItems : TeaModel {
            [NameInMap("dataSourceItem")]
            [Validation(Required=true)]
            public List<ListDataSourceItemResponseDataSourceItemsDataSourceItem> DataSourceItem { get; set; }
            public class ListDataSourceItemResponseDataSourceItemsDataSourceItem : TeaModel {
                [NameInMap("DataSourceItemId")]
                [Validation(Required=true)]
                public long? DataSourceItemId { get; set; }

                [NameInMap("DeviceName")]
                [Validation(Required=true)]
                public string DeviceName { get; set; }

                [NameInMap("ProductKey")]
                [Validation(Required=true)]
                public string ProductKey { get; set; }

                [NameInMap("ScopeType")]
                [Validation(Required=true)]
                public string ScopeType { get; set; }

                [NameInMap("Topic")]
                [Validation(Required=true)]
                public string Topic { get; set; }

            }

        }

    }

}
