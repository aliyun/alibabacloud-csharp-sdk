// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all existing tags from the specified resources. Default value: false. Valid values:
        /// 
        /// *   **true**: removes all existing tags from the specified resources.
        /// *   **false**: does not remove all existing tags from the specified resources.
        /// 
        /// > All existing tags of a resource are removed only if the **tagKeys** parameter is left empty and the **DeleteAll** parameter is set to true.
        /// </summary>
        [NameInMap("DeleteAll")]
        [Validation(Required=false)]
        public bool? DeleteAll { get; set; }

        /// <summary>
        /// The IDs of the resources from which you want to remove tags. You can specify up to 20 IDs.
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

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
        /// The tags that you want to remove. You can specify up to 20 tags. Set this parameter to a JSON array.
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

    }

}
