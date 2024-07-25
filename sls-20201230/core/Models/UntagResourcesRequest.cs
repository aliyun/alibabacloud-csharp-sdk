// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to unbind all tags. Default value: false. Valid values:
        /// 
        /// *   false: unbinds only the tags that match the value of tags.
        /// *   true: unbinds all tags that are bound to the resource.
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The resource IDs. Each time you call this operation, you can unbind tags only from a single resource. Therefore, you can enter only one resource ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   project
        /// *   logstore
        /// *   dashboard
        /// *   machinegroup
        /// *   logtailconfig
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag keys. If you set all to false, only the tags that match the value of this parameter are unbound.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

    }

}
