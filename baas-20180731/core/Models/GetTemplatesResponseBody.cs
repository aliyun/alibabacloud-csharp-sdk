// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class GetTemplatesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetTemplatesResponseBodyResult Result { get; set; }
        public class GetTemplatesResponseBodyResult : TeaModel {
            [NameInMap("SchemaList")]
            [Validation(Required=false)]
            public List<GetTemplatesResponseBodyResultSchemaList> SchemaList { get; set; }
            public class GetTemplatesResponseBodyResultSchemaList : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IsTemplate")]
                [Validation(Required=false)]
                public int? IsTemplate { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

        }

    }

}
