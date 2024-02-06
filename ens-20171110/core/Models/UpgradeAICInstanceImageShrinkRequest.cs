// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UpgradeAICInstanceImageShrinkRequest : TeaModel {
        /// <summary>
        /// The ID of the AIC image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The IDs of the servers.
        /// </summary>
        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public string ServerIdsShrink { get; set; }

        /// <summary>
        /// The timeout period of the update. Unit: seconds.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
