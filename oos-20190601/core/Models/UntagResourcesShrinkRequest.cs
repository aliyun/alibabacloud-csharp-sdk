// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UntagResourcesShrinkRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIdsShrink { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeysShrink { get; set; }

        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

    }

}
