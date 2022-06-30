// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class UntagResourcesResponseBody : TeaModel {
        [NameInMap("FailedResources")]
        [Validation(Required=false)]
        public UntagResourcesResponseBodyFailedResources FailedResources { get; set; }
        public class UntagResourcesResponseBodyFailedResources : TeaModel {
            [NameInMap("FailedResource")]
            [Validation(Required=false)]
            public List<UntagResourcesResponseBodyFailedResourcesFailedResource> FailedResource { get; set; }
            public class UntagResourcesResponseBodyFailedResourcesFailedResource : TeaModel {
                public string ResourceARN { get; set; }
                public UntagResourcesResponseBodyFailedResourcesFailedResourceResult Result { get; set; }
                public class UntagResourcesResponseBodyFailedResourcesFailedResourceResult : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
