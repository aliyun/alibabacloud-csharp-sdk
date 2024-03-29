// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to unbind all tags from the specified instances. Valid values:
        /// 
        /// *   **true**: unbinds all tags from the specified instances.
        /// *   **false**: To unbind only specific tags, you must specify the **TagKey.N** parameter.
        /// 
        /// > 
        /// *   You must specify at least one of the All and **TagKey.N** parameters.
        /// *   If you specify both the All parameter and the **TagKey.N** parameter, the All parameter does not take effect.
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The ID of the region where the data migration, data synchronization, or change tracking instance resides. For more information, see [List of supported regions](~~141033~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The resource type. Valid value: **ALIYUN::DTS::INSTANCE**.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
