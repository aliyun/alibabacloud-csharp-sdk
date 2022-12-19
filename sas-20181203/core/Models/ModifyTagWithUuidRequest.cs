// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyTagWithUuidRequest : TeaModel {
        /// <summary>
        /// The type of the assets whose tags you want to modify. Valid values:
        /// 
        /// *   **ecs**: Elastic Compute Service (ECS) instances or servers that are not deployed on Alibaba Cloud.
        /// *   **cloud_product**: Alibaba Cloud service.
        /// 
        /// >  If you do not specify this parameter, the default value **ecs** is used.
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// The ID of the tag whose name you want to change.
        /// 
        /// >  You can call the [DescribeGroupedTags](~~DescribeGroupedTags~~) operation to query the IDs of the tags.
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        /// <summary>
        /// The tag names that you want to change. Separate multiple tag names with commas (,).
        /// 
        /// >  You can call the [DescribeGroupedTags](~~DescribeGroupedTags~~) operation to query the names of the tags that are added to assets.
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public string TagList { get; set; }

        /// <summary>
        /// The UUIDs of the assets whose tags you want to modify. Separate multiple UUIDs with commas (,).
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of assets to which the tags are added. If you do not specify this parameter, the tags that are specified in **TagList** parameter are removed from all assets.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
