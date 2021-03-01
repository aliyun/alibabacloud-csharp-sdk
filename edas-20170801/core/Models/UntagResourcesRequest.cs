// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UntagResourcesRequest : TeaModel {
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

        [NameInMap("DeleteAll")]
        [Validation(Required=false)]
        public bool? DeleteAll { get; set; }

    }

}
