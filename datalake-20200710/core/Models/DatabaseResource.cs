// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DataLake20200710.Models
{
    public class DatabaseResource : TeaModel {
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        [NameInMap("DatabaseWildcard")]
        [Validation(Required=false)]
        public string DatabaseWildcard { get; set; }

    }

}
