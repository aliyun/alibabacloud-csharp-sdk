// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the value of **RequestId**as the value of **ClientToken**. The value of **RequestId** for each API request may be different.
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
        /// The ID of the GA resource.
        /// 
        /// *   If you set the **ResourceType** parameter to **accelerator**, set the value of ResourceId to the ID of a standard GA instance.
        /// *   If you set the **ResourceType** parameter to **basicaccelerator**, set the value of ResourceId to the ID of a basic GA instance.
        /// *   If you set the **ResourceType** parameter to**bandwidthpackage**, set the value of ResourceId to the ID of a bandwidth plan.
        /// *   If you set the **ResourceType** parameter to **acl**, set the value of ResourceId to the ID of an ACL.
        /// 
        /// You can specify 1 to 50 GA resource IDs.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the GA resource. Valid values:
        /// 
        /// *   **accelerator:** a standard GA instance.
        /// *   **basicaccelerator:** a basic GA instance.
        /// *   **bandwidthpackage:** a bandwidth plan.
        /// *   **acl:** an access control list (ACL).
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags of GA resources.
        /// 
        /// You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the GA resource. The tag key cannot be an empty string.
            /// 
            /// The tag key can be up to 64 characters in length and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the GA resource. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
            /// 
            /// You can specify up to 20 tag values.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
