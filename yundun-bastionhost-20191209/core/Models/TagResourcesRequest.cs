// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The region ID of the Bastionhost instances to which tags need to be created and bound.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource IDs.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// Set the value to INSTANCE, which indicates that the resource is a Bastionhost instance.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the instance.
            /// 
            /// Valid values of N: 1 to 20.
            /// 
            /// > 
            /// *   The key can be up to 128 characters in length but cannot be an empty string.
            /// *   The key cannot start with **aliyun** or **acs:**. It cannot contain **http://** or **https://**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the instance.
            /// 
            /// Valid values of N: 1 to 20.
            /// 
            /// > 
            /// *   The value can be up to 128 characters in length or an empty string.
            /// *   The value cannot start with **aliyun** or **acs:**. It cannot contain **http://** or **https://**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
