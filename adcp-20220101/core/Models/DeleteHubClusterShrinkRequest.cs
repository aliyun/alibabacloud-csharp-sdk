// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adcp20220101.Models
{
    public class DeleteHubClusterShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the master instance.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Specifies whether to forcefully delete the master instance in ACK One. Valid values:
        /// 
        /// *   true: forcefully deletes the master instance in ACK One.
        /// *   false: does not forcibly delete the master instance in ACK One.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The list of resources to retain.
        /// </summary>
        [NameInMap("RetainResources")]
        [Validation(Required=false)]
        public string RetainResourcesShrink { get; set; }

    }

}
