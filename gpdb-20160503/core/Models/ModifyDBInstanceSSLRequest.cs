// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyDBInstanceSSLRequest : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=true)]
        public string DBInstanceId { get; set; }

        [NameInMap("ConnectionString")]
        [Validation(Required=true)]
        public string ConnectionString { get; set; }

        [NameInMap("SSLEnabled")]
        [Validation(Required=true)]
        public int? SSLEnabled { get; set; }

    }

}
