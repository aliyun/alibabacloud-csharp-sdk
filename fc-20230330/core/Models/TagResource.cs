// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class TagResource : TeaModel {
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public string TagKey { get; set; }

        [NameInMap("TagValue")]
        [Validation(Required=false)]
        public string TagValue { get; set; }

    }

}
