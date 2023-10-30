// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The region ID of the bastion hosts to which you want to create and add tags.
        /// 
        /// > For more information about the mapping between region IDs and region names, see [Regions and zones](~~40654~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// An array that consists of IDs of bastion hosts.
        /// 
        /// Valid values: 1 to 20.
        /// 
        /// > You can call the [DescribeInstances](~~153281~~) operation to query IDs of bastion hosts.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource.
        /// 
        /// Set the value to **INSTANCE**, which indicates that the resource is a bastion host.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// An array that consists of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N. Valid values of N: 1 to 20.
            /// 
            /// > 
            /// 
            /// *   The value can be up to 128 characters in length but cannot be an empty string.
            /// 
            /// *   The value cannot start with **aliyun** or **acs:**. The value cannot contain **http://** or **https://**.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N.\
            /// Valid values of N: 1 to 20.
            /// 
            /// > 
            /// 
            /// *   The value can be up to 128 characters in length or an empty string.
            /// 
            /// *   The value cannot start with **aliyun** or **acs:**. The value cannot contain **http://** or **https://**.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
