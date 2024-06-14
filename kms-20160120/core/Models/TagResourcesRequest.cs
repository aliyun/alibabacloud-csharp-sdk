// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The region ID of the resource.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/601478.html) to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the resources to which you want to add tags. You can enter a maximum of 50 resource IDs.
        /// 
        /// Enter multiple resource IDs in the `["ResourceId. 1","ResourceId. 2",...]` format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource to which you want to add tags. Valid values:
        /// 
        /// *   key
        /// *   secret
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// A list of tags. You can enter up to 20 tags.
        /// 
        /// A tag consists of a key-value pair. Enter multiple tags in the `[{"Key":"key1","Value":"value1"},{"Key":"key2","Value":"value2"},..]` format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The key of the tag. A tag consists of a key-value pair.
            /// 
            /// You can enter up to 20 tags. Enter multiple tags in the `[{"Key":"key1","Value":"value1"},{"Key":"key2","Value":"value2"},..]` format.
            /// 
            /// Each key can be up to 128 characters in length and can contain letters, digits, forward slashes (/), backslashes (\\\\), underscores (_), hyphens (-), periods (.), plus signs (+), equal signs (=), colons (:), and at signs (@).
            /// 
            /// >  The key cannot start with aliyun or acs:.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the tag. A tag consists of a key-value pair.
            /// 
            /// You can enter up to 20 tags. Enter multiple tags in the `[{"Key":"key1","Value":"value1"},{"Key":"key2","Value":"value2"},..]` format.
            /// 
            /// Each value can be up to 128 characters in length and can contain letters, digits, forward slashes (/), backslashes (\\\\), underscores (_), hyphens (-), periods (.), plus signs (+), equal signs (=), colons (:), and at signs (@).
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
