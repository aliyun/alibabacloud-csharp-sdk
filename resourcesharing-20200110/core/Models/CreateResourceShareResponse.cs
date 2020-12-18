// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceSharing20200110.Models
{
    public class CreateResourceShareResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResourceShare")]
        [Validation(Required=true)]
        public CreateResourceShareResponseResourceShare ResourceShare { get; set; }
        public class CreateResourceShareResponseResourceShare : TeaModel {
            [NameInMap("ResourceShareId")]
            [Validation(Required=true)]
            public string ResourceShareId { get; set; }
            [NameInMap("ResourceShareName")]
            [Validation(Required=true)]
            public string ResourceShareName { get; set; }
            [NameInMap("ResourceShareOwner")]
            [Validation(Required=true)]
            public string ResourceShareOwner { get; set; }
            [NameInMap("ResourceShareStatus")]
            [Validation(Required=true)]
            public string ResourceShareStatus { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=true)]
            public string UpdateTime { get; set; }
        };

    }

}
