// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class CreateTagResourcesRequest : TeaModel {
        /// <summary>
        /// The region ID of the instance. Set the value to **cn-hangzhou**, which indicates an Anti-DDoS Pro instance in the Chinese mainland.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs in Resource Management.
        /// 
        /// If you do not specify this parameter, the instance belongs to the default resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// An array consisting of the IDs of the Anti-DDoS Pro instances to which you want to add the tag.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// The type of the resource to which the tag belongs. Set the value to **INSTANCE**, which indicates an Anti-DDoS Pro instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// An array that consists of the tags to add.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateTagResourcesRequestTags> Tags { get; set; }
        public class CreateTagResourcesRequestTags : TeaModel {
            /// <summary>
            /// The key of the tag to add.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag to add.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
