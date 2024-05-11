// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The token used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the resource.
        /// 
        /// Valid values of N: `[1,50]`.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// Currently, tags are supported for API groups, plug-ins, and apps. Operations performed on APIs are based on the tags of API groups.
        /// 
        /// *   **apiGroup**
        /// *   **plugin**
        /// *   **app**
        /// *   **api**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag of objects that match the lifecycle rule. You can specify multiple tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag.
            /// 
            /// Valid values of N: `[1,20]`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. If the parameter has a value, a value is also required for the tag key of the same N in the corresponding **tag.N.Key**. Otherwise, an error is reported.
            /// 
            /// Valid values of N: `[1,20]`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
