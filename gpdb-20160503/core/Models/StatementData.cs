// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class StatementData : TeaModel {
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<string> Parameters { get; set; }

        [NameInMap("SecretArn")]
        [Validation(Required=false)]
        public string SecretArn { get; set; }

        [NameInMap("Sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        [NameInMap("Sqls")]
        [Validation(Required=false)]
        public List<string> Sqls { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
