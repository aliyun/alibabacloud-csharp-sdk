// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// The list of applications that are related to the lane.
        /// </summary>
        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public string AppInfos { get; set; }

        /// <summary>
        /// Specifies whether to enable the throttling rule.
        /// </summary>
        [NameInMap("EnableRules")]
        [Validation(Required=false)]
        public bool? EnableRules { get; set; }

        /// <summary>
        /// The configuration of the throttling rule.
        /// </summary>
        [NameInMap("EntryRules")]
        [Validation(Required=false)]
        public string EntryRules { get; set; }

        /// <summary>
        /// The ID of the lane.
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

        /// <summary>
        /// The name of the lane.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
