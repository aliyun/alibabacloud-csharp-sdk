// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateAKSTokenRequest : TeaModel {
        [NameInMap("ContainerName")]
        [Validation(Required=false)]
        public string ContainerName { get; set; }

        [NameInMap("Ctoken")]
        [Validation(Required=false)]
        public string Ctoken { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("PodName")]
        [Validation(Required=false)]
        public string PodName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
