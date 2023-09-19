// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetInventorySchemaResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// The pagination token that was used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The detailed configurations of the configuration list.
        /// </summary>
        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public List<GetInventorySchemaResponseBodySchemas> Schemas { get; set; }
        public class GetInventorySchemaResponseBodySchemas : TeaModel {
            /// <summary>
            /// The properties of the configuration list.
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<GetInventorySchemaResponseBodySchemasAttributes> Attributes { get; set; }
            public class GetInventorySchemaResponseBodySchemasAttributes : TeaModel {
                /// <summary>
                /// The data type of the property.
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// The name of the property.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The name of the configuration list.
            /// </summary>
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            /// <summary>
            /// The version of the configuration list.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
