// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UntagDcdnResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to delete all tags. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// Default value: **false**
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The ID of the resource. Valid values of N: **1** to **50**.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Set the value to **DOMAIN**.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The key of the tag. Valid values of N: **1** to **20**.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
