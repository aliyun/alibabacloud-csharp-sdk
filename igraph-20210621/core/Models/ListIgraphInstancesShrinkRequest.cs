// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Igraph20210621.Models
{
    public class ListIgraphInstancesShrinkRequest : TeaModel {
        [NameInMap("pageContinue")]
        [Validation(Required=false)]
        public string PageContinue { get; set; }

        [NameInMap("pageLimit")]
        [Validation(Required=false)]
        public string PageLimit { get; set; }

        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
