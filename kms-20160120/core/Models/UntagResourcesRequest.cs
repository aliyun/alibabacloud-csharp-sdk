// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags from resources. Valid values:
        /// 
        /// *   true
        /// *   false (default)
        /// 
        /// >  This parameter takes effect only when you specify an empty tag key.
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The region ID of the resource.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/601478.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the resources from which you want to remove tags. You can enter up to 50 resource IDs.
        /// 
        /// Enter multiple resource IDs in the `["ResourceId.1","ResourceId.2",...]` format.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource from which you want to remove tags. Valid values:
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
        /// The keys of the tags that you want to remove. You can enter up to 20 tag keys.
        /// 
        /// Enter multiple tag keys in the `["key.1","key.2",...]` format.
        /// 
        /// >  The tag key cannot start with aliyun or acs:.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
