// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class TagResourcesResponseBody : TeaModel {
        /// <summary>
        /// The information about the resources to which tags fail to be added.
        /// 
        /// > 
        /// 
        /// *   If tags are added to all resources, the value of `FailedResources` is empty.
        /// 
        /// *   If tags fail to be added to some or all resources, the value of `FailedResources` contains the detailed information about the resources.
        /// </summary>
        [NameInMap("FailedResources")]
        [Validation(Required=false)]
        public TagResourcesResponseBodyFailedResources FailedResources { get; set; }
        public class TagResourcesResponseBodyFailedResources : TeaModel {
            [NameInMap("FailedResource")]
            [Validation(Required=false)]
            public List<TagResourcesResponseBodyFailedResourcesFailedResource> FailedResource { get; set; }
            public class TagResourcesResponseBodyFailedResourcesFailedResource : TeaModel {
                /// <summary>
                /// The ARN of the resource.
                /// </summary>
                [NameInMap("ResourceARN")]
                [Validation(Required=false)]
                public string ResourceARN { get; set; }

                /// <summary>
                /// The information about the error.
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public TagResourcesResponseBodyFailedResourcesFailedResourceResult Result { get; set; }
                public class TagResourcesResponseBodyFailedResourcesFailedResourceResult : TeaModel {
                    /// <summary>
                    /// The error code.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The error message.
                    /// </summary>
                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
