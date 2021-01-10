// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryAKSBuildPackTechStackVersionsRequest : TeaModel {
        [NameInMap("CafeRegionId")]
        [Validation(Required=false)]
        public string CafeRegionId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TechStack")]
        [Validation(Required=false)]
        public string TechStack { get; set; }

    }

}
