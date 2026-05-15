// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ExecuteStatementRequest : TeaModel {
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("maxBytes")]
        [Validation(Required=false)]
        public long? MaxBytes { get; set; }

        [NameInMap("maxRows")]
        [Validation(Required=false)]
        public long? MaxRows { get; set; }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public List<object> Parameters { get; set; }

        [NameInMap("queryTimeout")]
        [Validation(Required=false)]
        public long? QueryTimeout { get; set; }

        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

    }

}
