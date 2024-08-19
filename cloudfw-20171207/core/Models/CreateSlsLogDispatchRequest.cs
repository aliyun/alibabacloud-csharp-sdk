// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateSlsLogDispatchRequest : TeaModel {
        /// <summary>
        /// The region ID of the Simple Log Service project.
        /// </summary>
        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        /// <summary>
        /// The log retention period. Unit: days.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public long? Ttl { get; set; }

    }

}
