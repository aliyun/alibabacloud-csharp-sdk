// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ValidateDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The result returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ValidateDataSourcesResponseBodyResult> Result { get; set; }
        public class ValidateDataSourcesResponseBodyResult : TeaModel {
            /// <summary>
            /// The code returned for the request.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The data source.
            /// </summary>
            [NameInMap("dataSource")]
            [Validation(Required=false)]
            public ValidateDataSourcesResponseBodyResultDataSource DataSource { get; set; }
            public class ValidateDataSourcesResponseBodyResultDataSource : TeaModel {
                /// <summary>
                /// The parameters of the data source.
                /// </summary>
                [NameInMap("parameters")]
                [Validation(Required=false)]
                public Dictionary<string, object> Parameters { get; set; }

                /// <summary>
                /// The name of the table.
                /// </summary>
                [NameInMap("tableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// The type of the data source.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The status of the execution.
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
