// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyTagWithUuidRequest : TeaModel {
        /// <summary>
        /// The type of the asset to query. If you do not specify this parameter, the tags of all asset types are queried. Valid values:
        /// 
        /// *   **ecs**: server
        /// *   **cloud_product**: Alibaba Cloud service
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// The ID of the tag that you want to manage.
        /// 
        /// >  You can call the [DescribeGroupedTags](~~DescribeGroupedTags~~) operation to query the IDs of tags.
        /// </summary>
        [NameInMap("TagId")]
        [Validation(Required=false)]
        public string TagId { get; set; }

        /// <summary>
        /// The names of the tags that you want to manage. Separate multiple tag names with commas (,).
        /// 
        /// >  You can call the [DescribeGroupedTags](~~DescribeGroupedTags~~) operation to query the names of tags.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public string TagList { get; set; }

        /// <summary>
        /// The details of the server for which you want to manage the tag. The value of this parameter is in the JSON format and contains the following fields:
        /// 
        /// *   **Target**: the UUID of the server that you want to add or remove.
        /// 
        /// *   **targetType**: the method by which the server is added. Valid values:
        /// 
        ///     *   **uuid**: by server
        ///     *   **groupId**: by server group
        /// 
        /// *   **flag**: the operation that you want to perform on the server. Valid values:
        /// 
        ///     *   **del**: removes the tag from the server.
        ///     *   **add**: adds the tag to the server.
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// The UUIDs of the servers.
        /// 
        /// >  You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
