// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The IDs of the resources for which you want to query tags. You must specify at least one of resourceId and tags.
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Set the value to project.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags that you want to use to filter resources based on exact match. Each tag is a key-value pair. You must specify at least one of resourceId and tags.
        /// 
        /// You can enter up to 20 tags.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTags> Tags { get; set; }
        public class ListTagResourcesRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag that you want to use to filter resources. For example, if you set the key to `"test-key"`, only resources to which the key is added are returned.``
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag that you want to use to filter resources. If you set the value to null, resources are filtered based only on the key of the tag.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
