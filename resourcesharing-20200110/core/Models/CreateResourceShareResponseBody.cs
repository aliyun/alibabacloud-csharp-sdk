// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class CreateResourceShareResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceShare")]
        [Validation(Required=false)]
        public CreateResourceShareResponseBodyResourceShare ResourceShare { get; set; }
        public class CreateResourceShareResponseBodyResourceShare : TeaModel {
            [NameInMap("AllowExternalTargets")]
            [Validation(Required=false)]
            public bool? AllowExternalTargets { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ResourceShareId")]
            [Validation(Required=false)]
            public string ResourceShareId { get; set; }

            [NameInMap("ResourceShareName")]
            [Validation(Required=false)]
            public string ResourceShareName { get; set; }

            [NameInMap("ResourceShareOwner")]
            [Validation(Required=false)]
            public string ResourceShareOwner { get; set; }

            [NameInMap("ResourceShareStatus")]
            [Validation(Required=false)]
            public string ResourceShareStatus { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

    }

}
