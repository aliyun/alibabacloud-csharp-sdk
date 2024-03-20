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
        /// The result returned.
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDataSourceSchemasResponseBodyResult> Result { get; set; }
        public class ListDataSourceSchemasResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the index properties are added. Valid values: true and false. **true** indicates that the index properties are added, and **false** indicates that the index properties are not added.
            /// </summary>
            [NameInMap("addIndex")]
            [Validation(Required=false)]
            public bool? AddIndex { get; set; }

            /// <summary>
            /// Indicates whether it is an attribute field. Valid values: true and false. **true** indicates that it is an attribute field, and **false** indicates that it is not an attribute field.
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public bool? Attribute { get; set; }

            /// <summary>
            /// Indicates whether it is a custom field. Valid values: true and false. **true** indicates that it is a custom field, and **false** indicates that it is not a custom field.
            /// </summary>
            [NameInMap("custom")]
            [Validation(Required=false)]
            public bool? Custom { get; set; }

            /// <summary>
            /// The name of the field.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The primary key.
            /// </summary>
            [NameInMap("primaryKey")]
            [Validation(Required=false)]
            public ListDataSourceSchemasResponseBodyResultPrimaryKey PrimaryKey { get; set; }
            public class ListDataSourceSchemasResponseBodyResultPrimaryKey : TeaModel {
                /// <summary>
                /// Indicates whether it has the primary key property. **true** indicates that it has the primary key property, and **false** indicates that it does not have the primary key property.
                /// </summary>
                [NameInMap("hasPrimaryKeyAttribute")]
                [Validation(Required=false)]
                public bool? HasPrimaryKeyAttribute { get; set; }

                /// <summary>
                /// Indicates whether it is the primary key. Valid values: true and false. **true** indicates that it is the primary key, and **false** indicates that it is not the primary key.
                /// </summary>
                [NameInMap("isPrimaryKey")]
                [Validation(Required=false)]
                public bool? IsPrimaryKey { get; set; }

                /// <summary>
                /// Indicates whether data is sorted based on the primary key. Valid values: true and false. **true** indicates that data is sorted based on the primary key, and **false** indicates that data is not sorted based on the primary key.
                /// </summary>
                [NameInMap("isPrimaryKeySorted")]
                [Validation(Required=false)]
                public bool? IsPrimaryKeySorted { get; set; }

            }

            /// <summary>
            /// Indicates whether the information can be displayed. Valid values: true and false. **true** indicates that the information can be displayed, and **false** indicates that the information cannot be displayed.
            /// </summary>
            [NameInMap("summary")]
            [Validation(Required=false)]
            public bool? Summary { get; set; }

            /// <summary>
            /// The type of the field.
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
