// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class CreateResourceShareRequest : TeaModel {
        [NameInMap("ResourceShareName")]
        [Validation(Required=true)]
        public string ResourceShareName { get; set; }

        [NameInMap("Resources")]
        [Validation(Required=false)]
        public List<CreateResourceShareRequestResources> Resources { get; set; }
        public class CreateResourceShareRequestResources : TeaModel {
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<string> Targets { get; set; }

    }

}
