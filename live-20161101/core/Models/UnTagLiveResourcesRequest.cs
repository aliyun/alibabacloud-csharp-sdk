// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UnTagLiveResourcesRequest : TeaModel {
        [NameInMap("ResourceId")]
        [Validation(Required=true)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=true)]
        public string ResourceType { get; set; }

        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

    }

}
