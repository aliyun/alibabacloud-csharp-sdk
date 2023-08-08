// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UntagResourcesShrinkRequest : TeaModel {
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public string ResourceIdsShrink { get; set; }

        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("tag_keys")]
        [Validation(Required=false)]
        public string TagKeysShrink { get; set; }

    }

}
