// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate a value, but you must make sure that the value is unique among different requests. The client token can contain only ASCII characters.****
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the new resource group.
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the GA resource.
        /// 
        /// *   If **ResourceType** is set to **accelerator**, set the value of ResourceId to the ID of a standard GA instance.
        /// *   If **ResourceType** is set to **basicaccelerator**, set the value of ResourceId to the ID of a basic GA instance.
        /// *   If **ResourceType** is set to**bandwidthpackage**, set the value of ResourceId to the ID of a bandwidth plan.
        /// *   If **ResourceType** is set to **acl**, set the value of ResourceId to the ID of a network ACL.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the GA resource. Valid values:
        /// 
        /// *   **accelerator**: a standard GA instance.
        /// *   **basicaccelerator**: a basic GA instance.
        /// *   **bandwidthpackage**: a bandwidth plan.
        /// *   **acl**: a network ACL.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
