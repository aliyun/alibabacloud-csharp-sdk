// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListAddonTemplatesRequest : TeaModel {
        [NameInMap("AddonNames")]
        [Validation(Required=false)]
        public List<string> AddonNames { get; set; }

        [NameInMap("ClusterCategory")]
        [Validation(Required=false)]
        public string ClusterCategory { get; set; }

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
