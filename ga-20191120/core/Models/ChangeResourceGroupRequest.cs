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
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **client token** can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. The **request ID** may be different for each request.
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
        /// *   If you set **ResourceType** to **accelerator**, set the value of ResourceId to the ID of a standard GA instance.
        /// *   If you set **ResourceType** to **basicaccelerator**, set the value of ResourceId to the ID of a basic GA instance.
        /// *   If you set **ResourceType** to **bandwidthpackage**, set the value of ResourceId to the ID of a bandwidth plan.
        /// *   If you set **ResourceType** to **acl**, set the value of ResourceId to the ID of an access control list (ACL).
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// The type of the GA resource. Valid values:
        /// 
        /// *   **accelerator:** a standard GA instance.
        /// *   **basicaccelerator:** a basic GA instance.
        /// *   **bandwidthpackage:** a bandwidth plan.
        /// *   **acl:** an ACL.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
