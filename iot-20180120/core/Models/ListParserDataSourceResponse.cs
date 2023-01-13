// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ListParserDataSourceResponse : TeaModel {
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

        [NameInMap("Data")]
        [Validation(Required=true)]
        public ListParserDataSourceResponseData Data { get; set; }
        public class ListParserDataSourceResponseData : TeaModel {
            [NameInMap("DataSource")]
            [Validation(Required=true)]
            public List<ListParserDataSourceResponseDataDataSource> DataSource { get; set; }
            public class ListParserDataSourceResponseDataDataSource : TeaModel {
                [NameInMap("DataSourceId")]
                [Validation(Required=true)]
                public long? DataSourceId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=true)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=true)]
                public string Name { get; set; }

                [NameInMap("UtcCreated")]
                [Validation(Required=true)]
                public string UtcCreated { get; set; }

            }

        }

    }

}
