// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainOverviewResponseBody : TeaModel {
        /// <summary>
        /// The peak queries per second (QPS) during HTTP traffic scrubbing. Unit: QPS.
        /// </summary>
        [NameInMap("MaxHttp")]
        [Validation(Required=false)]
        public long? MaxHttp { get; set; }

        /// <summary>
        /// The peak QPS during HTTPS traffic scrubbing. Unit: QPS.
        /// </summary>
        [NameInMap("MaxHttps")]
        [Validation(Required=false)]
        public long? MaxHttps { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
