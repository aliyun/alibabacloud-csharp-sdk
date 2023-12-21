// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetInstanceResourceTableResponseBody : TeaModel {
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetInstanceResourceTableResponseBodyFields> Fields { get; set; }
        public class GetInstanceResourceTableResponseBodyFields : TeaModel {
            [NameInMap("IsDimensionField")]
            [Validation(Required=false)]
            public bool? IsDimensionField { get; set; }

            [NameInMap("Meaning")]
            [Validation(Required=false)]
            public string Meaning { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
