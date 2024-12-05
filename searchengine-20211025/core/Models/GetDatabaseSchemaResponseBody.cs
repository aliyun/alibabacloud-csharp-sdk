// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class GetDatabaseSchemaResponseBody : TeaModel {
        /// <summary>
        /// <para>id of request</para>
        /// 
        /// <b>Example:</b>
        /// <para>022F36C7-9FB4-5D67-BEBC-3D14B0984463</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetDatabaseSchemaResponseBodyResult> Result { get; set; }
        public class GetDatabaseSchemaResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("fieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("fieldType")]
            [Validation(Required=false)]
            public string FieldType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>FT_UINT64</para>
            /// </summary>
            [NameInMap("fieldTypeDetail")]
            [Validation(Required=false)]
            public Dictionary<string, object> FieldTypeDetail { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test_tusou_v2</para>
            /// </summary>
            [NameInMap("indexName")]
            [Validation(Required=false)]
            public string IndexName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NUMBER</para>
            /// </summary>
            [NameInMap("indexType")]
            [Validation(Required=false)]
            public string IndexType { get; set; }

        }

    }

}
