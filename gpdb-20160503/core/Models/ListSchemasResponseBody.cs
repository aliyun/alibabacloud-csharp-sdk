// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListSchemasResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Schemas")]
        [Validation(Required=false)]
        public ListSchemasResponseBodySchemas Schemas { get; set; }
        public class ListSchemasResponseBodySchemas : TeaModel {
            [NameInMap("Schemas")]
            [Validation(Required=false)]
            public List<string> Schemas { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
