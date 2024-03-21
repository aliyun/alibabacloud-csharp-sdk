// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class QueryDetailItemRequest : TeaModel {
        [NameInMap("DetailConvertType")]
        [Validation(Required=false)]
        public string DetailConvertType { get; set; }

        [NameInMap("DetailId")]
        [Validation(Required=false)]
        public string DetailId { get; set; }

        [NameInMap("DetailType")]
        [Validation(Required=false)]
        public string DetailType { get; set; }

        [NameInMap("Mock")]
        [Validation(Required=false)]
        public bool? Mock { get; set; }

    }

}
