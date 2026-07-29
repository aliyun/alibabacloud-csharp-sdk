// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListPublishedAgentShrinkRequest : TeaModel {
        [NameInMap("pageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("subTypes")]
        [Validation(Required=false)]
        public string SubTypesShrink { get; set; }

    }

}
