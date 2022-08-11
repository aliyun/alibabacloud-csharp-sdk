// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class TagResourcesRequest : TeaModel {
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
