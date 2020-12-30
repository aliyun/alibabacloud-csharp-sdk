// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class TagResourcesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("FailedResources")]
        [Validation(Required=false)]
        public TagResourcesResponseBodyFailedResources FailedResources { get; set; }
        public class TagResourcesResponseBodyFailedResources : TeaModel {
            [NameInMap("FailedResource")]
            [Validation(Required=false)]
            public List<TagResourcesResponseBodyFailedResourcesFailedResource> FailedResource { get; set; }
            public class TagResourcesResponseBodyFailedResourcesFailedResource : TeaModel {
                public string ResourceARN { get; set; }
                public TagResourcesResponseBodyFailedResourcesFailedResourceResult Result { get; set; }
                public class TagResourcesResponseBodyFailedResourcesFailedResourceResult : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }
            }
        };

    }

}
