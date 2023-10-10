// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The region ID of the resource.
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the resources that you want to label.
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// The type of resource that you want to label. Set the value to `CLUSTER`.
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The labels that you want to add to the resources in key-value pairs. You can add up to 20 labels. Note:
        /// 
        /// *   A value cannot be empty and can contain up to 128 characters.
        /// *   A key or value must not start with `aliyun` or `acs:`.
        /// *   A key or value must not contain `http://` or `https://`.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

    }

}
