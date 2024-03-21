// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class QueryActivityItemsRequest : TeaModel {
        [NameInMap("ActivityId")]
        [Validation(Required=false)]
        public int? ActivityId { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        [NameInMap("FloorIndex")]
        [Validation(Required=false)]
        public int? FloorIndex { get; set; }

        [NameInMap("Mock")]
        [Validation(Required=false)]
        public bool? Mock { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Refresh")]
        [Validation(Required=false)]
        public bool? Refresh { get; set; }

        [NameInMap("UmId")]
        [Validation(Required=false)]
        public string UmId { get; set; }

    }

}
