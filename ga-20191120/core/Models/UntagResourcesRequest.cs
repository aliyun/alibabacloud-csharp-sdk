// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all tags of the specified resource. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, **ClientToken** is set to the value of **RequestId**. The value of **RequestId** for each API request may be different.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The ID of the region where the GA instance is deployed. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The IDs of the resources whose tags you want to remove.
        /// 
        /// *   If you set **ResourceType** to **accelerator**, set the value of ResourceId to the ID of a standard GA instance.
        /// *   If you set **ResourceType** to **basicaccelerator**, set the value of ResourceId to the ID of a basic GA instance.
        /// *   If you set **ResourceType** to **bandwidthpackage**, set the value of ResourceId to the ID of a bandwidth plan.
        /// *   If you set **ResourceType** to **acl**, set the value of ResourceId to the ID of an ACL.
        /// *   If you set **ResourceType** to **endpointgroup**, set the value of ResourceId to the ID of an endpoint group.
        /// 
        /// You can specify up to 50 GA resource IDs.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource whose tags you want to remove. Valid values:
        /// 
        /// *   **accelerator**: a standard GA instance
        /// *   **basicaccelerator**: a basic GA instance
        /// *   **bandwidthpackage**: a bandwidth plan
        /// *   **acl**: an access control list (ACL).
        /// *   **endpointgroup**: an endpoint group
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The key of the tag to be removed.
        /// 
        /// The system removes all tags with this tag key.
        /// 
        /// You can specify up to 20 tag keys.
        /// 
        /// >  If the **All** parameter is set to **true**, this parameter does not take effect.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
