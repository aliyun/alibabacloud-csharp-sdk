// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetInventorySchemaResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public List<GetInventorySchemaResponseBodySchemas> Schemas { get; set; }
        public class GetInventorySchemaResponseBodySchemas : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<GetInventorySchemaResponseBodySchemasAttributes> Attributes { get; set; }
            public class GetInventorySchemaResponseBodySchemasAttributes : TeaModel {
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }

            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
