// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ValidateDataSourcesResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ValidateDataSourcesResponseBodyResult> Result { get; set; }
        public class ValidateDataSourcesResponseBodyResult : TeaModel {
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public ValidateDataSourcesResponseBodyResultDataSource DataSource { get; set; }
            public class ValidateDataSourcesResponseBodyResultDataSource : TeaModel {
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
