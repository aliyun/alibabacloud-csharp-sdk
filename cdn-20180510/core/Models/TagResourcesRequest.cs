// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The list of resource IDs. Maximum number of list elements: 50.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Set this value to **DOMAIN**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags. Maximum number of list elements: 20.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of a tag.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of a tag.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
