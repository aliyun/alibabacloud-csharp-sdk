// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The IDs of the resources. You can specify up to 20 IDs. Set this parameter to a JSON array.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public Dictionary<string, object> ResourceIds { get; set; }

        /// <summary>
        /// The region in which the resource resides.
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   **application**: Enterprise Distributed Application Service (EDAS) application
        /// *   **cluster**: EDAS cluster
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The key-value pairs that specify the tags.
        /// 
        /// *   You can add up to 20 tags to a resource.
        /// *   The key cannot start with **aliyun** or **acs:** and cannot contain **http://** or **https://**.
        /// *   The tag key or tag value can be up to 128 characters in length, and can contain letters, digits, hyphens (-), commas (,), asterisks (\*), forward slashes (/), question marks (?), and colons (:).
        /// *   Set this parameter to a JSON array.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
