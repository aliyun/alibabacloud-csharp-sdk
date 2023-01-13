// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateParserDataSourceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("DataSource")]
        [Validation(Required=true)]
        public CreateParserDataSourceResponseDataSource DataSource { get; set; }
        public class CreateParserDataSourceResponseDataSource : TeaModel {
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
