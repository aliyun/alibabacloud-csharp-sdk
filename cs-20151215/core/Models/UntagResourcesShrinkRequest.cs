// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class UntagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether to remove all custom labels. This parameter takes effect only when `tag_keys` is left empty. Valid values:
        /// 
        /// *   `true`: Remove all custom labels.
        /// *   `false`: Do not remove all custom labels.
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The region ID of the resources.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("region_id")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of resource IDs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resource_ids")]
        [Validation(Required=false)]
        public string ResourceIdsShrink { get; set; }

        /// <summary>
        /// The type of resource. Set the value to `CLUSTER`.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("resource_type")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The list of keys of the labels that you want to remove.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("tag_keys")]
        [Validation(Required=false)]
        public string TagKeysShrink { get; set; }

    }

}
