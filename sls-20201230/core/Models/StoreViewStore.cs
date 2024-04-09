// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class StoreViewStore : TeaModel {
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("storeName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

    }

}
