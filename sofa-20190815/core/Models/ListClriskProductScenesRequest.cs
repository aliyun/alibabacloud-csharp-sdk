// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListClriskProductScenesRequest : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("QueryKey")]
        [Validation(Required=false)]
        public string QueryKey { get; set; }

    }

}
