// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListTagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of the resources whose tags you want to query. You must specify at least one of resourceId and tags.
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceIdShrink { get; set; }

        /// <summary>
        /// The type of the resource. Valid values:
        /// 
        /// *   project
        /// *   logstore
        /// *   dashboard
        /// *   MachineGroup
        /// *   LogtailConfig
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags that you want to use to filter resources based on exact match. Each tag is a key-value pair. You must specify at least one of resourceId and tags.
        /// 
        /// You can enter up to 20 tags.
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

    }

}
