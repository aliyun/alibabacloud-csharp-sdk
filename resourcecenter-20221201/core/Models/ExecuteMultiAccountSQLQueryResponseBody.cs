// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class ExecuteMultiAccountSQLQueryResponseBody : TeaModel {
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<ExecuteMultiAccountSQLQueryResponseBodyColumns> Columns { get; set; }
        public class ExecuteMultiAccountSQLQueryResponseBodyColumns : TeaModel {
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

        [NameInMap("Rows")]
        [Validation(Required=false)]
        public List<object> Rows { get; set; }

    }

}
