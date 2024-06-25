// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDatabaseSchemaResponseBody : TeaModel {
        /// <summary>
        /// id of request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// List
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetDatabaseSchemaResponseBodyResult> Result { get; set; }
        public class GetDatabaseSchemaResponseBodyResult : TeaModel {
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            [NameInMap("fieldTypeDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> FieldTypeDetail { get; set; }

            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            [NameInMap("indexType")]
            [Validation(Required=false)]
            public string IndexType { get; set; }

        }

    }

}
