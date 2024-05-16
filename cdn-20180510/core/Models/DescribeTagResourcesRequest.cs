// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeTagResourcesRequest : TeaModel {
        /// <summary>
        /// The IDs of the resources. You can specify up to 50 IDs in each request.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type. Set the value to **DOMAIN**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags. You can specify up to 20 tags in each request.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeTagResourcesRequestTag> Tag { get; set; }
        public class DescribeTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. Valid values of N: **1** to **20**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. Valid values of N: **1** to **20**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
