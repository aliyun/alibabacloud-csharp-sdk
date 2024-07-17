// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListDataSourceSchemasResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The results returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDataSourceSchemasResponseBodyResult> Result { get; set; }
        public class ListDataSourceSchemasResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the field has the index attribute. Valid values: **true** and **false**.
            /// </summary>
            [NameInMap("addIndex")]
            [Validation(Required=false)]
            public bool? AddIndex { get; set; }

            /// <summary>
            /// Indicates whether the field is an attribute field. Valid values: **true** and **false**.
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public bool? Attribute { get; set; }

            /// <summary>
            /// Indicates whether the field is a custom field. Valid values: **true** and **false**.
            /// </summary>
            [NameInMap("custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            /// <summary>
            /// The field name.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The primary key field.
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public ListDataSourceSchemasResponseBodyResultPrimaryKey PrimaryKey { get; set; }
            public class ListDataSourceSchemasResponseBodyResultPrimaryKey : TeaModel {
                /// <summary>
                /// Indicates whether the field has the primary key attribute. Valid values: **true** and **false**.
                /// </summary>
                [NameInMap("hasPrimaryKeyAttribute")]
                [Validation(Required=false)]
                public bool? HasPrimaryKeyAttribute { get; set; }

                /// <summary>
                /// Indicates whether the field is the primary key. Valid values: **true** and **false**.
                /// </summary>
                [NameInMap("isPrimaryKey")]
                [Validation(Required=false)]
                public bool? IsPrimaryKey { get; set; }

                /// <summary>
                /// Indicates whether the field can be sorted. Valid values: **true** and **false**.
                /// </summary>
                [NameInMap("isPrimaryKeySorted")]
                [Validation(Required=false)]
                public bool? IsPrimaryKeySorted { get; set; }

            }

            /// <summary>
            /// Indicates whether the field can be displayed. Valid values: **true** and **false**.
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public bool? Summary { get; set; }

            /// <summary>
            /// The field type.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
