// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListDatabasesResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public ListDatabasesResponseBodyDatabases Databases { get; set; }
        public class ListDatabasesResponseBodyDatabases : TeaModel {
            [NameInMap("Databases")]
            [Validation(Required=false)]
            public List<string> Databases { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
