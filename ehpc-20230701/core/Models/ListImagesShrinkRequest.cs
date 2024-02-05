// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20230701.Models
{
    public class ListImagesShrinkRequest : TeaModel {
        [NameInMap("ImageIds")]
        [Validation(Required=false)]
        public string ImageIdsShrink { get; set; }

        [NameInMap("ImageNames")]
        [Validation(Required=false)]
        public string ImageNamesShrink { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
