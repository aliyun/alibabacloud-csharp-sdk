// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeLinklogKnowledgeRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        [NameInMap("KnowledgeName")]
        [Validation(Required=false)]
        public string KnowledgeName { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

    }

}
