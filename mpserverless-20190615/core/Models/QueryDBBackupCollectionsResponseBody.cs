// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class QueryDBBackupCollectionsResponseBody : TeaModel {
        [NameInMap("Collections")]
        [Validation(Required=false)]
        public List<string> Collections { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
